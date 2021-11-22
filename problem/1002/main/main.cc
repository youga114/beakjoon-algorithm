#include <iostream>
#include <vector>
#include <algorithm>
#include <cmath>

using namespace std;

int main(int argc, char** argv) {
    int n;
    cin >> n;

    while(n--) {
        int x1, y1, r1, x2, y2, r2;

        cin >> x1 >> y1 >> r1 >> x2 >> y2 >> r2;

        float distance = sqrt(pow((x2 - x1), 2) + pow((y2 - y1), 2));
        
        if (r2 + r1 < distance || abs(r2 - r1) > distance) {
            cout << 0 << '\n';
        }
        else if (r2 + r1 == distance || abs(r2 - r1) == distance) {
            if (distance == 0) {
                cout << -1 << '\n';
            }
            else {
                cout << 1 << '\n';
            }
        }
        else if (r2 + r1 > distance || abs(r2 - r1) < distance){
            cout << 2 << '\n';
        }
    }

    return 0;
}