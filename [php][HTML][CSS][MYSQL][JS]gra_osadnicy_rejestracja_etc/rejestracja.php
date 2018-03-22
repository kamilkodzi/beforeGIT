<?php
session_start();

	if(isset($_POST['email']))
	{
		//udana walidacja? Załóżmy, że tak!
		$wszystko_OK=true;
		
		//Sprawdzanie poprawnosci nickname
		$nick=$_POST['nick'];
		
		//sprawdzenie długości nika
		if((strlen($nick)<3) || (strlen($nick)>20))
		{
			$wszystko_OK=false;
			$_SESSION['e_nick']="Nick musi posiadać od 3 do 20 znaków";
		}
		if(ctype_alnum($nick)==false)
		{
			$wszystko_OK=false;
			$_SESSION['e_nick']="Nick może składać się tylko z liter i cyfr (bez polskich znaków)";
		}
		
		
		//sprawdź poprawnosc adresu e-mial 
		$email=$_POST['email'];
		$emailB=filter_var($email,FILTER_SANITIZE_EMAIL);
		
		if((filter_var($emailB,FILTER_VALIDATE_EMAIL)==false) || ($emailB!=$email))
		{
				$wszystko_OK=false;
				$_SESSION['e_email']="Podaj poprawy adres e-mial";
		}
		
		//Sprawdź poprawność hasła
		$haslo1=$_POST['haslo1'];
		$haslo2=$_POST['haslo2'];
		
		if ((strlen($haslo1)<8)|| (strlen($haslo1)>20))
		{
				$wszystko_OK=false;
				$_SESSION['e_haslo']="Haslo musi posiadać od 8 do 20 znaków!";			
		}
		
		if($haslo1!=$haslo2) 
		{
				$wszystko_OK=false;
				$_SESSION['e_haslo']="Podane hasła nie sa identyczne!";			
		}		
		
		$haslo_hash = password_hash($haslo1,PASSWORD_DEFAULT);
	
		//czy zaakceptowano regulamin
		
		if(!isset($_POST['regulamin']))
		{
			$wszystko_OK=false;
			$_SESSION['e_regulamin']="Potwerdź akceptację regulaminu";
		}
		
		
		require_once"connect.php";
		mysqli_report(MYSQLI_REPORT_STRICT);
		try 
		{
			$polaczenie = new mysqli($host,$db_user,$db_password,$db_name);
			if($polaczenie->connect_errno!=0)
			{
				throw new Exception (mysqli_connect_errno());
			}
			else
			{
				//czy emial juz istnieje
				$rezultat=$polaczenie->query("SELECT id FROM uzytkownicy WHERE email='$email'");
				if (!$rezultat)throw new Exception($polaczenie->error);
				
				$ile_takich_maili=$rezultat->num_rows;
				
					if($ile_takich_maili>0)
					{
						$wszystko_OK=false;
						$_SESSION['e_email']="Istnieje już konto przypisane do tego adresu e-mail";
					}
					
					
					//czy nick juz istnieje
				$rezultat=$polaczenie->query("SELECT id FROM uzytkownicy WHERE user='$nick'");
				
				if (!$rezultat)throw new Exception($polaczenie->error);
				
				$ile_takich_nikow=$rezultat->num_rows;
				
					if($ile_takich_nikow>0)
					{
						$wszystko_OK=false;
						$_SESSION['e_nick']="Istnieje już gracz o takim niku- wybierz inny";
					}
					
					
					if($wszystko_OK==true)
					{
					//wszystko ok dodajemy usera do bazy
							if($polaczenie->query("INSERT INTO uzytkownicy VALUES (NULL,'$nick','$haslo_hash','$email',100,100,100,now() + INTERVAL 14 DAY)"))
										  
							{
								$_SESSION['udanarejestracja']=true;
								header('Location: witamy.php');
								
							}
							else
							{
								throw new Exception($polaczenie->error);
							}
					}
					
					
				
				$polaczenie->close();
			}
		}
		catch(Exception $e)
		{
			echo 'Błąd serwera! Przepraszamy za niedogodności i prosimy o rejestracje w innym terminie';
			//echo '<br/>Informacja developerska:'.$e;
		}
		
	
		
	
}
	
	

?>



<!DOCTYPE HTML>
<html lang="pl">
<head>
<meta charset="utf-8"/>
<title>Osadnicy - załóż darmowe konto</title>
<style>

.error
{
	color:red;
	margin-top: 10px;
	margin-bottom: 10px;
}

</style>

</head>
<body>
	
	<form method="post">
	
	Nickname:<br/><input type="text" name="nick"/><br/>
	<?php
		if(isset($_SESSION['e_nick']))
		{
			echo '<div class="error">'.$_SESSION['e_nick'].'</div>';
			unset($_SESSION['e_nick']);
		}
	?>
	
	E-mail:<br/><input type="text" name="email"/><br/>
	<?php
		if(isset($_SESSION['e_email']))
		{
			echo '<div class="error">'.$_SESSION['e_email'].'</div>';
			unset($_SESSION['e_email']);
		}
	?>
	
	Twoje hasło:<br/><input type="password" name="haslo1"/><br/>
	<?php
		if(isset($_SESSION['e_haslo']))
		{
			echo '<div class="error">'.$_SESSION['e_haslo'].'</div>';
			unset($_SESSION['e_haslo']);
		}
	?>	
	Powtórz hasło:<br/><input type="password" name="haslo2"/><br/>
	
	<label>
	<input type="checkbox"name="regulamin"/> Akceptuje regulamin
	</label>
		<?php
		if(isset($_SESSION['e_regulamin']))
		{
			echo '<div class="error">'.$_SESSION['e_regulamin'].'</div>';
			unset($_SESSION['e_regulamin']);
		}
	?>	
	

	
	
	<input type="submit" value="Zarejestruj się"/>
	
	</form>


	
	
</body>
</html>