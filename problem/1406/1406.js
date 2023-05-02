const fs = require("fs");
const input = fs.readFileSync("dev/stdin").toString().split("\n");

let str = input[0];
const n = Number(input[1]);
let commands = [];
for (let i = 2; i < n + 2; ++i) {
    commands.push(input[i].split(" "));
}

let left = [],
    right = [];
for (let i = 0; i < str.length; ++i) {
    left.push(str[i]);
}

commands.forEach((command) => {
    switch (command[0]) {
        case "P":
            left.push(command[1]);
            break;
        case "L":
            if (left.length > 0) {
                right.push(left.pop());
            }
            break;
        case "B":
            left.pop();
            break;
        case "D":
            if (right.length > 0) {
                left.push(right.pop());
            }
            break;
    }
});

str = "";
for (let i = 0; i < left.length; ++i) {
    str += left[i];
}

for (let i = right.length - 1; i >= 0; --i) {
    str += right[i];
}

console.log(str);
