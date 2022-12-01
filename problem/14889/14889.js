const fs = require("fs");
// let input = fs.readFileSync("/dev/stdin").toString();
let inputArray = fs.readFileSync("input.text").toString().split("\n");

let n = inputArray[0];
let map = [];
for (let i = 1; i <= n; ++i) {
    map.push(inputArray[i].split(" "));
}

let isVisited = [];
for (let i = 0; i < n; ++i) {
    isVisited.push(false);
}

let min = 4000000;
let curNums = [];

let dfs = (prevIdx) => {
    if (curNums.length >= n / 2) {
        let sum = 0;
        for (let i = 0; i < curNums.length; ++i) {
            for (let j = 0; j < curNums.length; ++j) {
                sum += parseInt(map[curNums[i]][curNums[j]]);
            }
        }

        let otherSum = 0;
        let otherNums = [];
        for (let i = 0; i < isVisited.length; ++i) {
            if (isVisited[i] === false) {
                otherNums.push(i);
            }
        }
        for (let i = 0; i < otherNums.length; ++i) {
            for (let j = 0; j < otherNums.length; ++j) {
                otherSum += parseInt(map[otherNums[i]][otherNums[j]]);
            }
        }

        if (Math.abs(sum - otherSum) < min) {
            min = Math.abs(sum - otherSum);
        }

        return;
    }

    for (let i = prevIdx + 1; i < n; ++i) {
        if (isVisited[i] === false) {
            isVisited[i] = true;
            curNums.push(i);
            dfs(i);
            curNums = curNums.slice(0, -1);
            isVisited[i] = false;
        }
    }
}

dfs(-1);

console.log(min);