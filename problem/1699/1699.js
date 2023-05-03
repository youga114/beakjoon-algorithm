const fs = require("fs");
const input = fs.readFileSync("dev/stdin").toString().split("\n");

const number = input[0];

let squareNums = [];

for (let i = 0; i <= number; ++i) {
    squareNums.push(i);
}

for (let i = 2; i <= Math.sqrt(number); ++i) {
    for (let j = i * i; j <= number; ++j) {
        if (squareNums[j] > squareNums[j - i * i] + 1) {
            squareNums[j] = squareNums[j - i * i] + 1;
        }
    }
}

console.log(squareNums[number]);
