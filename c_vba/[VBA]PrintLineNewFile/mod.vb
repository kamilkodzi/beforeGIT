Sub generateCSV()

' v4 - 24.10.2017 - changes to support DPP upload

    Dim FilePath As String
    Dim FileName As String
    Dim Header As String
    Dim LDate As Date
    Dim DepotId As String
    Dim DepotName As String
    
    If Not IsEmpty(Worksheets(1).Range("D3")) Then
        DepotName = Worksheets(1).Range("D3")
    Else
        DepotName = Worksheets(1).Range("D4")
    End If
    
    If Not IsEmpty(Worksheets(1).Range("B3")) Then
        LDate = CDate(Worksheets(1).Range("B3"))
    Else
        LDate = CDate(Worksheets(1).Range("B4"))
    End If
    
    If Not IsEmpty(DepotName) Then
        If DepotName = "3" Or DepotName = "7" Then
            DepotId = "3_4"
        ElseIf DepotName = "7" Or DepotName = "8" Then
            DepotId = "7_8"
        ElseIf DepotName = "10" Or DepotName = "9" Then
            DepotId = "10_9"
        Else
            DepotId = DepotName
        End If
    End If
    
    FileName = "File_" & DepotId & "_" & Format(LDate, "ddmmyyyy") & "_" & Format(DateTime.Now, "YYYYMMDDHHMMSS") & ".csv"

    FilePath = ActiveWorkbook.Path & "\" & FileName
    Open FilePath For Output As #2
    
    StartString = "volume_type;delivery_date;dest_id;source_id;Pallets;Rollcages;Order_id;Cube;Cases;Sequence"
    Print #2, StartString
    
    If Not IsEmpty(Worksheets(1).Range("A3").Value) Then
        Worksheets(1).Range("A3").Select
    Else
        Worksheets(1).Range("A4").Select
    End If
    
    Worksheets(1).Range("A3").Select
    
    Do Until IsEmpty(ActiveCell)
        LDate = CDate(ActiveCell.Offset(0, 1).Value)
        LStoreId = CLng(ActiveCell.Offset(0, 2).Value)
        LWarehouseId = CLng(ActiveCell.Offset(0, 3).Value)
        
        If (ActiveCell.Offset(0, 4).Value) <> "" Then
            LPallets = CDbl(ActiveCell.Offset(0, 4).Value)
        Else
            LPallets = ""
        End If
        If (ActiveCell.Offset(0, 5).Value) <> "" Then
            LRollcages = CDbl(ActiveCell.Offset(0, 5).Value)
        Else
            LRollcages = ""
        End If
        If (ActiveCell.Offset(0, 7).Value) <> "" Then
            LCube = CDbl(ActiveCell.Offset(0, 7).Value)
        Else
            LCube = ""
        End If
        If (ActiveCell.Offset(0, 8).Value) <> "" Then
            LCases = CDbl(ActiveCell.Offset(0, 8).Value)
        Else
            LCases = ""
        End If
        
        Kind = Trim(ActiveCell.Value) & ";"
        ISD = Format(LDate, "yyyy-mm-dd") & ";"
        StoreId = LStoreId & ";"
        WarehouseId = LWarehouseId & ";"
        Pallets = Replace(LPallets, ",", ".") & ";"
        Rollcages = Replace(LRollcages, ",", ".") & ";"
        OrderId = Trim(ActiveCell.Offset(0, 6).Value) & ";"
        Cube = Replace(LCube, ",", ".") & ";"
        Cases = Replace(LCases, ",", ".") & ";"
        Sequence = Trim(ActiveCell.Offset(0, 9).Value)
      
        rowData = Kind & ISD & StoreId & WarehouseId & Pallets & Rollcages & OrderId & Cube & Cases & Sequence
        
        Print #2, rowData
        
        If Not IsEmpty(ActiveCell.Offset(1, 0)) Then
            ActiveCell.Offset(1, 0).Select
        Else
            ActiveCell.Offset(2, 0).Select
        End If
    Loop
    
    MsgBox ("Done!!!")
    
    Close #2
End Sub