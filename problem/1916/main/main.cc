#include <iostream>
#include <vector>
#include <algorithm>
#include <queue>

using namespace std;

int main(int argc, char** argv) {
    int n, m;
    cin >> n >> m;

    vector<vector<pair<int, int>>> graph(n + 1);
    vector<bool> isVisited(n + 1, false);
    vector<int> dist(n + 1, INT32_MAX);

    for (int i = 0; i < m; ++i) {
        int departure, arrival, distance;

        cin >> departure >> arrival >> distance;

        graph[departure].push_back(make_pair(arrival, distance));
    }

    int start, end;
    cin >> start >> end;

    priority_queue<pair<int, int>, vector<pair<int, int>>, greater<pair<int, int>>> pq;

    pq.push(make_pair(0, start));

    while (pq.empty() != true) {
        pair<int, int> line = pq.top();
        pq.pop();
        int destination = line.second;
        int distance = line.first;

        if (destination == end) {
            cout << distance;
            break;
        }

        if (isVisited[destination] == true) {
            continue;
        }
        isVisited[destination] = true;

        for (int i = 0; i < graph[destination].size(); ++i) {
            if (dist[graph[destination][i].first] > distance + graph[destination][i].second) {
                dist[graph[destination][i].first] = distance + graph[destination][i].second;
                pq.push(make_pair(dist[graph[destination][i].first], graph[destination][i].first));
            }
        }
    }
    

    return 0;
}