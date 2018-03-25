Type Vehy
NumerVeha As String
OstatniSklep As String
OstatniSklepMatrix As Long
Zwrot As String
czydotcom As String
ilekm As String
capacity As String
wielkoscostatniego As Long
End Type

Type Zwroty
NumerSklepu As String
NumerSklepuMatrix As Long
NumerOrdera As String
BigTruck As String
Rodzaj As String
kmdodepota As Long
vehprzypisanydozwrotu As String

End Type

Sub zwroter()


Sheet4.Range("V3:W2000").ClearContents

'pobranie range--- z matrixa-----------------------------------------
Dim rng As Range
Set rng = Sheet1.Range("A1").CurrentRegion

'dynamiczny zakres
Dim matrix As Variant
matrix = rng.Value



Dim i As Long, j As Long
    For i = LBound(matrix) To UBound(matrix)
        For j = LBound(matrix, 2) To UBound(matrix, 2)
            'Debug.Print i, j, matrix(i, j)
        Next j
    Next i
'popbranie range z matrixa--------------------------------------------





'Wczytanie samochodow-------------------------------------------------
Dim tablicazvehami(2 To 1500) As Vehy

For x = 2 To 1500

    typ = Sheet4.Cells(x, 4)

        If typ = "1-FF" Then
            fura = Sheet4.Cells(x, 1)
            ostatninafurze = Sheet4.Cells(x, 3)
            tablicazvehami(x).NumerVeha = fura
            tablicazvehami(x).OstatniSklep = ostatninafurze
            tablicazvehami(x).wielkoscostatniego = Sheet4.Cells(x, 7)
            tablicazvehami(x).capacity = Sheet4.Cells(x, 6)
            
                For Z = 1 To i
                    If tablicazvehami(x).OstatniSklep = matrix(Z, 1) Then
                    tablicazvehami(x).OstatniSklepMatrix = Z
                    tablicazvehami(x).ilekm = matrix(Z, 5) 'tutaj pracuje
                    
                    Exit For
                    End If
                Next Z
            
            
        End If
    
Next x
'Wczytanie samochodow-------------------------------------------------




'Wczytanie zwrotow ----------------------------------------------------
Dim tablicazezwrotami(2 To 1500) As Zwroty

For x = 2 To 1500

    typ = Sheet4.Cells(x, 17)
    tablicazezwrotami(x).vehprzypisanydozwrotu = Right(Sheet4.Cells(x, 12), 7)
    'If Sheet4.Cells(x, 19) <> "" Then tablicazezwrotami(x).kmbezpowrotu = Sheet4.Cells(x, 19).Value
        If typ >= 1 Then
            sklep = Sheet4.Cells(x, 13)
            Ordernumer = Sheet4.Cells(x, 14)
            czymoze = Sheet4.Cells(x, 18)
            coto = Sheet4.Cells(x, 15)
             tablicazezwrotami(x).NumerSklepu = sklep
             tablicazezwrotami(x).NumerOrdera = Ordernumer
             tablicazezwrotami(x).BigTruck = czymoze
             tablicazezwrotami(x).Rodzaj = coto
             
             
                             For Z = 1 To i
                    If tablicazezwrotami(x).NumerSklepu = matrix(Z, 1) Then
                    tablicazezwrotami(x).NumerSklepuMatrix = Z
                    tablicazezwrotami(x).kmdodepota = matrix(Z, 5)
                    Exit For
                    End If
                Next Z
             
             
             
             
        End If

Next x
'Wczytanie zwrotow -----------------------------------------------------





'Lista DOTCOMOW------------------
Dim uwagabh(1 To 11) As String
uwagabh(1) = "somenumber"
uwagabh(2) = "somenumber"
uwagabh(3) = "somenumber"
uwagabh(4) = "somenumber"
uwagabh(6) = "somenumber"
uwagabh(7) = "somenumber"
uwagabh(8) = "somenumber"
uwagabh(9) = "somenumber"


'Lista DOTCOMOW------------------


'Lista LAST DROPOW------------------

Dim uwagalasty(1 To 30) As String
uwagalasty(1) = Sheet4.Range("AB3")
uwagalasty(2) = Sheet4.Range("AB4")
uwagalasty(3) = Sheet4.Range("AB5")
uwagalasty(4) = Sheet4.Range("AB6")
uwagalasty(5) = Sheet4.Range("AB7")
uwagalasty(6) = Sheet4.Range("AB8")
uwagalasty(7) = Sheet4.Range("AB9")
uwagalasty(8) = Sheet4.Range("AB10")
uwagalasty(9) = Sheet4.Range("AB11")
uwagalasty(10) = Sheet4.Range("AB12")
uwagalasty(11) = Sheet4.Range("AB13")
uwagalasty(12) = Sheet4.Range("AB14")
uwagalasty(13) = Sheet4.Range("AB15")
uwagalasty(14) = Sheet4.Range("AB16")
uwagalasty(15) = Sheet4.Range("AB17")

uwagalasty(16) = Sheet4.Range("AB18")
uwagalasty(17) = Sheet4.Range("AB19")
uwagalasty(18) = Sheet4.Range("AB20")
uwagalasty(19) = Sheet4.Range("AB21")
uwagalasty(20) = Sheet4.Range("AB22")
uwagalasty(21) = Sheet4.Range("AB23")
uwagalasty(22) = Sheet4.Range("AB24")
uwagalasty(23) = Sheet4.Range("AB25")
uwagalasty(24) = Sheet4.Range("AB26")
uwagalasty(25) = Sheet4.Range("AB27")
uwagalasty(26) = Sheet4.Range("AB28")
uwagalasty(27) = Sheet4.Range("AB29")
uwagalasty(28) = Sheet4.Range("AB30")
uwagalasty(29) = Sheet4.Range("AB31")
uwagalasty(30) = Sheet4.Range("AB32")

'Lista LAST DROPOW------------------






'Uzipelnienie info czy na samochodzie jedzie dotrcom---------
w = 2
Do Until Cells(w, 13) = ""
    
    vv = Application.Match(Sheet4.Cells(w, 13), uwagabh, False)
    
    If IsError(Application.Match(Sheet4.Cells(w, 13), uwagabh, False)) Then
    GoTo kolejny:
    Else
    
        If (Right(Sheet4.Cells(w, 12), 7) <> "") And Sheet4.Cells(w, 15) = "1-FF" Then
            numervehazbh = Right(Sheet4.Cells(w, 12), 7)
        
            For x1 = 2 To 600
                If tablicazvehami(x1).NumerVeha = numervehazbh Then tablicazvehami(x1).czydotcom = "DOTCOM"
            Next x1
        
        
        End If
    
    End If
    
kolejny:
w = w + 1
Loop
'Uzipelnienie info czy na samochodzie jedzie dotrcom---------







'Uzipelnienie info czy na samochodzie jest LAST DROP---------
w = 2
Do Until Cells(w, 13) = ""
    
    vv = Application.Match(Sheet4.Cells(w, 13), uwagabh, False)
    
    If IsError(Application.Match(Sheet4.Cells(w, 13), uwagalasty, False)) Then
    GoTo kolejny2:
    Else
    
        If (Right(Sheet4.Cells(w, 12), 7) <> "") And Sheet4.Cells(w, 15) = "1-FF" Then
            numervehazbh = Right(Sheet4.Cells(w, 12), 7)
        
            For x1 = 2 To 600
                If tablicazvehami(x1).NumerVeha = numervehazbh Then tablicazvehami(x1).czydotcom = "LASTDROP"

            Next x1
        
        
        End If
    
    End If
    
kolejny2:
w = w + 1
Loop
'Uzipelnienie info czy na samochodzie JEST LAST DROP---------



















'BH ---------------------------------------------------------------------





niezaplanowanebh:

For x = 2 To 1500

    If tablicazezwrotami(x).Rodzaj = "11-BH" And tablicazezwrotami(x).NumerSklepu <> "pobrane" Then
        
        
        For gi = LBound(tablicazezwrotami) To UBound(tablicazezwrotami)
            If tablicazezwrotami(gi).kmdodepota > tablicazezwrotami(x).kmdodepota And tablicazezwrotami(gi).Rodzaj = "11-BH" Then
                GoTo jestwiekszy
            End If
        Next gi
        
        finalkm = 999
        
        For y = 2 To 1500
        'On Error Resume Next
            If tablicazvehami(y).Zwrot = "" And tablicazezwrotami(x).BigTruck And tablicazvehami(y).capacity = "33" And tablicazvehami(y).czydotcom <> "DOTCOM" And tablicazvehami(y).czydotcom <> "LASTDROP" Then
            
                bhplace = tablicazezwrotami(x).NumerSklepuMatrix
                magazynplace = 5
                lastplace = tablicazvehami(y).OstatniSklepMatrix
                wielakm = tablicazvehami(y).ilekm
                
                
                
                kmpierwotne = tablicazvehami(y).ilekm
                km = matrix(lastplace, bhplace) + matrix(bhplace, magazynplace)
                ilewplanie = km - kmpierwotne
                
                    If ilewplanie < finalkm Then
                        finalveh = tablicazvehami(y).NumerVeha
                        finalkm = ilewplanie
                        finalzwrot = tablicazezwrotami(x).NumerSklepu
                        iks = x
                        igrek = y
                        iledodam = ilewplanie
                    End If


            End If
        Next y
        
        
        
        'Debug.Print iledodam
        tablicazezwrotami(iks).NumerSklepu = "pobrane"
        tablicazezwrotami(iks).kmdodepota = "0"
        tablicazvehami(igrek).Zwrot = tablicazezwrotami(x).NumerOrdera
        
        
    End If
    
jestwiekszy:
Next x


'czy sa niezaplanowane BH

        For gz = LBound(tablicazezwrotami) To UBound(tablicazezwrotami)
            If tablicazezwrotami(gz).kmdodepota <> "0" And tablicazezwrotami(gz).Rodzaj = "11-BH" Then
                GoTo niezaplanowanebh:
            End If
        Next gz



'BH ---------------------------------------------------------------------







'Lasty ------------------------------------------------------------------ dodac sprawdzanie po full load truck


For x = 2 To 1500
    If tablicazvehami(x).Zwrot = "" And tablicazvehami(x).wielkoscostatniego >= 20 Then
        For y = 2 To 1500
            If (tablicazvehami(x).OstatniSklep = tablicazezwrotami(y).NumerSklepu) And tablicazezwrotami(y).NumerSklepu <> "pobrane" Then
            
            If tablicazvehami(x).capacity = "33" And tablicazezwrotami(y).BigTruck <> "1" Then GoTo Depo1
            
            tablicazvehami(x).Zwrot = tablicazezwrotami(y).NumerOrdera
            tablicazezwrotami(y).NumerSklepu = "pobrane"
            Exit For
            End If
        Next y
    End If
Depo1:
Next x



For x = 2 To 1500
If IsError(tablicazvehami(x).Zwrot = "" And tablicazvehami(x).wielkoscostatniego) Then GoTo Depo2
    If tablicazvehami(x).Zwrot = "" And tablicazvehami(x).wielkoscostatniego < 20 Then
    
        For y = 2 To 1500
            If (tablicazvehami(x).OstatniSklep = tablicazezwrotami(y).NumerSklepu) And tablicazezwrotami(y).NumerSklepu <> "pobrane" Then
            If tablicazvehami(x).capacity = "33" And tablicazezwrotami(y).BigTruck <> "1" Then GoTo Depo2
            tablicazvehami(x).Zwrot = tablicazezwrotami(y).NumerOrdera
            tablicazezwrotami(y).NumerSklepu = "pobrane"
            Exit For
            End If
        Next y
    End If
Depo2:
Next x


'Lasty ------------------------------------------------------------------



















'Zwroty po trasie ---------------------------------------------------------------------





niezaplanowanezwroty:

For x = 2 To 1500

    If tablicazezwrotami(x).NumerSklepu <> "pobrane" And tablicazezwrotami(x).BigTruck = "1" And tablicazezwrotami(x).Rodzaj = "10-LE" Then
        
        
        
        'TUTAJ PRACUJEM
        
                For gi = LBound(tablicazezwrotami) To UBound(tablicazezwrotami)
            If tablicazezwrotami(gi).kmdodepota > tablicazezwrotami(x).kmdodepota And tablicazezwrotami(gi).Rodzaj = "10-LE" And tablicazezwrotami(gi).BigTruck = "1" And tablicazezwrotami(gi).NumerSklepu <> "pobrane" Then
                GoTo jestwiekszyzwrot
            End If
        Next gi
        
        
        
        
        
        finalkm = Sheet4.Range("AH8")
        
        For y = 2 To 1500
        'On Error Resume Next
            If tablicazvehami(y).Zwrot = "" And tablicazezwrotami(x).BigTruck = "1" And tablicazvehami(y).capacity = "33" And tablicazvehami(y).czydotcom <> "LASTDROP" Then
            
                bhplace = tablicazezwrotami(x).NumerSklepuMatrix
                magazynplace = 5
                lastplace = tablicazvehami(y).OstatniSklepMatrix
                wielakm = tablicazvehami(y).ilekm
                kmpierwotne = tablicazvehami(y).ilekm
                km = matrix(lastplace, bhplace) + matrix(bhplace, magazynplace)
                ilewplanie = km - kmpierwotne
                
                    If ilewplanie < finalkm Then
                        finalveh = tablicazvehami(y).NumerVeha
                        finalkm = ilewplanie
                        finalzwrot = tablicazezwrotami(x).NumerSklepu
                        iks = x
                        igrek = y
                        iledodam = ilewplanie
                    End If
            End If
        Next y
        
        
        
        Debug.Print iledodam
        tablicazezwrotami(iks).NumerSklepu = "pobrane"
        tablicazezwrotami(iks).kmdodepota = "0"
        tablicazvehami(igrek).Zwrot = tablicazezwrotami(iks).NumerOrdera
        If iks <> x Then tablicazezwrotami(x).NumerSklepu = "pobrane"
        
        
    End If
    
jestwiekszyzwrot:
Next x




'czy sa niezaplanowane zwroty
        If superczek < 1000 Then
        superczek = superczek + 1
        GoTo niezaplanowanezwroty:
        
        End If
        
        
'Zwroty po trasie ---------------------------------------------------------------------




'drukowanie-----------------------------------------------------------------------------

For x = 3 To 1500
    Dim truck As Range
    Dim order As Range
    Set truck = Sheet4.Cells(x, 22)
    Set order = Sheet4.Cells(x, 23)

For y = 2 To 1500
If tablicazvehami(y).Zwrot <> "" Then
    truck = tablicazvehami(y).NumerVeha
    order = tablicazvehami(y).Zwrot
    tablicazvehami(y).Zwrot = ""
    Exit For
    End If
Next y

Next x

Sheet4.Range(Cells(1, 22), Cells(1, 22).End(xlDown).Offset(0, 4)).Copy
Workbooks.Add
Range("A1").PasteSpecial (xlPasteValuesAndNumberFormats)


'drukowanie-----------------------------------------------------------------------------


End Sub
