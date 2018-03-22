#include <iostream>

using namespace std;

class Ksztalt
{
public:
    virtual void oblicz_pole()=0;
    //czysta funkcja wirtualna
};

class Kolo:public Ksztalt
{
    float r;
public:
    Kolo(float x)
    {
        r=x;
    }
    virtual void oblicz_pole()
    {
        cout<<"Pole kola: "<<3.14*r*r<<endl;
    }
};
class Kwadrat:public Ksztalt
{
    float a;
public:
    Kwadrat (float x)
    {
        a=x;
    }
    virtual void oblicz_pole()
    {
        cout<<"pole kwadratu: "<<a*a<<endl;
    }
};
void obliczenia(Ksztalt *x)
{
    x->oblicz_pole();
}

int main()
{
    Kolo k(18.5);
    Kwadrat kw(5);

    Ksztalt *wsk;

    wsk=&k;
    wsk->oblicz_pole();

    wsk=&kw;
    wsk->oblicz_pole();

    obliczenia(&kw);
    return 0;
}
