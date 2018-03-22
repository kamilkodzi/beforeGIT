Sub plan_file()
Dim checker
checker = 0
'Przyspieszacz'
Application.ScreenUpdating = False
Application.Calculation = xlCalculationManual
'przyspieszacz'


'Tworzenie naglowka tabeli
Sheet23.Range("AM1:AQ2").copy
Sheet24.Range("A3000").End(xlUp).PasteSpecial xlPasteValuesAndNumberFormats

'Wklejanie Balma Hub1
Sheet23.Range("W3:AA18").copy
Sheet24.Range("A3000").End(xlUp).Offset(1, 0).PasteSpecial xlPasteValuesAndNumberFormats

'Wklejanie Balma Hub2
Sheet23.Range("W24:AA39").copy
Sheet24.Range("A3000").End(xlUp).Offset(1, 0).PasteSpecial xlPasteValuesAndNumberFormats

'Wklejanie Gyor
Sheet23.Range("W45:AA79").copy
Sheet24.Range("A3000").End(xlUp).Offset(1, 0).PasteSpecial xlPasteValuesAndNumberFormats
    
'Wklejanie Small Rigids
Sheet23.Range("AM3:AQ44").copy
Sheet24.Range("A3000").End(xlUp).Offset(1, 0).PasteSpecial xlPasteValuesAndNumberFormats
    
    
'Resztki Depo na 33 paletki
 For x = 3 To 14
    checker = 0
    na33 = Sheet23.Cells(x, 48)
    
        
            'Sprawdzamy checkerem czy orders jest juz w preplanie
            For y = 3 To 500
                preplanorder = Sheet24.Cells(y, 2)
                If preplanorder = na33 Then checker = 1
            Next y
        
       
    If na33 = "" Then Exit For
    If checker = 0 Then
      Sheet23.Range(Sheet23.Cells(x, 47), Sheet23.Cells(x, 51)).copy
    
    Sheet24.Range("A3000").End(xlUp).Offset(1, 0).PasteSpecial xlPasteValuesAndNumberFormats
    End If
    
 Next x

    
'Kolejny krok Wklejanie last dropa

For Z = 3 To 73


    checker2 = 0
    lasty = Sheet23.Cells(Z, 18)
    
        
            'Sprawdzamy checkerem czy orders jest juz w preplanie
            For g = 3 To 500
                preplanorder2 = Sheet24.Cells(g, 2)
                If preplanorder2 = lasty Then checker2 = 1
            Next g
        
       
    If checker2 = 0 Then
      Sheet23.Range(Sheet23.Cells(Z, 17), Sheet23.Cells(Z, 21)).copy
    
    Sheet24.Range("A3000").End(xlUp).Offset(1, 0).PasteSpecial xlPasteValuesAndNumberFormats
    End If
    
Next Z



'Kolejny krok wklejanie full trailer filow

For h = 3 To 97


    checker3 = 0
    fiul = Sheet23.Cells(h, 56)
    
        
            'Sprawdzamy checkerem czy orders jest juz w preplanie
            For hu = 3 To 500
                preplanorder3 = Sheet24.Cells(hu, 2)
                If preplanorder3 = fiul Then checker3 = 1
            Next hu
        
       
    If checker3 = 0 Then
      Sheet23.Range(Sheet23.Cells(h, 55), Sheet23.Cells(h, 59)).copy
    
    Sheet24.Range("A3000").End(xlUp).Offset(1, 0).PasteSpecial xlPasteValuesAndNumberFormats
    End If
    
Next h

    
    Call kasownik
    
    Sheet24.Activate

    Range(Sheet24.Cells(1, 1), Sheet24.Cells(200, 5).End(xlUp)).copy
    
    Workbooks.Add.Activate
    Selection.PasteSpecial paste:=xlPasteValues, Operation:=xlNone, SkipBlanks _
            :=False, Transpose:=False
    Selection.PasteSpecial paste:=xlPasteFormats, Operation:=xlNone, _
            SkipBlanks:=False, Transpose:=False

    
'koniec przyspieszacza'
Application.ScreenUpdating = True
Application.Calculation = xlCalculationAutomatic
'koniec przyszpieszacza'






End Sub
