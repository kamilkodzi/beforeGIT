Sub planglowny1()
'program dla jednej daty- tworzenie pliku glownego tzw "dla simony" glownego odbiorcy
'
'
'
'
'DEKLARACJE

Dim planglowny As Worksheet
Dim gala, box, hng As Integer
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
'
'ROBIENIE NOWEGO SKOROSZYTU
    krajek = "PL"
    Set planglowny = Sheets.Add(After:=Sheets(Sheets.Count))
    planglowny.Name = magazyn & " " & krajek & " " & datka & datka2
Sheet2.Range("BS2:CK2").Copy
    planglowny.PasteSpecial xlPasteValuesAndNumberFormats
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
                    krajekczek = Left(Sheet2.Cells(x, 1), 2)
                    systemno = Sheet2.Cells(x, 8)
                    If systemno = "" Then Exit For
                    Set linia = Sheet2.Range(Sheet2.Cells(x, 7), Sheet2.Cells(x, 14))
                    Set linia6 = Sheet2.Cells(x, 16)
                    Set linia2 = Sheet2.Range(Sheet2.Cells(Z, 27), Sheet2.Cells(Z, 30))
                    Set linia3 = Sheet2.Cells(x, 75)
                    Set linia4 = Sheet2.Range(Sheet2.Cells(x, 92), Sheet2.Cells(x, 94))
                    Set linia5 = Sheet2.Range(Sheet2.Cells(x, 96), Sheet2.Cells(x, 97))
                        If czeker = systemno Then
                            If krajekczek = krajek Then

                                planglowny.Activate
                                linia.Copy
                                planglowny.Range("A800").End(xlUp).Offset(1, 0).PasteSpecial xlPasteValuesAndNumberFormats
                                linia6.Copy
                                planglowny.Range("I800").End(xlUp).Offset(1, 0).PasteSpecial xlPasteValuesAndNumberFormats
                                linia5.Copy
                                planglowny.Range("J800").End(xlUp).Offset(1, 0).PasteSpecial xlPasteValuesAndNumberFormats
                                linia2.Copy
                                planglowny.Range("L800").End(xlUp).Offset(1, 0).PasteSpecial xlPasteValuesAndNumberFormats
                                linia3.Copy
                                planglowny.Range("P800").End(xlUp).Offset(1, 0).PasteSpecial xlPasteValuesAndNumberFormats
                                linia4.Copy
                                planglowny.Range("Q800").End(xlUp).Offset(1, 0).PasteSpecial xlPasteValuesAndNumberFormats
                                
                                gala = planglowny.Range("I800").End(xlUp).Offset(0, 0)
                                boxy = planglowny.Range("J800").End(xlUp).Offset(0, 0)
                                hng = planglowny.Range("K800").End(xlUp).Offset(0, 0)
                                    
                                planglowny.Range("I800").End(xlUp).Offset(0, 0) = gala - (boxy + hng)


                            End If
                        End If
                Next x
            End If
        Next Z
'UZUPELNIANIE SKOROSZYTU/
'
'
'
'
'SORTOWANIE DANYCH
    planglowny.AutoFilter.Sort.SortFields.Clear
    
        planglowny.AutoFilter.Sort.SortFields.Clear
    planglowny.AutoFilter.Sort.SortFields.Add Key _
        :=Range("G1"), SortOn:=xlSortOnValues, Order:=xlAscending, DataOption:= _
        xlSortNormal
    With planglowny.AutoFilter.Sort
        .Header = xlYes
        .MatchCase = False
        .Orientation = xlTopToBottom
        .SortMethod = xlPinYin
        .Apply
    End With



        planglowny.AutoFilter.Sort.SortFields.Clear
    planglowny.AutoFilter.Sort.SortFields.Add Key _
        :=Range("B1"), SortOn:=xlSortOnValues, Order:=xlAscending, DataOption:= _
        xlSortNormal
    With planglowny.AutoFilter.Sort
        .Header = xlYes
        .MatchCase = False
        .Orientation = xlTopToBottom
        .SortMethod = xlPinYin
        .Apply
    End With
    
        planglowny.AutoFilter.Sort.SortFields.Clear
    planglowny.AutoFilter.Sort.SortFields.Add Key _
        :=Range("M1"), SortOn:=xlSortOnValues, Order:=xlDescending, DataOption:= _
        xlSortNormal
    With planglowny.AutoFilter.Sort
        .Header = xlYes
        .MatchCase = False
        .Orientation = xlTopToBottom
        .SortMethod = xlPinYin
        .Apply
    End With

    
    
planglowny.AutoFilter.Sort.SortFields.Clear
    planglowny.AutoFilter.Sort.SortFields.Add Key _
        :=Range("A1"), SortOn:=xlSortOnValues, Order:=xlAscending, DataOption:= _
        xlSortNormal
    With planglowny.AutoFilter.Sort
        .Header = xlYes
        .MatchCase = False
        .Orientation = xlTopToBottom
        .SortMethod = xlPinYin
        .Apply
    End With
    
    
    planglowny.AutoFilter.Sort.SortFields.Add Key _
        :=Range("A1"), SortOn:=xlSortOnValues, Order:=xlAscending, DataOption:= _
        xlSortNormal
    With planglowny.AutoFilter.Sort
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
    I = Application.WorksheetFunction.CountA(planglowny.Range("B:B"))
    planglowny.Cells(I + 1, 2).Value = "X"
For Row = 2 To I
    Min = 1
    Do
    If planglowny.Cells(Row, 2).Value = planglowny.Cells(Row + Min, 2).Value Then
        Range(planglowny.Cells(Row, 1), planglowny.Cells(Row + Min, 1)).Merge
        Range(planglowny.Cells(Row, 2), planglowny.Cells(Row + Min, 2)).Merge
        Range(planglowny.Cells(Row, 3), planglowny.Cells(Row + Min, 3)).Merge
        Range(planglowny.Cells(Row, 4), planglowny.Cells(Row + Min, 4)).Merge
        'Range(planglowny.Cells(Row, 9), planglowny.Cells(Row + Min, 9)).Merge
        'Range(planglowny.Cells(Row, 11), planglowny.Cells(Row + Min, 11)).Merge
        Range(planglowny.Cells(Row, 12), planglowny.Cells(Row + Min, 12)).Merge
        Range(planglowny.Cells(Row, 13), planglowny.Cells(Row + Min, 13)).Merge
        Range(planglowny.Cells(Row, 14), planglowny.Cells(Row + Min, 14)).Merge
        Range(planglowny.Cells(Row, 15), planglowny.Cells(Row + Min, 15)).Merge
        Range(planglowny.Cells(Row, 16), planglowny.Cells(Row + Min, 16)).Merge
        Min = Min + 1
        Else
    End If
    Loop Until planglowny.Cells(Row, 2).Value <> planglowny.Cells(Row + Min, 2)
Next Row

Application.DisplayAlerts = True

planglowny.Cells(I + 1, 2).Value = ""
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
planglowny.AutoFilter.Sort.SortFields.Clear
Range("A1:S1").Select
Selection.AutoFilter
ile = Application.WorksheetFunction.CountA(Range("E:E"))
Range(Cells(1, 1), Cells(ile, 19)).Value = Range(Cells(1, 1), Cells(ile, 19)).Value
Range("A1").Select



End Sub
