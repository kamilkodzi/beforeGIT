Sub Button2_Click()

On Error GoTo Buba
eldatos = Sheets("Data Verification").Range("C5")
Windows("Planning information " & Format$(eldatos, ("dd-mm")) & ".xls").Activate
Dim Rng As Range
Dim Rng2 As Range
On Error Resume Next

Windows("Planning information " & Format$(eldatos, ("dd-mm")) & ".xls").Activate
Sheets("Store demand").Activate

Set Rng = Application.InputBox(prompt:="P O D A J - L A S T - D R O P Y", Type:=8, Title:="LAST DROPY- JESLI BRAK ZAZNACZ PUSTA KOMORKE")


Rng.copy
Sheet23.Range("F3").PasteSpecial xlPasteValuesAndNumberFormats



'tutaj pracuje przed obiedam890690857895789----------------------

Set Rng = Application.InputBox(prompt:="! ! ! - N O W O S C - Z M I A N A - G O D Z I N - ! ! !", Type:=8, Title:="PODAJ SKLEPY ZE ZMIENIONA GODZINA")
Set Rng2 = Rng.Offset(0, 2)
Rng.copy
Sheet23.Range("BK2").PasteSpecial xlPasteValuesAndNumberFormats
Rng2.copy
Sheet23.Range("BJ2").PasteSpecial xlPasteValuesAndNumberFormats



' tutaj bedzie wywolanie formatki ^-----------------



'Zaznaczamu huby albo huy

Windows("Planning information " & Format$(eldatos, ("dd-mm")) & ".xls").Activate
Sheets("HUBS").Activate

Set Rng = Application.InputBox(prompt:=" P O D A J - P I E R W S Z Y  - H U B ", Type:=8, Title:="HUB- JESLI BRAK ZAZNACZ PUSTA KOMORKE")


Rng.copy
Sheet23.Range("J3").PasteSpecial xlPasteValuesAndNumberFormats


'Zaznaczamy huby sruby

Windows("Planning information " & Format$(eldatos, ("dd-mm")) & ".xls").Activate
Sheets("HUBS").Activate

Set Rng = Application.InputBox(prompt:=" P O D A J - D R U G I  - H U B ", Type:=8, Title:="HUB2- JESLI BRAK ZAZNACZ PUSTA KOMORKE")


Rng.copy
Sheet23.Range("L3").PasteSpecial xlPasteValuesAndNumberFormats


'nowosc- dodaj directy ;0
'-----------------------------
Set Rng = Application.InputBox(prompt:="! ! ! - N O W O S C - D I R E C T Y - ! ! !", Type:=8, Title:="DIRECT1- JESLI BRAK ZAZNACZ PUSTA KOMORKE")
Rng.copy
Sheet23.Range("BO2").PasteSpecial xlPasteValuesAndNumberFormats
'-----------------------------
'Sheet4.Activate
Sheets("Pre-plan Gyal").Activate

'------------------------------







Exit Sub

Buba:
MsgBox ("Nie masz otwartego pliku planning information lub zla data lub zabezpieczony planning information")


End Sub



