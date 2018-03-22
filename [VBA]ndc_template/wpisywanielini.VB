
Sub wpisz_linie(nr_m, il_s, cap, cas_pal)


Dim nowalinia As Range
Do While il_s > 0

Set nowalinia = Sheet2.Range("A1").End(xlDown).Offset(1, 0)
nowalinia = "N_" & Format(Now(), "yymmdd") & "_" & nowalinia.Row + 95
nowalinia.Offset(0, 1) = Left(nr_m, 1)
nowalinia.Offset(0, 2) = nr_m
nowalinia.Offset(0, 3) = nr_m
nowalinia.Offset(0, 4) = "somestring"
nowalinia.Offset(0, 5) = cap
nowalinia.Offset(0, 7) = Round(cas_pal * cap)
nowalinia.Offset(0, 8) = "FTL"
If cap = 55 Then nowalinia.Offset(0, 9) = 1
If cap = 38 Then nowalinia.Offset(0, 10) = 1
If cap = 33 Then nowalinia.Offset(0, 11) = 1
If cap = 18 Then nowalinia.Offset(0, 14) = 1
nowalinia.Offset(0, 19) = "00:01"
nowalinia.Offset(0, 20) = "23:59"
nowalinia.Offset(0, 21) = Sheet1.Range("Q1")
nowalinia.Offset(0, 22) = Sheet1.Range("Q1")
nowalinia.Offset(0, 35) = Sheet1.Range("Q1")
If Sheet1.Range("A1") = "somestring" Then nowalinia.Offset(0, 42) = "B/C" & Round(cas_pal * cap) & "/P/" & cap & "/"
nowalinia.Offset(0, 44) = 0
If Sheet1.Range("A1") = "somestring" Then nowalinia.Offset(0, 45) = 99999
If Sheet1.Range("A1") = "somestring" Then nowalinia.Offset(0, 45) = 99999


il_s = il_s - 1
Loop


End Sub

