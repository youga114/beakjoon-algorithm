const fs = require("fs");
const input = fs.readFileSync("dev/stdin").toString().split("\n");

const n = input[0];
let paper = [];
for (let i = 1; i <= n; ++i) {
    paper.push(input[i].split(" "));
}

let blue = 0,
    white = 0;

const countPaper = (x, y, n) => {
    for (let i = x; i < x + n; ++i) {
        for (let j = y; j < y + n; ++j) {
            if (paper[i][j] !== paper[x][y]) {
                const nextN = n / 2;

                countPaper(x, y, nextN);
                countPaper(x + nextN, y, nextN);
                countPaper(x, y + nextN, nextN);
                countPaper(x + nextN, y + nextN, nextN);
                return;
            }
        }
    }

    if (paper[x][y] === "1") {
        blue++;
        return;
    }

    white++;
};

countPaper(0, 0, n);

console.log(white);
console.log(blue);
