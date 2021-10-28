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

    sort(v.begin(), v.end());

    // for (int i = 0; i < n; ++i) {
    //     cout<< v[i] << '\n';
    // }

    v.erase(unique(v.begin(), v.end()), v.end());

    cout << v.size();

    return 0;
}