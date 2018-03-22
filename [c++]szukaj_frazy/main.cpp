#include <iostream>
#include <string>
#include <algorithm>

using namespace std;

int main()
{
   string napis="Ala ma kota";
   string szukaj="kot";

   size_t pozycja=napis.find(szukaj);


   if (pozycja!=string::npos)
    cout<<"Znalezio na pozycji: "<<pozycja;
    else cout<<"Nie znaleziono!";

    return 0;
}
