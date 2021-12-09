#include <iostream>
#include <vector>
#include <algorithm>
#include <queue>

using namespace std;

int main(int argc, char** argv) {
    int n, m;
    cin >> n >> m;

    vector<int> v(n);

    for (int i = 0; i < n; ++i) {
        cin >> v[i];
    }
    
    int maxNum = *(max_element(v.begin(), v.end()));
    int minNum = 1;

    while (minNum <= maxNum) {
        long long length = 0;
        int half = (maxNum + minNum) / 2;

        for (int i = 0; i < n; ++i) {
            if (v[i] > half) {
                length += v[i] - half;
            }
        }
        
        if (length >= m) {
            minNum = half + 1;
        }
        else {
            maxNum = half - 1;
        }
    }

    cout << maxNum;

    return 0;
}