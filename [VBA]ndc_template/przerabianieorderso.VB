Private Sub CommandButton2_Click()

    Dim range_1 As Range
    Set range_1 = Range(Cells(6, 3), Cells(6, 15))

    cz = "somenumber"
    mo = "somenumber"
    sk = "somenumber"
    pr = "somenumber"
    pl = "somenumber"
    gl = "somenumber"
    po = "somenumber"
    gy = "somenumber"
    go = "somenumber"
    hub1 = "somenumber"
    hub2 = "somenumber"
    hub3 = "somenumber"
    hub4 = go
    
    For y = 0 To 3
    
    
    
    For Each cell In range_1.Offset(y, 0)
        
        w = cell.Column
      If cell = Empty Then
        GoTo nastepna_komorka1
        Else
        nazwa_magazynu = cell.Offset(-3 - y, 0).Text
        If y = 0 Then ilosc_palet_w_transporcie = 33
        If y = 1 Then ilosc_palet_w_transporcie = 38
        If y = 2 Then ilosc_palet_w_transporcie = 38
        If y = 3 Then ilosc_palet_w_transporcie = 18
        ilosc_transportow = cell.Value

        cas_pal = Sheet1.Cells(5, w) / (Sheet1.Cells(4, w) + Sheet1.Cells(6, w) * 33 + Sheet1.Cells(7, w) * 38 + Sheet1.Cells(8, w) * 38 + Sheet1.Cells(9, w) * 18)


       
            
             Select Case nazwa_magazynu
                Case Is = "somestring"
                    numer_magazynu = cz
                Case Is = "somestring"
                    numer_magazynu = mo
                Case Is = "somestring"
                    numer_magazynu = sk
                Case Is = "somestring"
                    numer_magazynu = pr
                Case Is = "somestring"
                    numer_magazynu = pl
                Case Is = "somestring"
                    numer_magazynu = gl
                Case Is = "somestring"
                    numer_magazynu = po
                Case Is = "somestring"
                    numer_magazynu = gy
                Case Is = "somestring"
                    numer_magazynu = go
                Case Is = "somestring"
                    numer_magazynu = hub1
                Case Is = "somestring"
                    numer_magazynu = hub2
                Case Is = "somestring"
                    numer_magazynu = hub3
                Case Is = "somestring"
                    numer_magazynu = hub4
             End Select
         
         If y = 1 Then ilosc_palet_w_transporcie = 55
         
         Call wpisz_linie(numer_magazynu, ilosc_transportow, ilosc_palet_w_transporcie, cas_pal)
         
         
      End If
            
nastepna_komorka1:
Next cell
Next y

Call nowy

End Sub
