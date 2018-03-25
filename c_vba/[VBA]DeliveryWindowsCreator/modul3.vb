



Sub DW()


'Bug Defender
If Application.WorksheetFunction.Count(Range("A6:A369")) = 0 Then
MsgBox ("Wpisz sklepy")
Exit Sub
End If
If Application.WorksheetFunction.Count(Sheet4.Range("A6:A369")) = 0 Then
MsgBox ("Wklej Mastera")
Exit Sub
End If
'Bug Defender


' DW Macro
tekst = Range("N1")
mnoznik = Range("M1")
policz = Application.WorksheetFunction.Count(Range("A6:A369")) + 1

    Sheet3.Select
    Range(Cells(2, 1), Cells(policz, 145)).Select
    Range("A2").Activate
    Selection.Copy
    Worksheets.Add
    
    Selection.PasteSpecial Paste:=xlPasteAllUsingSourceTheme, Operation:=xlNone _
        , SkipBlanks:=False, Transpose:=False
    Selection.PasteSpecial Paste:=xlPasteValues, Operation:=xlNone, SkipBlanks _
        :=False, Transpose:=False
        
    Selection.Replace What:="00:00", Replacement:="00:01", LookAt:=xlPart, _
        SearchOrder:=xlByRows, MatchCase:=False, SearchFormat:=False, _
        ReplaceFormat:=False
        
        
Range(Cells(1, 2), Cells(policz - 1, 145)).Value = Range(Cells(1, 2), Cells(policz - 1, 145)).Value

Selection.Offset(columnOffset:=1).Select
Selection.NumberFormat = "hh:mm"
             Call apdejt
End Sub


Sub ZrobNoweOknaCalegoMastera()

tekstdlaokna = Range("N2")
mnoznik = Range("M1")
'
    Sheet3.Select
    Range("B2:EO363").Select
    Range("B2").Activate
    Selection.Copy
    Worksheets.Add
    
    Selection.PasteSpecial Paste:=xlPasteAllUsingSourceTheme, Operation:=xlNone _
        , SkipBlanks:=False, Transpose:=False
    Selection.PasteSpecial Paste:=xlPasteValues, Operation:=xlNone, SkipBlanks _
        :=False, Transpose:=False
        
    Selection.Replace What:="00:00", Replacement:="00:01", LookAt:=xlPart, _
        SearchOrder:=xlByRows, MatchCase:=False, SearchFormat:=False, _
        ReplaceFormat:=False
        

For x = 1 To 363
    If Cells(x, 1) = tekstdlaokna Then
        Range(Cells(x, 1), Cells(x, 144)).ClearContents
         Else
             Range(Cells(x, 1), Cells(x, 144)).Value = Range(Cells(x, 1), Cells(x, 144)).Value
             
             'For y = 3 To 144 Step 4
            
                'Cells(x, y).Value = Cells(x, y).Value

             'Next y
          End If
Next x

Selection.NumberFormat = "hh:mm"

End Sub


Sub apdejt()
Dim rng, cl, MyRng As Range, szukana As String
Set rng = Sheet4.Range("A8:A400")
policzy = Application.WorksheetFunction.Count(Sheet2.Range("A6:A369"))
kopiowanka = 1
kopiszon = 8

'Sheet1.Range("A1").Select

For i = 1 To policzy
Sheets("Sheet1").Select
szukana = Cells(i, 1)

  For Each cl In rng
 
    If cl.Value Like szukana Then
      Sheets("Sheet1").Range(Cells(kopiowanka, 2), Cells(kopiowanka, 145)).Copy
      Sheet4.Select
        cl.Select
        cl.Interior.ColorIndex = 3
        Selection.Offset(columnOffset:=83).Select
        Selection.Interior.ColorIndex = 3
      Selection.PasteSpecial Paste:=xlPasteValues
      kopiowanka = kopiowanka + 1
      
    End If
    
       If cl.Value Like szukana Then
       Sheet2.Select
      Sheet2.Range(Cells(kopiszon, 8), Cells(kopiszon, 11)).Copy
      Sheet4.Select
        cl.Select
        Selection.Offset(columnOffset:=7).Select
        Selection.Interior.ColorIndex = 3
      Selection.PasteSpecial Paste:=xlPasteValues
      kopiszon = kopiszon + 1
      
      End If
  Next cl
  
  Next
  
Range("A1").Select

End Sub
