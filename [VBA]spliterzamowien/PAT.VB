Private Sub UserForm_QueryClose(Cancel As Integer, CloseMode As Integer)
    If CloseMode = vbFormControlMenu Then
        Workbooks("Spliter v38.3 04.01.2016").Close savechanges:=False
    End If
End Sub

Private Sub CheckBox1_Change()
If CheckBox1.Value = True Then
pole2.Text = "1"
pole4.Text = "1"
pole6.Text = "1"
pole8.Text = "1"
pole10.Text = "1"
pole12.Text = "1"

pole2.Enabled = False
pole4.Enabled = False
pole6.Enabled = False
pole8.Enabled = False
pole10.Enabled = False
pole12.Enabled = False
Else
pole2.Text = ""
pole4.Text = ""
pole6.Text = ""
pole8.Text = ""
pole10.Text = ""
pole12.Text = ""

pole2.Enabled = True
pole4.Enabled = True
pole6.Enabled = True
pole8.Enabled = True
pole10.Enabled = True
pole12.Enabled = True
End If


End Sub

Private Sub CheckBox2_Click()
If CheckBox2.Value = True Then
pole1.Text = "44"
pole3.Text = "44"
pole5.Text = "44"
pole7.Text = "44"
pole9.Text = "44"
pole11.Text = "44"
Else
pole1.Text = ""
pole3.Text = ""
pole5.Text = ""
pole7.Text = ""
pole9.Text = ""
pole11.Text = ""
End If
End Sub

Private Sub CommandButton1_Click()

Application.Calculation = xlCalculationManual
    
    lastline = Sheets("Plan Orders").Cells(4, 2).End(xlDown).Row
    
    Range(Sheets("Plan Orders").Cells(1, 1), Sheets("Plan Orders").Cells(lastline, 59)).copy
    
    Workbooks.Add.Activate
        Selection.PasteSpecial paste:=xlPasteValues, Operation:=xlNone, SkipBlanks _
                :=False, Transpose:=False
        Selection.PasteSpecial paste:=xlPasteFormats, Operation:=xlNone, _
                SkipBlanks:=False, Transpose:=False

Application.Calculation = xlCalculationAutomatic
ActiveWorkbook.SaveAs FileFormat:=xlCSVWindows, Local:=True

End Sub

Private Sub Klik1_Click()

Call Create_New

End Sub

Private Sub Klik2_Click()
Sheet2.Range("C3") = Sheet2.Range("C3") - 1
Label1.Caption = Sheet2.Range("C3")
If Len(Dir("url" & " " & Format$(Sheet2.Range("C3"), ("yyyy-mm-dd")) & "\", vbDirectory)) = 1 Then
    If Len(Dir("url" & " " & Format$(Sheet2.Range("C3"), ("yyyy-mm-dd")) & "\", vbDirectory)) = 1 Then
        If Len(Dir("url" & " " & Format$(Sheet2.Range("C3"), ("yyyy-mm-dd")) & "\", vbDirectory)) = 1 Then
            If Len(Dir("url" & " " & Format$(Sheet2.Range("C3"), ("yyyy-mm-dd")) & "\", vbDirectory)) = 1 Then
            Klik4.BackColor = &H0&
            Else
            Klik4.BackColor = &H808080
             End If
             Else
             Klik4.BackColor = &H808080
        End If
        Else
        Klik4.BackColor = &H808080
    End If
    Else
    Klik4.BackColor = &H808080
End If
End Sub

Private Sub Klik3_Click()
Sheet2.Range("C3") = Sheet2.Range("C3") + 1
Label1.Caption = Sheet2.Range("C3")
If Len(Dir("url" & " " & Format$(Sheet2.Range("C3"), ("yyyy-mm-dd")) & "\", vbDirectory)) = 1 Then
    If Len(Dir("url" & " " & Format$(Sheet2.Range("C3"), ("yyyy-mm-dd")) & "\", vbDirectory)) = 1 Then
        If Len(Dir("url" & " " & Format$(Sheet2.Range("C3"), ("yyyy-mm-dd")) & "\", vbDirectory)) = 1 Then
            If Len(Dir("url" & " " & Format$(Sheet2.Range("C3"), ("yyyy-mm-dd")) & "\", vbDirectory)) = 1 Then
            Klik4.BackColor = &H0&
            Else
            Klik4.BackColor = &H808080
             End If
             Else
             Klik4.BackColor = &H808080
        End If
        Else
        Klik4.BackColor = &H808080
    End If
    Else
    Klik4.BackColor = &H808080
End If


End Sub


Private Sub Klik4_Click()
Dim odpowiedz
odpowiedz = MsgBox("You will create follow folders:" & vbNewLine & vbNewLine & "in Daily Plans:" & vbNewLine & "FF " & Format$(Sheet2.Range("C3"), ("yyyy-mm-dd")) & "   and   " & "Hopi " & Format$(Sheet2.Range("C3"), ("yyyy-mm-dd")) & vbNewLine & vbNewLine & "in Reports:" & vbNewLine & "FF " & Format$(Sheet2.Range("C3"), ("yyyy-mm-dd")) & "   and   " & "Hopi " & Format$(Sheet2.Range("C3"), ("yyyy-mm-dd")), vbYesNo + vbQuestion, "Can i go ahed ?")
If Klik4.BackColor = &H808080 Then
    If odpowiedz = vbNo Then
        Exit Sub
        Else
        End If
End If


'Folder do Daily plan FF
If Len(Dir("url" & " " & Format$(Sheet2.Range("C3"), ("yyyy-mm-dd")) & "\", vbDirectory)) = 0 Then
MkDir "C:\ORTEC\BKP_30.10.2014\SHORTREC\SHORTREC\Divisions\Herceghalom\Data\Interface\Import\Daily Plan\FF" & " " & Format$(Sheet2.Range("C3"), ("yyyy-mm-dd"))
Else
End If

'Folder do Daily plan Hopi (dokonczyc)
If Len(Dir("url" & " " & Format$(Sheet2.Range("C3"), ("yyyy-mm-dd")) & "\", vbDirectory)) = 0 Then
MkDir "url" & " " & Format$(Sheet2.Range("C3"), ("yyyy-mm-dd"))
    
Else
End If

'Folder do reports FF
If Len(Dir("url" & " " & Format$(Sheet2.Range("C3"), ("yyyy-mm-dd")) & "\", vbDirectory)) = 0 Then
MkDir "url" & " " & Format$(Sheet2.Range("C3"), ("yyyy-mm-dd"))
    
Else
End If

'Folder do reports Hopi
If Len(Dir("url" & " " & Format$(Sheet2.Range("C3"), ("yyyy-mm-dd")) & "\", vbDirectory)) = 0 Then
MkDir "url" & " " & Format$(Sheet2.Range("C3"), ("yyyy-mm-dd"))
    
Else
End If

'Jesli wszedzie zostaly zrobione foldery- przycisk zmieni kolor na czarny
If Len(Dir("url" & " " & Format$(Sheet2.Range("C3"), ("yyyy-mm-dd")) & "\", vbDirectory)) = 1 Then
    If Len(Dir("url" & " " & Format$(Sheet2.Range("C3"), ("yyyy-mm-dd")) & "\", vbDirectory)) = 1 Then
        If Len(Dir("url" & " " & Format$(Sheet2.Range("C3"), ("yyyy-mm-dd")) & "\", vbDirectory)) = 1 Then
            If Len(Dir("url" & " " & Format$(Sheet2.Range("C3"), ("yyyy-mm-dd")) & "\", vbDirectory)) = 1 Then
            Klik4.BackColor = &H0&
             End If
        End If
    End If
End If


End Sub



Private Sub pole1_Change()
If Len(pole1.Text) = 5 Then
    If Len(pole2.Text) > 0 Then
       Sheet2.Range("B5") = pole1.Text
       Sheet2.Range("c5") = pole2.Text
    Else
        Sheet2.Range("B5").Value = ""
        Sheet2.Range("c5").Value = ""
    End If
Else
    Sheet2.Range("B5").Value = ""
    Sheet2.Range("c5").Value = ""
End If

End Sub



Private Sub pole10_Change()
If Len(pole10.Text) > 0 Then
Call pole9_Change
Else
Sheet2.Range("B9").Value = ""
Sheet2.Range("c9").Value = ""
End If
End Sub

Private Sub pole11_Change()
If Len(pole11.Text) = 5 Then
    If Len(pole12.Text) > 0 Then
       Sheet2.Range("B10") = pole11.Text
       Sheet2.Range("c10") = pole12.Text
    Else
        Sheet2.Range("B10").Value = ""
        Sheet2.Range("c10").Value = ""
    End If
Else
    Sheet2.Range("B10").Value = ""
    Sheet2.Range("c10").Value = ""
End If
End Sub

Private Sub pole12_Change()
If Len(pole12.Text) > 0 Then
Call pole11_Change
Else
Sheet2.Range("B10").Value = ""
Sheet2.Range("c10").Value = ""
End If
End Sub

Private Sub pole2_Change()
If Len(pole2.Text) > 0 Then
Call pole1_Change
Else
Sheet2.Range("B5").Value = ""
Sheet2.Range("c5").Value = ""
End If
End Sub

Private Sub pole3_Change()
If Len(pole3.Text) = 5 Then
    If Len(pole4.Text) > 0 Then
       Sheet2.Range("B6") = pole3.Text
       Sheet2.Range("c6") = pole4.Text
    Else
        Sheet2.Range("B6").Value = ""
        Sheet2.Range("c6").Value = ""
    End If
Else
    Sheet2.Range("B6").Value = ""
    Sheet2.Range("c6").Value = ""
End If
End Sub

Private Sub pole4_Change()
If Len(pole4.Text) > 0 Then
Call pole3_Change
Else
Sheet2.Range("B6").Value = ""
Sheet2.Range("c6").Value = ""
End If
End Sub

Private Sub pole5_Change()
If Len(pole5.Text) = 5 Then
    If Len(pole6.Text) > 0 Then
       Sheet2.Range("B7") = pole5.Text
       Sheet2.Range("c7") = pole6.Text
    Else
        Sheet2.Range("B7").Value = ""
        Sheet2.Range("c7").Value = ""
    End If
Else
    Sheet2.Range("B7").Value = ""
    Sheet2.Range("c7").Value = ""
End If
End Sub

Private Sub pole6_Change()
If Len(pole6.Text) > 0 Then
Call pole5_Change
Else
Sheet2.Range("B7").Value = ""
Sheet2.Range("c7").Value = ""
End If
End Sub

Private Sub pole7_Change()
If Len(pole7.Text) = 5 Then
    If Len(pole8.Text) > 0 Then
       Sheet2.Range("B8") = pole7.Text
       Sheet2.Range("c8") = pole8.Text
    Else
        Sheet2.Range("B8").Value = ""
        Sheet2.Range("c8").Value = ""
    End If
Else
    Sheet2.Range("B8").Value = ""
    Sheet2.Range("c8").Value = ""
End If
End Sub

Private Sub pole8_Change()
If Len(pole8.Text) > 0 Then
Call pole7_Change
Else
Sheet2.Range("B8").Value = ""
Sheet2.Range("c8").Value = ""
End If
End Sub

Private Sub pole9_Change()
If Len(pole9.Text) = 5 Then
    If Len(pole10.Text) > 0 Then
       Sheet2.Range("B9") = pole9.Text
       Sheet2.Range("c9") = pole10.Text
    Else
        Sheet2.Range("B9").Value = ""
        Sheet2.Range("c9").Value = ""
    End If
Else
    Sheet2.Range("B9").Value = ""
    Sheet2.Range("c9").Value = ""
End If
End Sub



Private Sub UserForm_Initialize()
Label1.Caption = Sheet2.Range("C3")
If Len(Dir("url" & " " & Format$(Sheet2.Range("C3"), ("yyyy-mm-dd")) & "\", vbDirectory)) = 0 Then
Klik4.BackColor = &H808080
Else
Klik4.BackColor = &H0&
End If
End Sub

