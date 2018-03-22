#include <iostream>

using namespace std;

long int potega(int p, int w)
{
    if(w==0) return 1;
    else return p*potega(p,w-1);

}

long int fib(int n)
{
    if (n==1|| n==2) return 1;
    else return fib(n-1)+fib(n-2);

}

long int silnia(int n)
{
    if (n==0) return 1;
    else return n*silnia(n-1);

}


int main()
{
    int poprzednia=1;
    int nowa,staraliczba,wynik;

    for (int i=1; i<=44;i++)
    {
        nowa=staraliczba+poprzednia;
        wynik=wynik+nowa;
        staraliczba=poprzednia;
        poprzednia=nowa;


    }

    cout<<wynik<<endl;
    cout<<fib(44)<<endl;
     return 0;
}


