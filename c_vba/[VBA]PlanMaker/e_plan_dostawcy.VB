Sub plandostawcy()
'DEKLARACJE
Dim plandostawcy As Worksheet
Dim linia As Range
Dim linia2 As Range
Dim linia3 As Range
Dim linia4 As Range
datka = Sheet2.Range("W1")
datka = Format(datka, "mmdd")
datka2 = Sheet2.Range("V1")
datka2 = "-" & Format(datka2, "dd")
If Sheet2.Range("V1") = Sheet2.Range("W1") Or Sheet2.Range("V1") = "00:00:00" Then datka2 = ""
magazyn = Sheet2.Range("W4")
'DEKLARACJE/
'
'



'
'Usuniecie duplikatow symboli dostawcow i wklejenie ich do kolumny U
'Sheet3.Activate
'Sheet3.Range("R110:R325").Select
    'Selection.Copy
    'Sheet2.Activate
    'Sheet2.Range("U11").PasteSpecial Paste:=xlPasteValues, Operation:=xlNone, SkipBlanks _
        ':=False, Transpose:=False
    'Application.CutCopyMode = False
'ActiveSheet.Range("$U$11:$U$803").RemoveDuplicates Columns:=1, Header:=xlNo
'Usuniecie duplikatow symboli dostawcow i wklejenie ich do kolumny U/
'
'
'
'UZUPELNIANIE SKOROSZYTU
For Each cl In Sheet2.Range("U11:U20")
    If cl <> "" Then
        extra = 0
        Set plandostawcy = Sheets.Add(After:=Sheets(Sheets.Count))
        plandostawcy.Name = "TP " & magazyn & " " & cl & " " & datka & datka2
        Sheet2.Range("BS2:CK2").Copy
        plandostawcy.PasteSpecial xlPasteValuesAndNumberFormats
        Range("A:S").Select
        Selection.AutoFilter
        dlugosc = Len(Sheet2.Range("W4"))
        symbolg = Mid(plandostawcy.Name, dlugosc + 5, 3)
        If Mid(symbolg, 2, 1) = "!" Then
        extra = 100
        End If
        
        For Z = 11 To 801
            czeker = Sheet2.Cells(Z, 24)
            If czeker <> "" Then
                
                For x = 11 To 801
                    symbol = Sheet2.Cells(x, 6 + extra)
                    systemno = Sheet2.Cells(x, 8)
                    If systemno = "" Then Exit For
                    Set linia = Sheet2.Range(Sheet2.Cells(x, 7), Sheet2.Cells(x, 14))
                    Set linia6 = Sheet2.Cells(x, 16)
                    Set linia2 = Sheet2.Range(Sheet2.Cells(Z, 27), Sheet2.Cells(Z, 30))
                    Set linia3 = Sheet2.Cells(x, 75)
                    Set linia4 = Sheet2.Range(Sheet2.Cells(x, 92), Sheet2.Cells(x, 94))
                    Set linia5 = Sheet2.Range(Sheet2.Cells(x, 96), Sheet2.Cells(x, 97))
                        If czeker = systemno Then
                            If symbol = cl Then
                                plandostawcy.Activate
                                linia.Copy
                                plandostawcy.Range("A800").End(xlUp).Offset(1, 0).PasteSpecial xlPasteValuesAndNumberFormats
                                linia6.Copy
                                plandostawcy.Range("I800").End(xlUp).Offset(1, 0).PasteSpecial xlPasteValuesAndNumberFormats
                                linia5.Copy
                                plandostawcy.Range("J800").End(xlUp).Offset(1, 0).PasteSpecial xlPasteValuesAndNumberFormats
                                linia2.Copy
                                plandostawcy.Range("L800").End(xlUp).Offset(1, 0).PasteSpecial xlPasteValuesAndNumberFormats
                                linia3.Copy
                                plandostawcy.Range("P800").End(xlUp).Offset(1, 0).PasteSpecial xlPasteValuesAndNumberFormats
                                linia4.Copy
                                plandostawcy.Range("Q800").End(xlUp).Offset(1, 0).PasteSpecial xlPasteValuesAndNumberFormats
                            End If
                        End If
                    
                Next x
            End If
        Next Z
     End If
     
     If cl = Empty Then Exit For
          Range("J:N").Delete
          Range("I1") = "Pallets"
          
'
'
'
'
'STOPKA
'
'
'
'SORTOWANIE DANYCH
If cl = "" Then GoTo Power

    plandostawcy.AutoFilter.Sort.SortFields.Clear
    
        plandostawcy.AutoFilter.Sort.SortFields.Clear
    plandostawcy.AutoFilter.Sort.SortFields.Add Key _
        :=Range("G1"), SortOn:=xlSortOnValues, Order:=xlAscending, DataOption:= _
        xlSortNormal
    With plandostawcy.AutoFilter.Sort
        .Header = xlYes
        .MatchCase = False
        .Orientation = xlTopToBottom
        .SortMethod = xlPinYin
        .Apply
    End With

    plandostawcy.AutoFilter.Sort.SortFields.Clear
    plandostawcy.AutoFilter.Sort.SortFields.Add Key _
        :=Range("B1"), SortOn:=xlSortOnValues, Order:=xlAscending, DataOption:= _
        xlSortNormal
    With plandostawcy.AutoFilter.Sort
        .Header = xlYes
        .MatchCase = False
        .Orientation = xlTopToBottom
        .SortMethod = xlPinYin
        .Apply
    End With
    
    plandostawcy.AutoFilter.Sort.SortFields.Clear
    plandostawcy.AutoFilter.Sort.SortFields.Clear
    plandostawcy.AutoFilter.Sort.SortFields.Add Key _
        :=Range("A1"), SortOn:=xlSortOnValues, Order:=xlAscending, DataOption:= _
        xlSortNormal
    With plandostawcy.AutoFilter.Sort
        .Header = xlYes
        .MatchCase = False
        .Orientation = xlTopToBottom
        .SortMethod = xlPinYin
        .Apply
    End With
    plandostawcy.AutoFilter.Sort.SortFields.Clear
'SORTOWANIE DANYCH/
'
'
'
'
'MERGOWANIE PODOBNYCH KOMOREK
    Application.DisplayAlerts = False
    I = Application.WorksheetFunction.CountA(plandostawcy.Range("B:B"))
    plandostawcy.Cells(I + 1, 2).Value = "X"
For Row = 2 To I
    Min = 1
    Do
    If plandostawcy.Cells(Row, 2).Value = plandostawcy.Cells(Row + Min, 2).Value Then
        Range(plandostawcy.Cells(Row, 1), plandostawcy.Cells(Row + Min, 1)).Merge
        Range(plandostawcy.Cells(Row, 2), plandostawcy.Cells(Row + Min, 2)).Merge
        Range(plandostawcy.Cells(Row, 3), plandostawcy.Cells(Row + Min, 3)).Merge
        Range(plandostawcy.Cells(Row, 4), plandostawcy.Cells(Row + Min, 4)).Merge
        'Range(plandostawcy.Cells(Row, 9), plandostawcy.Cells(Row + Min, 9)).Merge
        'Range(plandostawcy.Cells(Row, 11), plandostawcy.Cells(Row + Min, 11)).Merge
        Range(plandostawcy.Cells(Row, 10), plandostawcy.Cells(Row + Min, 10)).Merge
        Range(plandostawcy.Cells(Row, 11), plandostawcy.Cells(Row + Min, 11)).Merge
        Min = Min + 1
        Else
    End If
    Loop Until plandostawcy.Cells(Row, 2).Value <> plandostawcy.Cells(Row + Min, 2)
Next Row

Application.DisplayAlerts = True

plandostawcy.Cells(I + 1, 2).Value = ""
'MERGOWANIE PODOBNYCH KOMOREK
'
'
'
'
'AUTOMATYCZNE ROZSZERZANIE KOLUMN I WYSRODKOWANIE
    Columns("A:N").EntireColumn.AutoFit
    Columns("A:N").Select
    With Selection
        .HorizontalAlignment = xlCenter
        .VerticalAlignment = xlBottom
        .WrapText = False
        .Orientation = 0
        .AddIndent = False
        .IndentLevel = 0
        .ShrinkToFit = False
        .ReadingOrder = xlContext
    End With
    
    
    With Selection
        .HorizontalAlignment = xlCenter
        .VerticalAlignment = xlCenter
        .WrapText = False
        .Orientation = 0
        .AddIndent = False
        .IndentLevel = 0
        .ShrinkToFit = False
        .ReadingOrder = xlContext
    End With
'AUTOMATYCZNE ROZSZERZANIE KOLUMN I WYSRODKOWANIE/
'
'
'
'
'Wstawianie BORDERSÓW
Range("A1").CurrentRegion.Select

    With Selection.Borders(xlEdgeLeft)
        .LineStyle = xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = xlThin
    End With
    With Selection.Borders(xlEdgeTop)
        .LineStyle = xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = xlThin
    End With
    With Selection.Borders(xlEdgeBottom)
        .LineStyle = xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = xlThin
    End With
    With Selection.Borders(xlEdgeRight)
        .LineStyle = xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = xlThin
    End With
    With Selection.Borders(xlInsideVertical)
        .LineStyle = xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = xlThin
    End With
    With Selection.Borders(xlInsideHorizontal)
        .LineStyle = xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = xlThin
    End With
    
    

'Wstawianie BORDERSÓW/
'
'
'
'STOPKA
'
'
'

    plandostawcy.Range("A1:N1").AutoFilter
    ile = Application.WorksheetFunction.CountA(Range("E:E"))
Range(Cells(1, 1), Cells(ile, 14)).Value = Range(Cells(1, 1), Cells(ile, 14)).Value
Range("A1").Select

Power:
If cl = Empty Then Exit For

Next cl


'UZUPELNIANIE SKOROSZYTU/
'
'
'
'
End Sub
