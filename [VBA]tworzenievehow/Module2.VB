Sub Create_New()

Application.Workbooks("Spliter v38.3 04.01.2016.xlsm").Activate

Dim lastline
Dim datka88
Dim nazewka
nazewka = "\spliter"
datka88 = Format$(Sheet2.Range("C3"), ("yyyy-mm-dd"))

'Application.Workbooks("Spliter v38.3 04.01.2016.xlsm").Activate

Application.Calculation = xlCalculationManual
    
    lastline = Sheets("Plan Orders").Cells(4, 2).End(xlDown).Row
    
    Range(Sheets("Plan Orders").Cells(1, 1), Sheets("Plan Orders").Cells(lastline, 59)).Copy
    
    Workbooks.Add.Activate
        Selection.PasteSpecial Paste:=xlPasteValues, Operation:=xlNone, SkipBlanks _
                :=False, Transpose:=False
        Selection.PasteSpecial Paste:=xlPasteFormats, Operation:=xlNone, _
                SkipBlanks:=False, Transpose:=False

Application.Calculation = xlCalculationAutomatic

If MsgBox("Start automatic save system?", vbYesNo) = vbYes Then

    If Dir(("url" & " " & datka88 & "\spliter.csv")) = "" Then
        If Len(Dir("url" & " " & Format$(Sheet2.Range("C3"), ("yyyy-mm-dd")) & "\", vbDirectory)) = 1 Then
            ActiveWorkbook.SaveAs Filename:="url" & " " & datka88 & nazewka, FileFormat:=xlCSVWindows, Local:=True
            ActiveWorkbook.Close savechanges = True
    
            AppActivate "some name"
            Application.Wait (Now() + TimeValue("00:00:01"))
            Application.SendKeys "{F12}"
            
            Exit Sub

        Else
            ActiveWorkbook.Application.WindowState = xlMaximized
            Exit Sub
        End If
        
    Else
        Dim diefrage
        Application.DisplayAlerts = False
        diefrage = MsgBox("Overwrite old spliter file?", vbYesNo, "Question is?")
        
        
            If diefrage = vbYes Then
            ActiveWorkbook.SaveAs Filename:="url" & " " & datka88 & nazewka, FileFormat:=xlCSVWindows, Local:=True
            ActiveWorkbook.Close savechanges = True
            AppActivate "some name"
            Application.Wait (Now() + TimeValue("00:00:01"))
            Application.SendKeys "{F12}"
    
            Exit Sub
            End If
        
            If diefrage = vbNo Then
            ActiveWorkbook.Application.WindowState = xlMaximized
             Exit Sub
             End If
    End If
        Else
        ActiveWorkbook.Application.WindowState = xlMaximized
        End If


End Sub

