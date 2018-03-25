Sub Button2_Click()

For Each cl In Range("C4:o5")
        cl.Value = Round(cl, 0)
    Next cl

For x = 3 To 15

'=X-(B6*33+B7*55+B8*38+B9*18)


    Cells(4, x) = "=" & Cells(4, x).Value & "-(" & _
    Chr(x + 64) & "6*33+" & _
    Chr(x + 64) & "7*38+" & _
    Chr(x + 64) & "8*38+" & _
    Chr(x + 64) & "9*18)"
    
Next x

End Sub
