Sub zmieniarka()
    

    
'sprawdzamy czy mozemy odpalic zmieniarke
If Sheet2.Range("AF3") = "" Then
    MsgBox ("Nie wklejono nowego harmonogramu")
    Exit Sub
End If

If Sheet2.Cells(2, 10) <> "Mo" And Sheet2.Cells(2, 28) <> "Mo" Then
    MsgBox ("Przesuniete kolumny lub skasowane- nie mozena uruchomic zmieniarki okien")
    Exit Sub
End If

For Each cl In Sheet2.Range("AG3:AM1036")
    If cl <> 1 And cl <> Empty Then
        MsgBox ("Do zmieniarki moga trafic tylko 1 (jedynki) lub puste pola")
        Exit Sub
End If
Next cl

 
    
    
    
'sprawdzamy czy mozemy odpalic zmieniarke

Application.ScreenUpdating = False
Application.Calculation = xlCalculationManual

    
    For Each cl In Sheet2.Range("AF3:AF1036")
        If cl <> Empty Then
        
            nowyMO = cl.Offset(0, 1).Value
                If nowyMO = Empty Then nowyMO = ""
                
            nowyTue = cl.Offset(0, 2).Value
                If nowyTue = Empty Then nowyTue = ""
                
            nowyWe = cl.Offset(0, 3).Value
                If nowyWe = Empty Then nowyWe = ""
                
            nowyThu = cl.Offset(0, 4).Value
                If nowyThu = Empty Then nowyThu = ""
                
            nowyFri = cl.Offset(0, 5).Value
                If nowyFri = Empty Then nowyFri = ""
            
            
            
            nowySa = cl.Offset(0, 6).Value
                If nowySa = Empty Then nowySa = ""
                
            nowySu = cl.Offset(0, 7).Value
                If nowySu = Empty Then nowySu = ""
            
            
                For Each cl2 In Sheet2.Range("B3:B1036")
                    
                    If cl2 <> Empty And cl2 = cl Then
                        'nowe dni dostawy
                        cl2.Offset(0, 8) = nowyMO
                        cl2.Offset(0, 9) = nowyTue
                        cl2.Offset(0, 10) = nowyWe
                        cl2.Offset(0, 11) = nowyThu
                        cl2.Offset(0, 12) = nowyFri
                    
                        cl2.Offset(0, 13) = nowySa
                        cl2.Offset(0, 14) = nowySu
                    
                        'usuwanie dni dostawy
                        nowyMO = Empty
                        nowyTue = Empty
                        nowyWe = Empty
                        nowyThu = Empty
                        nowyFri = Empty
                        
                        nowySa = Empty
                        nowySu = Empty
                    
                        Exit For
                    End If
                
                Next cl2
        End If
    Next cl
    
Application.ScreenUpdating = True
Application.Calculation = xlCalculationAutomatic



End Sub

