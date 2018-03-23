<?php
	
	session_start();
	
	if(!isset($_SESSION['zalogowany']))
	{
		header('Location:index.php');
		exit();
	}
	
?>	


<!DOCTYPE HTML>
<html lang="pl">
<head>
<meta charset="utf-8"/>
<title>Osadnicy - gra przeglądarkowa</title>
</head>
<body>

<?php

	echo "<p>Witaj ".$_SESSION['user'].'! <a href="logout.php">[wyloguj]</a></p>';
	echo "<p><b>Drewno</b>: ".$_SESSION['drewno'];
	echo "|<b> Kamień</b>: ".$_SESSION['kamien'];
	echo "|<b> Zboże</b>: ".$_SESSION['zboze']."</p>";
	
	echo "<p><b>E-mail</b>: ".$_SESSION['email'];
	echo "<br/><b>Data wygaśnięcia premium</b>: ".$_SESSION['dnipremium']."</p>";

	$dataczas=new DateTime();
	echo "Data i czas serwera: ".$dataczas->format('Y-m-d H:i:s')."<br/>";
	
	$koniec = DateTime::createFromFormat('Y-m-d H:i:s',$_SESSION['dnipremium']);
	$roznica= $dataczas->diff($koniec);
	
	if ($dataczas<$koniec)
	echo "Pozostało premium: ".$roznica->format('%y year,%m mies ,%d dni, %h godz, %i min, %s sek');
	else
	echo "Premium nieaktywne od: ".$roznica->format('%y year,%m mies ,%d dni, %h godz, %i min, %s sek');
	
?>


</body>
</html>