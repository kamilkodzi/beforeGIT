Sub trim()


If Sheet1.Range("U13") = "" Then
MsgBox ("Wklej liste z numerami orders     (plik: Raporty-->preplan.csv)" & vbCrLf & " Zamowienia beda bezpiecznie i nie zostanie z nich odjety volumen DC3.")
Exit Sub
End If


Application.Calculation = xlCalculationManual
Application.ScreenUpdating = False

For x = 5 To Sheet3.Range("C2").Value

For y = 13 To Sheet1.Range("V9").Value + 13
If Sheet3.Cells(x, 1) = Sheet1.Cells(y, 21) Then GoTo zostaw
Next y

boxpal = 0
boxcase = 0
hngpal = 0
hngcase = 0
'

    If Sheet3.Cells(x, 43) <> " " And Sheet3.Cells(x, 43) <> "" Then
    boxpal = Mid(Sheet3.Cells(x, 43), InStr(Sheet3.Cells(x, 43), "P") + 1, Len(Sheet3.Cells(x, 43)) - InStr(Sheet3.Cells(x, 43), "P") - 1) + 0
    boxcase = Mid(Sheet3.Cells(x, 43), InStr(Sheet3.Cells(x, 43), "C") + 1, (Len(Sheet3.Cells(x, 43)) - 6) - (Len(Sheet3.Cells(x, 43)) - InStr(Sheet3.Cells(x, 43), "P") - 1)) + 0
    End If
    
    


    If Sheet3.Cells(x, 44) <> " " And Sheet3.Cells(x, 44) <> "" Then
    hngpal = Mid(Sheet3.Cells(x, 44), InStr(Sheet3.Cells(x, 44), "P") + 1, Len(Sheet3.Cells(x, 44)) - InStr(Sheet3.Cells(x, 44), "P") - 1) + 0
    hngcase = Mid(Sheet3.Cells(x, 44), InStr(Sheet3.Cells(x, 44), "C") + 1, (Len(Sheet3.Cells(x, 44)) - 6) - (Len(Sheet3.Cells(x, 44)) - InStr(Sheet3.Cells(x, 44), "P") - 1)) + 0
    End If
If boxpal = 0 And hngpal = 0 Then GoTo zostaw
Sheet3.Cells(x, 6) = Sheet3.Cells(x, 6) - boxpal - hngpal
If Sheet3.Cells(x, 6) <= 0 Then
Sheet3.Cells(x, 6) = 0
Sheet3.Cells(x, 8) = 0
End If
Sheet3.Cells(x, 8) = Sheet3.Cells(x, 8) - boxcase - hngcase
If Sheet3.Cells(x, 8) < 0 Then Sheet3.Cells(x, 8) = 0

If boxpal + hngpal > 0 Then Sheet3.Cells(x, 9) = ""
Sheet3.Cells(x, 43) = ""
Sheet3.Cells(x, 44) = ""

zostaw:
Next x




Application.Calculation = xlCalculationAutomatic
Application.DisplayAlerts = False
nazwatopsa = "Tops z dnia " & Format(Now(), "dd-mm-hh-mm")
ActiveWorkbook.SaveAs Filename:="url" & nazwatopsa & ".xlsm", FileFormat:=52, Local:=True
Application.DisplayAlerts = True

ostnr = Sheet3.Range("C2")
'Sheet4.Range("A1:AR4").Copy Sheet3.Range("A1")
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
