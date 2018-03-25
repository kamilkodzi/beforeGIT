Sub RoundedRectangle12_Click()

Application.Calculation = xlCalculationSemiautomatic
Application.ScreenUpdating = False

Dim dataplaned As Range
Dim datainplan As Range
Dim komentplaned As Range
Dim komentinplan As Range
Dim vehinplan As Range

If Sheet2.Range("V2") = 0 Then

    MsgBox ("Otworzyles nowego TICB Plan Makera. Opcja restorera jest niedostepna")
    
    Else
        Call zwracacz
        For x = 11 To 801
            vehplaned = Sheet2.Cells(x, 54)
            If vehplaned <> "" Then
                For y = 11 To 801
                    Set vehinplan = Sheet2.Cells(y, 24)
                    If vehplaned = vehinplan Then
                    
                        Set dataplaned = Sheet2.Cells(x, 53)
                        Set datainplan = Sheet2.Cells(y, 23)
                        
                        Set komentplaned = Sheet2.Cells(x, 55)
                        Set komentinplan = Sheet2.Cells(y, 30)
                    
                        If dataplaned = "" Then
                        Exit For
                        End If

                        datainplan.Value = dataplaned.Value
                        komentinplan.Value = komentplaned.Value
                        
                       Sheet2.Cells(y, 23).Font.Bold = True
                       Sheet2.Cells(y, 23).Font.Strikethrough = True
                       
                       Exit For
                    End If
                Next y
            End If
        Next x
    
    End If
    
Application.Calculation = xlCalculationAutomatic
Application.ScreenUpdating = True
    
    
    
End Sub
