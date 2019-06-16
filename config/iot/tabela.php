<?php
header('Content-Type: text/html; charset=utf-8');
?>

<script>
function goBack() {
  window.history.back()
}
</script>
<html lang="en">
<head>
	<title>ArqDB</title>
	<meta charset="UTF-8">
  <meta http-equiv="Content-type" content="text/html; charset=utf-8" />
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
$dbname = "arq_db";

$conn = new mysqli($servername, $username, $password, $dbname);
// Check connection
if ($conn->connect_error) {
   die("Connection failed: " . $conn->connect_error);
}
mysqli_set_charset($conn,"utf8");

$sql = "select * from items";
$recordset = mysqli_query($conn, $sql);

$row_Recordset = mysqli_fetch_assoc($recordset);
echo "<div class='limiter'>
		<div class='container-table100'>
			<div class='wrap-table100'>
				<div class='table100 ver2 m-b-110'>";
echo "<table data-vertable='ver2' align='center'>";
echo "<table data-vertable='ver2' align='center'>
	<thead>
		<tr class='row100 head'>
			<th class='column100 column1' data-column='column1'>Cod</th>
			<th class='column100 column2' data-column='column2'>Data</th>
			<th class='column100 column3' data-column='column3'>Concelho</th>
			<th class='column100 column6' data-column='column6'>Periodo</th>
			<th class='column100 column7' data-column='column7'>Matéria Prima</th>
			<th class='column100 column8' data-column='column8'>Descrição</th>
      <th class='column100 column9' data-column='column9'>Suporte</th>
      <th class='column100 column10' data-column='column10'>Tecnologia</th>
      <th class='column100 column11' data-column='column11'>Comprimento</th>
      <th class='column100 column12' data-column='column12'>Largura</th>
      <th class='column100 column13' data-column='column13'>Espessura</th>
      <th class='column100 column14' data-column='column14'>Latitude</th>
      <th class='column100 column15' data-column='column15'>Longitude</th>
		</tr>
	</thead>
	<tbody>";
  mysqli_query($conn, "SET NAMES 'utf8'");
	$i = 0;
	do {
		$i += 1;
		echo "<tr class='row100'>";
		echo "<td class='column100 column$i' data-column='column$i'>".$row_Recordset['Cod']."</td>";
		echo "<td class='column100 column$i' data-column='column$i'>".$row_Recordset['Date']."</td>";
		echo "<td class='column100 column$i' data-column='column$i'>".$row_Recordset['TownHall']."</td>";
		echo "<td class='column100 column$i' data-column='column$i'>".$row_Recordset['Epoch']."</td>";
		echo "<td class='column100 column$i' data-column='column$i'>".$row_Recordset['RawMaterial']."</td>";
    echo "<td class='column100 column$i' data-column='column$i'>".$row_Recordset['Description']."</td>";
    echo "<td class='column100 column$i' data-column='column$i'>".$row_Recordset['Base']."</td>";
    echo "<td class='column100 column$i' data-column='column$i'>".$row_Recordset['Technology']."</td>";
    echo "<td class='column100 column$i' data-column='column$i'>".$row_Recordset['Length']."</td>";
    echo "<td class='column100 column$i' data-column='column$i'>".$row_Recordset['Width']."</td>";
    echo "<td class='column100 column$i' data-column='column$i'>".$row_Recordset['Thickness']."</td>";
    echo "<td class='column100 column$i' data-column='column$i'>".$row_Recordset['Latitude']."</td>";
    echo "<td class='column100 column$i' data-column='column$i'>".$row_Recordset['Longitude']."</td>";?>
		<!--echo "<td class='column100 column$i' data-column='column$i'>";?><input type="button" onClick="deleteme(<?php/* echo $row_Recordset['Cod'];*/?>)" name="Delete" value="Eliminar">*/-->
	<?php echo "</td></tr>";
	} while ($row_Recordset = mysqli_fetch_assoc($recordset));
echo "</tbody>";
echo "</table></div>";
mysqli_free_result($recordset);
mysqli_close($conn);
//echo "<input type='button' onClick = 'goBack()' value='Voltar' style='background-color: #32CD32;'>";
?>
<script language="javascript">
function deleteme(delid){
	if (confirm("Do you want to Delete?")){
		window.location.href = "delete_id.php?del_id="+delid+"";
		return true;
	}
}
</script>
</body>
</html>
