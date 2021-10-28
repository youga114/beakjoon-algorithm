#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

int main(int argc, char** argv) {
    int n;
    cin >> n;
    vector<int> v(n);

    for (int i = 0; i < n; ++i) {
        cin >> v[i];
    }

    vector<int> dp(n, 1);

    for (int i = 1; i < n; ++i) {
        for (int j = i - 1; j >= 0; --j) {
            if (v[i] > v[j] && dp[i] <= dp[j]) {
                dp[i] = dp[j] + 1;
            };
        }
    }

    cout << *max_element(dp.begin(), dp.end());

    return 0;
}