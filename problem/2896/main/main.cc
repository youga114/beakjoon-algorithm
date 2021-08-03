#include <iostream>

using namespace std;

int main(int argc, char** argv) {
    long long A, B, V;
    cin >> A >> B >> V;

    cout << ((V - A) / (A - B)) + 1;

    return 0;
}
