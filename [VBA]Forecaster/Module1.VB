Sub mailer()

odbiorca = Application.WorksheetFunction.VLookup(Sheet1.Range("F10") & Sheet1.Range("G10"), Sheet1.Range("A32:C37"), 3, 0)
temat = ""
'Sheet1.Range("10") & " " & Sheet1.Range("F10") & Sheet1.Range("G10")
tresc = ""


'temat
For x = 15 To 24

    For y = 1 To 11
    kratkapoziom = Sheet1.Cells(x, y)
    If kratkapoziom <> "" Then tresc = tresc & " " & kratkapoziom
    Next y
    tresc = tresc & "<br>"
Next x

'tresc
For x = 15 To 29

    For y = 1 To 11
    kratkapoziom = Sheet1.Cells(x, y)
    If kratkapoziom <> "" Then tresc = tresc & " " & kratkapoziom
    Next y
    tresc = tresc & "<br>"
Next x




                            Set OutApp = CreateObject("Outlook.Application")
                            Set OutMail = OutApp.CreateItem(0)

                            With OutMail
     
                            .To = odbiorca
                            .cc = ""
                            .Subject = temat
                            .HTMLBody = tresc
                            '.Attachments.Add
                            .Display
                            
                            End With
    

End Sub


