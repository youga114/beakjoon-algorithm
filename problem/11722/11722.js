const fs = require("fs");
const input = fs.readFileSync("dev/stdin").toString().split("\n");

const n = input[0];
const progression = input[1].split(" ").map((num) => Number(num));

let count = [];

for (let i = 0; i < n; ++i) {
    count.push(1);
}

let max = 1;
for (let i = 0; i < n; ++i) {
    for (let j = i + 1; j < n; ++j) {
        if (progression[i] > progression[j] && count[i] + 1 > count[j]) {
            count[j] = count[i] + 1;
            max = Math.max(max, count[j]);
        }
    }
}

console.log(max);
