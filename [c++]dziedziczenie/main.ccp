#include <iostream>
#include<math.h>
using namespace std;

class Punkt
{
    float x,y;
    string nazwa;

public:
    void wyswietl()
    {
        cout<<nazwa<<"("<<x<<","<<y<<")"<<endl;
    }
    Punkt(string n="S", float a=0 , float b=0)
    {
        nazwa=n;
        x=a;
        y=b;
    }
};

class Kolo:public Punkt //klasa kolo dziedziczy publicznie z kalsy punkt
{
protected:
    float r;
    string nazwa;

public:
    void wyswietl()
    {
        cout<<"Kolo o nazwie: "<<nazwa<<endl;
        cout<<"Srodek kola: "<<endl;
        Punkt::wyswietl();
        cout<<"Promien: "<<r<<endl;
        cout<<"Pole kola: "<<M_PI*r*r<<endl;

    }
    Kolo(string nk="Kolko",string np="S", float a=0,float b=0, float pr=1)
    :Punkt(np,a,b)
    {
        nazwa=nk;
        r=pr;
    }
};

class Kula:public Kolo
{
    string nazwa;

public:
    wyswietl()
    {
        cout<<"Kula o nazwie: "<<nazwa<<endl;
        cout<<"Promien kuli: "<<r<<endl;
        cout<<"Objetosc kuli: "<<(4/3)*(M_PI*r*r*r)<<endl;
    }

    Kula(string nk="Kulka",string np="G", float a=0,float b=0,float=0, float pr=2)
    :Kolo(nk,np,a,b,pr)
    {
        nazwa=nk;
    }

};


int main()
{
    Kula k1;
    k1.wyswietl();
    return 0;
}
