//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Unit1.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TForm1 *Form1;
int x=-8,y=-8;
int dowygranej=30;
bool kolizja(TImage * pilka, TImage * cegla)
{
	if (pilka->Left  >=  cegla->Left  -  pilka->Width &&
		pilka->Left  <=  cegla->Left  +  cegla->Width &&
		pilka->Top   >=  cegla->Top   -  pilka->Height&&
		pilka->Top   <=  cegla->Top   +  cegla->Height )
		{
			return true ;
		}
		else return false;
}

//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
	: TForm(Owner)
{
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Timer_pilkaTimer(TObject *Sender)
{
 b->Left+=x;
 b->Top+=y;

 //odbij od lewej sciany
 if(b->Left-5<=tlo->Left) x=-x   ;

  //odbij od lewej sciany
 if(b->Top-5<=tlo->Top) y=-y ;

  //odbij od lewej sciany
 if(b->Left+b->Width+5 >= tlo->Width) x=-x ;

 //skucha
 if(b->Top>=p->Top+p->Height+15)
 {
	 Timer_pilka->Enabled=false;
	 b->Visible=false;
	 button1->Caption="PORAŻKA!, raz jeszcze" ;
	 button1->Visible=true  ;
 }else if ( b->Left > p->Left - b->Width/2  &&   b->Left  <  p->Left  +  p->Width &&
			b->Top  +  b->Height  >  p->Top)
 {
			if(y>0)y=-y;
 }
	 if(dowygranej<=0)
	 {
		 Timer_pilka->Enabled=false;
		 b->Visible=false;
		 button1->Caption="WYGRANA!, raz jeszcze";
		 button1->Visible=True  ;
	 }

   //blook1
   if(kolizja(b,Image1) && Image1->Visible==true)
   {
   x=-x ; y=-y ; Image1->Visible=false; dowygranej--;
   }
	  //blook2
   if(kolizja(b,Image2) && Image2->Visible==true)
   {
   x=-x ; y=-y ; Image2->Visible=false; dowygranej--;
   }
	  //blook3
   if(kolizja(b,Image3) && Image3->Visible==true)
   {
   x=-x ; y=-y ; Image3->Visible=false; dowygranej--;
   }
	  //blook4
   if(kolizja(b,Image4) && Image4->Visible==true)
   {
   x=-x ; y=-y ; Image4->Visible=false; dowygranej--;
   }
	  //blook5
   if(kolizja(b,Image5) && Image5->Visible==true)
   {
   x=-x ; y=-y ; Image5->Visible=false; dowygranej--;
   }
	  //blook6
   if(kolizja(b,Image6) && Image4->Visible==true)
   {
   x=-x ; y=-y ; Image6->Visible=false; dowygranej--;
   }
	  //blook7
   if(kolizja(b,Image7) && Image7->Visible==true)
   {
   x=-x ; y=-y ; Image7->Visible=false; dowygranej--;
   }
	  //blook8
   if(kolizja(b,Image8) && Image8->Visible==true)
   {
   x=-x ; y=-y ; Image8->Visible=false; dowygranej--;
   }
	  //blook9
   if(kolizja(b,Image9) && Image9->Visible==true)
   {
   x=-x ; y=-y ; Image9->Visible=false; dowygranej--;
   }
	  //blook10
   if(kolizja(b,Image10) && Image10->Visible==true)
   {
   x=-x ; y=-y ; Image10->Visible=false; dowygranej--;
   }
	  //blook11
   if(kolizja(b,Image11) && Image11->Visible==true)
   {
   x=-x ; y=-y ; Image11->Visible=false; dowygranej--;
   }
	  //blook12
   if(kolizja(b,Image12) && Image12->Visible==true)
   {
   x=-x ; y=-y ; Image12->Visible=false; dowygranej--;
   }
	  //blook13
   if(kolizja(b,Image13) && Image13->Visible==true)
   {
   x=-x ; y=-y ; Image13->Visible=false; dowygranej--;
   }
	  //blook14
   if(kolizja(b,Image14) && Image14->Visible==true)
   {
   x=-x ; y=-y ; Image14->Visible=false; dowygranej--;
   }
   	  //blook4
   if(kolizja(b,Image15) && Image15->Visible==true)
   {
   x=-x ; y=-y ; Image15->Visible=false; dowygranej--;
   }
	  //blook16
   if(kolizja(b,Image16) && Image16->Visible==true)
   {
   x=-x ; y=-y ; Image16->Visible=false; dowygranej--;
   }
	  //blook17
   if(kolizja(b,Image17) && Image17->Visible==true)
   {
   x=-x ; y=-y ; Image17->Visible=false; dowygranej--;
   }
	  //blook18
   if(kolizja(b,Image18) && Image18->Visible==true)
   {
   x=-x ; y=-y ; Image18->Visible=false; dowygranej--;
   }
	  //blook19
   if(kolizja(b,Image19) && Image19->Visible==true)
   {
   x=-x ; y=-y ; Image19->Visible=false; dowygranej--;
   }
	  //blook20
   if(kolizja(b,Image20) && Image20->Visible==true)
   {
   x=-x ; y=-y ; Image20->Visible=false; dowygranej--;
   }
	  //blook21
   if(kolizja(b,Image21) && Image21->Visible==true)
   {
   x=-x ; y=-y ; Image21->Visible=false; dowygranej--;
   }
	  //blook22
   if(kolizja(b,Image22) && Image22->Visible==true)
   {
   x=-x ; y=-y ; Image22->Visible=false; dowygranej--;
   }
	  //blook23
   if(kolizja(b,Image23) && Image23->Visible==true)
   {
   x=-x ; y=-y ; Image23->Visible=false; dowygranej--;
   }
	  //blook24
   if(kolizja(b,Image24) && Image24->Visible==true)
   {
   x=-x ; y=-y ; Image24->Visible=false; dowygranej--;
   }
	  //blook25
   if(kolizja(b,Image25) && Image25->Visible==true)
   {
   x=-x ; y=-y ; Image25->Visible=false; dowygranej--;
   }
	  //blook26
   if(kolizja(b,Image26) && Image26->Visible==true)
   {
   x=-x ; y=-y ; Image26->Visible=false; dowygranej--;
   }
	  //blook27
   if(kolizja(b,Image27) && Image27->Visible==true)
   {
   x=-x ; y=-y ; Image27->Visible=false; dowygranej--;
   }
	  //blook28
   if(kolizja(b,Image28) && Image28->Visible==true)
   {
   x=-x ; y=-y ; Image28->Visible=false; dowygranej--;
   }
	  //blook29
   if(kolizja(b,Image29) && Image29->Visible==true)
   {
   x=-x ; y=-y ; Image29->Visible=false; dowygranej--;
   }
	  //blook30
   if(kolizja(b,Image30) && Image30->Visible==true)
   {
   x=-x ; y=-y ; Image30->Visible=false; dowygranej--;
   }

}



//---------------------------------------------------------------------------
void __fastcall TForm1::lewoTimer(TObject *Sender)
{
	   if (p->Left>10) p->Left -=10;
}
//---------------------------------------------------------------------------
void __fastcall TForm1::prawoTimer(TObject *Sender)
{
	   if (p->Left+p->Width<tlo->Width-15) p->Left +=10;
}
//---------------------------------------------------------------------------
void __fastcall TForm1::FormKeyDown(TObject *Sender, WORD &Key, TShiftState Shift)

{
	 if(Key==VK_LEFT) lewo->Enabled=true;
	 if(Key==VK_RIGHT) prawo->Enabled=true;
}
//---------------------------------------------------------------------------
void __fastcall TForm1::FormKeyUp(TObject *Sender, WORD &Key, TShiftState Shift)
{
	 if(Key==VK_LEFT) lewo->Enabled=False;
	 if(Key==VK_RIGHT) prawo->Enabled=False;
}
//---------------------------------------------------------------------------
void __fastcall TForm1::button1Click(TObject *Sender)
{
	  b->Left=50;
	  b->Top=50;

	  b->Visible=true;
	  x=-8;y=-8;
	  Timer_pilka->Enabled=true;

	  button1->Visible=false;
	  dowygranej=30;

	  Image1->Visible=true;  Image21->Visible= true;
	  Image2->Visible=true;  Image22->Visible= true;
	  Image3->Visible=true;  Image23->Visible= true;
	  Image4->Visible=true;  Image24->Visible= true;
	  Image5->Visible=true;  Image25->Visible= true;
	  Image6->Visible=true;  Image26->Visible= true;
	  Image7->Visible=true;  Image27->Visible= true;
	  Image8->Visible=true;  Image28->Visible= true;
	  Image9->Visible=true;  Image29->Visible= true;
	  Image10->Visible=true; Image30->Visible= true;

	  Image11->Visible=true;
	  Image12->Visible=true;
	  Image13->Visible=true;
	  Image14->Visible=true;
	  Image15->Visible=true;
	  Image16->Visible=true;
	  Image17->Visible=true;
	  Image18->Visible=true;
	  Image19->Visible=true;
	  Image20->Visible=true;


}
//---------------------------------------------------------------------------
void __fastcall TForm1::bClick(TObject *Sender)
{

}
//---------------------------------------------------------------------------
