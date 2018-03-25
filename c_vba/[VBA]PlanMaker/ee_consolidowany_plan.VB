Sub planconsol()
'program dla jednej daty- tworzenie pliku glownego tzw "dla simony" glownego odbiorcy
'
'
'
'
'DEKLARACJE




Dim planconsol As Worksheet
Dim gala, box, hng As Integer
Dim linia As Range
Dim linia2 As Range
Dim linia3 As Range
Dim linia4 As Range
Dim linia5 As Range
Dim linia6 As Range
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
'
'ROBIENIE NOWEGO SKOROSZYTU
    krajek = Sheet2.Range("W4")
    Set planconsol = Sheets.Add(After:=Sheets(Sheets.Count))
    planconsol.Name = krajek & " " & datka & datka2
Sheet2.Range("BS2:CK2").Copy
    planconsol.PasteSpecial xlPasteValuesAndNumberFormats
Range("A1:S45").Select
Selection.AutoFilter
'ROBIENIE NOWEGO SKOROSZYTU/
'
'
'
'
'UZUPELNIANIE SKOROSZYTU
        For Z = 11 To 801
            czeker = Sheet2.Cells(Z, 24)
            If czeker <> "" Then
                For x = 11 To 801
                    If Sheet2.Cells(x, 8) = "" Then Exit For
                    systemno = Sheet2.Cells(x, 8)
                        If czeker = systemno Then
                           ' If krajekczek = krajek Then
                            If 1 = 1 Then
                    krajekczek = Left(Sheet2.Cells(x, 1), 2)
                    Set linia = Sheet2.Range(Sheet2.Cells(x, 7), Sheet2.Cells(x, 14))
                    Set linia6 = Sheet2.Cells(x, 16)
                    Set linia2 = Sheet2.Range(Sheet2.Cells(Z, 27), Sheet2.Cells(Z, 30))
                    Set linia3 = Sheet2.Cells(x, 75)
                    Set linia4 = Sheet2.Range(Sheet2.Cells(x, 92), Sheet2.Cells(x, 94))
                    Set linia5 = Sheet2.Range(Sheet2.Cells(x, 96), Sheet2.Cells(x, 97))
                                
                                planconsol.Activate
                                linia.Copy
                                planconsol.Range("A800").End(xlUp).Offset(1, 0).PasteSpecial xlPasteValuesAndNumberFormats
                                linia6.Copy
                                planconsol.Range("I800").End(xlUp).Offset(1, 0).PasteSpecial xlPasteValuesAndNumberFormats
                                linia5.Copy
                                planconsol.Range("J800").End(xlUp).Offset(1, 0).PasteSpecial xlPasteValuesAndNumberFormats
                                linia2.Copy
                                planconsol.Range("L800").End(xlUp).Offset(1, 0).PasteSpecial xlPasteValuesAndNumberFormats
                                linia3.Copy
                                planconsol.Range("P800").End(xlUp).Offset(1, 0).PasteSpecial xlPasteValuesAndNumberFormats
                                linia4.Copy
                                planconsol.Range("Q800").End(xlUp).Offset(1, 0).PasteSpecial xlPasteValuesAndNumberFormats
                                
                                gala = planconsol.Range("I800").End(xlUp).Offset(0, 0)
                                boxy = planconsol.Range("J800").End(xlUp).Offset(0, 0)
                                hng = planconsol.Range("K800").End(xlUp).Offset(0, 0)
                                    
                                planconsol.Range("I800").End(xlUp).Offset(0, 0) = gala - (boxy + hng)

                                
                                    
                            End If
                        End If
                Next x
            End If
        Next Z
'UZUPELNIANIE SKOROSZYTU/
'
'
'zmiana naglowkow

'zmiana naglowkow


'
'
'SORTOWANIE DANYCH
    planconsol.AutoFilter.Sort.SortFields.Clear
    
        planconsol.AutoFilter.Sort.SortFields.Clear
    planconsol.AutoFilter.Sort.SortFields.Add Key _
        :=Range("G1"), SortOn:=xlSortOnValues, Order:=xlAscending, DataOption:= _
        xlSortNormal
    With planconsol.AutoFilter.Sort
        .Header = xlYes
        .MatchCase = False
        .Orientation = xlTopToBottom
        .SortMethod = xlPinYin
        .Apply
    End With



        planconsol.AutoFilter.Sort.SortFields.Clear
    planconsol.AutoFilter.Sort.SortFields.Add Key _
        :=Range("B1"), SortOn:=xlSortOnValues, Order:=xlAscending, DataOption:= _
        xlSortNormal
    With planconsol.AutoFilter.Sort
        .Header = xlYes
        .MatchCase = False
        .Orientation = xlTopToBottom
        .SortMethod = xlPinYin
        .Apply
    End With
    
        planconsol.AutoFilter.Sort.SortFields.Clear
    planconsol.AutoFilter.Sort.SortFields.Add Key _
        :=Range("B1"), SortOn:=xlSortOnValues, Order:=xlDescending, DataOption:= _
        xlSortNormal
    With planconsol.AutoFilter.Sort
        .Header = xlYes
        .MatchCase = False
        .Orientation = xlTopToBottom
        .SortMethod = xlPinYin
        .Apply
    End With

    
    
planconsol.AutoFilter.Sort.SortFields.Clear
    planconsol.AutoFilter.Sort.SortFields.Add Key _
        :=Range("A1"), SortOn:=xlSortOnValues, Order:=xlAscending, DataOption:= _
        xlSortNormal
    With planconsol.AutoFilter.Sort
        .Header = xlYes
        .MatchCase = False
        .Orientation = xlTopToBottom
        .SortMethod = xlPinYin
        .Apply
    End With
    
    
    planconsol.AutoFilter.Sort.SortFields.Add Key _
        :=Range("B1"), SortOn:=xlSortOnValues, Order:=xlAscending, DataOption:= _
        xlSortNormal
    With planconsol.AutoFilter.Sort
        .Header = xlYes
        .MatchCase = False
        .Orientation = xlTopToBottom
        .SortMethod = xlPinYin
        .Apply
    End With
'SORTOWANIE DANYCH/
'
'
'
'
'MERGOWANIE PODOBNYCH KOMOREK
    Application.DisplayAlerts = False
    I = Application.WorksheetFunction.CountA(planconsol.Range("B:B"))
    planconsol.Cells(I + 1, 2).Value = "X"
For Row = 2 To I
    Min = 1
    Do
    If planconsol.Cells(Row, 2).Value = planconsol.Cells(Row + Min, 2).Value Then
        Range(planconsol.Cells(Row, 1), planconsol.Cells(Row + Min, 1)).Merge
        Range(planconsol.Cells(Row, 2), planconsol.Cells(Row + Min, 2)).Merge
        Range(planconsol.Cells(Row, 3), planconsol.Cells(Row + Min, 3)).Merge
        Range(planconsol.Cells(Row, 4), planconsol.Cells(Row + Min, 4)).Merge
        'Range(planconsol.Cells(Row, 9), planconsol.Cells(Row + Min, 9)).Merge
        'Range(planconsol.Cells(Row, 11), planconsol.Cells(Row + Min, 11)).Merge
        Range(planconsol.Cells(Row, 12), planconsol.Cells(Row + Min, 12)).Merge
        Range(planconsol.Cells(Row, 13), planconsol.Cells(Row + Min, 13)).Merge
        Range(planconsol.Cells(Row, 14), planconsol.Cells(Row + Min, 14)).Merge
        Range(planconsol.Cells(Row, 15), planconsol.Cells(Row + Min, 15)).Merge
        Range(planconsol.Cells(Row, 16), planconsol.Cells(Row + Min, 16)).Merge
        Min = Min + 1
        Else
    End If
    Loop Until planconsol.Cells(Row, 2).Value <> planconsol.Cells(Row + Min, 2)
Next Row

Application.DisplayAlerts = True

planconsol.Cells(I + 1, 2).Value = ""
'MERGOWANIE PODOBNYCH KOMOREK
'
'
'
'
'AUTOMATYCZNE ROZSZERZANIE KOLUMN I WYSRODKOWANIE
    Columns("A:S").EntireColumn.AutoFit
    Columns("A:S").Select
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
   
'USUWANIE NIEPOTRZEBNEJ KOLUMNY Z DEPOTEM
'Columns("I:I").EntireColumn.Delete
'USUWANIE NIEPOTRZEBNEJ KOLUMNY Z DEPOTEM/
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
'
planconsol.AutoFilter.Sort.SortFields.Clear
Range("A1:S1").Select
Selection.AutoFilter
ile = Application.WorksheetFunction.CountA(Range("E:E"))
Range(Cells(1, 1), Cells(ile, 19)).Value = Range(Cells(1, 1), Cells(ile, 19)).Value
Range("A1").Select



End Sub


