#include <iostream>

using namespace std;

float srednia(float &a, float &b, float &c)
{
    return (a+b+c)/3;
}


int main()
{
    float a,b,c;

    a=1.5;
    b=2.3;
    c=0.75;

  cout<<"Srednia wynosi: "<<srednia(a,b,c)<<endl;

    return 0;
}
