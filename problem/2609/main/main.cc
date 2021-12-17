#include <iostream>
#include <vector>

using namespace std;

int main(int argc, char** argv) {
    int n, m;
    cin >> n >> m;

    if (m > n) {
        int temp = n;
        n = m;
        m = temp;
    }
    
    for (int i = m; i > 0; --i) {
        if (n % i == 0 && m % i == 0) {
            cout << i << '\n';
            break;
        }
    }
    
    for (int i = n; i <= n * m; ++i) {
        if (i % n == 0 && i % m == 0) {
            cout << i << '\n';
            break;
        }
    }

    return 0;
}