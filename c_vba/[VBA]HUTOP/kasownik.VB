Sub kasownik()

'koniec przyspieszacza'
'Application.ScreenUpdating = False
'Application.Calculation = xlCalculationManual
'koniec przyszpieszacza'


wylacznik = 0

For x = 1 To 300
 
    If Sheet24.Cells(x, 2) = Empty Then
        Sheet24.Cells(x, 2).EntireRow.Delete
        x = x - 1
        wylacznik = wylacznik + 1
    End If
    
    
If wylacznik > 150 Then Exit For

Next x

'przyspieszacza'
'Application.ScreenUpdating = True
'Application.Calculation = xlCalculationAutomatic
'koniec przyszpieszacza'


End Sub
