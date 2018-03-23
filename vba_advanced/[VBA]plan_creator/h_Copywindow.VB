Sub copywindos()

Application.Calculation = xlCalculationManual
Application.ScreenUpdating = False


    Sheet1.Activate
    Columns("A:A").Select
    ActiveWorkbook.Worksheets("OrderGrid").Sort.SortFields.Clear
    ActiveWorkbook.Worksheets("OrderGrid").Sort.SortFields.Add Key:=Range("A1"), _
        SortOn:=xlSortOnValues, Order:=xlAscending, DataOption:= _
        xlSortTextAsNumbers
    With ActiveWorkbook.Worksheets("OrderGrid").Sort
        .SetRange Range("A2:AU10000")
        .Header = xlNo
        .MatchCase = False
        .Orientation = xlTopToBottom
        .SortMethod = xlPinYin
        .Apply
    End With
    
    For x = 2 To 10000
        If Sheet1.Cells(x, 1) = "" Then Exit For
        If Right(Sheet1.Cells(x, 1), 1) = "A" Then
        
            For y = x To 10000
                If Sheet1.Cells(y, 1) = Left(Sheet1.Cells(x, 1), Len(Sheet1.Cells(x, 1)) - 1) & "B" Then
                    Sheet1.Cells(y, 20) = Sheet1.Cells(x, 20)
                    Sheet1.Cells(y, 21) = Sheet1.Cells(x, 21)
                    Sheet1.Cells(y, 22) = Sheet1.Cells(x, 22)
                    Sheet1.Cells(y, 23) = Sheet1.Cells(x, 23)
                    Sheet1.Cells(y, 24) = Sheet1.Cells(x, 24)
                    Sheet1.Cells(y, 25) = Sheet1.Cells(x, 25)
                    Sheet1.Cells(y, 26) = Sheet1.Cells(x, 26)
                    Exit For
                End If
                If Sheet1.Cells(y, 1) = Empty Then Exit For
            Next y
            
        End If
        
        
    
    
    Next x
    
    
    Sheet2.Activate
    
    Application.Calculation = xlCalculationAutomatic
    Application.ScreenUpdating = True
    
    
End Sub
