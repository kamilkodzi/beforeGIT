Sub mailer()

If Sheet2.Range("W4") = "WYBIERZ MAGAZYN" Then MsgBox ("Wybierz magazyn"): Exit Sub


Call zapiser
Dim topskik As Workbook: Set topskik = ActiveWorkbook
If Sheet2.Range("E2") <> True Then GoTo bezmaila


Application.Calculation = xlCalculationManual
Application.ScreenUpdating = False

nazwafolderu = Sheet2.Range("AQ1") 'format C:\Users\Maciej\Desktop
droga = Sheet2.Range("X8")  'format Galanta 2016-05-25 27
wersja = Sheet2.Range("V2")
magazin = Sheet2.Range("W4")

    For Each ws In Sheets
        Application.DisplayAlerts = False
            If ws.Name <> "Master Plan" Then
                If ws.Name <> "OrderGrid" Then
                    If ws.Name <> "TripsGrid" Then
                        If ws.Name <> "ControlPanel" Then
                        
                        
                            nazwa = ws.Name
                            temat = ws.Name

                         
                           If Left(nazwa, 2) = "TP" Then '--------------------------------------------------------------IF (przewoznicy)
                                dlugosc = Len(Sheet2.Range("W4"))
                                symbol = Mid(temat, dlugosc + 5, 3)
                                If symbol = "F!B" And Right(temat, 2) = "ND" Then GoTo bezHuba
                                emil = Application.WorksheetFunction.VLookup(symbol, Sheet2.Range("AL11:AM801"), 2, 0)
                                If symbol = "F!B" Then temat = "Informacja dotyczaca xxx xxx-xxx"
                               
                                
                            Set OutApp = CreateObject("Outlook.Application")
                            Set OutMail = OutApp.CreateItem(0)
    
                            On Error Resume Next
                            With OutMail
                                .To = emil
                                .cc = ""
                            
                                If Right(temat, 2) <> "ND" Then
                                .Subject = temat
                                .HTMLBody = Sheet3.Range("K2")
                                .Attachments.Add droga & "\" & nazwafolderu & "\" & nazwa & ".xlsx"
                                 Else
                                .Subject = "No " & magazin & " deliveries for " & Mid(temat, 1, Len(temat) - 3)
                                .HTMLBody = "No deliveries<br>" & Sheet3.Range("K2")
                                End If
                                .Display
                            End With
                            On Error GoTo 0


                            With Application
                                .EnableEvents = True
                                .ScreenUpdating = True
                            End With
                            Set OutMail = Nothing
                            Set OutApp = Nothing

                            Else '---------------------------------------------------------------ELSE (Maile glowne )
                            
                                Set OutApp = CreateObject("Outlook.Application")
                                Set OutMail = OutApp.CreateItem(0)
    
                            On Error Resume Next
                            With OutMail
                                    
                                    Select Case magazin
                                    Case Is = "DC-2"
                                    .To = Sheet3.Range("G2")
                                    .cc = Sheet3.Range("G5")
                                    Case Is = "DC-3"
                                    .To = Sheet3.Range("H2")
                                    .cc = Sheet3.Range("H5")
                                    Case Is = "DC-X"
                                    .To = Sheet3.Range("I2")
                                    .cc = Sheet3.Range("I5")
                                    End Select
                                    
                                    
                                If Right(temat, 2) <> "ND" Then
                                .Subject = temat
                                .HTMLBody = Sheet3.Range("K2")
                                .Attachments.Add droga & "\" & nazwafolderu & "\" & nazwa & ".xlsx"
                                 Else
                                .Subject = "No " & magazin & " deliveries for " & Mid(temat, 1, Len(temat) - 3)
                                .HTMLBody = "No deliveries<br>" & Sheet3.Range("K2")
                                End If
                                .Display
                            End With
                            On Error GoTo 0


                                    With Application
                                    .EnableEvents = True
                                    .ScreenUpdating = True
                                    End With
    
                                    Set OutMail = Nothing
                                    Set OutApp = Nothing
                            End If '-------------------------------------------------------------------------------------- END IF
                        End If
                    End If
                End If
            End If
bezHuba:
    Next ws


bezmaila:
Call raporter
Call preplaner
Call przeklejacz
Application.Calculation = xlCalculationAutomatic
Application.ScreenUpdating = True
Application.DisplayAlerts = False
topskik.Activate
Sheet2.Range("W11").Select
ActiveWorkbook.Close savechanges = False
Application.Quit
End Sub

