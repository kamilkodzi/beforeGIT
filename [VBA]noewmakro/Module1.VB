Sub zabawa()
Dim x As Integer
Dim y As Integer
Cosinnego = 1
Do

y = Int(Rnd * (86 - 1) + 1)
x = Int(Rnd * (36 - 1) + 1)

zkol1x = Int(Rnd * (10 - 1) + 225)
zkol1y = Int(Rnd * (10 - 1) + 225)
zkol1z = Int(Rnd * (10 - 1) + 225)

zkol1 = Int(Rnd * (zkol1x - 1) + 225)
zkol2 = Int(Rnd * (zkol1y - 1) + 100)
zkol3 = Int(Rnd * (zkol1z - 1) + 100)

If Sheet1.Cells(x, y).Interior.Color <> RGB(0, 0, 0) And RGB(255, 255, 160) Then Sheet1.Cells(x, y).Interior.Color = RGB(zkol1, zkol2, zkol3)

Cosinnego = Cosinnego + 1
If Cosinnego = 80000 Then Exit Sub



Loop



End Sub

