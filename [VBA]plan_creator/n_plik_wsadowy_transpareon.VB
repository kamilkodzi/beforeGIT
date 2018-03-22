Sub plik_wsadowy()
'program dla jednej daty- tworzenie pliku glownego tzw "dla simony" glownego odbiorcy
'
'
'
'
'DEKLARACJE

Application.Calculation = xlCalculationManual
Application.ScreenUpdating = False


Dim planconsol As Worksheet
Dim linia As Range
Dim linia2 As Range
Dim linia3 As Range

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
    planconsol.Name = "Input TICB " & krajek & " " & datka & datka2
Sheet2.Range("BS4:CJ4").Copy
    planconsol.PasteSpecial xlPasteValuesAndNumberFormats
Range("A1:R1").Select
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
                    Set linia = Sheet2.Range(Sheet2.Cells(x, 7), Sheet2.Cells(x, 16))
                    Set linia2 = Sheet2.Range(Sheet2.Cells(Z, 27), Sheet2.Cells(Z, 30))
                    Set linia3 = Sheet2.Range(Sheet2.Cells(x, 76), Sheet2.Cells(x, 79))
                        If czeker = systemno Then
                                planconsol.Activate
                                linia.Copy
                                planconsol.Range("A800").End(xlUp).Offset(1, 0).PasteSpecial xlPasteValuesAndNumberFormats
                                linia2.Copy
                                planconsol.Range("K800").End(xlUp).Offset(1, 0).PasteSpecial xlPasteValuesAndNumberFormats
                                linia3.Copy
                                planconsol.Range("O800").End(xlUp).Offset(1, 0).PasteSpecial xlPasteValuesAndNumberFormats
                        End If
                Next x
            End If
        Next Z
        
        
        
        Range("M:M").Delete
        Range("L:L").Delete
        Range("K:K").Delete
        Range("I:I").Delete
        Range("A:A").Delete
        
        
        
        
'UZUPELNIANIE SKOROSZYTU/
'
'
'
'
'SORTOWANIE DANYCH
    planconsol.AutoFilter.Sort.SortFields.Clear
    
        planconsol.AutoFilter.Sort.SortFields.Clear
    planconsol.AutoFilter.Sort.SortFields.Add Key _
        :=Range("F1"), SortOn:=xlSortOnValues, Order:=xlAscending, DataOption:= _
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
   
planconsol.AutoFilter.Sort.SortFields.Clear
    planconsol.AutoFilter.Sort.SortFields.Add Key _
        :=Range("J1"), SortOn:=xlSortOnValues, Order:=xlAscending, DataOption:= _
        xlSortNormal
    With planconsol.AutoFilter.Sort
        .Header = xlYes
        .MatchCase = False
        .Orientation = xlTopToBottom
        .SortMethod = xlPinYin
        .Apply
    End With
    
    
    planconsol.AutoFilter.Sort.SortFields.Add Key _
        :=Range("J1"), SortOn:=xlSortOnValues, Order:=xlAscending, DataOption:= _
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
    planconsol.Cells(I + 1, 1).Value = "X"
For Row = 2 To I
    Min = 1
    Do
    If planconsol.Cells(Row, 1).Value = planconsol.Cells(Row + Min, 1).Value Then
        Range(planconsol.Cells(Row, 1), planconsol.Cells(Row + Min, 1)).Merge
        Range(planconsol.Cells(Row, 2), planconsol.Cells(Row + Min, 2)).Merge
        Range(planconsol.Cells(Row, 7), planconsol.Cells(Row + Min, 7)).Merge
        Range(planconsol.Cells(Row, 3), planconsol.Cells(Row + Min, 3)).Merge
        Range(planconsol.Cells(Row, 9), planconsol.Cells(Row + Min, 9)).Merge
        Range(planconsol.Cells(Row, 10), planconsol.Cells(Row + Min, 10)).Merge
        Range(planconsol.Cells(Row, 11), planconsol.Cells(Row + Min, 11)).Merge
        Range(planconsol.Cells(Row, 12), planconsol.Cells(Row + Min, 12)).Merge
        Range(planconsol.Cells(Row, 13), planconsol.Cells(Row + Min, 13)).Merge
        Min = Min + 1
        Else
    End If
    Loop Until planconsol.Cells(Row, 1).Value <> planconsol.Cells(Row + Min, 1)
Next Row

Application.DisplayAlerts = True

planconsol.Cells(I + 1, 1).Value = ""
'MERGOWANIE PODOBNYCH KOMOREK
'
'
'
'
'AUTOMATYCZNE ROZSZERZANIE KOLUMN I WYSRODKOWANIE
    Columns("A:M").EntireColumn.AutoFit
    Columns("A:M").Select
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
Range("A1:M1").Select
Selection.AutoFilter

ile = Application.WorksheetFunction.CountA(Range("E:E"))
Range(Cells(1, 1), Cells(ile, 15)).Value = Range(Cells(1, 1), Cells(ile, 15)).Value


Range("G2:G2000").ClearContents

For Each cl In Range("G2:G2000")
    If cl.Offset(0, -1) <> "" Then
        cl.Value = cl.Offset(0, -6) & Format(Date, "yy") & DatePart("y", Date) & Format(Now, "HHMM")
    
    End If
Next cl

For Each cl In Range("J2:J2000")
cl.Value = Format(cl, "dd.mm.yyyy")
Next cl

For Each cl In Range("L2:L2000")
cl.Value = Format(cl, "dd.mm.yyyy")
Next cl

Range("A1").Select


End Sub




