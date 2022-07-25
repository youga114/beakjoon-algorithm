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

    int n;

    cin >> n;

    vector<int> v(n);

    for (int i = 0; i < n; ++i)
    {
        cin >> v[i];
    }

    sort(v.begin(), v.end());

    int allWon;
    cin >> allWon;

    int curWon = v[v.size() - 1];

    while (curWon > 0)
    {
        int sum = 0;
        for (int i = 0; i < n; ++i)
        {
            if (curWon > v[i])
            {
                sum += v[i];
            }
            else
            {
                sum += curWon;
            }
        }
            
        if (sum <= allWon)
        {
            break;
        }

        curWon--;
    }

    cout << curWon;

    return 0;
}