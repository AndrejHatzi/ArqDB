<html lang="en">
<head>
	<title>Lista de Utilizadores</title>
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
<!--===============================================================================================-->
	<link rel="icon" type="image/png" href="images/icons/favicon.ico"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/bootstrap/css/bootstrap.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="fonts/font-awesome-4.7.0/css/font-awesome.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/animate/animate.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/select2/select2.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/perfect-scrollbar/perfect-scrollbar.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="css/util.css">
	<link rel="stylesheet" type="text/css" href="css/main.css">
<!--===============================================================================================-->
</head>
<body>
<!--===============================================================================================-->
	<script src="vendor/jquery/jquery-3.2.1.min.js"></script>
<!--===============================================================================================-->
	<script src="vendor/bootstrap/js/popper.js"></script>
	<script src="vendor/bootstrap/js/bootstrap.min.js"></script>
<!--===============================================================================================-->
	<script src="vendor/select2/select2.min.js"></script>
<!--===============================================================================================-->
	<script src="js/main.js"></script>

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
$sql = "select * from utilizador";
$recordset = mysqli_query($conn, $sql);

$row_Recordset = mysqli_fetch_assoc($recordset);
echo "<div class='limiter'>
		<div class='container-table100'>
			<div class='wrap-table100'>
				<div class='table100 ver2 m-b-110'>";
echo "<table data-vertable='ver2'>";
echo "<table data-vertable='ver2'>
	<thead>
		<tr class='row100 head'>
			<th class='column100 column1' data-column='column1'>Nome</th>
			<th class='column100 column2' data-column='column2'>Nif</th>
			<th class='column100 column3' data-column='column3'>Email</th>
			<th class='column100 column4' data-column='column4'>Morada</th>
			<th class='column100 column5' data-column='column5'>C. Postal</th>
			<th class='column100 column6' data-column='column6'>Localidade</th>
			<th class='column100 column7' data-column='column7'>Distrito</th>
			<th class='column100 column8' data-column='column8'>Telemóvel</th>
		</tr>
	</thead>
	<tbody>";
	$i = 0;
	do {
		$i += 1;
		echo "<tr class='row100'>";
		echo "<td class='column100 column$i' data-column='column$i'>".$row_Recordset['nome']."</td>";
		echo "<td class='column100 column$i' data-column='column$i'>".$row_Recordset['nif']."</td>";
		echo "<td class='column100 column$i' data-column='column$i'>".$row_Recordset['email']."</td>";
		echo "<td class='column100 column$i' data-column='column$i'>".$row_Recordset['morada']."</td>";
		echo "<td class='column100 column$i' data-column='column$i'>".$row_Recordset['codpostal']."</td>";
		echo "<td class='column100 column$i' data-column='column$i'>".$row_Recordset['localidade']."</td>";
		echo "<td class='column100 column$i' data-column='column$i'>".$row_Recordset['distrito']."</td>";
		echo "<td class='column100 column$i' data-column='column$i'>".$row_Recordset['telemovel']."</td>";
		echo "</tr>";?>
		<input type="button" onClick="deleteme(<?php echo $row_Recordset['nif'];?>)" name="Delete">
	<?php
	} while ($row_Recordset = mysqli_fetch_assoc($recordset));
echo "</tbody>";
echo "</table></div>";
mysqli_free_result($recordset);
mysqli_close($conn);
?>
<script language="javascript">
function deleteme(delid){
	if (confirm("Do you want to Delete?")){
		window.location.href = "delete_nif.php?del_id="+delid+"";
		return true;
	}
}
</script>
</body>
</html>
