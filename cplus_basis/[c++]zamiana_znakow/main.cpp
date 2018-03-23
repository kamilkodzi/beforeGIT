#include <iostream>
#include <string>
#include <algorithm>

using namespace std;

int main()
{
   string napis="Ala ma kota";

  napis.replace(4,2,"nie ma");
  cout<<napis;
    return 0;
}
