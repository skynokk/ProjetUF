<?php
include('connexion.php');

$sql = "select nom, createur, creation, resultat from level";
$result = mysqli_query($connect, $sql);

if(mysqli_num_rows($result)>0){
    while($row = mysqli_fetch_assoc($result)){
        echo "nom:".$row['nom']."|createur".$row['createur']."|creation".$row['creation']."|resultat".$row['resultat'].";";
    }
}
?>