import { Command } from "commander";
import parseHtml from "./html-parser.js";
import findJsonMutation from "./json-diff.js";

const program = new Command();

program
  .command("html-resources")
  .argument("<fileName>", "a file name to parse")
  .action((fileName: string) => {
    const result: Set<string> = parseHtml(fileName);
    console.log(Array.from(result));
  });

program
  .command("json-diff")
  .argument("<oldJsonPath>", "old json file")
  .argument("<newJsonPath>", "new json file")
  .action((oldJsonPath: string, newJsonPath: string) => {
    const result: Record<string, object> = findJsonMutation(
      oldJsonPath,
      newJsonPath
    );
    console.log(JSON.stringify(result, null, 2));
  });

try {
  program.parse();
} catch (e) {
  console.error(e);
}
