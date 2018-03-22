<!DOCTYPE HTML>
<html lang="pl">
<head>
<meta charset="utf-8"/>
<title>Podsumowanie zamówienia</title>
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.2/css/bootstrap.min.css" integrity="sha384-PsH8R72JQ3SOdhVi3uxftmaW6Vc51MKb0q5P2rRUpPvrszuE4W1povHYgTpBfshb" crossorigin="anonymous">
</head>
<body>

<?php

	$paczkow=$_POST['paczkow'];
	$grzebieni=$_POST['grzebieni'];
	$suma=0.99*$paczkow + 1.29*$grzebieni;

echo<<<END

	<h2>Podsumowanie zamówienia</h2>
	
	<table border="1" cellpadding="10" cellspacing="0">
	
		<tr>
			<td>Pączek (0.99PLN/szt)</td><td>$paczkow</td>
		</tr>
		
		<tr>
			<td>Grzebień (1.29PLN/szt)</td><td>$grzebieni</td>
		</tr>
		
		<tr>
			<td>SUMA</td><td>$suma PLN</td>
		</tr>
		
	</table>
	<br><a href="index.php">Powrot do strony głównej</a>
	
	
END;

?>



<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.2/js/bootstrap.min.js" integrity="sha384-alpBpkh1PFOepccYVYDB4do5UnbKysX5WZXm3XxPqe5iKTfUKjNkCk9SaVuEZflJ" crossorigin="anonymous"></script>
</body>
</html>