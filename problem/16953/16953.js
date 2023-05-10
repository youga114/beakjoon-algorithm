const fs = require("fs");
const input = fs.readFileSync("dev/stdin").toString().split("\n");

let [left, right] = input[0].split(" ").map((num) => Number(num));
let count = 0;

while (true) {
    if (right < left) {
        console.log(-1);
        return;
    }

    count++;

    if (right === left) {
        console.log(count);
        return;
    }

    if (right % 2 === 1) {
        if (right % 10 === 1) {
            right = Math.floor(right / 10);
            continue;
        }

        console.log(-1);
        return;
    }

    right /= 2;
}
