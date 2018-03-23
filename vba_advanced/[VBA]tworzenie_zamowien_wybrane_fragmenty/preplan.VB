Sub Szuk_num_depo()
Dim prawda As Single
Dim numerordera As Single

'Przyspieszacz'
Application.ScreenUpdating = False
Application.Calculation = xlCalculationManual
'przyspieszacz'

Sheet23.Activate
Sheet23.Range("B42:D79").clear
Sheet23.Range("AG3:AG42").clear
Sheet23.Range("AM3:AO44").clear
Sheet23.Range("O3:O125").clear
Sheet23.Range("BB3:BB97").clear
Sheet23.Range("BH3:BH97").clear
Sheet24.Activate
Sheet24.Range("A1:E500").clear

Sheet23.Activate

Sheet23.Range("M3:M78").copy
Sheet23.Range("F79").End(xlUp).Offset(2, 0).PasteSpecial xlPasteValuesAndNumberFormats




'Dla kazdego pierwszego numeru depo

    For x = 3 To 39
    
    store1 = Sheet23.Cells(x, 2)

    'Jesli pierwszy numer depo nie istnieje przerywamy pentle
    If store1 = "" Then
    Exit For
    End If
          
    Sheet23.Cells(x + 39, 2) = Application.WorksheetFunction.VLookup(store1, Sheet2.Range("B5:Q500"), 16, 0)
    'Sheet23.Cells(x, 41) = 1
    Next x
            
        'Dla kazdego drugiego numeru depo
        
    For y = 3 To 39
        store2 = Sheet23.Cells(y, 3)
            
                    If store2 = "" Then
                    Sheet23.Cells(y + 39, 3) = ""
                    Else
                    Sheet23.Cells(y + 39, 3) = Application.WorksheetFunction.VLookup(store2, Sheet2.Range("B5:Q500"), 16, 0)
                    'Sheet23.Range("AO80").End(xlUp).Offset(1, 0) = 2
                    End If
     Next y


    'Dla 3ciego numeru depo- slabo mi juz od tego kodzenia
    
        For Z = 3 To 39
        store3 = Sheet23.Cells(Z, 4)
        
                    
                    If store3 = "" Then
                    Sheet23.Cells(Z + 39, 4) = ""
                    Else
                    Sheet23.Cells(Z + 39, 4) = Application.WorksheetFunction.VLookup(store3, Sheet2.Range("B5:Q500"), 16, 0)

                    End If
                    
     Next Z
    
 



'----------------------------------------
'Ustawianie prawidlowego ordersu dla zamowien ktore zostaly rozbite na depo i jada na small rigids ! damn it

' DOKONCZYC !!! dla 2giej linijki i 3ciej li!


'Dla 1str
For x = 42 To 79

numerek_depska = Sheet23.Cells(x, 2)
    If numerek_depska = "" Then Exit For
    
        For Each cl In Sheet23.Range(Sheet23.Cells(x + 1, 2), Sheet23.Cells(79, 4))
            If numerek_depska = cl Then
            Sheet23.Activate
            cl.Select
            Selection = Selection + 1
            Else
            End If
        Next cl
Next x


'Dla2str
For e = 42 To 79

numerek_depska2 = Sheet23.Cells(e, 3)
    
    If numerek_depska2 <> "" Then
    
        For Each cl In Sheet23.Range(Sheet23.Cells(e + 1, 2), Sheet23.Cells(79, 4))
            If numerek_depska2 = cl Then
             Sheet23.Activate
             cl.Select
             Selection = Selection + 1
            End If
        Next cl
    End If
    
Next e

'Dla Str3

For n = 42 To 79

numerek_depska3 = Sheet23.Cells(n, 4)

    If numerek_depska <> "" Then
    For Each cl In Range(Sheet23.Cells(n + 1, 2), Sheet23.Cells(79, 4))
        If numerek_depska3 = cl Then
            Sheet23.Activate
            cl.Select
            Selection = Selection + 1
            End If
        Next cl
    End If
Next n
        
        


'koniec przyspieszacza'
Application.ScreenUpdating = True
Application.Calculation = xlCalculationAutomatic
'koniec przyszpieszacza'

Call przemiana

End Sub
