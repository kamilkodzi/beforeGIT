Private Sub Workbook_Open()

If Environ("COMPUTERNAME") = "somestring" Or Environ("somestring") = "somestring-3" Then
Dim WS1 As Worksheet: Set WS1 = ActiveSheet
Dim Shp1 As Shape: Set Shp1 = WS1.Shapes("CommandButton1")
Shp1.ControlFormat.Enabled = True
Dim WS2 As Worksheet: Set WS2 = ActiveSheet
Dim Shp2 As Shape: Set Shp2 = WS2.Shapes("CommandButton2")
Shp2.ControlFormat.Enabled = False

Else
Dim WS3 As Worksheet: Set WS3 = ActiveSheet
Dim Shp3 As Shape: Set Shp3 = WS3.Shapes("CommandButton1")
Shp3.ControlFormat.Enabled = False
Dim WS4 As Worksheet: Set WS4 = ActiveSheet
Dim Shp4 As Shape: Set Shp4 = WS4.Shapes("CommandButton2")
Shp4.ControlFormat.Enabled = False
End If

End Sub

