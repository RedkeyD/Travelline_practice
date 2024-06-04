"use strict";
var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    var desc = Object.getOwnPropertyDescriptor(m, k);
    if (!desc || ("get" in desc ? !m.__esModule : desc.writable || desc.configurable)) {
      desc = { enumerable: true, get: function() { return m[k]; } };
    }
    Object.defineProperty(o, k2, desc);
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __setModuleDefault = (this && this.__setModuleDefault) || (Object.create ? (function(o, v) {
    Object.defineProperty(o, "default", { enumerable: true, value: v });
}) : function(o, v) {
    o["default"] = v;
});
var __importStar = (this && this.__importStar) || function (mod) {
    if (mod && mod.__esModule) return mod;
    var result = {};
    if (mod != null) for (var k in mod) if (k !== "default" && Object.prototype.hasOwnProperty.call(mod, k)) __createBinding(result, mod, k);
    __setModuleDefault(result, mod);
    return result;
};
Object.defineProperty(exports, "__esModule", { value: true });
const fs = __importStar(require("fs"));
const readJsonFile = (fileName) => {
    const jsonContent = fs.readFileSync(fileName, { encoding: "utf8" });
    return JSON.parse(jsonContent);
};
const getMutationType = (oldValue, newValue) => {
    if (oldValue === undefined)
        return "new";
    if (newValue === undefined)
        return "delete";
    if (isObject(oldValue) && isObject(newValue)) {
        return JSON.stringify(oldValue) === JSON.stringify(newValue)
            ? "unchanged"
            : "changed";
    }
    return oldValue === newValue ? "unchanged" : "changed";
};
const isObject = (value) => typeof value === "object" && value !== null;
const findMutationsRecursively = (oldJson, newJson) => {
    const keys = [...Object.keys(oldJson), ...Object.keys(newJson)];
    return keys.reduce((mutations, key) => {
        const oldValue = oldJson[key];
        const newValue = newJson[key];
        const mutationType = getMutationType(oldValue, newValue);
        return Object.assign(Object.assign({}, mutations), { [key]: {
                type: mutationType,
                oldValue,
                newValue,
                children: mutationType === "changed" && isObject(oldValue) && isObject(newValue)
                    ? findMutationsRecursively(oldValue, newValue)
                    : undefined,
            } });
    }, {});
};
const findJsonMutations = (oldJsonFileName, newJsonFileName) => {
    const oldJson = readJsonFile(oldJsonFileName);
    const newJson = readJsonFile(newJsonFileName);
    return findMutationsRecursively(oldJson, newJson);
};
exports.default = findJsonMutations;
