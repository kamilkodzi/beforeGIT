Sub destruktor()
On Error Resume Next
If Sheet27.Range("J2") = "ALL" Then
    Call destruktorx2
    Exit Sub
End If

'funkcja która odpalana jest przez zrobieniem pliku input. Dla kazdej wartosci z tabeli przestawnej poprawia ilosci w pliku finalnym. czy jakos tak.
produkto = Sheet27.Range("J2")

ActiveWorkbook.RefreshAll
    Sheet4.PivotTables("PivotTable1").PivotFields("Product").ClearAllFilters
    Sheet4.PivotTables("PivotTable1").PivotFields("Product").CurrentPage = produkto
    
        With Sheet4.PivotTables("PivotTable1").PivotFields("OrderCode")
        .PivotItems("AUTOMATIC").Visible = True
        .PivotItems("MANUAL").Visible = True
    End With

Application.ScreenUpdating = False
Application.Calculation = xlCalculationManual

For x = 5 To 10000
Sheet4.Activate
    numerpivot = Sheet4.Cells(x, 1)
    poziomicapivot = Sheet4.Range(Sheet4.Cells(x, 2), Sheet4.Cells(x, 9))
    
    For y = 5 To 10000
        Sheet2.Activate
        magneto = Sheet2.Cells(y, 7)
        odrercode = Sheet2.Cells(y, 5)
        miejscewklejenia = Sheet2.Range(Cells(y, 8), Cells(y, 15))
        numercsv = Sheet2.Cells(y, 17)
        
        
        
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
            

    Next y
                
    
    If numerpivot = "" Then Exit For
    
Next x






Application.ScreenUpdating = True
Application.Calculation = xlCalculationAutomatic



End Sub





Sub SSL_COPY()
If Range("F7") = "" Then Exit Sub

If Sheet27.Range("J2") = "ALL" Then
    Call SSL_COPYx2
    Exit Sub
End If



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
        
        Range("G13:U50000").Select
      Selection.Replace What:=" ", Replacement:="", LookAt:=xlPart, _
        SearchOrder:=xlByRows, MatchCase:=False, SearchFormat:=False, _
        ReplaceFormat:=False
        
        
            For Each cl In Sheet27.Range(Cells(15, 11), Cells(15, 11).End(xlDown))
            cl.Value = Sheet27.Range("J2").Value
            Next cl
      
      
        
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
 
 Sub Go()
If Range("F7") = "" Then Exit Sub
 
 
 Application.ScreenUpdating = False
Application.Calculation = xlCalculationManual

Lastline = Sheets("TMS EX").Cells(15, 14).End(xlDown).Row

Range(Sheets("TMS EX").Cells(15, 5), Sheets("TMS EX").Cells(Lastline, 5)).Copy

Sheets("TMS EX").Cells(15, 27).PasteSpecial Paste:=xlPasteValues, Operation:=xlNone, SkipBlanks _
                :=False, Transpose:=False
                
Range("$AA$15:$AA$50000").Select
 
    ActiveSheet.Range("$AA$15:$AA$50000").RemoveDuplicates Columns:=1, Header:= _
        xlNo
        
Application.Calculation = xlCalculationAutomatic
 Application.ScreenUpdating = False
Application.Calculation = xlCalculationManual

lastline1 = Sheets("TMS EX").Cells(14, 26)


Range(Sheets("TMS EX").Cells(15, 28), Sheets("TMS EX").Cells(lastline1, 28)).Copy
Sheets("TMS EX").Cells(15, 48).PasteSpecial Paste:=xlPasteValues, Operation:=xlNone, SkipBlanks _
                :=False, Transpose:=False

Sheets("TMS EX").Cells(15, 53).PasteSpecial Paste:=xlPasteValues, Operation:=xlNone, SkipBlanks _
                :=False, Transpose:=False
 Sheets("TMS EX").Cells(15, 55).PasteSpecial Paste:=xlPasteValues, Operation:=xlNone, SkipBlanks _
                :=False, Transpose:=False
    Sheets("TMS EX").Cells(15, 49).PasteSpecial Paste:=xlPasteValues, Operation:=xlNone, SkipBlanks _
                :=False, Transpose:=False
  Range(Sheets("TMS EX").Cells(15, 33), Sheets("TMS EX").Cells(lastline1, 33)).Copy
   Sheets("TMS EX").Cells(15, 44).PasteSpecial Paste:=xlPasteValues, Operation:=xlNone, SkipBlanks _
                :=False, Transpose:=False
                
 Range(Sheets("TMS EX").Cells(15, 32), Sheets("TMS EX").Cells(lastline1, 32)).Copy
   Sheets("TMS EX").Cells(15, 46).PasteSpecial Paste:=xlPasteValues, Operation:=xlNone, SkipBlanks _
                :=False, Transpose:=False
     Sheets("TMS EX").Cells(15, 47).PasteSpecial Paste:=xlPasteValues, Operation:=xlNone, SkipBlanks _
                :=False, Transpose:=False
                
  Range(Sheets("TMS EX").Cells(15, 29), Sheets("TMS EX").Cells(lastline1, 29)).Copy
                
     Sheets("TMS EX").Cells(15, 50).PasteSpecial Paste:=xlPasteValues, Operation:=xlNone, SkipBlanks _
                :=False, Transpose:=False
                
  Range(Sheets("TMS EX").Cells(15, 30), Sheets("TMS EX").Cells(lastline1, 30)).Copy
                
     Sheets("TMS EX").Cells(15, 51).PasteSpecial Paste:=xlPasteValues, Operation:=xlNone, SkipBlanks _
                :=False, Transpose:=False
   Range(Sheets("TMS EX").Cells(15, 34), Sheets("TMS EX").Cells(lastline1, 34)).Copy
                
     Sheets("TMS EX").Cells(15, 52).PasteSpecial Paste:=xlPasteValues, Operation:=xlNone, SkipBlanks _
                :=False, Transpose:=False

 Range(Sheets("TMS EX").Cells(15, 31), Sheets("TMS EX").Cells(lastline1, 31)).Copy
                
     Sheets("TMS EX").Cells(15, 57).PasteSpecial Paste:=xlPasteValues, Operation:=xlNone, SkipBlanks _
                :=False, Transpose:=False

 Range(Sheets("TMS EX").Cells(15, 35), Sheets("TMS EX").Cells(lastline1, 35)).Copy
                
     Sheets("TMS EX").Cells(15, 58).PasteSpecial Paste:=xlPasteValues, Operation:=xlNone, SkipBlanks _
                :=False, Transpose:=False
                
      Sheets("TMS EX").Cells(15, 56).PasteSpecial Paste:=xlPasteValues, Operation:=xlNone, SkipBlanks _
                :=False, Transpose:=False
                           
                
Range(Sheets("TMS EX").Cells(15, 36), Sheets("TMS EX").Cells(lastline1, 36)).Copy
                
     Sheets("TMS EX").Cells(15, 45).PasteSpecial Paste:=xlPasteValues, Operation:=xlNone, SkipBlanks _
                :=False, Transpose:=False


lastline2 = Sheets("TMS EX").Cells(15, 48).End(xlDown).Row + 1
Range(Sheets("TMS EX").Cells(15, 43), Sheets("TMS EX").Cells(lastline2, 58)).Copy
Sheets("CSV").Cells(5, 3).PasteSpecial Paste:=xlPasteValues, Operation:=xlNone, SkipBlanks _
                :=False, Transpose:=False
              


        
 Application.Calculation = xlCalculationAutomatic
  Application.ScreenUpdating = True

Sheet3.Activate
 
 
End Sub

Sub manual()
Application.ScreenUpdating = False
Application.Calculation = xlCalculationManual

    For Each cl In Sheet3.Range("G8:O3000")
        cl.Value = cl.Value
    Next cl
Application.Calculation = xlCalculationAutomatic

If Range("J8") = "" Then
Sheet2.Activate
Exit Sub
End If

Application.ScreenUpdating = False
Application.Calculation = xlCalculationManual

lastline2 = Sheets("Manual").Cells(7, 64)

Range(Sheets("Manual").Cells(8, 46), Sheets("Manual").Cells(lastline2, 61)).Copy

Lastline3 = Sheets("CSV").Cells(5, 8).End(xlDown).Row + 1
Sheets("CSV").Cells(Lastline3, 3).PasteSpecial Paste:=xlPasteValues, Operation:=xlNone, SkipBlanks _
                :=False, Transpose:=False
              


 Application.Calculation = xlCalculationAutomatic
 
 
 Sheets("CSV").Activate

End Sub

Sub newww()

If Range("Q5") = "" Then
MsgBox ("Komorka sprawdzajaca Q5 jest pusta")
Exit Sub
End If


Application.ScreenUpdating = False
Application.Calculation = xlCalculationManual
    

Call destruktor

If Sheet3.Range("R4") = "Tak" Then Call konan



    For x = 5 To 2000
    If Sheet2.Cells(x, 5) = "MANUAL" Then
    Rows(x).Delete
    x = x - 1
    End If
    If Sheet2.Cells(x, 5) = "" Then Exit For
    Next x
    
    
        If Sheet2.Range("D2") <> "" Then
        d2 = Sheet2.Range("D2")
            For c = 5 To 2000
                If Sheet2.Cells(c, 8) = "" Then Exit For
                 If Sheet2.Cells(c, 8) <= d2 Then
                  Rows(c).Delete
                  c = c - 1
                  End If
              
              Next c
        End If
    
    
        If Sheet2.Range("C2") <> "ORGINAL" Then
            For Each cl In Sheet2.Range("R5:R2000")
                If cl = "" Then
                Exit For
                Else
                cl.Value = Sheet2.Range("C2")
            End If
            Next cl
        End If
    
    
    
Lastline = Sheets("CSV").Cells(5, 5).End(xlDown).Row
Range(Sheets("CSV").Cells(4, 3), Sheets("CSV").Cells(Lastline, 18)).Copy





Workbooks.Add.Activate
        Selection.PasteSpecial Paste:=xlPasteValues, Operation:=xlNone, SkipBlanks _
                :=False, Transpose:=False
 Selection.PasteSpecial Paste:=xlPasteFormats, Operation:=xlNone, _
                SkipBlanks:=False, Transpose:=False
                
                
                
Application.ScreenUpdating = True
Application.Calculation = xlCalculationAutomatic



End Sub


Sub ssl_paste()
Application.ScreenUpdating = False
Application.Calculation = xlCalculationManual


wartosc = Sheet27.Range("AO1")

Sheet27.Range("AO8:AO1000") = wartosc


Application.Calculation = xlCalculationAutomatic
Application.ScreenUpdating = True
End Sub



Sub konan()

Application.ScreenUpdating = False
Application.Calculation = xlCalculationManual

For Each cl In Sheet3.Range("Q8:Q31")

    If cl <> "" Then
        On Error Resume Next
        szukprod = cl.Text 'Produkty typu lop
        
        ActiveWorkbook.RefreshAll
         Sheet4.PivotTables("PivotTable3").PivotFields("Product").ClearAllFilters
         Sheet4.PivotTables("PivotTable3").PivotFields("Product").CurrentPage = szukprod
                
        With Sheet4.PivotTables("PivotTable3").PivotFields("OrderCode")
        .PivotItems("AUTOMATIC").Visible = True
        .PivotItems("MANUAL").Visible = True
    End With


        For x = 5 To 10000
        Sheet4.Activate
         numerpivot = Sheet4.Cells(x, 21)
         poziomicapivot = Sheet4.Range(Sheet4.Cells(x, 22), Sheet4.Cells(x, 29))
    
         For y = 5 To 10000
                Sheet2.Activate
                magneto = Sheet2.Cells(y, 7) 'kolumna produkt w CSV
              odrercode = Sheet2.Cells(y, 5) ' Automatic albio Manual
              miejscewklejenia = Sheet2.Range(Cells(y, 8), Cells(y, 15))
              numercsv = Sheet2.Cells(y, 17) 'numer sklepu w csv
        
        
        
                  If magneto = szukprod Then
                              If numercsv = numerpivot Then
                             Sheet4.Range(Sheet4.Cells(x, 22), Sheet4.Cells(x, 29)).Copy Sheet2.Range(Sheet2.Cells(y, 8), Sheet2.Cells(y, 15))
                              Sheet2.Cells(y, 5).Value = "AUTOMATIC"
                               Sheet2.Cells(y, 3).Value = ""
                               Exit For
                               End If
                  End If
            
                 If odrercode = "" Then Exit For
            
                       

          Next y
                
    
         If numerpivot = "" Then Exit For
    
        Next x
Else

End If

Next cl



Application.ScreenUpdating = True
Application.Calculation = xlCalculationAutomatic








End Sub

