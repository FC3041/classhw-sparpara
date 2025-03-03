#include<iostream>
#include<cstring>

using namespace std;

class MyStr
{
    public:
    int m_size;
    char* m_PChars;

    MyStr():m_size(0),m_PChars(nullptr){};

    MyStr(const char* chars)
    {
        int i;
        for(i=0;chars[i]!='\0';i++);
        m_size = i+1;

        m_PChars = (char*)malloc(sizeof(char)*(m_size));
        for(i=0; i<m_size;i++)
        {
            m_PChars[i] = chars[i];
        }
        m_PChars[m_size] = '\0';
    }

    MyStr(const char* chars, int start, int count)
    :m_size(count)
    {
        m_PChars = (char*)malloc(sizeof(char)*(m_size+1));

        for(int i=0;i<m_size ;i++)
        {
            m_PChars[i] = chars[start+i];
        }
        m_PChars[count] = '\0';

    }

    ~MyStr()
    {
        if (m_PChars)
        {
            free(m_PChars); 
        }
    }

    void printStr()
    {
        cout << m_PChars << endl;
    }

    int checkSubstr(MyStr str){
        for(int i = 0; i< m_size -str.m_size+1; i++){
            MyStr s1(m_PChars,i,str.m_size-1);
            cout << s1.m_PChars << " ";
            
            if(strcmp(s1.m_PChars,str.m_PChars) == 0)
                return i;
        }
        return -1;
    }

    int len(){
        return m_size-1;
    }

    void add(MyStr s1){
        char* n_PChars = (char*)malloc(sizeof(char)*(s1.m_size + m_size));
        int i ;
        for(i = 0; i<m_size; i++)
            n_PChars[i] = m_PChars[i];
        for(; i<m_size+s1.m_size-1;i++)
            n_PChars[i] = s1.m_PChars[i-m_size];
        free(m_PChars);
        m_PChars = n_PChars;
        m_size = m_size+s1.m_size-1;
        return;
    }
    
};


int main()
{
    MyStr s1("anghezi");

    MyStr s2("malihe hajihosseini", 7, 12);
    s2.printStr();

    cout << s2.checkSubstr("haji") << endl; // TODO1
    s2.len(); //TODO2
    s2.add(s1); // TODO3 
    s2.printStr();
    cout << s2.m_size << " ";
    
}