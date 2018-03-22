Sub raporter()

Dim zapisaniedaty As Range
Dim pasekcopy As Range
Dim wersja As Range
Dim paletynavehu As Range
Set wersja = Sheet2.Range("V2")


Set zapisaniedaty = Sheet2.Range("W1")
zapisaniedaty = zapisaniedaty.Value
klucz = Sheet2.Range("V4")
wersja = Sheet2.Range("V2")


Application.Calculation = xlCalculationManual
Application.ScreenUpdating = False


miejsceraportu = Sheet2.Range("AC8")


Dim planmaker As Workbook: Set planmaker = ActiveWorkbook

'defioniowanie pliku raporty
Application.DisplayAlerts = False
Dim wkb1 As Workbook:  Set wkb1 = Workbooks.Open(Sheet2.Range("AC8"))
Dim wks1 As Worksheet: Set wks1 = wkb1.Sheets("zaplanowane trasy")
    

  

counter = Sheets("zaplanowane trasy").Range("S2")
zacznij = Sheets("zaplanowane trasy").Range("S1")
    Sheets("zaplanowane trasy").Activate
    
  For Z = zacznij To counter
    keyplace = Sheets("zaplanowane trasy").Cells(Z, 12)
    If Left(keyplace, 17) = klucz Then
        Rows(Z).Delete
        Z = Z - 1
    End If
    
  Next Z
    
     planmaker.Activate
   
    For x = 11 To 801
        planmaker.Activate
        vehicle = Sheet2.Cells(x, 24)
        Set pasekcopy = Sheet2.Range(Sheet2.Cells(x, 23), Sheet2.Cells(x, 34))
        Set paletynavehu = Sheet2.Range(Sheet2.Cells(x, 100), Sheet2.Cells(x, 102))
        pasekcopy.Copy
        
            If vehicle <> Empty Then
                wks1.Activate
                Range("A1000000").End(xlUp).Offset(1, 0).PasteSpecial xlPasteValuesAndNumberFormats
                Selection.PasteSpecial xlPasteValuesAndNumberFormats
                paletynavehu.Copy
                Range("M1000000").End(xlUp).Offset(1, 0).PasteSpecial xlPasteValuesAndNumberFormats
                Selection.PasteSpecial xlPasteValuesAndNumberFormats
                
                Else


            End If
                
    Next x
    








wks1.Activate




Application.Calculation = xlCalculationAutomatic
Application.DisplayAlerts = False
Application.ScreenUpdating = True


ActiveWorkbook.SaveAs Filename:=miejsceraportu, FileFormat:=51
ActiveWorkbook.Close savechanges = True
Range("W9").Select

wersja = wersja + 1
Application.DisplayAlerts = True

End Sub
