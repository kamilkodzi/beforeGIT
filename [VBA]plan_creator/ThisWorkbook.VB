Private Sub Workbook_Open()


If Sheet2.Range("V2") = 0 Then
Dim kluczyk As Range
Set kluczyk = Sheet2.Range("V5")
kluczyk = Application.WorksheetFunction.RandBetween(100, 999)
Dim kluczyk2 As Range
Set kluczyk2 = Sheet2.Range("V6")
kluczyk2 = Format(Now(), "ddmmyyyy")

End If


'On Error GoTo ucieczka

If MsgBox("Czy zassac dane z raportu? Chodzi o vany i rigidy dla cscargo... ;)", vbOKCancel, "DATE UPDATE xD?") = vbOK Then

    Dim plan As Workbook: Set plan = ActiveWorkbook
    Workbooks.Open (Sheet2.Range("AC8"))
    Dim wkb1 As Workbook: Set wkb1 = ActiveWorkbook
    Dim wks1 As Worksheet: Set wks1 = wkb1.Sheets("wstepny raport")
    wks1.Activate
    
    Dim pt As PivotTable
        For Each pt In ActiveSheet.PivotTables
        pt.RefreshTable
    Next pt
    
    plan.Activate

    
        If Sheet2.Range("V2") > 0 Then
            Sheet2.Range("AS21:AX28").Select
            Selection.Copy
            Sheet2.Range("AS35").Select
            Selection.PasteSpecial Paste:=xlPasteValues, Operation:=xlNone, SkipBlanks _
            :=False, Transpose:=False
        End If


    Sheet2.Range("AS2").Formula = "=IFERROR(VLOOKUP(AS1,'[TICB raporty.xlsx]wstepny raport'!$B$5:$C$1048576,2,FALSE),0)"
    Sheet2.Range("AS3").Formula = "=IFERROR(VLOOKUP(AS1,'[TICB raporty.xlsx]wstepny raport'!$E$5:$F$1048576,2,FALSE),0)"
    Sheet2.Range("AS4").Formula = "=IFERROR(VLOOKUP(AS1,'[TICB raporty.xlsx]wstepny raport'!$H$5:$I$1048576,2,FALSE),0)"
    Sheet2.Range("AS5").Formula = "=IFERROR(VLOOKUP(AS1,'[TICB raporty.xlsx]wstepny raport'!$K$5:$L$1048576,2,FALSE),0)"
    Sheet2.Range("AS6").Formula = "=IFERROR(VLOOKUP(AS1,'[TICB raporty.xlsx]wstepny raport'!$N$5:$O$1048576,2,FALSE),0)"
    Sheet2.Range("AS7").Formula = "=IFERROR(VLOOKUP(AS1,'[TICB raporty.xlsx]wstepny raport'!$Q$5:$R$1048576,2,FALSE),0)"
    Sheet2.Range("AS8").Formula = "=IFERROR(VLOOKUP(AS1,'[TICB raporty.xlsx]wstepny raport'!$T$5:$U$1048576,2,FALSE),0)"
    Sheet2.Range("AS9").Formula = "=IFERROR(VLOOKUP(AS1,'[TICB raporty.xlsx]wstepny raport'!$W$5:$X$1048576,2,FALSE),0)"
    
    
    Range("AS2:AS9").Select
    Selection.AutoFill Destination:=Range("AS2:AX9"), Type:=xlFillDefault
    Range("AS2:AX9").Select
    
    
    Else
'ucieczka:                Exit Sub

    
End If

Application.CutCopyMode = False
Range("W11").Select
End Sub
