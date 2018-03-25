Sub report()


Dim powrot As Workbook
Set powrot = ActiveWorkbook


Sheet1.Range(Cells(6, 1), Cells(9, 15)).Copy
Workbooks.Open ("\\URL\NDC report.xlsx")
Range("A1000000").End(xlUp).Offset(1, 0).PasteSpecial xlPasteValuesAndNumberFormats
Selection.PasteSpecial xlPasteValuesAndNumberFormats

Application.DisplayAlerts = False
Workbooks("NDC report.xlsx").Close savechanges:=True
Application.DisplayAlerts = True

powrot.Activate

End Sub
