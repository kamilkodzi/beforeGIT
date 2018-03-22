Sub Rectangle1_Click()

Application.ScreenUpdating = False
For Each cl In Sheet1.Range("B2:KY600")

    cl.Value = cl.Value

Next cl

Application.ScreenUpdating = True

End Sub
