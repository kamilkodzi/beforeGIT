Sub admitted()

Application.Calculation = xlCalculationAutomatic
Application.ScreenUpdating = False
Application.Calculation = xlCalculationManual

'Key tables for HOUR
Dim hourtable(24) As String
hourtable(0) = "Y"
hourtable(1) = "A"
hourtable(2) = "B"
hourtable(3) = "C"
hourtable(4) = "D"
hourtable(5) = "A"
hourtable(6) = "B"
hourtable(7) = "C"
hourtable(8) = "D"
hourtable(9) = "E"
hourtable(10) = "F"
hourtable(11) = "G"
hourtable(12) = "H"
hourtable(13) = "I"
hourtable(14) = "J"
hourtable(15) = "K"
hourtable(16) = "L"
hourtable(17) = "Q"
hourtable(18) = "R"
hourtable(19) = "S"
hourtable(20) = "T"
hourtable(21) = "U"
hourtable(22) = "W"
hourtable(23) = "X"

' Key tables for minutes
'Dim mintable(12, 1) As String
'mintable(0, 0) = "5"
'mintable(1, 0) = "10"
'mintable(2, 0) = "15"
'mintable(3, 0) = "20"
'mintable(4, 0) = "25"
'mintable(5, 0) = "30"
'mintable(6, 0) = "35"
'mintable(7, 0) = "40"
'mintable(8, 0) = "45"
'mintable(9, 0) = "50"
'mintable(10, 0) = "55"
'mintable(11, 0) = "60"
'mintable(0, 1) = "A"
'mintable(1, 1) = "B"
'mintable(2, 1) = "C"
'mintable(3, 1) = "D"
'mintable(4, 1) = "E"
'mintable(5, 1) = "F"
'mintable(6, 1) = "G"
'mintable(7, 1) = "H"
'mintable(8, 1) = "I"
'mintable(9, 1) = "J"
'mintable(10, 1) = "K"
'mintable(11, 1) = "L"



' worksheet numba
Dim No As Integer
No = 1

'Magazyny numba
Dim magazyn As String
Dim magazyn2 As String
Dim magazyn3 As String
Dim magazyn4 As String
Dim magazyn5 As String


magazyn = "number"
magazyn2 = ""
magazyn3 = ""
magazyn4 = ""
magazyn5 = ""

' Taking Hour and Minutes to key tables
Dim thour As String
Dim tminut As String
Dim tsec As String
thour = Format(Now, "hh")
tminut = Format(Now, "N")
tsec = Format(Now, "ss")
 
 
' Common row counter for order_id last part
Dim ccount As Integer
 ccount = 1000
 
' first part of normal order id
Dim external As String
Dim rExternal As String

external = hourtable(thour) & tminut & tsec
   
Dim prod As String
   
   
   
'For y = 0 To 11
'    gho = mintable(y, 0)
'    If tminut * 1 <= gho Then
'    external = external & mintable(y, 1)
'    Exit For
'    End If
'Next y



    Cells(4, 2).Offset(1, 0).Select


Do Until IsEmpty(ActiveCell)

prod = Right(ActiveCell.Offset(0, 4).Value, 2)

ccount = ccount + 1

    
    Selection.Offset(0, 57).Value = "N"
    Selection.Offset(0, 58).Value = magazyn
    Selection.Offset(0, 59).Value = magazyn2
    Selection.Offset(0, 60).Value = magazyn3
    Selection.Offset(0, 61).Value = magazyn4
    Selection.Offset(0, 62).Value = magazyn5

rExternal = external & Right(ccount, 3)

Select Case prod
Case "BS"  ' PBS
Selection.Offset(0, 63).Value = rExternal
 
    GoTo DALEJ
Case "BL"  ' PBL
Selection.Offset(0, 63).Value = rExternal
  
    GoTo DALEJ
Case "FF"  ' FF
   
Selection.Offset(0, 63).Value = rExternal
 
    GoTo DALEJ
Case "MB"  ' AMB
   
Selection.Offset(0, 63).Value = rExternal
 

    GoTo DALEJ
Case "BH" '  BH
Selection.Offset(0, 15).Value = Left(rExternal, 5) & "_" & prod & "_" & Right(ccount, 3)
Selection.Offset(0, 63).Value = "B" & external & Right(ccount, 2)
'  If Worksheets("Manula Order").Range("F1").Value = "TAK" Then Selection.Offset(0, 15).Value = Selection.Offset(0, 15).Value _
'& Selection.Offset(0, 63).Value

    GoTo DALEJ
    
Case "LE" '  LE
Selection.Offset(0, 63).Value = rExternal

'  If Range("F1").Value = "TAK" Then
'  Selection.Offset(0, 15).Value = Left(Selection.Offset(0, 15).Value, 9) & Right(Selection.Offset(0, 63).Value, 3) & "D"
'  Selection.Offset(0, 38).Value = "Extra"
'  Else
'  Selection.Offset(0, 15).Value = Left(Selection.Offset(0, 15).Value, 9) & Right(Selection.Offset(0, 63).Value, 4)
'  End If
    GoTo DALEJ


End Select

DALEJ:
    Selection.Offset(1, 0).Select
    
Loop
Application.Calculation = xlCalculationAutomatic
Application.ScreenUpdating = True


End Sub





