Type daty
 veh As String
 tw1 As Date
 tw2 As Date
 tw3 As Date
 tw4 As Date
 tw5 As Date
 tw6 As Date
 tw7 As Date
 dzien1 As Date
End Type


Sub nakoniecukladanie()
Set dzien1 = Sheet2.Range("W1")

If Sheet2.Range("AG8") <> 0 Then rzadanydzien1 = Sheet2.Range("AG8")
If Sheet2.Range("AH8") <> 0 Then rzadanydzien2 = Sheet2.Range("AH8")
If Sheet2.Range("AI8") <> 0 Then rzadanydzien3 = Sheet2.Range("AI8")
If Sheet2.Range("AJ8") <> 0 Then rzadanydzien4 = Sheet2.Range("AJ8")
If Sheet2.Range("AK8") <> 0 Then rzadanydzien5 = Sheet2.Range("AK8")
If Sheet2.Range("AL8") <> 0 Then rzadanydzien6 = Sheet2.Range("AL8")


'Wczytanie TW-------------------------------------------------
Dim tablica(11 To 801) As daty

For x = 11 To 801

    veszka = Sheet2.Cells(x, 80)

        If veszka <> "" Then
            tablica(x).veh = Sheet2.Cells(x, 80)
            
            If Sheet2.Cells(x, 81) = rzadanydzien1 Or _
               Sheet2.Cells(x, 81) = rzadanydzien2 Or _
               Sheet2.Cells(x, 81) = rzadanydzien3 Or _
               Sheet2.Cells(x, 81) = rzadanydzien4 Or _
               Sheet2.Cells(x, 81) = rzadanydzien5 Or _
               Sheet2.Cells(x, 81) = rzadanydzien6 _
            Then tablica(x).tw1 = Sheet2.Cells(x, 81)
            Else
            tablica(x).tw1 = Empty
            End If
            
            
            If Sheet2.Cells(x, 82) = rzadanydzien1 Or _
               Sheet2.Cells(x, 82) = rzadanydzien2 Or _
               Sheet2.Cells(x, 82) = rzadanydzien3 Or _
               Sheet2.Cells(x, 82) = rzadanydzien4 Or _
               Sheet2.Cells(x, 82) = rzadanydzien5 Or _
               Sheet2.Cells(x, 82) = rzadanydzien6 _
            Then
            tablica(x).tw2 = Sheet2.Cells(x, 82)
            Else
            tablica(x).tw2 = Empty
            End If
            
            
            If Sheet2.Cells(x, 83) = rzadanydzien1 Or _
               Sheet2.Cells(x, 83) = rzadanydzien2 Or _
               Sheet2.Cells(x, 83) = rzadanydzien3 Or _
               Sheet2.Cells(x, 83) = rzadanydzien4 Or _
               Sheet2.Cells(x, 83) = rzadanydzien5 Or _
               Sheet2.Cells(x, 83) = rzadanydzien6 _
            Then
            tablica(x).tw3 = Sheet2.Cells(x, 83)
            Else
            tablica(x).tw3 = Empty
            End If
            
            
            If Sheet2.Cells(x, 84) = rzadanydzien1 Or _
               Sheet2.Cells(x, 84) = rzadanydzien2 Or _
               Sheet2.Cells(x, 84) = rzadanydzien3 Or _
               Sheet2.Cells(x, 84) = rzadanydzien4 Or _
               Sheet2.Cells(x, 84) = rzadanydzien5 Or _
               Sheet2.Cells(x, 84) = rzadanydzien6 _
            Then
            tablica(x).tw4 = Sheet2.Cells(x, 84)
            Else
            tablica(x).tw4 = Empty
            End If
            
            
            If Sheet2.Cells(x, 85) = rzadanydzien1 Or _
               Sheet2.Cells(x, 85) = rzadanydzien2 Or _
               Sheet2.Cells(x, 85) = rzadanydzien3 Or _
               Sheet2.Cells(x, 85) = rzadanydzien4 Or _
               Sheet2.Cells(x, 85) = rzadanydzien5 Or _
               Sheet2.Cells(x, 85) = rzadanydzien6 _
            Then
            tablica(x).tw5 = Sheet2.Cells(x, 85)
            Else
            tablica(x).tw5 = Empty
            End If
            
            
            If Sheet2.Cells(x, 86) = rzadanydzien1 Or _
               Sheet2.Cells(x, 86) = rzadanydzien2 Or _
               Sheet2.Cells(x, 86) = rzadanydzien3 Or _
               Sheet2.Cells(x, 86) = rzadanydzien4 Or _
               Sheet2.Cells(x, 86) = rzadanydzien5 Or _
               Sheet2.Cells(x, 86) = rzadanydzien6 _
            Then
            tablica(x).tw6 = Sheet2.Cells(x, 86)
            Else
            tablica(x).tw6 = Empty
            End If
            
            
            If Sheet2.Cells(x, 87) = rzadanydzien1 Or _
               Sheet2.Cells(x, 87) = rzadanydzien2 Or _
               Sheet2.Cells(x, 87) = rzadanydzien3 Or _
               Sheet2.Cells(x, 87) = rzadanydzien4 Or _
               Sheet2.Cells(x, 87) = rzadanydzien5 Or _
               Sheet2.Cells(x, 87) = rzadanydzien6 _
            Then
            tablica(x).tw7 = Sheet2.Cells(x, 87)
            
        End If
    
Next x
'Wczytanie TW-------------------------------------------------
sredni = Sheet2.Range("AM9")

'walka z oknami
Dim dzien As Range

For x = 11 To 801


    Set dzien = Sheet2.Cells(x, 23)
    If Sheet2.Cells(x, 23).Font.Bold = True Then GoTo leave
    If dzien = "" Then GoTo leave
    If dzien.Offset(0, 20) <> "X" Then GoTo leave
    
    najlepszy = ""
    najlepszylicznik = ""
    
    'sprawdzanie czy pierwza trasa jest mniejsza niz 15 h
    'If tablica(x).tw1 = dzien1 And Sheet2.Cells(x, 89) > 1 And Sheet2.Cells(x, 90) > 0.63 Then GoTo skoktw2
    
        If tablica(x).tw1 <> Empty Then
            dzien = tablica(x).tw1
            
                If najlepszy = "" Then
                    najlepszy = dzien
                    najlepszylicznik = Sheet2.Range("AQ10")
                Else
                    If Sheet2.Range("AQ10") <= najlepszylicznik Then
                        If Sheet2.Range("AQ10") < najlepszylicznik Then
                        najlepszy = dzien
                        najlepszylicznik = Sheet2.Range("AQ10")
                            Else
                        If Application.WorksheetFunction.RandBetween(1, 2) = 2 Then
                        najlepszy = dzien
                        najlepszylicznik = Sheet2.Range("AQ10")
                        End If
                        End If
                        
                    End If
                End If
        End If

'Zacznij od tw2
skoktw2:

        If tablica(x).tw2 <> Empty Then
            dzien = tablica(x).tw2
            
                If najlepszy = "" Then
                    najlepszy = dzien
                    najlepszylicznik = Sheet2.Range("AQ10")
                Else
                    If Sheet2.Range("AQ10") <= najlepszylicznik Then
                        If Sheet2.Range("AQ10") < najlepszylicznik Then
                        najlepszy = dzien
                        najlepszylicznik = Sheet2.Range("AQ10")
                            Else
                        If Application.WorksheetFunction.RandBetween(1, 2) = 2 Then
                        najlepszy = dzien
                        najlepszylicznik = Sheet2.Range("AQ10")
                        End If
                        End If
                        
                    End If
                End If
        End If
        
        
        
        If tablica(x).tw3 <> Empty Then
            dzien = tablica(x).tw3
            
                If najlepszy = "" Then
                    najlepszy = dzien
                    najlepszylicznik = Sheet2.Range("AQ10")
                Else
                    If Sheet2.Range("AQ10") <= najlepszylicznik Then
                        If Sheet2.Range("AQ10") < najlepszylicznik Then
                        najlepszy = dzien
                        najlepszylicznik = Sheet2.Range("AQ10")
                            Else
                        If Application.WorksheetFunction.RandBetween(1, 2) = 2 Then
                        najlepszy = dzien
                        najlepszylicznik = Sheet2.Range("AQ10")
                        End If
                        End If
                        
                    End If
                End If
        End If
        
        
        
        If tablica(x).tw4 <> Empty Then
            dzien = tablica(x).tw4
            
                If najlepszy = "" Then
                    najlepszy = dzien
                    najlepszylicznik = Sheet2.Range("AQ10")
                Else
                    If Sheet2.Range("AQ10") <= najlepszylicznik Then
                        If Sheet2.Range("AQ10") < najlepszylicznik Then
                        najlepszy = dzien
                        najlepszylicznik = Sheet2.Range("AQ10")
                            Else
                        If Application.WorksheetFunction.RandBetween(1, 2) = 2 Then
                        najlepszy = dzien
                        najlepszylicznik = Sheet2.Range("AQ10")
                        End If
                        End If
                        
                    End If
                End If
        End If
        
        
        If tablica(x).tw5 <> Empty Then
            dzien = tablica(x).tw5
            
                If najlepszy = "" Then
                    najlepszy = dzien
                    najlepszylicznik = Sheet2.Range("AQ10")
                Else
                    If Sheet2.Range("AQ10") <= najlepszylicznik Then
                        If Sheet2.Range("AQ10") < najlepszylicznik Then
                        najlepszy = dzien
                        najlepszylicznik = Sheet2.Range("AQ10")
                            Else
                        If Application.WorksheetFunction.RandBetween(1, 2) = 2 Then
                        najlepszy = dzien
                        najlepszylicznik = Sheet2.Range("AQ10")
                        End If
                        End If
                        
                    End If
                End If
        End If
        
        
        
        If tablica(x).tw6 <> Empty Then
            dzien = tablica(x).tw6
            
                If najlepszy = "" Then
                    najlepszy = dzien
                    najlepszylicznik = Sheet2.Range("AQ10")
                Else
                    If Sheet2.Range("AQ10") <= najlepszylicznik Then
                        If Sheet2.Range("AQ10") < najlepszylicznik Then
                        najlepszy = dzien
                        najlepszylicznik = Sheet2.Range("AQ10")
                            Else
                        If Application.WorksheetFunction.RandBetween(1, 2) = 2 Then
                        najlepszy = dzien
                        najlepszylicznik = Sheet2.Range("AQ10")
                        End If
                        End If
                        
                    End If
                End If
        End If
        
        
        
        If tablica(x).tw7 <> Empty Then
            dzien = tablica(x).tw7
            
                If najlepszy = "" Then
                    najlepszy = dzien
                    najlepszylicznik = Sheet2.Range("AQ10")
                Else
                    If Sheet2.Range("AQ10") <= najlepszylicznik Then
                        If Sheet2.Range("AQ10") < najlepszylicznik Then
                        najlepszy = dzien
                        najlepszylicznik = Sheet2.Range("AQ10")
                            Else
                        If Application.WorksheetFunction.RandBetween(1, 2) = 2 Then
                        najlepszy = dzien
                        najlepszylicznik = Sheet2.Range("AQ10")
                        End If
                        End If
                        
                    End If
                End If
        End If
        
        
If najlepszy = "" Then najlepszy = "Error112"
dzien = najlepszy
leave:
Next x






End Sub



