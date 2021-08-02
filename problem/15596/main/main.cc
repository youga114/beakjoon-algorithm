#include <iostream>
#include "main/sum.h"

using namespace std;

int main(int argc, char** argv) {
    vector<int> a;
    int len;
    cin >> len;
    
    for (int i = 0; i < len; ++i) {
        int num;
        cin >> num;
        a.push_back(num);
    }

    cout << sum(a);

    return 0;
}
