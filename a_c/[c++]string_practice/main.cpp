#include <iostream>

using namespace std;

int main()
{

   string imie;
    cout<<"Podaj imie:";
    cin>> imie;

    int dlugosc=imie.length();

    if (imie[dlugosc-1]=='a')
        cout<<"Wydaje mmi sie, ze jestes kobieta";
        else cout<< "wydaje mi sie, ze jestes facetem";



    return 0;
}