<?php
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "bd_joalheria";

$conn = new mysqli($servername, $username, $password, $dbname);
// Check connection
if ($conn->connect_error) {
   die("Connection failed: " . $conn->connect_error);
}

$aviso = "Nao foi possivel apagar o registo";
$select = "delete from utilizador where nif='".$_GET['del_id']."'";
$query = mysqli_query($conn, $select) or die($aviso);
mysqli_close($conn);
header("Location listar.php");?>
