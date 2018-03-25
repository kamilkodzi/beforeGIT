<!DOCTYPE HTML>
<html lang="pl">
<head>
<meta charset="utf-8"/>
<title>Dział planowania transportu</title>


<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.2/css/bootstrap.min.css" integrity="sha384-PsH8R72JQ3SOdhVi3uxftmaW6Vc51MKb0q5P2rRUpPvrszuE4W1povHYgTpBfshb" crossorigin="anonymous">

</head>
<body>
<div class="center">

	<h1>Zamówienie online</h1>
	<form action="order.php" method="POST">
	Ile planistów (0.99 PLN/szt):
	<input type="text" name="paczkow"/>
	<br/><br/>
	Ile kierowników (1.29 PLN/szt):
	<input type="text" name="grzebieni"/>
	<br/><br/>
	
	<input type="submit" value="Wyślij zamówienie"/>
	</form>
</div>

<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.2/js/bootstrap.min.js" integrity="sha384-alpBpkh1PFOepccYVYDB4do5UnbKysX5WZXm3XxPqe5iKTfUKjNkCk9SaVuEZflJ" crossorigin="anonymous"></script>
</body>