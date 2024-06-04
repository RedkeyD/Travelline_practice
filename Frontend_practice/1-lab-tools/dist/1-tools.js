"use strict";
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", { value: true });
const commander_1 = require("commander");
const html_parser_js_1 = __importDefault(require("./html-parser.js"));
const json_diff_js_1 = __importDefault(require("./json-diff.js"));
const program = new commander_1.Command();
program
    .command("html-resources")
    .argument("<fileName>", "a file name to parse")
    .action((fileName) => {
    const result = (0, html_parser_js_1.default)(fileName);
    console.log(Array.from(result));
});
program
    .command("json-diff")
    .argument("<oldJsonPath>", "old json file")
    .argument("<newJsonPath>", "new json file")
    .action((oldJsonPath, newJsonPath) => {
    const result = (0, json_diff_js_1.default)(oldJsonPath, newJsonPath);
    console.log(JSON.stringify(result, null, 2));
});
try {
    program.parse();
}
catch (e) {
    console.error(e);
}
