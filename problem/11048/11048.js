const fs = require("fs");
const input = fs.readFileSync("dev/stdin").toString().split("\n");

const [n, m] = input[0].split(" ").map((num) => Number(num));

let map = [];
for (let i = 1; i < n + 1; ++i) {
    map.push(input[i].split(" ").map((num) => Number(num)));
}

let maxCandy = [];
for (let i = 0; i < n + 1; ++i) {
    maxCandy.push([]);
    for (let j = 0; j < m + 1; ++j) {
        if (i === 0 || j === 0) {
            maxCandy[i].push(0);
        } else {
            maxCandy[i].push(-1);
        }
    }
}

maxCandy[1][1] = map[0][0];

const recursive = (n, m) => {
    if (maxCandy[n][m] !== -1) {
        return maxCandy[n][m];
    }

    maxCandy[n][m] =
        Math.max(recursive(n - 1, m), recursive(n, m - 1)) + map[n - 1][m - 1];
    return maxCandy[n][m];
};

console.log(recursive(n, m));
