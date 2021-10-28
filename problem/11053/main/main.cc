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

    /* 
     *   dp(time complex: n2) */
    // vector<int> dp(n, 1);

    // for (int i = 1; i < n; ++i) {
    //     for (int j = i - 1; j >= 0; --j) {
    //         if (v[i] > v[j] && dp[i] <= dp[j]) {
    //             dp[i] = dp[j] + 1;
    //         };
    //     }
    // }

    // cout << *max_element(dp.begin(), dp.end());


    /* 
     *   binary search(time complex: nlogn) */

    vector<int> num;
    num.push_back(v[0]);

    for (int i = 1; i < n; ++i) {
        if(num.back() > v[i]) {
            *(lower_bound(num.begin(), num.end(), v[i])) = v[i];
        } else if (num.back() < v[i]) {
            num.push_back(v[i]);
        }
    }

    cout << num.size();

    return 0;
}