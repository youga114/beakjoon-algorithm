#include <iostream>
#include <stack>
#include <string>

using namespace std;

int main()
{
    string str;
    stack<char> st;
    int answer = 0;
    
    getline(cin, str);
    
    bool flag = false;
    for (int i = 0; i < str.length(); ++i)
    {
        if (str[i] == '(')
        {
            flag = true;
            st.push(str[i]);
        }
        else 
        {
            st.pop();
            if (flag == true)
            {
                answer += st.size();
            }
            else 
            {
                answer++;
            }
            flag = false;
        }
    }
    
    cout << answer;

    return 0;
}
