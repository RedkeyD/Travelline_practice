import * as fs from "fs";

type JsonParseData = Record<string, unknown>;
type MutationType = "new" | "delete" | "unchanged" | "changed";
type Mutation = {
  type: MutationType;
  oldValue?: unknown;
  newValue?: unknown;
  children?: Mutations;
};
type Mutations = Record<string, Mutation>;

const readJsonFile = (fileName: string): JsonParseData => {
  const jsonContent: string = fs.readFileSync(fileName, { encoding: "utf8" });
  return JSON.parse(jsonContent);
};

const getMutationType = (
  oldValue: unknown,
  newValue: unknown
): MutationType => {
  if (oldValue === undefined) return "new";
  if (newValue === undefined) return "delete";
  if (isObject(oldValue) && isObject(newValue)) {
    return JSON.stringify(oldValue) === JSON.stringify(newValue)
      ? "unchanged"
      : "changed";
  }
  return oldValue === newValue ? "unchanged" : "changed";
};

const isObject = (value: unknown): value is Record<string, unknown> =>
  typeof value === "object" && value !== null;

const findMutationsRecursively = (
  oldJson: JsonParseData,
  newJson: JsonParseData
): Mutations => {
  const keys: string[] = [...Object.keys(oldJson), ...Object.keys(newJson)];

  return keys.reduce<Mutations>((mutations: Mutations, key: string) => {
    const oldValue = oldJson[key];
    const newValue = newJson[key];
    const mutationType = getMutationType(oldValue, newValue);

    return {
      ...mutations,
      [key]: {
        type: mutationType,
        oldValue,
        newValue,
        children:
          mutationType === "changed" && isObject(oldValue) && isObject(newValue)
            ? findMutationsRecursively(oldValue, newValue)
            : undefined,
      },
    };
  }, {});
};

const findJsonMutations = (
  oldJsonFileName: string,
  newJsonFileName: string
): Mutations => {
  const oldJson: JsonParseData = readJsonFile(oldJsonFileName);
  const newJson: JsonParseData = readJsonFile(newJsonFileName);

  return findMutationsRecursively(oldJson, newJson);
};

export default findJsonMutations;
