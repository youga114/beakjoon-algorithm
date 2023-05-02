const fs = require("fs");
const input = fs.readFileSync("dev/stdin").toString().split("\n");

const n = input[0];
let numbers = input[1].split(" ").map((value) => {
    return Number(value);
});
let sums = [];

for (let i = 0; i <= 1000; ++i) {
    sums.push(0);
}

let maxValue = 0;

for (let i = 0; i < n; ++i) {
    const sum = sums[numbers[i]] + numbers[i];
    maxValue = Math.max(maxValue, sum);

    for (let j = numbers[i] + 1; j <= 1000; ++j) {
        if (sums[j] < sum) {
            sums[j] = sum;
        }
    }
}

console.log(maxValue);
