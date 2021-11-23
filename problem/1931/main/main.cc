#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

bool comp(const pair<int, int> left, const pair<int, int> right) {
    if (left.second == right.second) {
        return left.first < right.first;
    }

    return left.second < right.second;
}

int main(int argc, char** argv) {
    int n;
    cin >> n;

    vector<pair<int, int>> v(n);

    for (int i = 0; i < n; ++i) {
        int start, end;
        cin >> start >> end;
        v[i] = {start, end};
    }

    sort(v.begin(), v.end(), comp);

    int cnt = 1;
    int curEnd = v[0].second;

    for (int i = 1; i < n; ++i) {
        if (curEnd <= v[i].first) {
            cnt++;
            curEnd = v[i].second;
        }
    }

    cout << cnt;

    return 0;
}