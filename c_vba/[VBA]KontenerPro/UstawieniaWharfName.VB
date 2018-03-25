Public Function wharfchanger(wharfcode As String)
Select Case wharfcode

'- - - - - - - - - L I S T A  K O D O W - - - - - - - - - -
'
' w kolumnie Ports of Arival moga pojawic sie skroty
'
' przykladem jest FXT
'
' ta funkcja zamienia napotkane FXT na inna wybrana nazwe
'
' jesli pojawi sie cos nowego po porstu dopisz linie jak w LISCIE KODOW
'
' pozdro
'
'- - - - - - - - - L I S T A  K O D O W - - - - - - - - - -
    Case "somename 1" ' < - - - - - - K O D  Z  I N P U T A
    wharfcode = "600" ' < -  N A  C O  Z A M I E N I C

    Case "920 somename"
    wharfcode = "920"

    Case "560 somename"
    wharfcode = "560"

    Case "810 somename somename"
    wharfcode = "810"

    Case "somename - somename"
    wharfcode = "700"

    Case "somename"
    wharfcode = "800"
    
    Case "___"
    wharfcode = "____"
    
    Case "___"
    wharfcode = "____"
    
    
    
    
    
    
'- - - - - - - - - L I S T A  K O D O W - - - - - - - - - -




End Select
End Function

