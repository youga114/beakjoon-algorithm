const fs = require("fs");
// let input = fs.readFileSync("/dev/stdin").toString();
let input = fs.readFileSync("input.text").toString();

let result = 0;

let plusInput = input.split("-");

let plusNums = plusInput[0].split("+");
for (let i = 0; i < plusNums.length; ++i) {
    result += parseInt(plusNums[i]);
}

for (let i = 1; i < plusInput.length; ++i) {
    let plusNums = plusInput[i].split("+");

    for (let j = 0; j < plusNums.length; ++j) {
        result -= parseInt(plusNums[j]);
    }
}

console.log(result);