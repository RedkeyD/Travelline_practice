"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var fs = require("fs");
var node_html_parser_1 = require("node-html-parser");
var parseHtml = function (fileName) {
    var rawDocument = fs.readFileSync(fileName, { encoding: "utf8" });
    var root = (0, node_html_parser_1.parse)(rawDocument);
    var nodes = root.querySelectorAll("[href],[src]");
    var urls = nodes
        .map(function (node) { return node.getAttribute("href") || node.getAttribute("src"); })
        .filter(function (url) { return url !== undefined; });
    return new Set(urls);
};
exports.default = parseHtml;
