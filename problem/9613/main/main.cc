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

    while (testCnt--)
    {
        int n;
        cin >> n;

        vector<int> v(n);
        for (int i = 0; i < n; ++i)
        {
            cin >> v[i];
        }

        sort(v.begin(), v.end());
        
        long long answer = 0;
        for (int i = 0; i < n; ++i)
        {
            for (int j = i + 1; j < n; ++j)
            {
                int a = v[i], b = v[j];

                while (b % a != 0)
                {
                    int temp = a;
                    a = b % a;
                    b = temp;
                }

                answer += a;
            }
        }

        cout << answer << endl;
    }

    return 0;
}