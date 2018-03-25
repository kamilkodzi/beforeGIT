Sub mials()


Dim OutApp As Object
Dim OutMail As Object
Dim rng2 As Range
Set rng2 = Nothing
Set rng2 = Sheet1.Range("A1:O9").SpecialCells(xlCellTypeVisible)


wiadomosc = Sheet1.Range("E14")

Select Case Sheet1.Range("A1")
Case "DC2"
maileto = Sheet1.Range("A14")
mailecc = Sheet1.Range("A17")
Case "DC3"
maileto = Sheet1.Range("B14")
mailecc = Sheet1.Range("B17")
End Select

Set OutApp = CreateObject("Outlook.Application")
Set OutMail = OutApp.CreateItem(0)

                            With OutMail
                                .To = maileto
                                .cc = mailecc
                            
                      
                                .Subject = "[" & Sheet1.Range("A1") & "] Planed NDC (" & Sheet1.Range("Q1") & ")"
                                .HTMLBody = "Hi<br/>" & RangetoHTML(rng2) & "<br/>" & wiadomosc
                                .Display
                                
                            End With

End Sub

Function RangetoHTML(rng As Range)
' By Ron de Bruin.
    Dim fso As Object
    Dim ts As Object
    Dim TempFile As String
    Dim TempWB As Workbook

    TempFile = Environ$("temp") & "/" & Format(Now, "dd-mm-yy h-mm-ss") & ".htm"

    'Copy the range and create a new workbook to past the data in
    rng.Copy
    Set TempWB = Workbooks.Add(1)
    With TempWB.Sheets(1)
        .Cells(1).PasteSpecial Paste:=8
        .Cells(1).PasteSpecial xlPasteValues, , False, False
        .Cells(1).PasteSpecial xlPasteFormats, , False, False
        .Cells(1).Select
        Application.CutCopyMode = False
        On Error Resume Next
        .DrawingObjects.Visible = True
        .DrawingObjects.Delete
        On Error GoTo 0
    End With

    'Publish the sheet to a htm file
    With TempWB.PublishObjects.Add( _
         SourceType:=xlSourceRange, _
         Filename:=TempFile, _
         Sheet:=TempWB.Sheets(1).Name, _
         Source:=TempWB.Sheets(1).UsedRange.Address, _
         HtmlType:=xlHtmlStatic)
        .Publish (True)
    End With

    'Read all data from the htm file into RangetoHTML
    Set fso = CreateObject("Scripting.FileSystemObject")
    Set ts = fso.GetFile(TempFile).OpenAsTextStream(1, -2)
    RangetoHTML = ts.ReadAll
    ts.Close
    RangetoHTML = Replace(RangetoHTML, "align=center x:publishsource=", _
                          "align=left x:publishsource=")

    'Close TempWB
    TempWB.Close savechanges:=False

    'Delete the htm file we used in this function
    Kill TempFile

    Set ts = Nothing
    Set fso = Nothing
    Set TempWB = Nothing
End Function

