#include <iostream>

using namespace std;

int main(int argc, char** argv) {
    int min, max;
    cin >> min >> max;

    bool allNum[max + 1];
    for(int i = 0; i <= max; ++i) {
        allNum[i] = true;
    };

    for(unsigned long long i = 2; i <= max; ++i) {
        if(allNum[i] == true) {
            if(i >= min) {
                cout << i << '\n';
            }
            for(unsigned long long j = i * i; j <= max; j += i) {
                allNum[j] = false;
            }
        }
    }

    return 0;
}
