#include <iostream>
#include <math.h>

using namespace std;

int main(int argc, char** argv) {
    double A, B, V;
    cin >> A >> B >> V;

    cout << static_cast<int>(ceil((V - A) / (A - B))) + 1;

    return 0;
}