Sub przeklejaniedoinputa()

Application.Calculation = xlCalculationManual
Application.ScreenUpdating = False

Sheet7.Range("N36:N2000").ClearContents
Sheet8.Range("N30:N2000").ClearContents
For i = 2 To Sheet6.Range("L2")
        For k = 1 To Sheet6.Cells(i, 15)
            Sheet7.Range("N1000").End(xlUp).Offset(1, 0) = Sheet6.Cells(i, 2)
            Sheet8.Range("N1000").End(xlUp).Offset(1, 0) = Sheet6.Cells(i, 2)
        Next k
Next i
Application.ScreenUpdating = True
Application.Calculation = xlCalculationAutomatic
Call kopiujZakres
End Sub

' Bardzo dobry sposob w przypadku gdy mamy formuly :)
Sub kopiujZakres()
rowX = Range("A:A").Find(What:="*", LookIn:=xlValues, Lookat:=xlPart, searchorder:=xlByRows, searchdirection:=xlPrevious).Row
Range(Cells(2, 1), Cells(rowX, 16)).Copy
End Sub