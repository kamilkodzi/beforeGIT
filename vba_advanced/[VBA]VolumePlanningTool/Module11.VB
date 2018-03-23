Sub destruktorx2()
'funkcja która odpalana jest przez zrobieniem pliku input. Dla kazdej wartosci z tabeli przestawnej poprawia ilosci w pliku finalnym. czy jakos tak.
'produkto = Sheet27.Range("J2")
On Error Resume Next
ActiveWorkbook.RefreshAll
    Sheet4.PivotTables("PivotTable1").PivotFields("Product").ClearAllFilters
    Sheet4.PivotTables("PivotTable1").PivotFields("Product").CurrentPage = "FF"
        
        With Sheet4.PivotTables("PivotTable1").PivotFields("OrderCode")
        .PivotItems("AUTOMATIC").Visible = True
        .PivotItems("MANUAL").Visible = True
    End With


Application.ScreenUpdating = False
Application.Calculation = xlCalculationManual

'DLA FRESH


For x = 5 To 10000 'dla kazdej pozycji w pivocie pierwszym
Sheet4.Activate
    numerpivot = Sheet4.Cells(x, 1) 'numer sklepu w pivocie
    poziomicapivot = Sheet4.Range(Sheet4.Cells(x, 2), Sheet4.Cells(x, 9)) 'linia w pivocie za numerem sklepu
    
    For y = 5 To 10000 'dla kazdej pozycji w sheet CSV
        Sheet2.Activate
        magneto = Sheet2.Cells(y, 7) 'kolumna Product
        odrercode = Sheet2.Cells(y, 5) 'kolumna OrderCode (np. Automatic, Manual)
        miejscewklejenia = Sheet2.Range(Cells(y, 8), Cells(y, 15)) 'miejsce od kolumyny palets do kolumny Price
        numercsv = Sheet2.Cells(y, 17) 'kolumna To w csv- numer sklepu
        
            If magneto <> "FF" Then GoTo kolejka

                 If odrercode = "AUTOMATIC" Then
                              If numercsv = numerpivot Then
                              Sheet4.Range(Sheet4.Cells(x, 2), Sheet4.Cells(x, 9)).Copy Sheet2.Range(Sheet2.Cells(y, 8), Sheet2.Cells(y, 15))
                              Exit For
                               End If
                 End If
            
                    If odrercode = "" Then Exit For
            
            
                    If odrercode = "MANUAL" Then
                             If numercsv = numerpivot Then
                             Sheet4.Range(Sheet4.Cells(x, 2), Sheet4.Cells(x, 9)).Copy Sheet2.Range(Sheet2.Cells(y, 8), Sheet2.Cells(y, 15))
                              Sheet2.Cells(y, 5).Value = "AUTOMATIC"
                             Sheet2.Cells(y, 3).Value = ""
                              Exit For
                              End If
                 End If
            

kolejka:         Next y
                
    
    
            If numerpivot = "" Then Exit For
    
        Next x





'DLA AMBIENT


    Sheet4.PivotTables("PivotTable2").PivotFields("Product").ClearAllFilters
    Sheet4.PivotTables("PivotTable2").PivotFields("Product").CurrentPage = "AMB"
    
            With Sheet4.PivotTables("PivotTable2").PivotFields("OrderCode")
        .PivotItems("AUTOMATIC").Visible = True
        .PivotItems("MANUAL").Visible = True
    End With

For x = 5 To 10000
Sheet4.Activate
    numerpivot = Sheet4.Cells(x, 11)
    poziomicapivot = Sheet4.Range(Sheet4.Cells(x, 12), Sheet4.Cells(x, 19))
    
    For y = 5 To 10000
        Sheet2.Activate
        magneto = Sheet2.Cells(y, 7)
        odrercode = Sheet2.Cells(y, 5)
        miejscewklejenia = Sheet2.Range(Cells(y, 8), Cells(y, 15))
        numercsv = Sheet2.Cells(y, 17)
        
            If magneto <> "AMB" Then GoTo kolejka2

                 If odrercode = "AUTOMATIC" Then
                              If numercsv = numerpivot Then
                              Sheet4.Range(Sheet4.Cells(x, 12), Sheet4.Cells(x, 19)).Copy Sheet2.Range(Sheet2.Cells(y, 8), Sheet2.Cells(y, 15))
                              Exit For
                               End If
                 End If
            
                    If odrercode = "" Then Exit For
            
            
                    If odrercode = "MANUAL" Then
                             If numercsv = numerpivot Then
                             Sheet4.Range(Sheet4.Cells(x, 12), Sheet4.Cells(x, 19)).Copy Sheet2.Range(Sheet2.Cells(y, 8), Sheet2.Cells(y, 15))
                              Sheet2.Cells(y, 5).Value = "AUTOMATIC"
                             Sheet2.Cells(y, 3).Value = ""
                              Exit For
                              End If
                 End If
            

kolejka2:         Next y
                
    
    
            If numerpivot = "" Then Exit For
    
        Next x



Application.ScreenUpdating = True
Application.Calculation = xlCalculationAutomatic



End Sub





Sub SSL_COPYx2()
'
' Macro2 Macro
Application.ScreenUpdating = False
Application.Calculation = xlCalculationManual

Range("F7:F50000").Select
    Selection.TextToColumns Destination:=Range("F7"), DataType:=xlDelimited, _
        TextQualifier:=xlDoubleQuote, ConsecutiveDelimiter:=False, Tab:=False, _
        Semicolon:=False, Comma:=False, Space:=False, Other:=True, OtherChar _
        :="|", FieldInfo:=Array(Array(1, 1), Array(2, 1)), DecimalSeparator:=".", _
        ThousandsSeparator:=",", TrailingMinusNumbers:=True
        
        
        Range("F13:F50000").Select
      Selection.Replace What:=" ", Replacement:="", LookAt:=xlPart, _
        SearchOrder:=xlByRows, MatchCase:=False, SearchFormat:=False, _
        ReplaceFormat:=False
        
        Range("H13:U50000").Select
      Selection.Replace What:=" ", Replacement:="", LookAt:=xlPart, _
        SearchOrder:=xlByRows, MatchCase:=False, SearchFormat:=False, _
        ReplaceFormat:=False
        
        
            'For Each cl In Sheet27.Range(Cells(15, 11), Cells(15, 11).End(xlDown))
            'cl.Value = Sheet27.Range("J2").Value
            'Next cl
      
      
        
        For i = 5 To 50000
        
            If Sheets("TMS EX").Cells(i, 6) = "DEST_ID" Then
            
            Range(Sheets("TMS EX").Cells(i + 2, 6), Sheets("TMS EX").Cells(50000, 8)).Copy
            
            Sheets("TMS EX").Cells(8, 38).PasteSpecial Paste:=xlPasteValues, Operation:=xlNone, SkipBlanks _
                :=False, Transpose:=False
            
            
            Exit For
            
            Else 'nic
            
            
            End If
        
        
        
        Next i
        
 Application.Calculation = xlCalculationAutomatic
 
 End Sub
 





