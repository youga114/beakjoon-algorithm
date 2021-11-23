#include <iostream>
#include <vector>
#include <algorithm>
#include <queue>

using namespace std;

int main(int argc, char** argv) {
    int v, e;
    cin >> v >> e;

    int start;
    cin >> start;

    vector<vector<pair<int, int>>> graph(v + 1);

    for (int i = 0; i < e; ++i) {
        int begin, end, distance;
        cin >> begin >> end >> distance;

        graph[begin].push_back({end, distance});
    }

    int infNum = 5000000;
    vector<int> dis(v + 1, infNum);
    vector<bool> isVisited(v + 1, false);

    dis[start] = 0;

    priority_queue<pair<int, int>, vector<pair<int, int>>, greater<pair<int, int>>> pq;
    pq.push({0, start});

    while(pq.empty() == false) {
        pair<int, int> line = pq.top();
        pq.pop();

        if (isVisited[line.second] == true) {
            continue;
        }
        isVisited[line.second] = true;

        vector<pair<int, int>> node = graph[line.second];

        for (int i = 0; i < node.size(); ++i) {
            if(dis[node[i].first] > dis[line.second] + node[i].second) {
                dis[node[i].first] = dis[line.second] + node[i].second;
                pq.push({dis[node[i].first], node[i].first});
            }
        }
    }

    for (int i = 1; i <= v; ++i) {
        if (dis[i] == infNum) {
            cout << "INF" << '\n';
        }
        else {
            cout << dis[i] << '\n';
        }
    }

    return 0;
}