Sub zapiser()

datka = Sheet2.Range("W1")
datka = Format(datka, "mmdd")
datka2 = Sheet2.Range("V1")
datka2 = "-" & Format(datka2, "dd")
If Sheet2.Range("V1") = Sheet2.Range("W1") Then datka2 = ""

Dim wersja As Range


Set wersja = Sheet2.Range("V2")
'wersja = wersja + 1

Application.Calculation = xlCalculationManual
Application.ScreenUpdating = False
Application.EnableEvents = False

Dim datka88
Dim nazewka
nazwafolderu = Sheet2.Range("AA8") 'format C:\Users\Maciej\Desktop
droga = Sheet2.Range("X8")  'format Galanta 2016-05-25 27

juz:
If Len(Dir(droga & "\" & nazwafolderu & "\", vbDirectory)) = 0 Then
MkDir droga & "\" & nazwafolderu & "\"
Else
nazwafolderu = Sheet2.Range("AA8")
x = x + 1
nazwafolderu = nazwafolderu & " v" & x
GoTo juz
End If

Sheet2.Range("AQ1") = nazwafolderu

    For Each ws In Sheets
        Application.DisplayAlerts = False
            If ws.Name <> "Master Plan" Then
                If ws.Name <> "OrderGrid" Then
                    If ws.Name <> "TripsGrid" Then
                        If ws.Name <> "ControlPanel" Then
                                        If Right(ws.Name, 2) <> "ND" Then
                                            ws.Select
                                            ws.Copy
                                            nazwapliku = ws.Name ' & " v" & wersja
                                            ActiveWorkbook.SaveAs Filename:=droga & "\" & nazwafolderu & "\" & nazwapliku & ".xlsx", FileFormat:=51, Local:=True
                                            ActiveWorkbook.Close savechanges = True
                                        End If
                                    End If
                                End If
                End If
            End If
    Next
    

nazwaplanmakera = "TICB Plan Maker " & datka & datka2 ' & "v" & wersja
ActiveWorkbook.SaveAs Filename:=droga & "\" & nazwafolderu & "\" & nazwaplanmakera & ".xlsm", FileFormat:=52, Local:=True



Application.DisplayAlerts = True
Sheets("Master Plan").Activate
Application.Calculation = xlCalculationAutomatic
Application.ScreenUpdating = True
Application.EnableEvents = True
End Sub
