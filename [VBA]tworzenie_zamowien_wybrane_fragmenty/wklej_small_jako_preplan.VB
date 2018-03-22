Sub przemiana()
'Przyspieszacz'
Application.ScreenUpdating = False
Application.Calculation = xlCalculationManual
'przyspieszacz'

wunderlista = Sheet23.Range("AH3:AH79")
For x = 42 To 79

    auto = Sheet23.Cells(x, 1)
    str1 = Sheet23.Cells(x, 2)
    str2 = Sheet23.Cells(x, 3)
    str3 = Sheet23.Cells(x, 4)

        If auto <> "" Then
            
            'Szukanie auta
            For y = 3 To 79
            wunderauto = Sheet23.Cells(y, 34)
            numerveh = Sheet23.Cells(y, 36)
                    If wunderauto <> "" Then
                        If wunderauto = auto Then
                            Sheet23.Cells(y, 34).Select
                            ActiveCell.Offset(0, -1).Select
                                If ActiveCell = "" Then
                                    ActiveCell.Value = "in_use"
                                    'Teraz makro znalazlo samochod dla depo i rezerwuje auto
                                    'kolejne kroki to wpisanie traka, ordersa i kolejnosci dla
                                    'kolejnych ordersow
                                    Sheet23.Range("AM79").End(xlUp).Offset(1, 0) = numerveh
                                    Sheet23.Range("AN79").End(xlUp).Offset(1, 0) = str1
                                    Sheet23.Range("AO79").End(xlUp).Offset(1, 0) = 1
                                    
                                        If str2 <> "" Then
                                        Sheet23.Range("AM79").End(xlUp).Offset(1, 0) = numerveh
                                        Sheet23.Range("AN79").End(xlUp).Offset(1, 0) = str2
                                        Sheet23.Range("AO79").End(xlUp).Offset(1, 0) = 2
                                        Else
                                        End If
                                        
                                        If str3 <> "" Then
                                        Sheet23.Range("AM79").End(xlUp).Offset(1, 0) = numerveh
                                        Sheet23.Range("AN79").End(xlUp).Offset(1, 0) = str3
                                        Sheet23.Range("AO79").End(xlUp).Offset(1, 0) = 3
                                        Else
                                        End If
                                
                                
                                    Exit For
 
                                Else
                                End If

                            
                        Else
                        End If

                    
                    Else
                    Exit For
                    End If
                    
            Next y
                          
    
        Else
        Exit For
        End If
    
    
Next x

'koniec przyspieszacza'
Application.ScreenUpdating = True
Application.Calculation = xlCalculationAutomatic
'koniec przyszpieszacza'

Call plan_file

End Sub




