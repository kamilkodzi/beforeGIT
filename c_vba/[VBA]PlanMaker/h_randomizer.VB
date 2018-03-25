Sub randomizer()








If Sheet2.Range("V2") >= 1 Then

    If MsgBox("Tworzysz wersje dodatkowa. Jestes pewny, ze Date Randomizer jest niezbedny i chcesz go wlaczyc?", vbYesNo, "Turn it ON?") = vbNo Then
        Exit Sub
    Else
    
    End If
      
End If




'For x = 11 To 801
'Dim poleveh As Range
'Set poleveh = Sheet2.Cells(x, 24)
'koszty = Sheet2.Cells(x, 29)
'If koszty < 0 Then poleveh.ClearContents
'Next x

'Application.Calculation = xlCalculationManual
'Application.ScreenUpdating = False



For Each cl In Sheet2.Range("W11:W801")
    If cl <> "" And cl.Font.Bold <> True Then cl.Value = Sheet2.Range("W1")
Next cl

If Sheet2.Range("W1") <> "" Then Number = Number + 1
If Sheet2.Range("AC1") <> "" Then Number = Number + 1
If Sheet2.Range("AI1") <> "" Then Number = Number + 1

If Sheet2.Range("W5") <> "" Then Number = Number + 1
If Sheet2.Range("AC5") <> "" Then Number = Number + 1
If Sheet2.Range("AI5") <> "" Then Number = Number + 1



If Sheet2.Range("AB1") <> "SUMA / MAX" Then zmianasredniej = zmianasredniej - 1
If Sheet2.Range("AH1") <> "SUMA / MAX" Then zmianasredniej = zmianasredniej - 1
If Sheet2.Range("AN1") <> "SUMA / MAX" Then zmianasredniej = zmianasredniej - 1

If Sheet2.Range("AB5") <> "SUMA / MAX" Then zmianasredniej = zmianasredniej - 1
If Sheet2.Range("AH5") <> "SUMA / MAX" Then zmianasredniej = zmianasredniej - 1
If Sheet2.Range("AN5") <> "SUMA / MAX" Then zmianasredniej = zmianasredniej - 1



If Sheet2.Range("AB1") <> "SUMA / MAX" Then max1 = Sheet2.Range("AB1").Value
If Sheet2.Range("AH1") <> "SUMA / MAX" Then max2 = Sheet2.Range("AH1").Value
If Sheet2.Range("AN1") <> "SUMA / MAX" Then max3 = Sheet2.Range("AN1").Value

If Sheet2.Range("AB5") <> "SUMA / MAX" Then max4 = Sheet2.Range("AB5").Value
If Sheet2.Range("AH5") <> "SUMA / MAX" Then max5 = Sheet2.Range("AH5").Value
If Sheet2.Range("AN5") <> "SUMA / MAX" Then max6 = Sheet2.Range("AN5").Value


liczba1 = Sheet2.Range("AB3")
liczba2 = Sheet2.Range("AH3")
liczba3 = Sheet2.Range("AN3")
liczba4 = Sheet2.Range("AB7")
liczba5 = Sheet2.Range("AH7")
liczba6 = Sheet2.Range("AN7")




one = Sheet2.Range("W1")
two = Sheet2.Range("AC1")
tri = Sheet2.Range("AI1")
fou = Sheet2.Range("W5")
fiv = Sheet2.Range("AC5")
six = Sheet2.Range("AI5")


'westepny sort ;)
For Each cl In Sheet2.Range("W11:W801")

    If cl <> "" Then

liczba1 = Sheet2.Range("AB3")
liczba2 = Sheet2.Range("AH3")
liczba3 = Sheet2.Range("AN3")
liczba4 = Sheet2.Range("AB7")
liczba5 = Sheet2.Range("AH7")
liczba6 = Sheet2.Range("AN7")

    los = Application.WorksheetFunction.RandBetween(1, Number)


        Select Case los
        Case 1
                If cl.Font.Bold <> True Then cl.Value = one
        Case 2
                If cl.Font.Bold <> True Then cl.Value = two
        Case 3
                If cl.Font.Bold <> True Then cl.Value = tri
        Case 4
                If cl.Font.Bold <> True Then cl.Value = fou
        Case 5
                If cl.Font.Bold <> True Then cl.Value = fiv
        Case 6
                If cl.Font.Bold <> True Then cl.Value = six
        End Select
        
    End If
    
Next cl


'ukladanie
Application.Calculation = xlCalculationSemiautomatic
srednia = (liczba1 - max1 + liczba2 - max2 + liczba3 - max3 + liczba4 - max4 + liczba5 - max5 + liczba6 - max6) / (Number + zmianasredniej)


For Each cl In Sheet2.Range("W11:W801")

    If cl <> "" Then
    
powrot2:
        kontrol = kontrol + 1
        If kontrol > 1000 Then Exit For
        los = Application.WorksheetFunction.RandBetween(1, Number)

liczba1 = Sheet2.Range("AB3")
liczba2 = Sheet2.Range("AH3")
liczba3 = Sheet2.Range("AN3")
liczba4 = Sheet2.Range("AB7")
liczba5 = Sheet2.Range("AH7")
liczba6 = Sheet2.Range("AN7")

        Select Case los
        Case 1
            If max1 = Empty Then
                If liczba1 < srednia And liczba1 <> max1 Then
                    If cl.Font.Bold <> True Then cl.Value = one
                Else
                    GoTo powrot2
                End If
            Else
                If liczba1 < max1 And liczba1 <> max1 Then
                    If cl.Font.Bold <> True Then cl.Value = one
                Else
                    GoTo powrot2
                End If
            End If
        Case 2
            If max2 = Empty Then
                If liczba2 < srednia And liczba2 <> max2 Then
                    If cl.Font.Bold <> True Then cl.Value = two
                Else
                    GoTo powrot2
                End If
            Else
                If liczba2 < max2 And liczba2 <> max2 Then
                    If cl.Font.Bold <> True Then cl.Value = two
                Else
                    GoTo powrot2
                End If
            End If
        Case 3
            If max3 = Empty Then
                If liczba3 < srednia And liczba3 <> max3 Then
                    If cl.Font.Bold <> True Then cl.Value = tri
                Else
                    GoTo powrot2
                End If
            Else
                If liczba3 < max3 And liczba3 <> max3 Then
                    If cl.Font.Bold <> True Then cl.Value = tri
                Else
                    GoTo powrot2
                End If
            End If
        Case 4
            If max4 = Empty Then
                If liczba4 < srednia And liczba4 <> max4 Then
                    If cl.Font.Bold <> True Then cl.Value = fou
                Else
                    GoTo powrot2
                End If
            Else
                If liczba4 < max4 And liczba4 <> max4 Then
                    If cl.Font.Bold <> True Then cl.Value = fou
                Else
                    GoTo powrot2
                End If
            End If
        Case 5
            If max5 = Empty Then
                If liczba5 < srednia And liczba5 <> max5 Then
                    If cl.Font.Bold <> True Then cl.Value = fiv
                Else
                    GoTo powrot2
                End If
            Else
                If liczba5 < max5 And liczba5 <> max5 Then
                    If cl.Font.Bold <> True Then cl.Value = fiv
                Else
                    GoTo powrot2
                End If
            End If
        Case 6
            If max6 = Empty Then
                If liczba6 < srednia And liczba6 <> max6 Then
                    If cl.Font.Bold <> True Then cl.Value = six
                Else
                    GoTo powrot2
                End If
            Else
                If liczba6 < max6 And liczba6 <> max6 Then
                    If cl.Font.Bold <> True Then cl.Value = six
                Else
                    GoTo powrot2
                End If
            End If
        End Select
        
    End If
       
    
Next cl




Application.Calculation = xlCalculationAutomatic

Application.ScreenUpdating = True
'Call copywindos 'zrobione
'Call dodawaniekomentow 'ok
Call wstepneukladanie 'ok
Call ostatecznieukladanie 'ok
Call nakoniecukladanie 'ok
Application.Calculation = xlCalculationAutomatic
Application.EnableEvents = True
Application.ScreenUpdating = True
End Sub
