const fs = require("fs");
// let inputArray = fs.readFileSync("/dev/stdin").toString().trim().split("\n");
let inputArray = fs.readFileSync("input.text").toString().trim().split("\n");

let n = inputArray.shift();

let arr = [];

for (let i = 0; i <= n; ++i) {
    arr.push([]);
}

inputArray.forEach((input) => {
    let fromTo = input.split(" ");

    arr[parseInt(fromTo[0])].push(parseInt(fromTo[1]));
    arr[parseInt(fromTo[1])].push(parseInt(fromTo[0]));
})

let parentArr = new Array(parseInt(n) + 1);

let queue = [1];

while (queue.length > 0) {
    let parent = queue.shift();

    if (arr.length <= parent) {
        return;
    }

    for (let i = 0; i < arr[parent].length; ++i) {
        if (parentArr.length <= arr[parent][i]) {
            return;
        }

        if (parentArr[arr[parent][i]] == undefined) {
            parentArr[arr[parent][i]] = parent;

            queue.push(arr[parent][i]);
        }
    }
}

let result = "";

for (let i = 2; i < parentArr.length; ++i) {
    result += parentArr[i] + '\n';
}

console.log(result);