#include <iostream>
#include <stack>
#include <string>

using namespace std;

int main(int argc, char** argv) {
    int n;
    stack<int> s;

    cin >> n;

    for(int i = 0; i < n; ++i) {
        string cmd;
        cin >> cmd;

        if(cmd == "push") {
            int num;
            cin >> num;

            s.push(num);
        } else if (cmd == "pop") {
            if (s.empty() == 1) {
                cout << -1 << '\n';
                continue;
            }
            
            cout << s.top() << '\n';
            s.pop();
        } else if (cmd == "size") {
            cout << s.size() << '\n';
        } else if (cmd == "empty") {
            cout << s.empty() << '\n';
        } else {
            cout << ((s.empty() == 1) ? -1 : s.top()) << '\n';
        }
    }

    return 0;
}