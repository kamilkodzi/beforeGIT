Type tablica
'miejsce w tablicy dla dc2
Numersklepu As Long
kartony As Long
palety As Long

'miejsce w tablicy dla dc3BOX
paletydodatkoweB As Long
kartonyydodatkoweB As Long
magazyndodatkowyB As String

'miejsce w tablicy dla dc3HNG
paletydodatkoweH As Long
kartonyydodatkoweH As Long
magazyndodatkowyH As String
End Type

Sub suprem3()


If Sheet1.Range("A13") = "" And Sheet1.Range("E13") = "" And Sheet1.Range("I13") = "" Then
MsgBox ("Wklej ordersy")
Exit Sub
End If

If Sheet1.Range("B1") = "" Then
MsgBox ("Wpisz mozliwe daty dojazdu na sklepy")
Exit Sub
End If
Dim tablica(3000) As tablica

'Czyszczenie (tzw przygotowanie)
Application.ScreenUpdating = False


For Each cl In Sheet1.Range("D13:D3000") 'czyscimy wszystkie B i H jako komentarza w D tabelce
    If cl <> "" Then
        cl.Offset(0, -1) = ""
        cl.Offset(0, -2) = ""
        cl.Offset(0, -3) = ""
        cl.Offset(0, 0) = ""
    End If
Next cl


Call zamkniecie1
Call zamkniecie2
Call zamkniecie3


Sheet3.Range("A5:AT10000").ClearContents
Sheet4.Range("A1:AT5").Copy Sheet3.Range("A1")
Sheet3.Range("A5:AT1500").FillDown




count1 = Sheet1.Range("A11")
If coun1 = 0 Then GoTo kolumna2
For Each klz In Sheet1.Range(Cells(13, 3), Cells(12 + count1, 3))
    If klz < 0.99 Then
        klz.Offset(0, -1) = 0
        klz.Value = 0
    End If
Next klz


kolumna2:
count2 = Sheet1.Range("E11")
If count2 = 0 Then GoTo kolumna3
For Each kl In Sheet1.Range(Cells(13, 7), Cells(12 + count2, 7))
    If kl < 0.99 Then
        kl.Offset(0, -1) = 0
        kl.Value = 0
    End If
Next kl

Sheet1.Range(Cells(13, 5), Cells(13, 7).End(xlDown).Offset(0, 1)).Select
Selection.Copy
Sheet1.Cells(10000, 1).End(xlUp).Offset(1, 0).PasteSpecial xlPasteValues



kolumna3:
count3 = Sheet1.Range("I11")
If count3 = 0 Then GoTo bez3
For Each kl In Sheet1.Range(Cells(13, 11), Cells(12 + count3, 11))
    If kl < 0.99 Then
        kl.Offset(0, -1) = 0
        kl.Value = 0
    End If
Next kl

Sheet1.Range(Cells(13, 9), Cells(13, 11).End(xlDown).Offset(0, 1)).Select
Selection.Copy
Sheet1.Cells(10000, 1).End(xlUp).Offset(1, 0).PasteSpecial xlPasteValues



count1 = Sheet1.Range("A11")
For Each klz In Sheet1.Range(Cells(13, 3), Cells(12 + count1, 3))
    If klz > 0 Then
        piepal = klz.Value
        piecase = klz.Offset(0, -1)
        pieprzelicznikpalnacase = piecase / piepal
        klz.Value = Int(klz.Value)
        klz.Offset(0, -1) = Int(klz.Offset(0, -1) - ((piepal - klz) * pieprzelicznikpalnacase))
    End If
Next klz


bez3:
Application.Calculation = xlCalculationSemiautomatic


r = 0

Do Until Cells(r + 13, 1) = "" 'Dla kazdego numeru sklepu

   For i = LBound(tablica) To r - 1 'dla wszystkich juz zapisanych w pamieci
   
        If Cells(r + 13, 1) = tablica(i).Numersklepu Then 'jesli sa takie same to dodajemy je do siebie (wartosci case i palet)
        tablica(i).kartony = tablica(i).kartony + Sheet1.Cells(r + 13, 2)
        tablica(i).palety = tablica(i).palety + Sheet1.Cells(r + 13, 3)
            
            'Dodatkowo dodajemy DC3(BOX) jako informacje w pamieci
            If Cells(r + 13, 4) = "B" Then
            tablica(i).kartonyydodatkoweB = Sheet1.Cells(r + 13, 2) + tablica(i).kartonyydodatkoweB
            tablica(i).paletydodatkoweB = Sheet1.Cells(r + 13, 3) + tablica(i).paletydodatkoweB
            tablica(i).magazyndodatkowyB = "B"
            End If
            
            'Dodatkowo dodajemy DC3(HNG) jako informacje w pamieci
            If Cells(r + 13, 4) = "H" Then
            tablica(i).kartonyydodatkoweH = Sheet1.Cells(r + 13, 2) + tablica(i).kartonyydodatkoweH
            tablica(i).paletydodatkoweH = Sheet1.Cells(r + 13, 3) + tablica(i).paletydodatkoweH
            tablica(i).magazyndodatkowyH = "H"
            End If


        GoTo komasowanie 'Jesli juz cos zsumowalismy to nie potrzebujemy zejsc nizej by wpisac w pamiec nowego sklepu
        End If
    
    
    Next i


On Error Resume Next


'Jesli nie dodalismy niczego do siebie to znaczy, ze numer sklepu jest unikalny (trzeba dodac nowy sklep do pamieci)

tablica(r).Numersklepu = Sheet1.Cells(r + 13, 1)

If Cells(r + 13, 4) = "B" Then 'Jesli wolumen pochodzi z Boxow
tablica(i).magazyndodatkowyB = "B"
tablica(r).kartonyydodatkoweB = Sheet1.Cells(r + 13, 2)
tablica(r).paletydodatkoweB = Sheet1.Cells(r + 13, 3)
tablica(r).kartony = tablica(r).kartony + Sheet1.Cells(r + 13, 2)
tablica(r).palety = tablica(r).palety + Sheet1.Cells(r + 13, 3) 'dodane


ElseIf Cells(r + 13, 4) = "H" Then 'Jesli wolumen pochodzi z HNG
tablica(i).magazyndodatkowyH = "H"
tablica(r).kartonyydodatkoweH = Sheet1.Cells(r + 13, 2)
tablica(r).paletydodatkoweH = Sheet1.Cells(r + 13, 3)
tablica(r).kartony = tablica(r).kartony + Sheet1.Cells(r + 13, 2)
tablica(r).palety = tablica(r).palety + Sheet1.Cells(r + 13, 3) 'dodane


Else 'Jesli wolumen pochodzi z Gan
tablica(r).kartony = tablica(r).kartony + Sheet1.Cells(r + 13, 2)
tablica(r).palety = tablica(r).palety + Sheet1.Cells(r + 13, 3)

End If


On Error GoTo 0
'kolejna linia
komasowanie:
    r = r + 1
   
Loop






'- - - - - - - - - - - - - - - - - -



Sheet3.Activate


'Drukowanie- Wpisujemy z pamieci do lini (logika)
For i = LBound(tablica) To UBound(tablica)
If tablica(i).Numersklepu = 0 Then GoTo niemasensu
If tablica(i).palety = 0 Then GoTo niemasensu
kapacity = Application.WorksheetFunction.VLookup(tablica(i).Numersklepu, Sheet2.Range("B3:Q10000"), 16, 0)

youspinme:
    If tablica(i).palety > kapacity Then
    
        If (tablica(i).palety - tablica(i).paletydodatkoweB - tablica(i).paletydodatkoweH) >= kapacity Then 'przypadek w ktorym 100% volumenu jest z podstawowej tabeli
        kartonynapalete = (tablica(i).kartony - tablica(i).kartonyydodatkoweB - tablica(i).kartonyydodatkoweH) / (tablica(i).palety - tablica(i).paletydodatkoweB - tablica(i).paletydodatkoweH)
        Sheet3.Range("C10000").End(xlUp).Offset(1, 0) = tablica(i).Numersklepu
        Sheet3.Range("F10000").End(xlUp).Offset(1, 0) = kapacity
        tablica(i).palety = tablica(i).palety - kapacity
        Sheet3.Range("H10000").End(xlUp).Offset(1, 0) = kapacity * kartonynapalete
        tablica(i).kartony = tablica(i).kartony - (kapacity * kartonynapalete)
        Sheet3.Range("AQ10000").End(xlUp).Offset(1, 0) = " "
        Sheet3.Range("AR10000").End(xlUp).Offset(1, 0) = " "
        If Sheet3.Range("C10000").End(xlUp).Offset(0, 6) = " " And tablica(i).Numersklepu <> 31021 Then Sheet3.Range("C10000").End(xlUp).Offset(0, 6) = "FLT"
        
        
        Else 'przypadek w ktorym mamy osiagniete capacity ale z pomoca box lub hng
        If (tablica(i).palety - tablica(i).paletydodatkoweB - tablica(i).paletydodatkoweH) = 0 Then GoTo dzielenie0
        kartonynapalete = (tablica(i).kartony - tablica(i).kartonyydodatkoweB - tablica(i).kartonyydodatkoweH) / (tablica(i).palety - tablica(i).paletydodatkoweB - tablica(i).paletydodatkoweH)
        
            If 8 = 10 Then
dzielenie0: kartonynapalete = (tablica(i).kartony) / (tablica(i).palety) 'przypadek kiedy mamy rowne capacity zlozone tylko z resztek Box i HNG
            End If
            
        If tablica(i).paletydodatkoweB <> 0 Then kartonydodatkowenapaleteB = tablica(i).kartonyydodatkoweB / tablica(i).paletydodatkoweB 'przelicznik case na palecie (jesli sa boxy)
        If tablica(i).paletydodatkoweH <> 0 Then kartonydodatkowenapaleteH = tablica(i).kartonyydodatkoweH / tablica(i).paletydodatkoweH 'przelicznik case na palecie (jesli sa HNG)

        
        'nowosc
        zrzuthngpal = 0
        zrzuthngcas = 0
        zrzutboxpal = 0
        zrzutboxcas = 0
        kartonynaaucie = 0
        paletynaaucie = 0
        
        
        If (tablica(i).palety - tablica(i).paletydodatkoweB - tablica(i).paletydodatkoweH) > 0 Then
        kartonynaaucie = (tablica(i).palety - tablica(i).paletydodatkoweB - tablica(i).paletydodatkoweH) * kartonynapalete
        paletynaaucie = paletynaaucie + (tablica(i).palety - tablica(i).paletydodatkoweB - tablica(i).paletydodatkoweH)
        End If
        
        
        'Mechanizm dla HNG (priorytet pierwszy)
        If tablica(i).paletydodatkoweH > 0 Then
            If tablica(i).paletydodatkoweH <= kapacity - paletynaaucie Then
            paletynaaucie = paletynaaucie + tablica(i).paletydodatkoweH
            kartonynaaucie = kartonynaaucie + tablica(i).kartonyydodatkoweH
            Sheet3.Range("AR10000").End(xlUp).Offset(1, 0) = "H" & "/C" & Round(tablica(i).kartonyydodatkoweH) & "/P" & Round(tablica(i).paletydodatkoweH) & "/"
            tablica(i).paletydodatkoweH = 0
            tablica(i).kartonyydodatkoweH = 0
            Else
            zrzuthngcas = kartonydodatkowenapaleteH * (kapacity - paletynaaucie)
            kartonynaaucie = kartonynaaucie + (kartonydodatkowenapaleteH * (kapacity - paletynaaucie))
            zrzuthngpal = kapacity - paletynaaucie
            paletynaaucie = paletynaaucie + (kapacity - paletynaaucie)
            Sheet3.Range("AR10000").End(xlUp).Offset(1, 0) = "H" & "/C" & Round(zrzuthngcas) & "/P" & Round(zrzuthngpal) & "/"
            tablica(i).paletydodatkoweH = tablica(i).paletydodatkoweH - zrzuthngpal
            tablica(i).kartonyydodatkoweH = tablica(i).kartonyydodatkoweH - zrzuthngcas
            End If
        Else
        Sheet3.Range("AR10000").End(xlUp).Offset(1, 0) = " "
        End If
        'Mechanizm dla HNG (priorytet pierwszy)
        
        
        'Mechanizm dla BOX (priorytet drugi)
        If (kapacity - paletynaaucie) = 0 Then GoTo pelny
        If tablica(i).paletydodatkoweB > 0 Then
            If tablica(i).paletydodatkoweB <= kapacity - paletynaaucie Then
            paletynaaucie = paletynanaucie + tablica(i).paletydodatkoweB
            kartonynaaucie = kartonynaaucie + tablica(i).kartonyydodatkoweB
            Sheet3.Range("AQ10000").End(xlUp).Offset(1, 0) = "B" & "/C" & Round(tablica(i).kartonyydodatkoweB) & "/P" & Round(tablica(i).paletydodatkoweB) & "/"
            tablica(i).paletydodatkoweB = 0
            tablica(i).kartonyydodatkoweB = 0
            Else
            zrzutboxcas = kartonydodatkowenapaleteB * (kapacity - paletynaaucie)
            kartonynaaucie = kartonynaaucie + (kartonydodatkowenapaleteB * (kapacity - paletynaaucie))
            zrzutboxpal = kapacity - paletynaaucie
            paletynaaucie = paletynaaucie + (kapacity - paletynaaucie)
            Sheet3.Range("AQ10000").End(xlUp).Offset(1, 0) = "B" & "/C" & Round(zrzutboxcas) & "/P" & Round(zrzutboxpal) & "/"
            tablica(i).paletydodatkoweB = tablica(i).paletydodatkoweB - zrzutboxpal
            tablica(i).kartonyydodatkoweB = tablica(i).kartonyydodatkoweB - zrzutboxcas
            End If
        Else
pelny:
        Sheet3.Range("AQ10000").End(xlUp).Offset(1, 0) = " "
        End If
        'Mechanizm dla BOX (priorytet drugi)
        
        
        Sheet3.Range("C10000").End(xlUp).Offset(1, 0) = tablica(i).Numersklepu 'wpisujemy nazwe sklepu oraz ilosc palet
        Sheet3.Range("F10000").End(xlUp).Offset(1, 0) = paletynaaucie '(pewne jest, ze ilosc rowna capacity)
        Sheet3.Range("H10000").End(xlUp).Offset(1, 0) = kartonynaaucie
        tablica(i).palety = tablica(i).palety - kapacity ' wiec odejmujemy capacity z totalnej ilosci na dany sklep
        tablica(i).kartony = tablica(i).kartony - kartonynaaucie ' wiec odejmujemy kartony z totalnej ilosci na dany sklep
        If Sheet3.Range("C10000").End(xlUp).Offset(0, 6) = " " And tablica(i).Numersklepu <> 31021 Then Sheet3.Range("C10000").End(xlUp).Offset(0, 6) = "FLT"
        
        End If

        GoTo youspinme
    
    
    
    
    Else 'przypadek w ktorym nie osiagamy capacity - mozliwe ze mamy w volumenie box lub hng
        Sheet3.Range("C10000").End(xlUp).Offset(1, 0) = tablica(i).Numersklepu
        Sheet3.Range("F10000").End(xlUp).Offset(1, 0) = tablica(i).palety
        Sheet3.Range("H10000").End(xlUp).Offset(1, 0) = tablica(i).kartony
        If tablica(i).palety = kapacity And Sheet3.Range("C10000").End(xlUp).Offset(0, 6) = " " And tablica(i).Numersklepu <> 31021 Then Sheet3.Range("C10000").End(xlUp).Offset(0, 6) = "FLT"
        
            If tablica(i).paletydodatkoweB = 0 Then
            Sheet3.Range("AQ10000").End(xlUp).Offset(1, 0) = " "
            Else
            Sheet3.Range("AQ10000").End(xlUp).Offset(1, 0) = "B" & "/C" & Round(tablica(i).kartonyydodatkoweB) & "/P" & Round(tablica(i).paletydodatkoweB) & "/"
            End If
            
            If tablica(i).paletydodatkoweH = 0 Then
            Sheet3.Range("AR10000").End(xlUp).Offset(1, 0) = " "
            Else
            Sheet3.Range("AR10000").End(xlUp).Offset(1, 0) = "H" & "/C" & Round(tablica(i).kartonyydodatkoweH) & "/P" & Round(tablica(i).paletydodatkoweH) & "/"
            End If
            
            If tablica(i).palety = kapacity And Sheet3.Range("C10000").End(xlUp).Offset(0, 6) = " " And tablica(i).Numersklepu <> 31021 Then Sheet3.Range("C10000").End(xlUp).Offset(0, 6) = "FLT"
    End If


niemasensu:
Next i



Application.Calculation = xlCalculationAutomatic
'usuwanie pustych lini w poziomie (jesli nie ma godziny dostawy i nie ma nawet jednej daty dostawy - znaczy, ze sklep nie jedzie i nie trzeba zamowienia)
Z = 5
Do Until Cells(Z, 3) = ""
sprawdz = Application.WorksheetFunction.Count(Sheet3.Range(Cells(Z, 22), Cells(Z, 35)))
    
    If sprawdz = 0 Then
    Rows(Z).Delete
    GoTo skokwbok
    End If
    
Z = Z + 1
skokwbok:
Loop

Application.DisplayAlerts = False
nazwatopsa = "Tops z dnia " & Format(Now(), "dd-mm-hh-mm")
ActiveWorkbook.SaveAs Filename:="/" & nazwatopsa & ".xlsm", FileFormat:=52, Local:=True
Application.DisplayAlerts = True

ostnr = Sheet3.Range("C2")
'Sheet4.Range("A1:AR4").Copy Sheet3.Range("A1")
Sheet3.Range(Sheet3.Cells(1, 1), Sheet3.Cells(ostnr, 46)).Copy
Workbooks.Add
Selection.PasteSpecial Paste:=xlValues
Selection.PasteSpecial Paste:=xlFormats



'Przesuwanie dzni dostawy z data
Dim nowa As Range
Dim stara As Range

For x = 5 To 10000
If Cells(x, 4) = "" Then Exit For
    For Z = 1 To 10
        For y = 22 To 34
            Set nowa = Cells(x, y)
            Set stara = Cells(x, y + 1)
                If nowa = "" Then
                nowa = stara
                stara = ""
                End If
        Next y
    Next Z
Next x


Application.ScreenUpdating = True
End Sub





