Sub aktualizacja()


Dim fso As Scripting.FileSystemObject
Dim fld As Scripting.Folder
Dim f As Scripting.File
Dim sciezka As String
Dim aktualizer As Workbook: Set aktualizer = ActiveWorkbook
Dim dozamkniecia As Workbook
'Dim lastupdate As String
Set fso = New Scripting.FileSystemObject
Set fld = fso.GetFolder(ActiveWorkbook.Path)
Application.DisplayFullScreen = True


Do
For Each f In fld.Files
  
    '---------Plik pierwszy
    'If InStr(f.Path, "Delivery On Time") <> 0 Then
    '.
    '.
    'End If
   
   
   
    '---------Plik drugi
If InStr(f.Path, "Departure On Time") <> 0 Then

    Sheet3.Cells.Clear
    Set dozamkniecia = Workbooks.Open(f.Path)
    lastupdate = Mid(Range("A2"), InStr(Range("A2"), "/") - 2, 16)
    Range(Cells(5, 1), Cells(5, 23).End(xlDown)).Copy
    aktualizer.Activate
    Sheet3.Range("A1").PasteSpecial (xlPasteAll)
    Application.DisplayAlerts = False
    dozamkniecia.Close
    aktualizer.Activate
    Sheet1.Activate
    Range("M5") = lastupdate
    aktualizer.Save
    Application.DisplayAlerts = True
    
End If
Next f
  
  
Application.Wait (Now + TimeValue("0:10:00"))
Loop
End Sub
