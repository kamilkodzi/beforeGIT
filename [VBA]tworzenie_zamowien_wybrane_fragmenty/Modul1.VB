Sub batonis()
Dim lastline
Static tekstkon

Sheet22.PivotTables("PivotTable2").PivotCache.Refresh

If Sheet22.Range("AB5") <> Sheet22.Range("AC5") Then
MsgBox ("Uwaga ! ! !" & vbNewLine & "Makro do splitu nie zadziala. Wegrzy chca zrobic DEPO ze sklepu ktorego nie ma w inpucie ! Damm it!")
Exit Sub
End If

If Sheet22.Range("AB10") <> Sheet22.Range("AC10") Then
MsgBox ("Uwaga ! ! !" & vbNewLine & "Makro do splitu nie zadziala. Najprawdopodobniej usunales sklep z depo jako WrongCombination !" & vbNewLine _
& "Lub Ten sam sklep pojawil sie dwa razy jako DEPO. Damm it!")
Exit Sub
End If


'Przyspieszacz'
Application.ScreenUpdating = False
Application.Calculation = xlCalculationManual
'przyspieszacz'

'1 DEPO
    If Sheet22.Range("R6").Value <> 0 Then
    
      jedwiersz = Sheet22.Range("W6")
      jedsklep = Sheet22.Range("R6")
      jeddepo = Sheet22.Range("U6")
      jedtotal = Sheet22.Range("S6")
      jedroz = Sheet22.Range("V6")
      Sheet2.Cells(jedwiersz, 3) = jeddepo
      '1 DEPO Add Add line
      lastline = Sheet2.Cells(5, 2).End(xlDown).Row + 1
      Sheet2.Cells(lastline, 2) = Sheet22.Range("R6")
      Sheet2.Cells(lastline, 3) = Sheet22.Range("V6")
      Sheet2.Cells(lastline, 4) = "1"
   
        If jeddepo = 0 Then
            tekstkon = "Store " & jedsklep & " have " & jedtotal & " pal. Depo for this store is " & jedroz & ". Please send us correct information." & vbNewLine
    End If
    End If

'2 DEPO
    If Sheet22.Range("R7").Value <> 0 Then

        jedwiersz = Sheet22.Range("W7")
        jedsklep = Sheet22.Range("R7")
        jeddepo = Sheet22.Range("U7")
        jedtotal = Sheet22.Range("S7")
        jedroz = Sheet22.Range("V7")
        Sheet2.Cells(jedwiersz, 3) = jeddepo
        '2 DEPO Add Add line
        lastline = Sheet2.Cells(5, 2).End(xlDown).Row + 1
        Sheet2.Cells(lastline, 2) = Sheet22.Range("R7")
        Sheet2.Cells(lastline, 3) = Sheet22.Range("V7")
        Sheet2.Cells(lastline, 4) = "1"
   
         If jeddepo = 0 Then
            tekstkon = tekstkon + "Store " & jedsklep & " have " & jedtotal & " pal. Depo for this store is " & jedroz & ". Please send us correct information." & vbNewLine
        End If
        End If

'3 DEPO
If Sheet22.Range("R8").Value <> 0 Then

jedwiersz = Sheet22.Range("W8")
jedsklep = Sheet22.Range("R8")
jeddepo = Sheet22.Range("U8")
jedtotal = Sheet22.Range("S8")
jedroz = Sheet22.Range("V8")
Sheet2.Cells(jedwiersz, 3) = jeddepo
'3 DEPO Add Add line
lastline = Sheet2.Cells(5, 2).End(xlDown).Row + 1
   Sheet2.Cells(lastline, 2) = Sheet22.Range("R8")
   Sheet2.Cells(lastline, 3) = Sheet22.Range("V8")
   Sheet2.Cells(lastline, 4) = "1"
   
   If jeddepo = 0 Then
   tekstkon = tekstkon + "Store " & jedsklep & " have " & jedtotal & " pal. Depo for this store is " & jedroz & ". Please send us correct information." & vbNewLine
End If
End If

'4 DEPO
If Sheet22.Range("R9").Value <> 0 Then

jedwiersz = Sheet22.Range("W9")
jedsklep = Sheet22.Range("R9")
jeddepo = Sheet22.Range("U9")
jedtotal = Sheet22.Range("S9")
jedroz = Sheet22.Range("V9")
Sheet2.Cells(jedwiersz, 3) = jeddepo
'4 DEPO Add Add line
lastline = Sheet2.Cells(5, 2).End(xlDown).Row + 1
   Sheet2.Cells(lastline, 2) = Sheet22.Range("R9")
   Sheet2.Cells(lastline, 3) = Sheet22.Range("V9")
   Sheet2.Cells(lastline, 4) = "1"
   
   If jeddepo = 0 Then
   tekstkon = tekstkon + "Store " & jedsklep & " have " & jedtotal & " pal. Depo for this store is " & jedroz & ". Please send us correct information." & vbNewLine
End If
End If

'5 DEPO
If Sheet22.Range("R10").Value <> 0 Then

jedwiersz = Sheet22.Range("W10")
jedsklep = Sheet22.Range("R10")
jeddepo = Sheet22.Range("U10")
jedtotal = Sheet22.Range("S10")
jedroz = Sheet22.Range("V10")
Sheet2.Cells(jedwiersz, 3) = jeddepo
'5 DEPO Add Add line
lastline = Sheet2.Cells(5, 2).End(xlDown).Row + 1
   Sheet2.Cells(lastline, 2) = Sheet22.Range("R10")
   Sheet2.Cells(lastline, 3) = Sheet22.Range("V10")
   Sheet2.Cells(lastline, 4) = "1"
   
   If jeddepo = 0 Then
   tekstkon = tekstkon + "Store " & jedsklep & " have " & jedtotal & " pal. Depo for this store is " & jedroz & ". Please send us correct information." & vbNewLine
End If
End If

'6 DEPO
If Sheet22.Range("R11").Value <> 0 Then

jedwiersz = Sheet22.Range("W11")
jedsklep = Sheet22.Range("R11")
jeddepo = Sheet22.Range("U11")
jedtotal = Sheet22.Range("S11")
jedroz = Sheet22.Range("V11")
Sheet2.Cells(jedwiersz, 3) = jeddepo
'6 DEPO Add Add line
lastline = Sheet2.Cells(5, 2).End(xlDown).Row + 1
   Sheet2.Cells(lastline, 2) = Sheet22.Range("R11")
   Sheet2.Cells(lastline, 3) = Sheet22.Range("V11")
   Sheet2.Cells(lastline, 4) = "1"
   
   If jeddepo = 0 Then
   tekstkon = tekstkon + "Store " & jedsklep & " have " & jedtotal & " pal. Depo for this store is " & jedroz & ". Please send us correct information." & vbNewLine
End If
End If

'7 DEPO
If Sheet22.Range("R12").Value <> 0 Then

jedwiersz = Sheet22.Range("W12")
jedsklep = Sheet22.Range("R12")
jeddepo = Sheet22.Range("U12")
jedtotal = Sheet22.Range("S12")
jedroz = Sheet22.Range("V12")
Sheet2.Cells(jedwiersz, 3) = jeddepo
'7 DEPO Add Add line
lastline = Sheet2.Cells(5, 2).End(xlDown).Row + 1
   Sheet2.Cells(lastline, 2) = Sheet22.Range("R12")
   Sheet2.Cells(lastline, 3) = Sheet22.Range("V12")
   Sheet2.Cells(lastline, 4) = "1"
   
   If jeddepo = 0 Then
   tekstkon = tekstkon + "Store " & jedsklep & " have " & jedtotal & " pal. Depo for this store is " & jedroz & ". Please send us correct information." & vbNewLine
End If
End If

'8 DEPO
If Sheet22.Range("R13").Value <> 0 Then

jedwiersz = Sheet22.Range("W13")
jedsklep = Sheet22.Range("R13")
jeddepo = Sheet22.Range("U13")
jedtotal = Sheet22.Range("S13")
jedroz = Sheet22.Range("V13")
Sheet2.Cells(jedwiersz, 3) = jeddepo
'8 DEPO Add Add line
lastline = Sheet2.Cells(5, 2).End(xlDown).Row + 1
   Sheet2.Cells(lastline, 2) = Sheet22.Range("R13")
   Sheet2.Cells(lastline, 3) = Sheet22.Range("V13")
   Sheet2.Cells(lastline, 4) = "1"
   
   If jeddepo = 0 Then
   tekstkon = tekstkon + "Store " & jedsklep & " have " & jedtotal & " pal. Depo for this store is " & jedroz & ". Please send us correct information." & vbNewLine
End If
End If

'9 DEPO
If Sheet22.Range("R14").Value <> 0 Then

jedwiersz = Sheet22.Range("W14")
jedsklep = Sheet22.Range("R14")
jeddepo = Sheet22.Range("U14")
jedtotal = Sheet22.Range("S14")
jedroz = Sheet22.Range("V14")
Sheet2.Cells(jedwiersz, 3) = jeddepo
'9 DEPO Add Add line
lastline = Sheet2.Cells(5, 2).End(xlDown).Row + 1
   Sheet2.Cells(lastline, 2) = Sheet22.Range("R14")
   Sheet2.Cells(lastline, 3) = Sheet22.Range("V14")
   Sheet2.Cells(lastline, 4) = "1"
   
   If jeddepo = 0 Then
   tekstkon = tekstkon + "Store " & jedsklep & " have " & jedtotal & " pal. Depo for this store is " & jedroz & ". Please send us correct information." & vbNewLine
End If
End If

'10 DEPO
If Sheet22.Range("R15").Value <> 0 Then

jedwiersz = Sheet22.Range("W15")
jedsklep = Sheet22.Range("R15")
jeddepo = Sheet22.Range("U15")
jedtotal = Sheet22.Range("S15")
jedroz = Sheet22.Range("V15")
Sheet2.Cells(jedwiersz, 3) = jeddepo
'10 DEPO Add Add line
lastline = Sheet2.Cells(5, 2).End(xlDown).Row + 1
   Sheet2.Cells(lastline, 2) = Sheet22.Range("R10")
   Sheet2.Cells(lastline, 3) = Sheet22.Range("V10")
   Sheet2.Cells(lastline, 4) = "1"
   
   If jeddepo = 0 Then
   tekstkon = tekstkon + "Store " & jedsklep & " have " & jedtotal & " pal. Depo for this store is " & jedroz & ". Please send us correct information." & vbNewLine
End If
End If

'11 DEPO
If Sheet22.Range("R16").Value <> 0 Then

jedwiersz = Sheet22.Range("W16")
jedsklep = Sheet22.Range("R16")
jeddepo = Sheet22.Range("U16")
jedtotal = Sheet22.Range("S16")
jedroz = Sheet22.Range("V16")
Sheet2.Cells(jedwiersz, 3) = jeddepo
'11 DEPO Add Add line
lastline = Sheet2.Cells(5, 2).End(xlDown).Row + 1
   Sheet2.Cells(lastline, 2) = Sheet22.Range("R11")
   Sheet2.Cells(lastline, 3) = Sheet22.Range("V11")
   Sheet2.Cells(lastline, 4) = "1"
   
   If jeddepo = 0 Then
   tekstkon = tekstkon + "Store " & jedsklep & " have " & jedtotal & " pal. Depo for this store is " & jedroz & ". Please send us correct information." & vbNewLine
End If
End If

'12 DEPO
If Sheet22.Range("R17").Value <> 0 Then

jedwiersz = Sheet22.Range("W17")
jedsklep = Sheet22.Range("R17")
jeddepo = Sheet22.Range("U17")
jedtotal = Sheet22.Range("S17")
jedroz = Sheet22.Range("V17")
Sheet2.Cells(jedwiersz, 3) = jeddepo
'12 DEPO Add Add line
lastline = Sheet2.Cells(5, 2).End(xlDown).Row + 1
   Sheet2.Cells(lastline, 2) = Sheet22.Range("R12")
   Sheet2.Cells(lastline, 3) = Sheet22.Range("V12")
   Sheet2.Cells(lastline, 4) = "1"
   
   If jeddepo = 0 Then
   tekstkon = tekstkon + "Store " & jedsklep & " have " & jedtotal & " pal. Depo for this store is " & jedroz & ". Please send us correct information." & vbNewLine
End If
End If

'13 DEPO
If Sheet22.Range("R17").Value <> 0 Then

jedwiersz = Sheet22.Range("W18")
jedsklep = Sheet22.Range("R18")
jeddepo = Sheet22.Range("U18")
jedtotal = Sheet22.Range("S18")
jedroz = Sheet22.Range("V18")
Sheet2.Cells(jedwiersz, 3) = jeddepo
'13 DEPO Add Add line
lastline = Sheet2.Cells(5, 2).End(xlDown).Row + 1
   Sheet2.Cells(lastline, 2) = Sheet22.Range("R13")
   Sheet2.Cells(lastline, 3) = Sheet22.Range("V13")
   Sheet2.Cells(lastline, 4) = "1"
   
   If jeddepo = 0 Then
   tekstkon = tekstkon + "Store " & jedsklep & " have " & jedtotal & " pal. Depo for this store is " & jedroz & ". Please send us correct information." & vbNewLine
End If
End If

'14 DEPO
If Sheet22.Range("R19").Value <> 0 Then

jedwiersz = Sheet22.Range("W19")
jedsklep = Sheet22.Range("R19")
jeddepo = Sheet22.Range("U19")
jedtotal = Sheet22.Range("S19")
jedroz = Sheet22.Range("V19")
Sheet2.Cells(jedwiersz, 3) = jeddepo
'14 DEPO Add Add line
lastline = Sheet2.Cells(5, 2).End(xlDown).Row + 1
   Sheet2.Cells(lastline, 2) = Sheet22.Range("R19")
   Sheet2.Cells(lastline, 3) = Sheet22.Range("V19")
   Sheet2.Cells(lastline, 4) = "1"
   
   If jeddepo = 0 Then
   tekstkon = tekstkon + "Store " & jedsklep & " have " & jedtotal & " pal. Depo for this store is " & jedroz & ". Please send us correct information." & vbNewLine
End If
End If

'15 DEPO
If Sheet22.Range("R20").Value <> 0 Then

jedwiersz = Sheet22.Range("W20")
jedsklep = Sheet22.Range("R20")
jeddepo = Sheet22.Range("U20")
jedtotal = Sheet22.Range("S20")
jedroz = Sheet22.Range("V20")
Sheet2.Cells(jedwiersz, 3) = jeddepo
'15 DEPO Add Add line
lastline = Sheet2.Cells(5, 2).End(xlDown).Row + 1
   Sheet2.Cells(lastline, 2) = Sheet22.Range("R20")
   Sheet2.Cells(lastline, 3) = Sheet22.Range("V20")
   Sheet2.Cells(lastline, 4) = "1"
   
   If jeddepo = 0 Then
   tekstkon = tekstkon + "Store " & jedsklep & " have " & jedtotal & " pal. Depo for this store is " & jedroz & ". Please send us correct information." & vbNewLine
End If
End If

'16 DEPO
If Sheet22.Range("R21").Value <> 0 Then

jedwiersz = Sheet22.Range("W21")
jedsklep = Sheet22.Range("R21")
jeddepo = Sheet22.Range("U21")
jedtotal = Sheet22.Range("S21")
jedroz = Sheet22.Range("V21")
Sheet2.Cells(jedwiersz, 3) = jeddepo
'16 DEPO Add Add line
lastline = Sheet2.Cells(5, 2).End(xlDown).Row + 1
   Sheet2.Cells(lastline, 2) = Sheet22.Range("R21")
   Sheet2.Cells(lastline, 3) = Sheet22.Range("V21")
   Sheet2.Cells(lastline, 4) = "1"
   
   If jeddepo = 0 Then
   tekstkon = tekstkon + "Store " & jedsklep & " have " & jedtotal & " pal. Depo for this store is " & jedroz & ". Please send us correct information." & vbNewLine
End If
End If

'17 DEPO
If Sheet22.Range("R22").Value <> 0 Then

jedwiersz = Sheet22.Range("W22")
jedsklep = Sheet22.Range("R22")
jeddepo = Sheet22.Range("U22")
jedtotal = Sheet22.Range("S22")
jedroz = Sheet22.Range("V22")
Sheet2.Cells(jedwiersz, 3) = jeddepo
'17 DEPO Add Add line
lastline = Sheet2.Cells(5, 2).End(xlDown).Row + 1
   Sheet2.Cells(lastline, 2) = Sheet22.Range("R22")
   Sheet2.Cells(lastline, 3) = Sheet22.Range("V22")
   Sheet2.Cells(lastline, 4) = "1"
   
   If jeddepo = 0 Then
   tekstkon = tekstkon + "Store " & jedsklep & " have " & jedtotal & " pal. Depo for this store is " & jedroz & ". Please send us correct information." & vbNewLine
End If
End If


    ActiveWorkbook.Worksheets("Plan Orders").AutoFilter.Sort.SortFields.clear
    ActiveWorkbook.Worksheets("Plan Orders").AutoFilter.Sort.SortFields.Add Key:= _
        Range("B4:B3002"), SortOn:=xlSortOnValues, Order:=xlAscending, DataOption _
        :=xlSortNormal
    With ActiveWorkbook.Worksheets("Plan Orders").AutoFilter.Sort
        .Header = xlYes
        .MatchCase = False
        .Orientation = xlTopToBottom
        .SortMethod = xlPinYin
        .Apply
    End With

'koniec przyspieszacza'
Application.ScreenUpdating = True
Application.Calculation = xlCalculationAutomatic
'koniec przyszpieszacza'

If tekstkon <> "" Then
MsgBox (tekstkon)
Else
MsgBox ("Bezblednie! All OK.")
End If
End Sub
