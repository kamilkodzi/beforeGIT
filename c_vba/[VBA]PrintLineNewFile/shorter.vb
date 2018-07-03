Option Explicit
Sub CreateImportCSV()
Dim head As String, FilePath As String, Depot As String, Store As String, TWStart As String, TWEnd As String, Row As String, x As Long

Application.ScreenUpdating = False

FilePath = ActiveWorkbook.Path & "\TW for " & Format(DateTime.Now, "dd.mm.yyyy") & ".csv"

Open FilePath For Output As #1

head = "Source Id;Delivery Pattern;Dest Id;Container Type;Lead Time;Load Unit;Uda01<BR>;Max Load;Uda02<BR>;Uda03<BR>;Uda08<BR>;Uda09<BR>;Pnb lead time;Tw start;Tw end;Capability;Hub tw start;Hub tw end"

Print #1, head

x = 2

Do While Not IsEmpty(Sheets("TW").Range("A" & x))

Sheets("TW").Range("A" & x).Select

Depot = ActiveCell.Value
Store = ActiveCell.Offset(0, 1).Value
TWStart = Format(ActiveCell.Offset(0, 2).Value, "hhmm")
TWEnd = Format(ActiveCell.Offset(0, 3).Value, "hhmm")


Row = Depot & ";;" & Store & ";;;;;;;;;;;" & TWStart & ";" & TWEnd & ";;;;"
Print #1, Row

x = x + 1

Loop
Close #1

Application.ScreenUpdating = True

End Sub
