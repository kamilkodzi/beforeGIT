#include <iostream>
#include <cmath>
#include<string>
using namespace std;

float liczba[5], roznica[5];
float suma, srednia, w, r;
string wygrany;

int main()
{
    cout << "Podaj 5 liczb oddzielonych spacja: ";
    cin>>liczba[0]>>liczba[1]>>liczba[2]>>liczba[3]>>liczba[4];

    suma = liczba[0]+liczba[1]+liczba[2]+liczba[3]+liczba[4];
    srednia = suma/5;
/*
   for (int i=0; i<5; i++)
    {
        roznica[i]=srednia-liczba[i];
    }

    w = liczba[0];
    r = abs(roznica[0]);

     for (int i=0; i<5; i++)
    {
        if (abs(r)>abs(roznica[i])) r=abs(roznica[i]), w=liczba[i];
    }
    cout<<"srednia: "<<srednia<<endl;
    cout << "najblizej: "<<w;


*/
for (int i=0;i=4;i++)
{
    if(   (i=0) || abs(srednia-liczba[i])<w  )
        {

          w=liczba[i];
          wygrany=liczba[i];
        }
    if (  abs(srednia-liczba[i])  == w)
        {
          wygrany=liczba[i];

        }

}
    cout<<wygrany;


    return 0;
}
