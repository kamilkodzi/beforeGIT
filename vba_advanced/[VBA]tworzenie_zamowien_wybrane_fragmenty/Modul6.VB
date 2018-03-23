Sub w_prawo()
Application.ScreenUpdating = False

Sheet8.Range("C5") = Sheet8.Range("C5") + 1

Application.ScreenUpdating = True
End Sub

Sub w_lewo()
Application.ScreenUpdating = False

Sheet8.Range("C5") = Sheet8.Range("C5") - 1

Application.ScreenUpdating = True
End Sub

