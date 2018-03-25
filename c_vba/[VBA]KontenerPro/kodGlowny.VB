Option Base 1

Type InputFile

Added As Date
ContainerNum As String
Division As String
ContSize As String
PortofArival As String
Vessel As String
VoyageFlight As String
ShippingLine As String
ETAPortofArrival As String
WharfName As String
DoubleDrop As String
SlipSheet As String
TotalCntrCartonQty As String
SubCategory As String
ContainerLocation As String
HoldStatus As String
Priority As String
PinRelese As String
AdditionalTipInfo As String
DandS As String
TLRef As String
Haulier As String

End Type

Public Sub RoundedRectangle4_Click()

Dim m As Single
Dim i As Single
m = Application.WorksheetFunction.CountA(Sheet2.Range("B9:B9999"))
ReDim InputFile(m) As InputFile

r = 1
Do Until Sheet2.Cells(8 + r, 2) = ""

InputFile(r).Added = Sheet2.Cells(8 + r, 1)
InputFile(r).ContainerNum = Sheet2.Cells(8 + r, 2)
InputFile(r).Division = Sheet2.Cells(8 + r, 3)
InputFile(r).ContSize = Sheet2.Cells(8 + r, 4)
InputFile(r).PortofArival = Sheet2.Cells(8 + r, 5)
InputFile(r).Vessel = Sheet2.Cells(8 + r, 6)
InputFile(r).VoyageFlight = Sheet2.Cells(8 + r, 7)
InputFile(r).ShippingLine = Sheet2.Cells(8 + r, 8)
InputFile(r).ETAPortofArrival = Sheet2.Cells(8 + r, 9)
InputFile(r).WharfName = Sheet2.Cells(8 + r, 10)
InputFile(r).DoubleDrop = Sheet2.Cells(8 + r, 11)
InputFile(r).SlipSheet = Sheet2.Cells(8 + r, 12)
InputFile(r).TotalCntrCartonQty = Sheet2.Cells(8 + r, 13)
InputFile(r).SubCategory = Sheet2.Cells(8 + r, 14)
InputFile(r).ContainerLocation = Sheet2.Cells(8 + r, 15)
InputFile(r).HoldStatus = Sheet2.Cells(8 + r, 16)
InputFile(r).Priority = Sheet2.Cells(8 + r, 17)
InputFile(r).PinRelese = Sheet2.Cells(8 + r, 18)
InputFile(r).AdditionalTipInfo = Sheet2.Cells(8 + r, 19)
InputFile(r).DandS = Sheet2.Cells(8 + r, 20)
InputFile(r).TLRef = Sheet2.Cells(8 + r, 21)
InputFile(r).Haulier = Sheet2.Cells(8 + r, 22)

r = r + 1
Loop

'1
' W P R O W A D Z A N I E - - Z M I A N - - P O R T U
For i = LBound(InputFile) To UBound(InputFile)
    zmiana1 = portchanger(InputFile(i).PortofArival)
    Debug.Print InputFile(i).PortofArival
Next i
' W P R O W A D Z A N I E - - Z M I A N - - P O R T U
'2
' W P R O W A D Z A N I E - - Z M I A N - - W H A R F
For i = LBound(InputFile) To UBound(InputFile)
    zmiana2 = wharfchanger(InputFile(i).WharfName)
    Debug.Print InputFile(i).WharfName
Next i
' W P R O W A D Z A N I E - - Z M I A N - - W H A R F




End Sub
