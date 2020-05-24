<?php
include('connexion.php');

$nom = $_POST['editNom'];
$createur = $_POST['editCreateur'];
$creation = $_POST['editCreation'];
$resultat = $_POST['editResultat'];

$whereField = $_POST['whereField'];
$whereCondition = $_POST['whereCondition'];

$sql = "update level set nom='".$nom."',createur='".$createur."',creation='".$creation."',resultat='".$resultat."' where ".$whereField."='".$whereCondition."'";
mysqli_query($connect, $sql);
?>