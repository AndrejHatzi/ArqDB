Public Class options
    Dim TopMenu As Boolean
    Public language As Integer
    Private Sub OptionPortuguese_Click(sender As Object, e As EventArgs) Handles OptionPortuguese.Click
        language = 0
        'Form1 - Main Buttons
        Form1.Homepage1.WelcomeSentence.Text = "Bem-vindo ao ArqDB"
        Form1.BtnHome.Text = "Home"
        Form1.BtnBD.Text = "Base de Dados"
        Form1.BtnDetetor.Text = "Detetor de Minerais"
        Form1.BtnMapStudio.Text = "Map Studio"
        Form1.BtnOptions.Text = "Opções"
        Form1.BtnAbout.Text = "Acerca de"
        'Form1 - Top Menu
        Form1.BtnHomeSmall.Text = "Home"
        Form1.BtnBDSmall.Text = "Base de Dados"
        Form1.BtnDetetorSmall.Text = "Detetor Minerais"
        Form1.BtnMapStudioSmall.Text = "Map Studio"
        Form1.BtnOptionsSmall.Text = "Opções"
        Form1.BtnAboutSmall.Text = "Acerca de"
        'Options
        LabelLanguage.Text = "Idioma"
        SempreTopo.Text = "Menu no Topo"
        'db_form
        Form1.Db_form1.Labelcodigo.Text = "Código"
        Form1.Db_form1.Labeldata.Text = "Data"
        Form1.Db_form1.LabelConcelho.Text = "Concelho"
        Form1.Db_form1.LabelFreguesia.Text = "Freguesia"
        Form1.Db_form1.LabelLugar.Text = "Lugar"
        Form1.Db_form1.LabelPeriodo.Text = "Periodo"
        Form1.Db_form1.LabelMateriaPrima.Text = "Matéria Prima"
        Form1.Db_form1.LabelDescricao.Text = "Descrição"
        Form1.Db_form1.LabelSuporte.Text = "Suporte"
        Form1.Db_form1.LabelTecnologia.Text = "Tecnologia"
        Form1.Db_form1.LabelComprimento.Text = "Comprimento"
        Form1.Db_form1.labelLargura.Text = "Largura"
        Form1.Db_form1.labelEspessura.Text = "Espessura"
        Form1.Db_form1.labelcoordenadas.Text = "Coordenadas"
        Form1.Db_form1.LblCorIcon.Text = "Cor do Icon"
        Form1.Db_form1.Label1.Text = "Legenda"
        db_form_delete.updatebutton.ButtonText = "Atualizar"
        db_form_delete.deleteButton.ButtonText = "Eliminar"
        'Form1.Db_form1.labelbibliografia.Text = "Bibliografia"
        'db_form Materia Prima
        Form1.Db_form1.MateriaPrimaCombo.Clear()
        Form1.Db_form1.MateriaPrimaCombo.AddItem("Quartzo Hialino")
        Form1.Db_form1.MateriaPrimaCombo.AddItem("Quartzo Leitoso")
        Form1.Db_form1.MateriaPrimaCombo.AddItem("Quartzito")
        Form1.Db_form1.MateriaPrimaCombo.AddItem("Sílex")
        Form1.Db_form1.MateriaPrimaCombo.AddItem("Granito")
        Form1.Db_form1.MateriaPrimaCombo.AddItem("Xisto")
        Form1.Db_form1.MateriaPrimaCombo.AddItem("Calcário")
        Form1.Db_form1.MateriaPrimaCombo.AddItem("Obsidiana")
        'db_form Descricao
        Form1.Db_form1.DescricaoCombo.Clear()
        Form1.Db_form1.DescricaoCombo.AddItem("Lasca")
        Form1.Db_form1.DescricaoCombo.AddItem("Seixo Talhado")
        Form1.Db_form1.DescricaoCombo.AddItem("Núcleo")
        Form1.Db_form1.DescricaoCombo.AddItem("Movente")
        Form1.Db_form1.DescricaoCombo.AddItem("Resto de Talhe")
        Form1.Db_form1.DescricaoCombo.AddItem("Esquírola")
        Form1.Db_form1.DescricaoCombo.AddItem("Indeterminado")
        'db_form Periodo
        Form1.Db_form1.PeriodoCombo.Clear()
        Form1.Db_form1.PeriodoCombo.AddItem("Alta Idade Média")
        Form1.Db_form1.PeriodoCombo.AddItem("Baixa Idade Média")
        Form1.Db_form1.PeriodoCombo.AddItem("Calcolítico")
        Form1.Db_form1.PeriodoCombo.AddItem("Contemporâneo")
        Form1.Db_form1.PeriodoCombo.AddItem("Epipaleolítico")
        Form1.Db_form1.PeriodoCombo.AddItem("Idade Média")
        Form1.Db_form1.PeriodoCombo.AddItem("Idade do Bronze")
        Form1.Db_form1.PeriodoCombo.AddItem("Idade do Ferro")
        Form1.Db_form1.PeriodoCombo.AddItem("Medieval Cristão")
        Form1.Db_form1.PeriodoCombo.AddItem("Medieval Islâmico")
        Form1.Db_form1.PeriodoCombo.AddItem("Mesolítico")
        Form1.Db_form1.PeriodoCombo.AddItem("Moderno")
        Form1.Db_form1.PeriodoCombo.AddItem("Neolítico")
        Form1.Db_form1.PeriodoCombo.AddItem("Paleolítico")
        'db_form colour
        'Form1.Db_form1.CorIconComboBox.Clear()
        'Form1.Db_form1.CorIconComboBox.AddItem("Verde Claro")0
        'Form1.Db_form1.CorIconComboBox.AddItem("Vermelho Escuro")1
        'Form1.Db_form1.CorIconComboBox.AddItem("Branco")2
        'Form1.Db_form1.CorIconComboBox.AddItem("Roxo")3
        'Form1.Db_form1.CorIconComboBox.AddItem("Laranjas")4
        'Form1.Db_form1.CorIconComboBox.AddItem("Azul")5
        'Form1.Db_form1.CorIconComboBox.AddItem("Cinzento Claro")6
        'Form1.Db_form1.CorIconComboBox.AddItem("Azul Claro")7
        'Form1.Db_form1.CorIconComboBox.AddItem("Cinzento")8
        'Form1.Db_form1.CorIconComboBox.AddItem("Vermelho")9
        'Form1.Db_form1.CorIconComboBox.AddItem("Verde")10
        'Form1.Db_form1.CorIconComboBox.AddItem("Roxo Escuro")11
        'Form1.Db_form1.CorIconComboBox.AddItem("Verde Escuro")12
        'Form1.Db_form1.CorIconComboBox.AddItem("Azul Turquesa")13
        'Form1.Db_form1.CorIconComboBox.AddItem("Azul Escuro")14
        'Form1.Db_form1.CorIconComboBox.AddItem("Rosa")15
        'Form1.Db_form1.CorIconComboBox.AddItem("Bege")16
        'Form1.Db_form1.CorIconComboBox.AddItem("Vermelho Claro")17


        'Form1.Db_form1.CorIconComboBox.Clear()
        'Form1.Db_form1.CorIconComboBox.AddItem("")
        'Form1.Db_form1.CorIconComboBox.AddItem("")
        'Form1.Db_form1.CorIconComboBox.AddItem("")
        'Form1.Db_form1.CorIconComboBox.AddItem("")
        'Form1.Db_form1.CorIconComboBox.AddItem("")
        'Form1.Db_form1.CorIconComboBox.AddItem("")
        'Form1.Db_form1.CorIconComboBox.AddItem("")
        'Form1.Db_form1.CorIconComboBox.AddItem("")
        'Form1.Db_form1.CorIconComboBox.AddItem("")
        'Form1.Db_form1.CorIconComboBox.AddItem("")
        'Form1.Db_form1.CorIconComboBox.AddItem("")
        'Form1.Db_form1.CorIconComboBox.AddItem("")
        'Form1.Db_form1.CorIconComboBox.AddItem("")
        'Form1.Db_form1.CorIconComboBox.AddItem("")
        'Form1.Db_form1.CorIconComboBox.AddItem("")
        'Form1.Db_form1.CorIconComboBox.AddItem("")
        'Form1.Db_form1.CorIconComboBox.AddItem("")
        'Form1.Db_form1.CorIconComboBox.AddItem("")

    End Sub

    Private Sub OptionEnglish_Click(sender As Object, e As EventArgs) Handles OptionEnglish.Click
        language = 1
        'Form1 - Main Buttons
        Form1.Homepage1.WelcomeSentence.Text = "Welcome to ArqDB"
        Form1.BtnHome.Text = "Home"
        Form1.BtnBD.Text = "Database"
        Form1.BtnDetetor.Text = "Minerals Detector"
        Form1.BtnMapStudio.Text = "Map Studio"
        Form1.BtnOptions.Text = "Options"
        Form1.BtnAbout.Text = "About"
        'Form 1 - Top Menu
        Form1.BtnHomeSmall.Text = "Home"
        Form1.BtnBDSmall.Text = "Database"
        Form1.BtnDetetorSmall.Text = "Minerals Detetor"
        Form1.BtnMapStudioSmall.Text = "Map Studio"
        Form1.BtnOptionsSmall.Text = "Options"
        Form1.BtnAboutSmall.Text = "About"
        'Options
        LabelLanguage.Text = "Language"
        SempreTopo.Text = "Top Menu"
        'db_form
        Form1.Db_form1.Labelcodigo.Text = "Code"
        Form1.Db_form1.Labeldata.Text = "Date"
        Form1.Db_form1.LabelConcelho.Text = "Town Hall"
        Form1.Db_form1.LabelFreguesia.Text = "Parish"
        Form1.Db_form1.LabelLugar.Text = "Place"
        Form1.Db_form1.LabelPeriodo.Text = "Epoch"
        Form1.Db_form1.LabelMateriaPrima.Text = "Raw Material"
        Form1.Db_form1.LabelDescricao.Text = "Description"
        Form1.Db_form1.LabelSuporte.Text = "Base"
        Form1.Db_form1.LabelTecnologia.Text = "Technology"
        Form1.Db_form1.LabelComprimento.Text = "Length"
        Form1.Db_form1.labelLargura.Text = "Width"
        Form1.Db_form1.labelEspessura.Text = "thickness"
        Form1.Db_form1.labelcoordenadas.Text = "Coordinates"
        Form1.Db_form1.LblCorIcon.Text = "Icon Colour"
        Form1.Db_form1.Label1.Text = "Label"
        db_form_delete.updatebutton.ButtonText = "Update"
        db_form_delete.deleteButton.ButtonText = "Delete"
        'Form1.Db_form1.labelbibliografia.Text = "Bibliography"
        'db_form Materia Prima
        Form1.Db_form1.MateriaPrimaCombo.Clear()
        Form1.Db_form1.MateriaPrimaCombo.AddItem("Hyaline Quartz")
        Form1.Db_form1.MateriaPrimaCombo.AddItem("Milky Quartz")
        Form1.Db_form1.MateriaPrimaCombo.AddItem("Quartzite")
        Form1.Db_form1.MateriaPrimaCombo.AddItem("Flint")
        Form1.Db_form1.MateriaPrimaCombo.AddItem("Granite")
        Form1.Db_form1.MateriaPrimaCombo.AddItem("Shale")
        Form1.Db_form1.MateriaPrimaCombo.AddItem("LimeStone")
        Form1.Db_form1.MateriaPrimaCombo.AddItem("Obsidian")
        'db_form Descricao
        Form1.Db_form1.DescricaoCombo.Clear()
        Form1.Db_form1.DescricaoCombo.AddItem("Splinter")
        Form1.Db_form1.DescricaoCombo.AddItem("Pebble Cut")
        Form1.Db_form1.DescricaoCombo.AddItem("Core")
        Form1.Db_form1.DescricaoCombo.AddItem("Moving Wheel")
        Form1.Db_form1.DescricaoCombo.AddItem("Remainder of Carve")
        Form1.Db_form1.DescricaoCombo.AddItem("Bone Fragment")
        Form1.Db_form1.DescricaoCombo.AddItem("Undetermined")
        'db_form Periodo
        Form1.Db_form1.PeriodoCombo.Clear()
        Form1.Db_form1.PeriodoCombo.AddItem("High Middle Ages")
        Form1.Db_form1.PeriodoCombo.AddItem("Late Middle Ages")
        Form1.Db_form1.PeriodoCombo.AddItem("Chalcolithic")
        Form1.Db_form1.PeriodoCombo.AddItem("Contemporaneous")
        Form1.Db_form1.PeriodoCombo.AddItem("Epipaleolithic")
        Form1.Db_form1.PeriodoCombo.AddItem("Middle Ages")
        Form1.Db_form1.PeriodoCombo.AddItem("Bronze Age")
        Form1.Db_form1.PeriodoCombo.AddItem("Iron Age")
        Form1.Db_form1.PeriodoCombo.AddItem("Medieval Christian")
        Form1.Db_form1.PeriodoCombo.AddItem("Medieval Islamic")
        Form1.Db_form1.PeriodoCombo.AddItem("Mesolithic")
        Form1.Db_form1.PeriodoCombo.AddItem("Modern")
        Form1.Db_form1.PeriodoCombo.AddItem("Neolithic")
        Form1.Db_form1.PeriodoCombo.AddItem("Paleolithic")
        'db_form icon colour
        'Form1.Db_form1.CorIconComboBox.Clear()
        'Form1.Db_form1.CorIconComboBox.AddItem("LightGreen")
        'Form1.Db_form1.CorIconComboBox.AddItem("DarkRed")
        'Form1.Db_form1.CorIconComboBox.AddItem("White")
        'Form1.Db_form1.CorIconComboBox.AddItem("Purple")
        'Form1.Db_form1.CorIconComboBox.AddItem("Orange")
        'Form1.Db_form1.CorIconComboBox.AddItem("Blue")
        'Form1.Db_form1.CorIconComboBox.AddItem("LightGrayBlack")
        'Form1.Db_form1.CorIconComboBox.AddItem("LightBlue")
        'Form1.Db_form1.CorIconComboBox.AddItem("Gray")
        'Form1.Db_form1.CorIconComboBox.AddItem("Red")
        'Form1.Db_form1.CorIconComboBox.AddItem("Green")
        'Form1.Db_form1.CorIconComboBox.AddItem("DarkPurple")
        'Form1.Db_form1.CorIconComboBox.AddItem("Darkgreen")
        'Form1.Db_form1.CorIconComboBox.AddItem("CadetBlue")
        'Form1.Db_form1.CorIconComboBox.AddItem("DarkBlue")
        'Form1.Db_form1.CorIconComboBox.AddItem("Pink")
        'Form1.Db_form1.CorIconComboBox.AddItem("Beige")
        'Form1.Db_form1.CorIconComboBox.AddItem("LightRed")
    End Sub

    Private Sub options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuTopo.Checked = False
    End Sub

    Private Sub MenuTopo_OnChange(sender As Object, e As EventArgs) Handles MenuTopo.OnChange
        'home 0; 43
        'BtnHomeSmall 0; 38
        'BtnBDSmall 155; 38
        'BtnDetetorSmall 303; 38
        'BtnMapStudioSmall 451; 38
        'BtnOptionsSmall 599; 38
        'BtnAboutSmall 747; 38
        If MenuTopo.Checked Then

            Form1.Options1.Width = 900
            Form1.Options1.Height = 600 '512
            Form1.Options1.Location = New Point(0, 100) '38

            Form1.Db_form1.Width = 900
            Form1.Db_form1.Height = 600
            Form1.Db_form1.Location = New Point(0, 100)

            Form1.BtnHomeSmall.Visible = 1
            Form1.BtnHomeSmall.BringToFront()
            Form1.BtnHomeSmall.IconZoom = 50
            Form1.BtnHome.SendToBack()
            Form1.BtnHome.Visible = 0

            Form1.BtnBDSmall.Visible = 1
            Form1.BtnBDSmall.BringToFront()
            Form1.BtnBDSmall.IconZoom = 50
            Form1.BtnBD.SendToBack()
            Form1.BtnBD.Visible = 0

            Form1.BtnDetetorSmall.Visible = 1
            Form1.BtnDetetorSmall.BringToFront()
            Form1.BtnDetetorSmall.IconZoom = 50
            Form1.BtnDetetor.SendToBack()
            Form1.BtnDetetor.Visible = 0

            Form1.BtnMapStudioSmall.Visible = 1
            Form1.BtnMapStudioSmall.BringToFront()
            Form1.BtnMapStudioSmall.IconZoom = 50
            Form1.BtnMapStudio.SendToBack()
            Form1.BtnMapStudio.Visible = 0


            Form1.BtnOptionsSmall.Visible = 1
            Form1.BtnOptionsSmall.BringToFront()
            Form1.BtnOptionsSmall.IconZoom = 50
            Form1.BtnOptions.SendToBack()
            Form1.BtnOptions.Visible = 0

            Form1.BtnAboutSmall.Visible = 1
            Form1.BtnAboutSmall.BringToFront()
            Form1.BtnAboutSmall.IconZoom = 50
            Form1.BtnAbout.SendToBack()
            Form1.BtnAbout.Visible = 0

            Form1.PanelHomeOne.Visible = 0
            Form1.PanelHomeOne.SendToBack()
            Form1.PanelHomeTwo.Visible = 0
            Form1.PanelHomeTwo.SendToBack()

            Form1.PanelHomeExpanded.Visible = 1
            Form1.PanelHomeExpanded.BringToFront()

            Form1.SelectorPanel.Visible = 0

            Form1.Db_form1.SendToBack()
            Form1.Mapstudio1.SendToBack()
            TopMenu = True

        End If
        If MenuTopo.Checked = False Then
            Form1.BtnHomeSmall.Visible = 0
            Form1.BtnHomeSmall.SendToBack()

            Form1.BtnBDSmall.Visible = 0
            Form1.BtnBDSmall.SendToBack()


            Form1.BtnDetetorSmall.Visible = 0
            Form1.BtnDetetorSmall.SendToBack()


            Form1.BtnMapStudioSmall.Visible = 0
            Form1.BtnMapStudioSmall.SendToBack()



            Form1.BtnOptionsSmall.Visible = 0
            Form1.BtnOptionsSmall.SendToBack()


            Form1.BtnAboutSmall.Visible = 0
            Form1.BtnAboutSmall.SendToBack()

            Form1.PanelHomeExpanded.Visible = 0
            Form1.PanelHomeExpanded.SendToBack()
            TopMenu = False

            Form1.Options1.Width = 900
            Form1.Options1.Height = 512 '512
            Form1.Options1.Location = New Point(0, 38)

            Form1.Db_form1.Width = 900
            Form1.Db_form1.Height = 600
            Form1.Db_form1.Location = New Point(0, 38)
        End If
    End Sub
End Class
