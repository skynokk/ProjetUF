<?php
include('connexion.php');

$whereField = $_POST['whereField'];
$whereCondition = $_POST['whereCondition'];

$sql = "delete from level where ".$whereField."='".$whereCondition."'";
$result = mysqli_query($connect, $sql);
?>