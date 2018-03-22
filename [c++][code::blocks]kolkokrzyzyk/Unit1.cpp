//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Unit1.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TForm1 *Form1;
char p1,p2,p3,p4,p5,p6,p7,p8,p9;
//pi...9 pola w grze (ich zawartosc: p1='n' ; lub 'x' lub 'o')
 char kto;

 void sprawdz()
 {
	if((p1==p2 && p2==p3 && p1!='n') ||
	  (p4==p5 && p5==p6 && p4!='n') ||
	  (p7==p8 && p8==p9 && p7!='n') ||
	  (p1==p4 && p4==p7 && p7!='n') ||
	  (p2==p5 && p5==p8 && p2!='n') ||
	  (p3==p6 && p6==p9 && p3!='n') ||
	  (p1==p5 && p5==p9 && p1!='n') ||
	  (p3==p5 && p5==p7 && p3!='n'))
	   {
		  char * wiad;
		  if (kto=='x') Application->MessageBoxW(L"Wygrywa kółko!",L"Wygrana",MB_OK) ;
		  else Application->MessageBoxW(L"Wygrywa krzyżyk!",L"Wygrana",MB_OK) ;
	   }
 }



//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
	: TForm(Owner)
{
}
//---------------------------------------------------------------------------
void __fastcall TForm1::FormCreate(TObject *Sender)
{
	pole1->Picture->LoadFromFile("img/nic.bmp");
	pole2->Picture->LoadFromFile("img/nic.bmp");
	pole3->Picture->LoadFromFile("img/nic.bmp");
	pole4->Picture->LoadFromFile("img/nic.bmp");
	pole5->Picture->LoadFromFile("img/nic.bmp");
	pole6->Picture->LoadFromFile("img/nic.bmp");
	pole7->Picture->LoadFromFile("img/nic.bmp");
	pole8->Picture->LoadFromFile("img/nic.bmp");
	pole9->Picture->LoadFromFile("img/nic.bmp");
	tura->Picture->LoadFromFile("img/osmall.bmp");

	  p1='n'  ; p2='n'  ; p3='n'  ;
	  p4='n'  ; p5='n'  ; p6='n'  ;
	  p7='n'  ; p8='n'  ; p9='n'  ;

	  kto='o' ;

	  pole1->Enabled=True ;
	  pole2->Enabled=True ;
	  pole3->Enabled=True ;
	  pole4->Enabled=True ;
	  pole5->Enabled=True ;
	  pole6->Enabled=True ;
	  pole7->Enabled=True ;
	  pole8->Enabled=True ;
	  pole9->Enabled=True ;
}
//---------------------------------------------------------------------------
void __fastcall TForm1::pole1Click(TObject *Sender)
{
		if(p1=='n')
		{
		  if(kto=='o')
		  {
			 pole1->Picture->LoadFromFile("img/o.bmp") ;
			 p1='o' ;
			 kto='x';
			 tura->Picture->LoadFromFile("img/xsmall.bmp");
		  }
		  else
		  {
			 pole1->Picture->LoadFromFile("img/x.bmp") ;
			 p1='x' ;
			 kto='o';
			 tura->Picture->LoadFromFile("img/osmall.bmp");
		  }
		  pole1->Enabled=false  ;
		  sprawdz();
		}
}
//---------------------------------------------------------------------------
void __fastcall TForm1::pole2Click(TObject *Sender)
{
		if(p2=='n')
		{
		  if(kto=='o')
		  {
			 pole2->Picture->LoadFromFile("img/o.bmp") ;
			 p2='o' ;
			 kto='x';
			 tura->Picture->LoadFromFile("img/xsmall.bmp");
		  }
		  else
		  {
			 pole2->Picture->LoadFromFile("img/x.bmp") ;
			 p2='x' ;
			 kto='o';
			 tura->Picture->LoadFromFile("img/osmall.bmp");
		  }
		  pole2->Enabled=false  ;
		  sprawdz();
		}
}
//---------------------------------------------------------------------------
void __fastcall TForm1::pole3Click(TObject *Sender)
{
		if(p3=='n')
		{
		  if(kto=='o')
		  {
			 pole3->Picture->LoadFromFile("img/o.bmp") ;
			 p3='o' ;
			 kto='x';
			 tura->Picture->LoadFromFile("img/xsmall.bmp");
		  }
		  else
		  {
			 pole3->Picture->LoadFromFile("img/x.bmp") ;
			 p3='x' ;
			 kto='o';
			 tura->Picture->LoadFromFile("img/osmall.bmp");
		  }
		  pole3->Enabled=false  ;
		  sprawdz();
		}
}
//---------------------------------------------------------------------------
void __fastcall TForm1::pole4Click(TObject *Sender)
{
		if(p4=='n')
		{
		  if(kto=='o')
		  {
			 pole4->Picture->LoadFromFile("img/o.bmp") ;
			 p4='o' ;
			 kto='x';
			 tura->Picture->LoadFromFile("img/xsmall.bmp");
		  }
		  else
		  {
			 pole4->Picture->LoadFromFile("img/x.bmp") ;
			 p4='x' ;
			 kto='o';
			 tura->Picture->LoadFromFile("img/osmall.bmp");
		  }
		  pole4->Enabled=false  ;
		  sprawdz();
		}
}
//---------------------------------------------------------------------------
void __fastcall TForm1::pole5Click(TObject *Sender)
{
		if(p5=='n')
		{
		  if(kto=='o')
		  {
			 pole5->Picture->LoadFromFile("img/o.bmp") ;
			 p5='o' ;
			 kto='x';
			 tura->Picture->LoadFromFile("img/xsmall.bmp");
		  }
		  else
		  {
			 pole5->Picture->LoadFromFile("img/x.bmp") ;
			 p5='x' ;
			 kto='o';
			 tura->Picture->LoadFromFile("img/osmall.bmp");
		  }
		  pole5->Enabled=false  ;
		  sprawdz();
		}
}
//---------------------------------------------------------------------------
void __fastcall TForm1::pole6Click(TObject *Sender)
{
		if(p6=='n')
		{
		  if(kto=='o')
		  {
			 pole6->Picture->LoadFromFile("img/o.bmp") ;
			 p6='o' ;
			 kto='x';
			 tura->Picture->LoadFromFile("img/xsmall.bmp");
		  }
		  else
		  {
			 pole6->Picture->LoadFromFile("img/x.bmp") ;
			 p6='x' ;
			 kto='o';
			 tura->Picture->LoadFromFile("img/osmall.bmp");
		  }
		  pole6->Enabled=false  ;
		  sprawdz();
		}
}
//---------------------------------------------------------------------------
void __fastcall TForm1::pole7Click(TObject *Sender)
{
		if(p7=='n')
		{
		  if(kto=='o')
		  {
			 pole7->Picture->LoadFromFile("img/o.bmp") ;
			 p7='o' ;
			 kto='x';
			 tura->Picture->LoadFromFile("img/xsmall.bmp");
		  }
		  else
		  {
			 pole7->Picture->LoadFromFile("img/x.bmp") ;
			 p7='x' ;
			 kto='o';
			 tura->Picture->LoadFromFile("img/osmall.bmp");
		  }
		  pole7->Enabled=false  ;
		  sprawdz();
		}
}
//---------------------------------------------------------------------------
void __fastcall TForm1::pole8Click(TObject *Sender)
{
		if(p8=='n')
		{
		  if(kto=='o')
		  {
			 pole8->Picture->LoadFromFile("img/o.bmp") ;
			 p8='o' ;
			 kto='x';
			 tura->Picture->LoadFromFile("img/xsmall.bmp");
		  }
		  else
		  {
			 pole8->Picture->LoadFromFile("img/x.bmp") ;
			 p8='x' ;
			 kto='o';
			 tura->Picture->LoadFromFile("img/osmall.bmp");
		  }
		  pole8->Enabled=false  ;
		  sprawdz();
		}
}
//---------------------------------------------------------------------------
void __fastcall TForm1::pole9Click(TObject *Sender)
{
		if(p9=='n')
		{
		  if(kto=='o')
		  {
			 pole9->Picture->LoadFromFile("img/o.bmp") ;
			 p9='o' ;
			 kto='x';
			 tura->Picture->LoadFromFile("img/xsmall.bmp");
		  }
		  else
		  {
			 pole9->Picture->LoadFromFile("img/x.bmp") ;
			 p9='x' ;
			 kto='o';
			 tura->Picture->LoadFromFile("img/osmall.bmp");
		  }
		  pole9->Enabled=false  ;
		  sprawdz();
		}
}
//---------------------------------------------------------------------------