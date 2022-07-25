#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

void dfs(int n, int m, vector<int> v, vector<int> result, int curIdx, int nextIdx)
{
    if (curIdx >= m)
    {
        for (int i = 0; i < m; ++i)
        {
            cout << result[i] << " ";
        }

        cout << endl;

        return;
    }

    for (int i = nextIdx; i < n; ++i)
    {
        result[curIdx] = v[i];
        dfs(n, m, v, result, curIdx + 1, i + 1);
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

    dfs(n, m, v, result, 0, 0);

    return 0;
}