#include <iostream>
#include <vector>

using namespace std;

int main(int argc, char** argv) {
    const int len = 10001;
    vector<bool> v(len, true);

    for(int i = 1; i < len; ++i) {
        if(v[i] == false) {
            continue;
        }

        int n = i;
        while(n < len) {
            int j = 1, temp = n;
            while(j < len) {
                temp += n / j % 10;
                j *= 10;
            }

            n = temp;

            if(v[n] == false) {
                break;
            }

            v[n] = false;
        }
    }

    for(int i = 1; i < len; ++i) {
        if(v[i] == true) {
            cout << i << endl;
        }
    }

    return 0;
}