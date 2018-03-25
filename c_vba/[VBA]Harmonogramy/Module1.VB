Sub zamiana()
'GY-W / HC-W
Dim aktualnakomorka As Range

Application.ScreenUpdating = False
Application.Calculation = xlCalculationManual

For x = 3 To 208
    proporcjaLE = Sheet2.Cells(x, 2)
    proporcjaW = Sheet2.Cells(x, 3)
    ktorazmiana = 1
    
    For y = 3 To 9
jeszczeraz:
        czyjakolej = ktorazmiana Mod 2
        Set aktualnakomorka = Sheet1.Cells(x, y)
            If aktualnakomorka = "" Then GoTo nastepna
            
            If Len(aktualnakomorka) = 4 Then
            'krotkiciag
                If czyjakolej = 0 Then 'parzyste
                
                    If proporcjaLE = 0 Then
                    
                        GoTo zmianaznaku
                    
                    Else
                    
                        proporcjaLE = proporcjaLE - 1
                        aktualnakomorka = Replace(aktualnakomorka, "W", "L")

                        
                    End If
                
                Else 'nieparzyste
                
                    If proporcjaW = 0 Then
                    
                        GoTo zmianaznaku
                    
                    Else
                    
                        proporcjaW = proporcjaW - 1
                        aktualnakomorka = Replace(aktualnakomorka, "L", "W")


                        
                    End If
                
                
                End If
               
               
               
            'krotkiciag
            Else
            'dlugi ciag
            
            If proporcjaLE <> 0 And proporcjaW <> 0 Then
                    
                proporcjaLE = proporcjaLE - 1
                proporcjaW = proporcjaW - 1
                aktualnakomorka = "GY-W / HC-L"
                    
                     
            Else
                    If proporcjaLE = 0 And proporcjaW = 0 Then Exit For
                    
                    If czyjakolej = 0 Then 'parzyste
                    
                    If proporcjaLE = 0 Then
                        GoTo zmianaznaku
                    
                    Else
                    
                        proporcjaLE = proporcjaLE - 1
                        aktualnakomorka = Replace(aktualnakomorka, "W", "L")
                        triger = triger + 1
                        
                    End If
                
                Else 'nieparzyste
                
                    If proporcjaW = 0 Then
                        GoTo zmianaznaku
                    
                    Else
                    
                        proporcjaW = proporcjaW - 1
                        aktualnakomorka = Replace(aktualnakomorka, "L", "W")
                        triger = triger + 1
                        

                        
                    End If
                
                
                End If
            
            
            End If
            
            
            
            
            
            
            
            
            
            End If
            
If triger > 0 Then
    If triger >= 2 Then
    triger = 0
    GoTo nastepna
    End If
        
GoTo jeszczeraz
End If
            
If 6 = 9 Then
zmianaznaku:
ktorazmiana = ktorazmiana + 1
GoTo jeszczeraz
End If

If ktorazmiana > 20 Then Exit For
ktorazmiana = ktorazmiana + 1
nastepna:




    Next y
    
       
       
Next x

Application.ScreenUpdating = True
Application.Calculation = xlCalculationAutomatic


End Sub
