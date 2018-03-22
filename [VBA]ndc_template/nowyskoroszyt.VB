Sub nowy()

    Sheet2.Range(Sheet2.Cells(1, 1), Sheet2.Cells(1, 46).End(xlDown)).Copy
    Workbooks.Add
    Range("A1").PasteSpecial (xlPasteAll)
    Range("A1").PasteSpecial (xlPasteValues)

End Sub
