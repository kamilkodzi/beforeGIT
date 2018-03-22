Sub dodawaniekomentow()

Application.Calculation = xlCalculationManual
Application.ScreenUpdating = False


On Error Resume Next
Sheet2.Range("W:W").SpecialCells(xlCellTypeComments).Select
Selection.ClearComments
Sheet2.Range("Y:Y").SpecialCells(xlCellTypeComments).Select
Selection.ClearComments
Sheet2.Range("CC11:CI802").ClearContents
On Error GoTo 0

'For Each cl In Sheet1.Range("O2:U10000")
'If cl <> "" Then cl.Value = cl.Value
'Next cl

Dim tw1 As Date
Dim tw2 As Date
Dim tw3 As Date
Dim tw4 As Date
Dim tw5 As Date
Dim tw6 As Date
Dim tw7 As Date


For x = 11 To 801


tw1 = 0
tw2 = 0
tw3 = 0
tw4 = 0
tw5 = 0
tw6 = 0
tw7 = 0


koment = ""
tw1check = 1
tw2check = 1
tw3check = 1
tw4check = 1
tw5check = 1
tw6check = 1
tw7check = 1
poledaty = Sheet2.Cells(x, 23)
numerwozu = Sheet2.Cells(x, 24)
iledniodjac = Sheet2.Cells(x, 57)
If poledaty = "" Or numerwozu = "" Then GoTo pustka

    For y = 2 To 5000
    NumerVeha = Sheet1.Cells(y, 6)
    
    If NumerVeha <> numerwozu Then GoTo inneauto

    If NumerVeha = "" And Sheet1.Cells(y, 2) = "" Then Exit For
    
    If Sheet1.Cells(y, 20) <> "" Then tw1 = Sheet1.Cells(y, 20)
        tw1 = tw1 - iledniodjac
    If Sheet1.Cells(y, 20) = "" Then
    tw1check = tw1check * 0
        Else
    tw1check = tw1check * 1
    End If
    
    If Sheet1.Cells(y, 21) <> "" Then tw2 = Sheet1.Cells(y, 21)
    tw2 = tw2 - iledniodjac
    If Sheet1.Cells(y, 21) = "" Then
    tw2check = tw2check * 0
        Else
    tw2check = tw2check * 1
    End If
    
        If Sheet1.Cells(y, 22) <> "" Then tw3 = Sheet1.Cells(y, 22)
        tw3 = tw3 - iledniodjac
    If Sheet1.Cells(y, 22) = "" Then
    tw3check = tw3check * 0
        Else
    tw3check = tw3check * 1
    End If
    
        If Sheet1.Cells(y, 23) <> "" Then tw4 = Sheet1.Cells(y, 23)
        tw4 = tw4 - iledniodjac
    If Sheet1.Cells(y, 23) = "" Then
    tw4check = tw4check * 0
        Else
    tw4check = tw4check * 1
    End If
    
        If Sheet1.Cells(y, 24) <> "" Then tw5 = Sheet1.Cells(y, 24)
        tw5 = tw5 - iledniodjac
    If Sheet1.Cells(y, 24) = "" Then
    tw5check = tw5check * 0
        Else
    tw5check = tw5check * 1
    End If
    
        If Sheet1.Cells(y, 25) <> "" Then tw6 = Sheet1.Cells(y, 25)
        tw6 = tw6 - iledniodjac
    If Sheet1.Cells(y, 25) = "" Then
    tw6check = tw6check * 0
        Else
    tw6check = tw6check * 1
    End If
    
        If Sheet1.Cells(y, 26) <> "" Then tw7 = Sheet1.Cells(y, 26)
        tw7 = tw7 - iledniodjac
    If Sheet1.Cells(y, 26) = "" Then
    tw7check = tw7check * 0
        Else
    tw7check = tw7check * 1
    End If
    
inneauto:
    Next y
    

If Left(numerwozu, 2) = "PL" And Sheet2.Range("D2") = False And (tw1check + tw2check + tw3check + tw4check + tw5check + tw6check + tw7check) - 1 > 0 Then

If Weekday(tw1, vbMonday) = 6 Then tw1check = 0
If Weekday(tw2, vbMonday) = 6 Then tw2check = 0
If Weekday(tw3, vbMonday) = 6 Then tw3check = 0
If Weekday(tw4, vbMonday) = 6 Then tw4check = 0
If Weekday(tw5, vbMonday) = 6 Then tw5check = 0
If Weekday(tw6, vbMonday) = 6 Then tw6check = 0
If Weekday(tw7, vbMonday) = 6 Then tw7check = 0

End If




If tw1check = 1 And (tw1 = Sheet2.Range("W1") Or tw1 = Sheet2.Range("AC1") Or tw1 = Sheet2.Range("AI1") Or tw1 = Sheet2.Range("W5") Or tw1 = Sheet2.Range("AC5") Or tw1 = Sheet2.Range("AI5")) Then

koment = koment & Left(tw1, 2) & " | "
Sheet2.Cells(x, 81) = tw1
End If

If tw2check = 1 And (tw2 = Sheet2.Range("W1") Or tw2 = Sheet2.Range("AC1") Or tw2 = Sheet2.Range("AI1") Or tw2 = Sheet2.Range("W5") Or tw2 = Sheet2.Range("AC5") Or tw2 = Sheet2.Range("AI5")) Then
koment = koment & Left(tw2, 2) & " | "
Sheet2.Cells(x, 82) = tw2
End If

If tw3check = 1 And (tw3 = Sheet2.Range("W1") Or tw3 = Sheet2.Range("AC1") Or tw3 = Sheet2.Range("AI1") Or tw3 = Sheet2.Range("W5") Or tw3 = Sheet2.Range("AC5") Or tw3 = Sheet2.Range("AI5")) Then
koment = koment & Left(tw3, 2) & " | "
Sheet2.Cells(x, 83) = tw3
End If

If tw4check = 1 And (tw4 = Sheet2.Range("W1") Or tw4 = Sheet2.Range("AC1") Or tw4 = Sheet2.Range("AI1") Or tw4 = Sheet2.Range("W5") Or tw4 = Sheet2.Range("AC5") Or tw4 = Sheet2.Range("AI5")) Then
koment = koment & Left(tw4, 2) & " | "
Sheet2.Cells(x, 84) = tw4
End If

If tw5check = 1 And (tw5 = Sheet2.Range("W1") Or tw5 = Sheet2.Range("AC1") Or tw5 = Sheet2.Range("AI1") Or tw5 = Sheet2.Range("W5") Or tw5 = Sheet2.Range("AC5") Or tw5 = Sheet2.Range("AI5")) Then
koment = koment & Left(tw5, 2) & " | "
Sheet2.Cells(x, 85) = tw5
End If

If tw6check = 1 And (tw6 = Sheet2.Range("W1") Or tw6 = Sheet2.Range("AC1") Or tw6 = Sheet2.Range("AI1") Or tw6 = Sheet2.Range("W5") Or tw6 = Sheet2.Range("AC5") Or tw6 = Sheet2.Range("AI5")) Then
koment = koment & Left(tw6, 2) & " | "
Sheet2.Cells(x, 86) = tw6
End If

If tw7check = 1 And (tw7 = Sheet2.Range("W1") Or tw7 = Sheet2.Range("AC1") Or tw7 = Sheet2.Range("AI1") Or tw7 = Sheet2.Range("W5") Or tw7 = Sheet2.Range("AC5") Or tw7 = Sheet2.Range("AI5")) Then
koment = koment & Left(tw7, 2) & " | "
Sheet2.Cells(x, 87) = tw7
End If

Sheet2.Cells(x, 23).AddComment
    Sheet2.Cells(x, 23).Comment.Text Text:=koment

If Sheet2.Cells(x, 101) <> 0 Or Sheet2.Cells(x, 102) <> 0 Then

ileczego = ""
ileczego = (Sheet2.Cells(x, 101) + Sheet2.Cells(x, 102))
Sheet2.Cells(x, 25).AddComment
    Sheet2.Cells(x, 25).Comment.Text Text:="DC3: " & ileczego
    
End If
   
pustka:
Next x

Application.Calculation = xlCalculationAutomatic
Application.ScreenUpdating = True
End Sub

