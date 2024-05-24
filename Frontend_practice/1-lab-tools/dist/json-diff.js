"use strict";
var __assign = (this && this.__assign) || function () {
    __assign = Object.assign || function(t) {
        for (var s, i = 1, n = arguments.length; i < n; i++) {
            s = arguments[i];
            for (var p in s) if (Object.prototype.hasOwnProperty.call(s, p))
                t[p] = s[p];
        }
        return t;
    };
    return __assign.apply(this, arguments);
};
var __spreadArray = (this && this.__spreadArray) || function (to, from, pack) {
    if (pack || arguments.length === 2) for (var i = 0, l = from.length, ar; i < l; i++) {
        if (ar || !(i in from)) {
            if (!ar) ar = Array.prototype.slice.call(from, 0, i);
            ar[i] = from[i];
        }
    }
    return to.concat(ar || Array.prototype.slice.call(from));
};
Object.defineProperty(exports, "__esModule", { value: true });
var fs = require("fs");
var findFilesJsonDifference = function (firstJsonFileName, secondJsonFileName) {
    var firstJson = JSON.parse(fs.readFileSync(firstJsonFileName, { encoding: "utf8" }));
    var secondJson = JSON.parse(fs.readFileSync(secondJsonFileName, { encoding: "utf8" }));
    return findJsonDifference(firstJson, secondJson);
};
var isObject = function (value) {
    return typeof value === "object" && value !== null;
};
function findJsonDifference(oldJson, newJson) {
    var keys = __spreadArray(__spreadArray([], Object.keys(oldJson), true), Object.keys(newJson), true);
    return keys.reduce(function (differences, key) {
        var _a, _b, _c, _d;
        var oldValue = oldJson[key];
        var newValue = newJson[key];
        if (oldValue === undefined)
            return __assign(__assign({}, differences), (_a = {}, _a[key] = {
                type: "new",
                newValue: newValue,
            }, _a));
        if (newValue === undefined)
            return __assign(__assign({}, differences), (_b = {}, _b[key] = {
                type: "delete",
                oldValue: oldValue,
            }, _b));
        if (isObject(oldValue) && isObject(newValue))
            return __assign(__assign({}, differences), (_c = {}, _c[key] = {
                type: JSON.stringify(oldValue) === JSON.stringify(newValue)
                    ? "unchanged"
                    : "changed",
                children: findJsonDifference(oldValue, newValue),
            }, _c));
        return __assign(__assign({}, differences), (_d = {}, _d[key] = {
            type: oldValue === newValue ? "unchanged" : "changed",
            oldValue: oldValue,
            newValue: newValue,
        }, _d));
    }, {});
}
exports.default = findFilesJsonDifference;
