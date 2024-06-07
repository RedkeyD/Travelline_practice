import * as fs from "fs";
import { parse, HTMLElement } from "node-html-parser";

const parseHtml = (fileName: string): Set<string> => {
  const rawDocument: string = fs.readFileSync(fileName, { encoding: "utf8" });
  const root = parse(rawDocument);
  const nodes: HTMLElement[] = root.querySelectorAll("[href],[src]");

  const urls = nodes
    .map((node) => node.getAttribute("href") || node.getAttribute("src"))
    .filter((url): url is string => url !== undefined);

  return new Set(urls);
};

export default parseHtml;
