Sub preplaner()

Application.Calculation = xlCalculationManual
Application.ScreenUpdating = False
Set tuiteraz = ActiveWorkbook
datka = Sheet2.Range("W1")
datka = Format(datka, "mmdd")
datka2 = Sheet2.Range("V1")
datka2 = "-" & Format(datka2, "dd")
If Sheet2.Range("V1") = Sheet2.Range("W1") Then datka2 = ""
magazyn = Sheet2.Range("W4")

nazwafolderu = Sheet2.Range("AQ1") 'format C:\Users\Maciej\Desktop
droga = Sheet2.Range("X8")  'format Galanta 2016-05-25 27
Set wersja = Sheet2.Range("V2")

stoper = 0
Sheet2.Range("BG9:BM801").Copy


Workbooks.Add.Activate
    Selection.PasteSpecial xlPasteValuesAndNumberFormats



For x = 1 To 801

    komorka = Cells(x, 1)

    If komorka = "" Then
        Rows(x).Delete
        x = x - 1
        stoper = stoper + 1
    End If
    
    If stoper = 300 Then Exit For

Next x






Application.DisplayAlerts = False

nazwapreplanu = "Preplan " & magazyn & " " & datka & datka2 ' & " v" & wersja

ActiveWorkbook.SaveAs Filename:=droga & "\" & nazwafolderu & "\" & nazwapreplanu & ".csv", FileFormat:=xlCSVWindows, Local:=True

ActiveWorkbook.Close savechanges = True

Application.DisplayAlerts = True

Application.Calculation = xlCalculationAutomatic

Application.ScreenUpdating = True

tuiteraz.Activate
Sheet2.Activate
End Sub

