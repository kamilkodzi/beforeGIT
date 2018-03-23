Sub Button1_Click()
'
' Button1_Click Macro

Dim eldatos
On Error GoTo Buba
eldatos = Sheets("Data Verification").Range("C5")

Dim planmaker As Workbook: Set planmaker = ActiveWorkbook


' dd_mm
    Windows("GYAL INPUT " & Format$(eldatos, ("dd_mm")) & ".csv").Activate
    
    
    Range("A1", Range("P1").End(xlDown)).Select
    
    Selection.copy
    planmaker.Activate
    Cells(2, 2).Select
    ActiveSheet.paste
    
    'dd-mm
    Windows("Planning information " & Format$(eldatos, ("dd-mm")) & ".xls").Activate
    
    
    Sheets("Small Rigids").Select
    Range("B11:L33").Select
    Application.CutCopyMode = False
    Selection.copy
    planmaker.Activate
    Sheets("DepoCreator").Select
    Cells(2, 1).Select
    Selection.PasteSpecial paste:=xlPasteValues, Operation:=xlNone, SkipBlanks _
        :=False, Transpose:=False
    Sheets("Input").Select
    
    Windows("Planning information " & Format$(eldatos, ("dd-mm")) & ".xls").Activate
    Sheets("Backhauling").Select
    Range("B11", Range("J11").End(xlDown)).Select
    Selection.copy
    planmaker.Activate
    Sheets("Input").Select
    Range("AA5").Select
    Selection.PasteSpecial paste:=xlPasteValues, Operation:=xlNone, SkipBlanks _
        :=False, Transpose:=False
        
    Range("AA5").Select
    Do Until ActiveCell.Value = ""
    If ActiveCell.Value = 0 Then
    Range(Selection, Selection.End(xlToRight)).clear
    ActiveCell.Offset(1, 0).Select
    Else
    ActiveCell.Offset(1, 0).Select
    End If
    Loop
        
        
        Call Button2_Click
        
        For Each cl In Sheet4.Range("V16:W36")
            If cl = "BRAK!" Then
            MsgBox "Pojawil sie brak w inpucie dotyczacy small rigids. Masz dwie opcje. 1- Usunac brakujacy numer sklepu w skoroszycie DepoCeator jesli nie chcesz sklepu w planie. 2- Skopiowac linie z ordersem, wkleic na samym dole planu i zmienic numer sklepu i wartosci na takie jakie chcemy= nie uzywac INSERT LINE", vbOKOnly
            Exit Sub
            End If
        Next cl
        
        
        
    Sheet23.Activate
    Sheet23.Range("BL2").Select
    Exit Sub
    
Buba:
Msg = "Wystapil blad. By uzyc makra:" & vbNewLine & vbNewLine
Msg = Msg & "1. Pliki wsadowe musza byc otwarte." & vbNewLine
Msg = Msg & "2. Planning information musi byc Unprotected." & vbNewLine
Msg = Msg & "3. Data musi sie zgadzac." & vbNewLine
Msg = Msg & "4. Albo Small rigids zostaly zassane z tekstem."

MsgBox Msg

    
End Sub


