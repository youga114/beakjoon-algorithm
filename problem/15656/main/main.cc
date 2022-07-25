#include <iostream>
#include <vector>
#include <algorithm>
#include <string>

using namespace std;

string str = "";

void dfs(int n, int m, vector<int> v, vector<int> result, int curIdx)
{
    if (curIdx >= m)
    {
        for (int i = 0; i < m; ++i)
        {
            str += to_string(result[i]) + " ";
        }

        str += "\n";

        return;
    }

    for (int i = 0; i < n; ++i)
    {
        result[curIdx] = v[i];
        dfs(n, m, v, result, curIdx + 1);
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

    dfs(n, m, v, result, 0);

    cout << str;

    return 0;
}