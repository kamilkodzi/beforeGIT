Sub refresh()
w = 11
For Each cl In Sheet2.Range("W11:W801")
If cl.Offset(0, 1) = "" And cl <> "" Then
cl.Value = ""
GoTo nastepna
End If
If cl <> "" Then
If cl.Offset(0, 76) = 1 Then Sheet2.Cells(w, 23).Font.Bold = True
End If
w = w + 1
nastepna:
Next cl

Call copywindos 'zrobione
Call dodawaniekomentow 'ok


End Sub
