Sub odbiory()



If Sheet1.Range("O13") = "" Then
MsgBox ("Wymagany numer klienta." & vbCrLf & "Jesli to BH to wklej nazwe taka jak w zakladce MASTER IN w pierwszej kolumnie.")
MsgBox ("Jesli to LE to wystarczy numer sklepu.")
Exit Sub
End If

If Sheet1.Range("P13") = "" Then
MsgBox ("Wklej ilosc palet! W przypadku BH i zwrocow nie dziala splitowanie po capacity. Wpisujemy dwie linie po 33, 33 a nie jedna po 66.")
Exit Sub
End If

If Sheet1.Range("Q13") = "" And Sheet1.Range("B1") = "" Then
MsgBox ("Wymagana dzien odbioru. Program w pierwszej kolejnosci bierze pod uwage date BH/LE. Jesli jest nie obecna to z okien sklepowych.")
Exit Sub
End If

'Application.ScreenUpdating = False
'Application.Calculation = xlCalculationManual

Sheet3.Range("C3:C1500").ClearContents
Sheet3.Range("F3:F1500").ClearContents
Sheet3.Range("G3:G1500").ClearContents
Sheet3.Range("H3:H1500").ClearContents
Sheet3.Range("AQ3:AQ1500").ClearContents
Sheet3.Range("AR3:AT1500").ClearContents

Sheet4.Range("A1:AT5").Copy Sheet3.Range("A1")
Sheet3.Range("A5:AT1500").FillDown

For x = 13 To 64
If Sheet1.Cells(x, 15) = "" Then GoTo puste 'jesli nie ma numeru sklepu w inpucie- konczymy dzialanie
Sheet3.Cells(x - 8, 3) = Sheet1.Cells(x, 15) 'wpisujemy numer sklepu do double outa
Sheet3.Cells(x - 8, 7) = Sheet1.Cells(x, 16) 'wpisujemy ilosc palet na load



Sheet3.Cells(x - 8, 9) = "COLLECTIONS"



Next x


puste:

Application.Calculation = xlCalculationAutomatic

'Tworzymy nowy plik w ktorym wklejone zostaja ordersy
ostnr = Sheet3.Range("C2")
Sheet4.Range("A1:AT4").Copy Sheet3.Range("A1")
Sheet3.Range(Sheet3.Cells(1, 1), Sheet3.Cells(ostnr, 46)).Copy
Workbooks.Add
Selection.PasteSpecial Paste:=xlValues
Selection.PasteSpecial Paste:=xlFormats



'Przesuwanie dzni dostawy z data
Dim nowa As Range
Dim stara As Range


For x = 5 To 10000
If Cells(x, 4) = "" Then Exit For
    For Z = 1 To 10
        For y = 22 To 34
            Set nowa = Cells(x, y)
            Set stara = Cells(x, y + 1)
                If nowa = "" Then
                nowa = stara
                stara = ""
                End If
        Next y
    Next Z
Next x

Application.ScreenUpdating = True

End Sub


Sub odbiory2()



If Sheet1.Range("O13") = "" Then Exit Sub 'jak nie ma pierwszego numeru sklepu w inpucie to konczymy
If Sheet1.Range("P13") = "" Then Exit Sub ' jak nie ma pierwszej ilosci palet w inpucie to konczymy dzialania
If Sheet1.Range("Q13") = "" And Sheet1.Range("B1") = "" Then Exit Sub 'jesli nie mamy podanej daty to konczymy dzialania

Application.ScreenUpdating = False
Application.Calculation = xlCalculationManual


Sheet3.Range("A5:AR10000").ClearContents
Sheet4.Range("A1:AR5").Copy Sheet3.Range("A1")
Sheet3.Range("A5:AP1500").FillDown


For x = 13 To 64
If Sheet1.Cells(x, 15) = "" Then GoTo puste 'jesli nie ma numeru sklepu w inpucie- konczymy dzialanie
Sheet3.Cells(x - 8, 3) = Sheet1.Cells(x, 15) 'wpisujemy numer sklepu do double outa
Sheet3.Cells(x - 8, 7) = Sheet1.Cells(x, 16) 'wpisujemy ilosc palet na load

    If Sheet1.Cells(x, 17) <> "" Then ' Daty z warunkiem, jesli sa wpisane to kasujemy wszystko i wpisujemy ta ktora jest, jesli pusto to standardowo te daty ktore sa wpisane :)
    Sheet3.Cells(x - 8, 22) = Sheet1.Cells(x, 17)
    Sheet3.Cells(x - 8, 23) = Sheet1.Cells(x, 17)
    Sheet3.Cells(x - 8, 36) = Sheet1.Cells(x, 17)
    For Each cl In Sheet3.Range(Sheet3.Cells(x - 8, 24), Sheet3.Cells(x - 8, 35))
    cl.Value = ""
    Next cl
    For Each cls In Sheet3.Range(Sheet3.Cells(x - 8, 37), Sheet3.Cells(x - 8, 42))
    cls.Value = ""
    Next cls
    End If

If Sheet1.Cells(x, 18) <> "" And Sheet1.Cells(x, 19) <> "" Then
Sheet3.Cells(x - 8, 20) = Sheet1.Cells(x, 18)
Sheet3.Cells(x - 8, 21) = Sheet1.Cells(x, 19)
End If

Sheet3.Cells(x - 8, 9) = "COLLECTIONS"



Next x


puste:

Application.Calculation = xlCalculationAutomatic

'Tworzymy nowy plik w ktorym wklejone zostaja ordersy
ostnr = Sheet3.Range("C2")
Sheet4.Range("A1:AR4").Copy Sheet3.Range("A1")
Sheet3.Range(Sheet3.Cells(1, 1), Sheet3.Cells(ostnr, 46)).Copy
Workbooks.Add
Selection.PasteSpecial Paste:=xlValues
Selection.PasteSpecial Paste:=xlFormats



'Przesuwanie dzni dostawy z data
Dim nowa As Range
Dim stara As Range


For x = 5 To 10000
If Cells(x, 4) = "" Then Exit For
    For Z = 1 To 10
        For y = 22 To 34
            Set nowa = Cells(x, y)
            Set stara = Cells(x, y + 1)
                If nowa = "" Then
                nowa = stara
                stara = ""
                End If
        Next y
    Next Z
Next x

Application.ScreenUpdating = True

End Sub


