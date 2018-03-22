Sub Rectangle1_Click()

'Application.ScreenUpdating = False
'Application.Calculation = xlCalculationManual

Sheet3.Range("A2:AX300").ClearContents
Sheet3.Range("C3:I300").ClearFormats
Sheet3.Range("M3:S300").ClearFormats
Sheet3.Range("W3:AC300").ClearFormats
Sheet3.Range("AG3:AM300").ClearFormats
Sheet3.Range("AQ3:AW300").ClearFormats


Sheet2.Range("B7:AX196").Copy
Sheet3.Activate
Sheet3.Range("A1").Select
Selection.PasteSpecial Paste:=xlPasteValues

Call konwerter
Call dziala
Call MIENIACZ

Sheet3.Range("A:A").ClearContents
Sheet3.Range("K:K").ClearContents
Sheet3.Range("U:U").ClearContents
Sheet3.Range("AE:AE").ClearContents
Sheet3.Range("AO:AO").ClearContents

Sheet3.Range("A:A").ClearFormats
Sheet3.Range("K:K").ClearFormats
Sheet3.Range("U:U").ClearFormats
Sheet3.Range("AE:AE").ClearFormats
Sheet3.Range("AO:AO").ClearFormats


End Sub

Sub dziala()

Dim a As Range
Dim b As Range
Dim c As Range
Dim d As Range
Dim e As Range
Dim f As Range
Dim g As Range

For Z = 0 To 40 Step 10

For x = 3 To 250
    
    wystepuje = Sheet3.Cells(x, 1 + Z)
    If wystepuje = "" Then Exit For
    Set a = Sheet3.Cells(x, 3 + Z)
        If a.Interior.Color = 11234 Then a = ""
    Set b = Sheet3.Cells(x, 4 + Z)
        If b.Interior.Color = 11234 Then b = ""
    Set c = Sheet3.Cells(x, 5 + Z)
        If c.Interior.Color = 11234 Then c = ""
    Set d = Sheet3.Cells(x, 6 + Z)
        If d.Interior.Color = 11234 Then d = ""
    Set e = Sheet3.Cells(x, 7 + Z)
        If e.Interior.Color = 11234 Then e = ""
    Set f = Sheet3.Cells(x, 8 + Z)
        If f.Interior.Color = 11234 Then f = ""
    Set g = Sheet3.Cells(x, 9 + Z)
        If g.Interior.Color = 11234 Then g = ""
    
        For y = 1 To 7
            On Error Resume Next
            one = Application.WorksheetFunction.Large(Sheet3.Range(Cells(x, 3 + Z), Cells(x, 9 + Z)), y)
            
            If one = a Then a = y
            If one = b Then b = y
            If one = c Then c = y
            If one = d Then d = y
            If one = e Then e = y
            If one = f Then f = y
            If one = g Then g = y
            
                
            
        Next y
        
If a > wystepuje Then
    a = ""
    Else
    a = a
End If


If b > wystepuje Then
    b = ""
    Else
    b = b
End If


If c > wystepuje Then
    c = ""
    Else
    c = c
End If


If d > wystepuje Then
    d = ""
    Else
    d = d
End If


If e > wystepuje Then
    e = ""
    Else
    e = e
End If


If f > wystepuje Then
    f = ""
    Else
    f = f
End If


If g > wystepuje Then
    g = ""
    Else
    g = g
End If
        
        
Next x

Next Z

End Sub


Sub konwerter()
Dim pole As Range

For y = 0 To 6

For x = 3 To 190
    numerek = Sheet2.Cells(x + 6, 63 + y)
    Set pole = Sheet3.Cells(x, 3 + y)
    
    If numerek = "0" Then
        With pole.Interior
        .Pattern = xlSolid
        .PatternColorIndex = xlAutomatic
        .Color = 11234
        .TintAndShade = 0
        .PatternTintAndShade = 0
    End With
    End If
    
    
Next x
Next y

Sheet3.Range("B3:I300").Copy
Sheet3.Range("L3").PasteSpecial (xlPasteFormats)
Sheet3.Range("V3").PasteSpecial (xlPasteFormats)
Sheet3.Range("AF3").PasteSpecial (xlPasteFormats)
Sheet3.Range("AP3").PasteSpecial (xlPasteFormats)


End Sub


Sub MIENIACZ()
Dim Cell As Range
'=C3:I5;M3:S5
For Each cl In Sheet3.Range("A1:AX300")
Set Cell = cl
Select Case cl
    Case 1
    Cell.Value = "GY-W"
    
    Case 2
    Cell.Value = "GY-LE"
    
    Case 3
    Cell.Value = "GY-W"
    
    Case 4
    Cell.Value = "GY-LE"
    
    Case 5
    Cell.Value = "GY-W"
    
    Case 6
    Cell.Value = "GY-LE"
    
    Case 7
    Cell.Value = "GY-W"
    
    
End Select

Next cl


Application.ScreenUpdating = True
Application.Calculation = xlCalculationAutomatic

End Sub


