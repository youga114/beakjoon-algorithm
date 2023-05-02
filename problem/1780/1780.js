const fs = require("fs");
const input = fs.readFileSync("dev/stdin").toString().split("\n");

const n = input[0];
let paper = [];
for (let i = 1; i <= n; ++i) {
    paper.push(input[i].split(" "));
}

let minusPaper = 0,
    zeroPaper = 0,
    plusPaper = 0;

const countPaper = (x, y, n) => {
    for (let i = x; i < x + n; ++i) {
        for (let j = y; j < y + n; ++j) {
            if (paper[i][j] !== paper[x][y]) {
                const nextN = n / 3;

                for (let k = 0; k < 3; ++k) {
                    for (let l = 0; l < 3; ++l) {
                        countPaper(x + nextN * k, y + nextN * l, nextN);
                    }
                }
                return;
            }
        }
    }

    if (paper[x][y] === "-1") {
        minusPaper++;
        return;
    }

    if (paper[x][y] === "0") {
        zeroPaper++;
        return;
    }

    plusPaper++;
};

countPaper(0, 0, n);

console.log(minusPaper);
console.log(zeroPaper);
console.log(plusPaper);
