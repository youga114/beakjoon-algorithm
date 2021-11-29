#include <iostream>
#include <vector>
#include <algorithm>
#include <numeric>
#include <cmath>

using namespace std;

int main(int argc, char** argv) {
    int n;
    cin >> n;

    vector<int> v(n);
    
    for (int i = 0; i < n; ++i) {
        cin >> v[i];
    }

    float tempSum = accumulate(v.begin(), v.end(), 0);
    cout << floor(tempSum / n + 0.5) << '\n';

    sort(v.begin(), v.end());

    cout << v[n/2] << '\n';
    
    vector<int> cnt(8001, 0);

    for (int i = 0; i < n; ++i) {
        cnt[v[i] + 4000]++;
    }
    
    int maxCnt = *(max_element(cnt.begin(), cnt.end()));
    int maxCntNum = -4001;

    for (int i = 0; i < 8001; ++i) {
        if (maxCnt == cnt[i]) {
            if (maxCntNum != -4001) {
                maxCntNum = i - 4000;
                break;
            }
            
            maxCntNum = i - 4000;
        }
    }

    cout << maxCntNum << '\n';

    cout << v[v.size() - 1] - v[0];

    return 0;
}