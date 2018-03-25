Sub fule()

'Przyspieszacz '
Application.ScreenUpdating = False
Application.Calculation = xlCalculationManual
'Przyspieszacz '

trailer = Sheet4.Range("W16")



For x = 5 To 800

ilosco = Sheet2.Cells(x, 3)
ordero = Sheet2.Cells(x, 17)
     
    If ilosco >= trailer Then
        Sheet23.Cells(125, 60).End(xlUp).Offset(1, 0) = ordero
    End If
    
    
Next x


For y = 3 To 125

veszka = Sheet23.Cells(y, 17)
peszka = Sheet23.Cells(y, 15)

    If veszka <> "" Then Sheet23.Cells(y, 15) = "x"
Next y

Sheet23.Range(Sheet23.Cells(125, 15).End(xlUp).Offset(5, 1), Sheet23.Cells(125, 16)).copy Sheet23.Range("BB3")


'Przyspieszacz '
Application.ScreenUpdating = True
Application.Calculation = xlCalculationAutomatic
Application.ScreenUpdating = False
Application.Calculation = xlCalculationManual
'przyspieszacz'


End Sub
