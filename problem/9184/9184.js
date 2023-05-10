const fs = require("fs");
const input = fs.readFileSync("dev/stdin").toString().split("\n");

let dp = [];

for (let i = 0; i < 21; ++i) {
    dp.push([]);
    for (let j = 0; j < 21; ++j) {
        dp[i].push([]);
        for (let k = 0; k < 21; ++k) {
            if (i === 0 || j === 0 || k === 0) {
                dp[i][j].push(1);
            } else {
                dp[i][j].push(-1);
            }
        }
    }
}

const w = (a, b, c) => {
    if (a <= 0 || b <= 0 || c <= 0) {
        return 1;
    }

    if (a > 20 || b > 20 || c > 20) {
        return w(20, 20, 20);
    }

    if (dp[a][b][c] !== -1) {
        return dp[a][b][c];
    }

    if (a < b && b < c) {
        return w(a, b, c - 1) + w(a, b - 1, c - 1) - w(a, b - 1, c);
    } else {
        return (
            w(a - 1, b, c) +
            w(a - 1, b - 1, c) +
            w(a - 1, b, c - 1) -
            w(a - 1, b - 1, c - 1)
        );
    }
};

for (let i = 1; i < 21; ++i) {
    for (let j = 1; j < 21; ++j) {
        for (let k = 1; k < 21; ++k) {
            dp[i][j][k] = w(i, j, k);
        }
    }
}

for (let i = 0; i < input.length; ++i) {
    let nums = input[i].split(" ").map((num) => Number(num));
    if (nums[0] === -1 && nums[1] === -1 && nums[2] === -1) {
        return;
    }

    console.log(
        `w(${nums[0]}, ${nums[1]}, ${nums[2]}) = ${w(
            nums[0],
            nums[1],
            nums[2]
        )}`
    );
}
