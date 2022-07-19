#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

void dfs(int n, int m, vector<int> v, vector<int> result, vector<bool> isVisited, int curIdx)
{
    if (curIdx >= m)
    {
        for (int i = 0; i < m; ++i)
        {
            cout << result[i] << " ";
        }
        cout << '\n';
        return;
    }

    for (int i = 0; i < n; ++i)
    {
        if (isVisited[i] == false)
        {
            isVisited[i] = true;
            result[curIdx] = v[i];
            dfs(n, m, v, result, isVisited, curIdx + 1);
            isVisited[i] = false;
        }
    }
}

int main(int argc, char** argv) {
    ios_base :: sync_with_stdio(false);
    cin.tie(NULL);
    cout.tie(NULL);

    int n, m;

    cin >> n >> m;

    vector<int> v(n);

    for (int i = 0; i < n; ++i)
    {
        cin >> v[i];
    }

    sort(v.begin(), v.end());

    vector<int> result(m);
    vector<bool> isVisited(n, false);

    dfs(n, m, v, result, isVisited, 0);

    return 0;
}