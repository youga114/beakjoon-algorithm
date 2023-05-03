const fs = require("fs");
const input = fs.readFileSync("dev/stdin").toString().split("\n");

const n = Number(input[0]);
const nums = input[1].split(" ").map((num) => Number(num));

let isVisited = [];

for (let i = 0; i < n; ++i) {
    isVisited.push(false);
}

let max = 0;

const dfs = (progression) => {
    if (progression.length >= n) {
        let result = 0;

        for (let i = 0; i < n - 1; ++i) {
            result += Math.abs(progression[i] - progression[i + 1]);
        }

        max = Math.max(max, result);

        return;
    }

    for (let i = 0; i < n; ++i) {
        if (isVisited[i] === false) {
            isVisited[i] = true;
            progression.push(nums[i]);
            dfs(progression);
            progression.pop();
            isVisited[i] = false;
        }
    }
};

dfs([]);

console.log(max);
