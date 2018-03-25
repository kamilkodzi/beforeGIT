Sub zamkniecie1()

If Sheet1.Range("M12") = "ON" Then

For Each cl In Sheet1.Range("A13:A10000")
If cl <> "" Then
    For Each clz In Sheet1.Range("M15:M27")
        If cl = clz Then
            cl.Offset(1, 0).Select
            Range(cl.Offset(1, 0), cl.Offset(0, 2).End(xlDown)).Copy Range(cl.Offset(0, 0), cl.Offset(0, 0))
            cl.Offset(0, 0).End(xlDown).ClearContents
            cl.Offset(0, 1).End(xlDown).ClearContents
            cl.Offset(0, 2).End(xlDown).ClearContents
End If
Next clz
Else
Exit Sub
End If
Next cl
End If
End Sub


Sub zamkniecie2()

If Sheet1.Range("M12") = "ON" Then

For Each cl In Sheet1.Range("E13:E10000")
If cl <> "" Then
    For Each clz In Sheet1.Range("M15:M27")
        If cl = clz Then
            cl.Offset(1, 0).Select
            Range(cl.Offset(1, 0), cl.Offset(0, 2).End(xlDown)).Copy Range(cl.Offset(0, 0), cl.Offset(0, 0))
            cl.Offset(0, 0).End(xlDown).ClearContents
            cl.Offset(0, 1).End(xlDown).ClearContents
            cl.Offset(0, 2).End(xlDown).ClearContents
End If
Next clz
Else
Exit Sub
End If
Next cl
End If
End Sub


Sub zamkniecie3()

If Sheet1.Range("M12") = "ON" Then

For Each cl In Sheet1.Range("I13:I10000")
If cl <> "" Then
    For Each clz In Sheet1.Range("M15:M27")
        If cl = clz Then
            cl.Offset(1, 0).Select
            Range(cl.Offset(1, 0), cl.Offset(0, 2).End(xlDown)).Copy Range(cl.Offset(0, 0), cl.Offset(0, 0))
            cl.Offset(0, 0).End(xlDown).ClearContents
            cl.Offset(0, 1).End(xlDown).ClearContents
            cl.Offset(0, 2).End(xlDown).ClearContents
End If
Next clz
Else
Exit Sub
End If
Next cl
End If
End Sub
