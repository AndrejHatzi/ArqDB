Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Drawing.Imaging
Imports System.Data.SqlClient
Module io
    Public Function CreateOptions(ByVal ParamArray args As String()) As Integer
        ''Dim file As System.IO.StreamWriter
        ' ''Dim path As String = Application.StartupPath.ToLower.Replace("\bin\debug", "").Replace("\bin\release", "").Replace("\ArqDB-master\ArqDB", "")
        ''Dim path As String = Application.StartupPath.Replace("\ArqDB\bin\Debug", "")
        ''path = path.Replace("\ArqDB\bin\Debug", "")
        ''MessageBox.Show(path)
        ''file = My.Computer.FileSystem.OpenTextFileWriter(path, True)
        ''For Each i As String In args
        ''    file.WriteLine(i)
        ''Next
        ''file.Close()
        ''Return 1
        'Dim sTextFile As New System.Text.StringBuilder

        'sTextFile.AppendLine("The")
        'sTextFile.AppendLine("brown")
        'sTextFile.AppendLine("fox")
        'sTextFile.AppendLine("jumps")
        'Dim path As String = Application.StartupPath.Replace("\ArqDB\bin\Debug", "")
        'path = path.Replace("\ArqDB\bin\Debug", "")
        ''Dim sFileName As String = "C:\test.txt"

        'System.IO.File.AppendAllText(path, sTextFile.ToString)
        Return 1
    End Function
    Public Sub LacksText()

    End Sub


    Public Sub CreateMapHTML(latitude As String, longitude As String, IconColour As String, Label As String)
        Dim file As System.IO.StreamWriter
        Dim path As String = My.Application.Info.DirectoryPath
        Dim relpath As String
        'F:\UI_ARQDB\ArqDB-master\ArqDB\bin\Debug
        relpath = path.Replace("\ArqDB-master\ArqDB\bin\Debug", "\ArqDB-master\config\teste.html")
        Try
            My.Computer.FileSystem.DeleteFile(relpath)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        file = My.Computer.FileSystem.OpenTextFileWriter(relpath, True)
        file.WriteLine("<head>")
        file.WriteLine("<meta http-equiv='content-type' content='text/html; charset=UTF-8' />")
        file.WriteLine(" <title>Teste</title>")
        file.WriteLine("<script>")
        file.WriteLine("    L_NO_TOUCH = false;")
        file.WriteLine("    L_DISABLE_3D = false;")
        file.WriteLine("</script>")
        file.WriteLine("<script src='https://cdn.jsdelivr.net/npm/leaflet@1.4.0/dist/leaflet.js'></script>")
        file.WriteLine("<script src='https://code.jquery.com/jquery-1.12.4.min.js'></script>")
        file.WriteLine("<script src='https://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/js/bootstrap.min.js'></script>")
        file.WriteLine("<script src='https://cdnjs.cloudflare.com/ajax/libs/Leaflet.awesome-markers/2.0.2/leaflet.awesome-markers.js'></script>")
        file.WriteLine("<link rel='stylesheet' href='https://cdn.jsdelivr.net/npm/leaflet@1.4.0/dist/leaflet.css'/>")
        file.WriteLine("<link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css'/>")
        file.WriteLine("<link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap-theme.min.css'/>")
        file.WriteLine("<link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/font-awesome/4.6.3/css/font-awesome.min.css'/>")
        file.WriteLine("<link rel='stylesheet' href='https://cdnjs.cloudflare.com/ajax/libs/Leaflet.awesome-markers/2.0.2/leaflet.awesome-markers.css'/>")
        file.WriteLine("<link rel='stylesheet' href='https://rawcdn.githack.com/python-visualization/folium/master/folium/templates/leaflet.awesome.rotate.css'/>")
        file.WriteLine("<style>html, body {width: 100%;height: 100%;margin: 0;padding: 0;}</style>")
        file.WriteLine("<style>#map {position:absolute;top:0;bottom:0;right:0;left:0;}</style>")
        file.WriteLine("<meta name='viewport' content='width=device-width,initial-scale=1.0, maximum-scale=1.0, user-scalable=no'/>")
        file.WriteLine("<style>")
        file.WriteLine("#map_8d82423173704cfe89ef80a2889ff409 {")
        file.WriteLine("position: relative;")
        file.WriteLine("width: 100.0%;")
        file.WriteLine("height: 100.0%;")
        file.WriteLine("left: 0.0%;")
        file.WriteLine("top: 0.0%;")
        file.WriteLine("}")
        file.WriteLine("</style>")
        file.WriteLine("</head>")
        file.WriteLine("<body>")
        file.WriteLine("<div class='folium-map' id='map_8d82423173704cfe89ef80a2889ff409' ></div>")
        file.WriteLine("</body>")
        file.WriteLine("<script>")
        file.WriteLine("var map_8d82423173704cfe89ef80a2889ff409 = L.map(")
        file.WriteLine("'map_8d82423173704cfe89ef80a2889ff409',")
        file.WriteLine("{")
        file.WriteLine("center: [52.2322, 21.0083],")
        file.WriteLine("crs: L.CRS.EPSG3857,")
        file.WriteLine("zoom: 4,")
        file.WriteLine("zoomControl: true,")
        file.WriteLine("preferCanvas: false,")
        file.WriteLine("}")
        file.WriteLine(");")
        file.WriteLine("var tile_layer_73e75f2f86ae4aa2bf8edbf4e6fb96e8 = L.tileLayer(")
        file.WriteLine("'https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png',")
        file.WriteLine("  {'attribution': 'Data by \u0026copy; \u003ca href=\'http://openstreetmap.org\'\u003eOpenStreetMap\u003c/a\u003e, under \u003ca href=\'http://www.openstreetmap.org/copyright\'\u003eODbL\u003c/a\u003e.', 'detectRetina': false, 'maxNativeZoom': 18, 'maxZoom': 18, 'minZoom': 0, 'noWrap': false, 'opacity': 1, 'subdomains': 'abc', 'tms': false}")
        file.WriteLine(").addTo(map_8d82423173704cfe89ef80a2889ff409);")
        file.WriteLine("var marker_8fa4876c4c5a4efdbd005aecc64c5ce1 = L.marker(")
        file.WriteLine("  [" & latitude & "," & longitude & "],")
        file.WriteLine("{}")
        file.WriteLine(").addTo(map_8d82423173704cfe89ef80a2889ff409);")
        file.WriteLine("var icon_fe71723e2c9e4224bcf8b3218b987430 = L.AwesomeMarkers.icon(")
        file.WriteLine("{'extraClasses': 'fa-rotate-0', 'icon': 'info-sign', 'iconColor': 'white', 'markerColor': '" & IconColour & "', 'prefix': 'glyphicon'}")
        file.WriteLine(");")
        file.WriteLine("marker_8fa4876c4c5a4efdbd005aecc64c5ce1.setIcon(icon_fe71723e2c9e4224bcf8b3218b987430);")
        file.WriteLine("popup_e314ff6cfb16410bbc2a3a1f88cd2425 = L.popup({'maxWidth': '100%'});")
        file.WriteLine("var html_894d79bdf3f046df8497af07e4e63b32 = $(`<div id='html_894d79bdf3f046df8497af07e4e63b32' style='width: 100.0%; height: 100.0%;'>" & Label & "</div>`)[0];")
        file.WriteLine("popup_e314ff6cfb16410bbc2a3a1f88cd2425.setContent(html_894d79bdf3f046df8497af07e4e63b32);")
        file.WriteLine("marker_8fa4876c4c5a4efdbd005aecc64c5ce1.bindPopup(popup_e314ff6cfb16410bbc2a3a1f88cd2425);")
        file.WriteLine("</script>")
        file.Close()
        Dim webAddress As String = relpath
        Process.Start(webAddress)
    End Sub
    Public Function CreateMapMultipleLocations() As Boolean
        Dim conexao As New MySqlConnection()
        Dim adaptador As New MySqlDataAdapter
        Dim registos As MySqlDataReader
        'Dim result As String
        Dim Sql As String
        Dim i As Integer
        Dim file As System.IO.StreamWriter
        Dim path As String = My.Application.Info.DirectoryPath
        Dim relpath As String
        'F:\UI_ARQDB\ArqDB-master\ArqDB\bin\Debug
        relpath = path.Replace("\ArqDB-master\ArqDB\bin\Debug", "\ArqDB-master\config\Maps.html")
        My.Computer.FileSystem.DeleteFile(relpath)

        file = My.Computer.FileSystem.OpenTextFileWriter(relpath, True)
        file.WriteLine("<head>")
        file.WriteLine("<meta http-equiv='content-type' content='text/html; charset=UTF-8' />")
        file.WriteLine(" <title>Teste</title>")
        file.WriteLine("<script>")
        file.WriteLine("    L_NO_TOUCH = false;")
        file.WriteLine("    L_DISABLE_3D = false;")
        file.WriteLine("</script>")
        file.WriteLine("<script src='https://cdn.jsdelivr.net/npm/leaflet@1.4.0/dist/leaflet.js'></script>")
        file.WriteLine("<script src='https://code.jquery.com/jquery-1.12.4.min.js'></script>")
        file.WriteLine("<script src='https://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/js/bootstrap.min.js'></script>")
        file.WriteLine("<script src='https://cdnjs.cloudflare.com/ajax/libs/Leaflet.awesome-markers/2.0.2/leaflet.awesome-markers.js'></script>")
        file.WriteLine("<link rel='stylesheet' href='https://cdn.jsdelivr.net/npm/leaflet@1.4.0/dist/leaflet.css'/>")
        file.WriteLine("<link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css'/>")
        file.WriteLine("<link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap-theme.min.css'/>")
        file.WriteLine("<link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/font-awesome/4.6.3/css/font-awesome.min.css'/>")
        file.WriteLine("<link rel='stylesheet' href='https://cdnjs.cloudflare.com/ajax/libs/Leaflet.awesome-markers/2.0.2/leaflet.awesome-markers.css'/>")
        file.WriteLine("<link rel='stylesheet' href='https://rawcdn.githack.com/python-visualization/folium/master/folium/templates/leaflet.awesome.rotate.css'/>")
        file.WriteLine("<style>html, body {width: 100%;height: 100%;margin: 0;padding: 0;}</style>")
        file.WriteLine("<style>#map {position:absolute;top:0;bottom:0;right:0;left:0;}</style>")
        file.WriteLine("<meta name='viewport' content='width=device-width,initial-scale=1.0, maximum-scale=1.0, user-scalable=no'/>")
        file.WriteLine("<style>")
        file.WriteLine("#map_8d82423173704cfe89ef80a2889ff409 {")
        file.WriteLine("position: relative;")
        file.WriteLine("width: 100.0%;")
        file.WriteLine("height: 100.0%;")
        file.WriteLine("left: 0.0%;")
        file.WriteLine("top: 0.0%;")
        file.WriteLine("}")
        file.WriteLine("</style>")
        file.WriteLine("</head>")
        file.WriteLine("<body>")
        file.WriteLine("<div class='folium-map' id='map_8d82423173704cfe89ef80a2889ff409' ></div>")
        file.WriteLine("</body>")
        file.WriteLine("<script>")
        file.WriteLine("var map_8d82423173704cfe89ef80a2889ff409 = L.map(")
        file.WriteLine("'map_8d82423173704cfe89ef80a2889ff409',")
        file.WriteLine("{")
        file.WriteLine("center: [52.2322, 21.0083],")
        file.WriteLine("crs: L.CRS.EPSG3857,")
        file.WriteLine("zoom: 4,")
        file.WriteLine("zoomControl: true,")
        file.WriteLine("preferCanvas: false,")
        file.WriteLine("}")
        file.WriteLine(");")
        file.WriteLine("var tile_layer_73e75f2f86ae4aa2bf8edbf4e6fb96e8 = L.tileLayer(")
        file.WriteLine("'https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png',")
        file.WriteLine("  {'attribution': 'Data by \u0026copy; \u003ca href=\'http://openstreetmap.org\'\u003eOpenStreetMap\u003c/a\u003e, under \u003ca href=\'http://www.openstreetmap.org/copyright\'\u003eODbL\u003c/a\u003e.', 'detectRetina': false, 'maxNativeZoom': 18, 'maxZoom': 18, 'minZoom': 0, 'noWrap': false, 'opacity': 1, 'subdomains': 'abc', 'tms': false}")
        file.WriteLine(").addTo(map_8d82423173704cfe89ef80a2889ff409);")
        Sql = "SELECT Latitude, Longitude, Colour, Label from markers"
        conexao = New MySqlConnection
        conexao.ConnectionString = "SERVER=localhost; user=root; password=''; database=arq_db"
        Dim comando As MySqlCommand = New MySqlCommand(Sql, conexao)
        Try
            conexao.Open()
            Try
                registos = comando.ExecuteReader
                While registos.Read
                    'MessageBox.Show(registos("Latitude").ToString() & registos("Longitude").ToString() & registos("Colour").ToString() & registos("Label").ToString())
                    'comboBox.Items.add(registos(CStr(dname)).ToString)
                    'MessageBox.Show(registos("Latitude").ToString() & registos("Longitude").ToString() & registos("Colour").ToString() & registos("Label").ToString())
                    i += 1
                    file.WriteLine("var meu_marcador" & i & " = L.marker(")
                    file.WriteLine("  [" & registos("Latitude").ToString().Replace(",", ".") & "," & registos("Longitude").ToString().Replace(",", ".") & "],")
                    file.WriteLine("{}")
                    file.WriteLine(").addTo(map_8d82423173704cfe89ef80a2889ff409);")
                    file.WriteLine("var meu_icon" & i & " = L.AwesomeMarkers.icon(")
                    file.WriteLine("{'extraClasses': 'fa-rotate-0', 'icon': 'info-sign', 'iconColor': 'white', 'markerColor': '" & registos("Colour").ToString() & "', 'prefix': 'glyphicon'}")
                    file.WriteLine(");")
                    file.WriteLine("meu_marcador" & i & ".setIcon(meu_icon" & i & ");")
                    file.WriteLine("meu_popup" & i & " = L.popup({'maxWidth': '100%'});")
                    file.WriteLine("var meuhtml" & i & " = $(`<div id='meuhtml" & i & "' style='width: 100.0%; height: 100.0%;'>" & registos("Label").ToString() & "</div>`)[0];")
                    file.WriteLine("meu_popup" & i & ".setContent(meuhtml" & i & ");")
                    file.WriteLine("meu_marcador" & i & ".bindPopup(meu_popup" & i & ");")
                End While
                'MessageBox.Show(i)
                conexao.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Erro1")
                Return 0

            End Try
        Catch ex As Exception
            MessageBox.Show("Erro2", ex.Message)
            Return 0
        End Try
        file.WriteLine("</script>")
        file.Close()
        Dim webAddress As String = relpath
        Process.Start(webAddress)
    End Function
End Module
'Dim file As System.IO.StreamWriter
'file = My.Computer.FileSystem.OpenTextFileWriter("c:\test.txt", True)
'file.WriteLine("Here is the first string.")
'file.Close()
