"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var commander_1 = require("commander");
var html_parser_js_1 = require("./html-parser.js");
var json_diff_js_1 = require("./json-diff.js");
var program = new commander_1.Command();
program
    .command("html-resources")
    .argument("<fileName>", "a file name to parse")
    .action(function (fileName) {
    var result = (0, html_parser_js_1.default)(fileName);
    console.log(Array.from(result));
});
program
    .command("json-diff")
    .argument("<firstJsonFileName>", "old json file")
    .argument("<secondJsonFileName>", "new json file")
    .action(function (firstJsonFileName, secondJsonFileName) {
    var result = (0, json_diff_js_1.default)(firstJsonFileName, secondJsonFileName);
    console.log(JSON.stringify(result, null, 2));
});
try {
    program.parse();
}
catch (e) {
    console.error(e);
}
