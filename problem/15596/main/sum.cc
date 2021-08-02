#include "main/sum.h"

long long sum(vector<int> &a)
{
    long long retNum = 0;
    for (int i = 0; i < a.size(); ++i) {
        retNum += a[i];
    }

    return retNum;
}