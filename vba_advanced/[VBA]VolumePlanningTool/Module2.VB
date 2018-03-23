Sub testkaila()
'
' testkaila Macro
'

'
    ActiveSheet.PivotTables("PivotTable3").PivotFields("OrderCode").CurrentPage = _
        "(All)"
    With ActiveSheet.PivotTables("PivotTable3").PivotFields("OrderCode")
        .PivotItems("OPISANE").Visible = False
        .PivotItems("(blank)").Visible = False
    End With
    ActiveSheet.PivotTables("PivotTable3").PivotFields("OrderCode"). _
        EnableMultiplePageItems = True
End Sub
