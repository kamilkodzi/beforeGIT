
Sub starter()

If Application.WorksheetFunction.CountA(Sheet1.Range("A1:P100")) = 0 Or Application.WorksheetFunction.CountA(Sheet4.Range("A1:P100")) = 0 Then
    UserForm1.Show
    
    Else
    Call plan_mejker("nic")
End If


End Sub





Sub plan_mejker(co As String)
Dim magazynek As Range
Dim datarap As Range


'MsgBox ("Pamietaj o wycieciu kilku tras z CS cargo i wyslaniu ich do nowego przewoznika!")

Application.Calculation = xlCalculationManual
Application.ScreenUpdating = False
Sheet2.Range("BA11:BC801").ClearContents
For g = 11 To 800
systemno = Sheet2.Cells(g, 24)
Set datarap = Sheet2.Cells(g, 23)
    If (systemno = "" And datarap <> "") Then datarap.ClearContents
Next g



'Kasowanie sheetow wiekszych niz 4
Application.DisplayAlerts = False
    Do While Worksheets.Count > 4
        Worksheets(5).Delete
    Loop
Application.DisplayAlerts = True
'/Kasowanie sheetow wiekszych niz 4


'Czy plan skonsolidowany czy nie?
If co = "nic" Then
skonsolidowany = Sheet2.Range("W4")
Else
skonsolidowany = co
Set magazynek = Sheet2.Range("W4")
magazynek = skonsolidowany
End If


    Call planconsol
    'Call planglowny1
    'Call planglowny2
    'Call planglowny3
    'Call planglowny4
    'Call plik_wsadowy
    Call plandostawcy

    Sheet2.Activate




    
    
Application.DisplayAlerts = False
Max = Worksheets.Count
For I = 5 To Max
        Application.DisplayAlerts = False
        If Application.WorksheetFunction.CountA(Worksheets(I).Range("A2:P35")) = 0 Then Worksheets(I).Name = Worksheets(I).Name & " ND"
Next I
    
    
    
  Application.DisplayAlerts = True
    
    
    
Application.Calculation = xlCalculationAutomatic
Application.ScreenUpdating = True




'Call przeklejacz

Sheet2.Range("W11").Activate
End Sub
