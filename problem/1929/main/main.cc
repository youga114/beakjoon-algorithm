#include <iostream>

using namespace std;

int main(int argc, char** argv) {
    // 1 <= min, max <= 1,000,000,000,000
    //min ~ max 까지의 소수를 출력하라 (한줄씩) ex) 3 16 -> 3\n5\n7\n11\n13\n
    
    // 에라토스테네스의 체(수학자! 모든 내용)
    int min, max;
    cin >> min >> max;

    bool allNum[max + 1];
    for(int i = 0; i <= max; ++i) {
        allNum[i] = true;
    };

    // [true, true, .... , true] 원소개수 17개 (0~16) 
    // [true(0), true(1), true(2), true(3), false(4), true(5), false(6) .. false(9), .. , false(16)]

    // max : 1,000,000
    // (2, 3)  101 * 101 -> 10201 
    // i * i 이유 : 101 보다 작은수에서 이미 배수를 false 로 만들때, 
    // ex) 2 * 101 = false;
    //     3 * 101 = false;
    //     5 * 101 = false;

    for(unsigned long long i = 2; i <= max; ++i) {
        if(allNum[i] == true) {
            if(i >= min) {
                cout << i << '\n';
            }       //endl 은 flush buffer(버퍼에 출력을 채우는데 그 버퍼를 비우는 작업)
            for(unsigned long long j = i * i/* (i * 2) 는 "시간초과"*/; j <= max; j += i) {
                allNum[j] = false;
            }
        }
    }

    return 0;
}
