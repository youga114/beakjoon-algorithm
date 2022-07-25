#include <iostream>
#include <vector>
#include <algorithm>
#include <string>
#include <map>

using namespace std;

int main(int argc, char** argv) {
    ios_base :: sync_with_stdio(false);
    cin.tie(NULL);
    cout.tie(NULL);

    int testCnt;

    cin >> testCnt;

    for (int t = 0; t < testCnt; ++t)
    {
        int n;
        cin >> n;

        map<string, int> m;

        for (int i = 0; i < n; ++i)
        {
            string name, part;
            cin >> name >> part;

            m[part] += 1;
        }

        int answer = 1;

        for (auto it = m.begin(); it != m.end(); it++)
        {
            answer *= it->second + 1;
        }

        cout << answer - 1 << endl;
    }

    return 0;
}