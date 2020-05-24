<?php
include('connexion.php');

$nom = $_POST['addNom'];
$createur = $_POST['addCreateur'];
$creation = $_POST['addCreation'];
$resultat = $_POST['addResultat'];

$sql = "insert into level(nom, createur, creation, resultat) values ('".$nom."','".$createur."','".$creation."','".$resultat."')";
$result = mysqli_query($connect, $sql);
?>