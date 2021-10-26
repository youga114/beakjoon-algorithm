#include <iostream>
#include <stack>
#include <string>

using namespace std;

int main(int argc, char** argv) {
    int n;
    cin >> n;
    while(n--) {
        string str;
        cin >> str;
        stack<char> s;

        bool flag = false;
        for (int i = 0; i < str.length(); ++i) {
            if (str[i] == '(') {
                s.push('(');
            }
            else {
                if (s.empty() == true) {
                    flag = true;
                    break;
                }
                s.pop();
            }
        }

        if (flag == true) {
            cout << "NO\n";
        }
        else if (s.empty() == true) {
            cout << "YES\n";
        }
        else {
            cout << "NO\n";
        }   
    }

    return 0;
}