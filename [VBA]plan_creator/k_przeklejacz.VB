Sub przeklejacz()

    Sheet2.Range("W11:W801").Copy
    Sheet2.Range("BA11").Select
    Selection.PasteSpecial Paste:=xlPasteValues
        
    Sheet2.Range("X11:X801").Copy
    Sheet2.Range("BB11").Select
    Selection.PasteSpecial Paste:=xlPasteValues
        
        
    Sheet2.Range("AD11:AD801").Copy
    Sheet2.Range("BC11").Select
    Selection.PasteSpecial Paste:=xlPasteValues
    
    Sheet2.Range("W11").Select
    Sheet2.Range("W11").Activate
    Application.CutCopyMode = False
    End Sub
