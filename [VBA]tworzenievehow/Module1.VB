Sub Rectangle1_Click()



ActiveWorkbook.Saved = True
Dim oknoglowne As Workbook: Set oknoglowne = ActiveWorkbook

'FF- GYAL
Application.ScreenUpdating = False
dataff = Format$(Sheet1.Range("B5"), ("yyyy-mm-dd"))
nazwaffxlm = Sheet1.Range("B6") & Sheet1.Range("E2")
sciezkaff = Sheet1.Range("B2") & Sheet1.Range("B6") & Sheet1.Range("E2")
nazwamakraff = "'" & nazwaffxlm & "'" & "!Maciek.Vehicle"

Dim topsff As Workbook:  Set topsff = Workbooks.Open(sciezkaff)
Set topsff = ActiveWorkbook
Dim topsffdata As Worksheet: Set topsffdata = topsff.Sheets("Data Verification")
Dim topsffdatapole As Range: Set topsffdatapole = topsffdata.Range("C5")
Dim topsffinput As Worksheet: Set topsffinput = topsff.Sheets("Input")


topsffdatapole = dataff
Application.Run nazwamakraff



If Len(Dir("url" & " " & dataff & "\", vbDirectory)) = 0 Then
    MkDir "url" & " " & dataff
    ActiveWorkbook.SaveAs Filename:="url" & " " & dataff & "\veh.csv", FileFormat:=xlCSVWindows, Local:=True
    ActiveWorkbook.Close savechanges = True
Else
    ActiveWorkbook.SaveAs Filename:="url" & " " & dataff & "\veh.csv", FileFormat:=xlCSVWindows, Local:=True
    ActiveWorkbook.Close savechanges = True
End If
 Application.DisplayAlerts = False
topsff.Saved = True
topsff.Close savechanges = False
Application.DisplayAlerts = True

  
    

Call hopiveh


End Sub

Sub hopiveh()
ActiveWorkbook.Saved = True

Dim oknoglowne2 As Workbook: Set oknoglowne2 = ActiveWorkbook

'HOPI

datahopi = Format$(Sheet1.Range("D5"), ("yyyy-mm-dd"))
nazwahopixlm = Sheet1.Range("D6") & Sheet1.Range("E2")
sciezkahopi = Sheet1.Range("B2") & Sheet1.Range("D6") & Sheet1.Range("E2")
nazwamakrahopi = "'" & nazwahopixlm & "'" & "!Maciek.Vehicle"

Dim topshopi As Workbook:  Set topshopi = Workbooks.Open(sciezkahopi)
Dim topshopidata As Worksheet: Set topshopidata = topshopi.Sheets("Data Verification")
Dim topshopidatapole As Range: Set topshopidatapole = topshopidata.Range("C5")
Dim topshopiinput As Worksheet: Set topshopiinput = topshopi.Sheets("Input")


topshopidatapole = datahopi
Application.Run nazwamakrahopi



If Len(Dir("url" & " " & datahopi & "\", vbDirectory)) = 0 Then
    MkDir "url" & " " & datahopi
    ActiveWorkbook.SaveAs Filename:="url" & " " & datahopi & "\veh.csv", FileFormat:=xlCSVWindows, Local:=True
    ActiveWorkbook.Close savechanges = True
Else
    ActiveWorkbook.SaveAs Filename:="url" & " " & datahopi & "\veh.csv", FileFormat:=xlCSVWindows, Local:=True
    ActiveWorkbook.Close savechanges = True
End If



 Application.DisplayAlerts = False
topshopi.Saved = True
topshopi.Close savechanges = False

oknoglowne2.Close savechanges = False

ActiveWorkbook.Close savechanges = False

 Application.DisplayAlerts = True
Application.ScreenUpdating = True



End Sub
