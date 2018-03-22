Sub zwracacz()
    Sheet2.Range("W11:AD11").ClearFormats
    Sheet2.Range("BN11:BU11").Copy Sheet2.Range("W11:AD11")
    
    Sheet2.Range("W11").FormulaLocal = Sheet2.Range("BN11").FormulaLocal
    Sheet2.Range("X11").FormulaLocal = Sheet2.Range("BO11").FormulaLocal
    Sheet2.Range("Y11").FormulaLocal = Sheet2.Range("BP11").FormulaLocal
    Sheet2.Range("Z11").FormulaLocal = Sheet2.Range("BQ11").FormulaLocal
    
    Sheet2.Range("AA11").FormulaLocal = Sheet2.Range("BR11").FormulaLocal
    Sheet2.Range("AB11").FormulaLocal = Sheet2.Range("BS11").FormulaLocal
    Sheet2.Range("AC11").FormulaLocal = Sheet2.Range("BT11").FormulaLocal
    Sheet2.Range("AD11").FormulaLocal = Sheet2.Range("BU11").FormulaLocal
    
    
    Range("W11:AD11").Select
    Selection.AutoFill Destination:=Range("W11:AD801")
    Range("W11").Select
End Sub
