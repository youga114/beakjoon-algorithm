const fs = require("fs");
const input = fs.readFileSync("dev/stdin").toString().split("\n");

const nodeCount = input[0];
let node = [];
let isVisited = [];
for (let i = 0; i <= nodeCount; ++i) {
    node.push([]);
    isVisited.push(false);
}

const [start, end] = input[1].split(" ").map((value) => Number(value));

const edgeCount = Number(input[2]);
for (let i = 3; i < edgeCount + 3; ++i) {
    const edge = input[i].split(" ").map((value) => Number(value));
    node[edge[0]].push(edge[1]);
    node[edge[1]].push(edge[0]);
}

let flag = false;
const dfs = (child, n) => {
    if (isVisited[child] === true) {
        return;
    }

    isVisited[child] = true;

    if (child === end) {
        console.log(n);
        flag = true;
        return;
    }

    for (let i = 0; i < node[child].length; ++i) {
        dfs(node[child][i], n + 1);
    }
};

dfs(start, 0);

if (flag === false) {
    console.log(-1);
}
