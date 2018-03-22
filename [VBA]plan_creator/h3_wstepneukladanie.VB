Sub ostatecznieukladanie()

Application.Calculation = xlCalculationAutomatic
Application.ScreenUpdating = True

Dim wartoscPL1 As Range
Dim wartoscPL2 As Range
Dim wartoscPL3 As Range
Dim wartoscPL4 As Range
Dim wartoscPL5 As Range
Dim wartoscPL6 As Range

Dim wartoscCZ1 As Range
Dim wartoscCZ2 As Range
Dim wartoscCZ3 As Range
Dim wartoscCZ4 As Range
Dim wartoscCZ5 As Range
Dim wartoscCZ6 As Range

Dim wartoscSK1 As Range
Dim wartoscSK2 As Range
Dim wartoscSK3 As Range
Dim wartoscSK4 As Range
Dim wartoscSK5 As Range
Dim wartoscSK6 As Range

Dim wartoscHU1 As Range
Dim wartoscHU2 As Range
Dim wartoscHU3 As Range
Dim wartoscHU4 As Range
Dim wartoscHU5 As Range
Dim wartoscHU6 As Range

'Po ustawianiu obiektow dynamicznych



Set wartoscPL1 = Sheet2.Range("X3")
Set wartoscPL2 = Sheet2.Range("AD3")
Set wartoscPL3 = Sheet2.Range("AJ3")
Set wartoscPL4 = Sheet2.Range("X7")
Set wartoscPL5 = Sheet2.Range("AD7")
Set wartoscPL6 = Sheet2.Range("AJ7")

Set wartoscCZ1 = Sheet2.Range("Y3")
Set wartoscCZ2 = Sheet2.Range("AE3")
Set wartoscCZ3 = Sheet2.Range("AK3")
Set wartoscCZ4 = Sheet2.Range("Y7")
Set wartoscCZ5 = Sheet2.Range("AE7")
Set wartoscCZ6 = Sheet2.Range("AK7")

Set wartoscSK1 = Sheet2.Range("Z3")
Set wartoscSK2 = Sheet2.Range("AF3")
Set wartoscSK3 = Sheet2.Range("AL3")
Set wartoscSK4 = Sheet2.Range("Z7")
Set wartoscSK5 = Sheet2.Range("AF7")
Set wartoscSK6 = Sheet2.Range("AL7")

Set wartoscHU1 = Sheet2.Range("AA3")
Set wartoscHU2 = Sheet2.Range("AG3")
Set wartoscHU3 = Sheet2.Range("AM3")
Set wartoscHU4 = Sheet2.Range("AA7")
Set wartoscHU5 = Sheet2.Range("AG7")
Set wartoscHU6 = Sheet2.Range("AM7")

Dim staradata As Date

slot1 = 1
slot2 = 1
slot3 = 1
slot4 = 1
slot5 = 1
slot6 = 1

If Sheet2.Range("W1") = "" Then slot1 = 0
If Sheet2.Range("AC1") = "" Then slot2 = 0
If Sheet2.Range("AI1") = "" Then slot3 = 0
If Sheet2.Range("W5") = "" Then slot4 = 0
If Sheet2.Range("AC5") = "" Then slot5 = 0
If Sheet2.Range("AI5") = "" Then slot6 = 0

srednia1 = (wartoscPL1 + wartoscPL2 + watoscPL3 + wartoscPL4 + wartoscPL5 + watroscPL6) / (slot1 + slot2 + slot3 + slot4 + slot5 + slot6)
srednia2 = (wartoscCZ1 + wartoscCZ2 + watoscCZ3 + wartoscCZ4 + wartoscCZ5 + watroscCZ6) / (slot1 + slot2 + slot3 + slot4 + slot5 + slot6)
srednia3 = (wartoscSK1 + wartoscSK2 + watoscSK3 + wartoscSK4 + wartoscSK5 + watroscSK6) / (slot1 + slot2 + slot3 + slot4 + slot5 + slot6)
srednia4 = (wartoscHU1 + wartoscHU2 + watoscHU3 + wartoscHU4 + wartoscHU5 + watroscHU6) / (slot1 + slot2 + slot3 + slot4 + slot5 + slot6)




For Z = 11 To 801
    If Sheet2.Cells(Z, 23).Font.Bold = True Then GoTo puste
    If Sheet2.Cells(Z, 24) = "" Then
        GoTo puste
    Else
     Select Case Left(Sheet2.Cells(Z, 24), 2)
    Case Is = "PL" 'POLSKA ASDASDASD----------------------------
        For g = 81 To 87
            staradata = Empty
            starywzor = Empty
            starawartosc = Empty
            wzor = Empty
            
            If Sheet2.Cells(Z, g) <> "" Then
                staradata = Sheet2.Cells(Z, 23)
                
                starywzor = Abs(wartoscPL1 - srednia1) ^ 2 * slot1 + Abs(wartoscPL2 - srednia1) ^ 2 * slot2 + Abs(wartoscPL3 - srednia1) ^ 2 * slot3 + Abs(wartoscPL4 - srednia1) ^ 2 * slot4 + Abs(wartoscPL5 - srednia1) ^ 2 * slot5 + Abs(wartoscPL6 - srednia1) ^ 2 * slot6
                starawartosc = starywzor
                Sheet2.Cells(Z, 23) = Sheet2.Cells(Z, g)
                wzor = Abs(wartoscPL1 - srednia1) ^ 2 * slot1 + Abs(wartoscPL2 - srednia1) ^ 2 * slot2 + Abs(wartoscPL3 - srednia1) ^ 2 * slot3 + Abs(wartoscPL4 - srednia1) ^ 2 * slot4 + Abs(wartoscPL5 - srednia1) ^ 2 * slot5 + Abs(wartoscPL6 - srednia1) ^ 2 * slot6
                If starawartosc <= wzor Then Sheet2.Cells(Z, 23) = staradata
        
            End If
        Next g
     
     

     Case Is = "CZ" 'CZECHY SDASDASDASD-----------------------------
             For g = 81 To 87
            staradata = Empty
            starywzor = Empty
            starawartosc = Empty
            wzor = Empty
            
            If Sheet2.Cells(Z, g) <> "" Then
                staradata = Sheet2.Cells(Z, 23)
                
                starywzor = Abs(wartoscCZ1 - srednia2) ^ 2 * slot1 + Abs(wartoscCZ2 - srednia2) ^ 2 * slot2 + Abs(wartoscCZ3 - srednia2) ^ 2 * slot3 + Abs(wartoscCZ4 - srednia2) ^ 2 * slot4 + Abs(wartoscCZ5 - srednia2) ^ 2 * slot5 + Abs(wartoscCZ6 - srednia2) ^ 2 * slot6
                starawartosc = starywzor
                Sheet2.Cells(Z, 23) = Sheet2.Cells(Z, g)
                wzor = Abs(wartoscCZ1 - srednia2) ^ 2 * slot1 + Abs(wartoscCZ2 - srednia2) ^ 2 * slot2 + Abs(wartoscCZ3 - srednia2) ^ 2 * slot3 + Abs(wartoscCZ4 - srednia2) ^ 2 * slot4 + Abs(wartoscCZ5 - srednia2) ^ 2 * slot5 + Abs(wartoscCZ6 - srednia2) ^ 2 * slot6
                If starawartosc <= wzor Then Sheet2.Cells(Z, 23) = staradata
        
            End If
        Next g
     
     
     Case Is = "SK"
                  For g = 81 To 87
            staradata = Empty
            starywzor = Empty
            wzor = Empty
            starawartosc = Empty
            starawartosc = starywzor
            
            If Sheet2.Cells(Z, g) <> "" Then
                staradata = Sheet2.Cells(Z, 23)
                
                starywzor = Abs(wartoscSK1 - srednia3) ^ 2 * slot1 + Abs(wartoscSK2 - srednia3) ^ 2 * slot2 + Abs(wartoscSK3 - srednia3) ^ 2 * slot3 + Abs(wartoscSK4 - srednia3) ^ 2 * slot4 + Abs(wartoscSK5 - srednia3) ^ 2 * slot5 + Abs(wartoscSK6 - srednia3) ^ 2 * slot6
                starawartosc = starywzor
                Sheet2.Cells(Z, 23) = Sheet2.Cells(Z, g)
                wzor = Abs(wartoscSK1 - srednia3) ^ 2 * slot1 + Abs(wartoscSK2 - srednia3) ^ 2 * slot2 + Abs(wartoscSK3 - srednia3) ^ 2 * slot3 + Abs(wartoscSK4 - srednia3) ^ 2 * slot4 + Abs(wartoscSK5 - srednia3) ^ 2 * slot5 + Abs(wartoscSK6 - srednia3) ^ 2 * slot6
                If starawartosc <= wzor Then Sheet2.Cells(Z, 23) = staradata
        
            End If
        Next g
     
     
     Case Is = "HU"
                  For g = 81 To 87
            staradata = Empty
            starywzor = Empty
            wzor = Empty
            starawartosc = Empty
            starawartosc = starywzor
            
            If Sheet2.Cells(Z, g) <> "" Then
                staradata = Sheet2.Cells(Z, 23)
                
                starywzor = Abs(wartoscHU1 - srednia4) ^ 2 * slot1 + Abs(wartoscHU2 - srednia4) ^ 2 * slot2 + Abs(wartoscHU3 - srednia4) ^ 2 * slot3 + Abs(wartoscHU4 - srednia4) ^ 2 * slot4 + Abs(wartoscHU5 - srednia4) ^ 2 * slot5 + Abs(wartoscHU6 - srednia4) ^ 2 * slot6
                starawartosc = starywzor
                Sheet2.Cells(Z, 23) = Sheet2.Cells(Z, g)
                wzor = Abs(wartoscHU1 - srednia4) ^ 2 * slot1 + Abs(wartoscHU2 - srednia4) ^ 2 * slot2 + Abs(wartoscHU3 - srednia4) ^ 2 * slot3 + Abs(wartoscHU4 - srednia4) ^ 2 * slot4 + Abs(wartoscHU5 - srednia4) ^ 2 * slot5 + Abs(wartoscHU6 - srednia4) ^ 2 * slot6
                If starawartosc <= wzor Then Sheet2.Cells(Z, 23) = staradata
        
            End If
        Next g
     
     

    End Select

    End If

puste:
Next Z








End Sub

