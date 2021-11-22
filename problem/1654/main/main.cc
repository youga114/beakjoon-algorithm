#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

int main(int argc, char** argv) {
    unsigned int k, n;
    cin >> k >> n;
    vector<unsigned int> v(k);

    for (int i = 0; i < k; ++i) {
        cin >> v[i];
    }

    unsigned int max = *(max_element(v.begin(), v.end()));
    unsigned int min = 1;
    
    while (max >= min) {
        unsigned int cnt = 0;
        unsigned int length = (max + min) / 2;
        
        for (unsigned int i = 0; i < v.size(); ++i) {
            cnt += v[i]/length;
        }

        if (cnt >= n) {
            min = length + 1;
        }
        else {
            max = length - 1;
        }
    }

    cout << max;

    return 0;
}