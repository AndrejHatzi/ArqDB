Public Class Form1
    Dim activate, activateSmall As Boolean
    'Colocar a vermelho se estiver errado - Ideia








    ''Dim ee As Boolean = EmbLogin1.entrou
    'Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
    '    Dim ee As Boolean
    '    ee = EmbLogin1.entrou
    '    If ee Then
    '        RegCliente1.BringToFront()
    '    Else
    '        MessageBox.Show("Por Favor faça Login", "alerta")
    '    End If

    'End Sub

    'Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
    '    Dim ee As Boolean
    '    ee = EmbLogin1.entrou
    '    If ee Then
    '        Reg_vendas1.BringToFront()
    '    Else
    '        MessageBox.Show("Por Favor faça Login", "alerta")
    '    End If
    'End Sub

    'Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    'PagIni1.BringToFront()
    '    EmbLogin1.BringToFront()
    '    'ee = EmbLogin1.entrou
    '    'If ee Then
    '    '    
    '    'Else
    '    '    MessageBox.Show("Por Favor faça Login", "alerta")
    '    'End If
    'End Sub

    'Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
    '    Dim ee As Boolean
    '    ee = EmbLogin1.entrou
    '    If ee Then
    '        RegProdutos1.BringToFront()
    '    Else
    '        MessageBox.Show("Por Favor faça Login", "alerta")
    '    End If
    'End Sub

    'Private Sub header_Paint(sender As Object, e As PaintEventArgs) Handles header.Paint

    'End Sub

    'Private Sub EmbLogin1_Load(sender As Object, e As EventArgs)

    'End Sub

    'Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
    '    Dim ee As Boolean
    '    ee = EmbLogin1.entrou
    '    If ee Then
    '        Utils1.BringToFront()
    '    Else
    '        MessageBox.Show("Por Favor faça Login", "alerta")
    '    End If
    'End Sub

    'Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
    '    Dim ee As Boolean
    '    ee = EmbLogin1.entrou
    '    If ee Then
    '        PagIni1.BringToFront()
    '    Else
    '        MessageBox.Show("Por Favor faça Login", "alerta")
    '    End If
    'End Sub

    'Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
    '    Me.WindowState = FormWindowState.Minimized
    'End Sub

    'Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
    '    Me.WindowState = FormWindowState.Maximized
    'End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Options1.language = 0
        Db_form1.BringToFront()
        'Db_form1.CorIconComboBox.Clear()
        'Db_form1.CorIconComboBox.AddItem("Verde Claro")
        'Db_form1.CorIconComboBox.AddItem("Verde Escuro")
        'Db_form1.CorIconComboBox.AddItem("Branco")
        'Db_form1.CorIconComboBox.AddItem("Roxo")
        'Db_form1.CorIconComboBox.AddItem("Laranjas")
        'Db_form1.CorIconComboBox.AddItem("Azul")
        'Db_form1.CorIconComboBox.AddItem("Cinzento Claro")
        'Db_form1.CorIconComboBox.AddItem("Azul Claro")
        'Db_form1.CorIconComboBox.AddItem("Cinzento")
        'Db_form1.CorIconComboBox.AddItem("Vermelho")
        'Db_form1.CorIconComboBox.AddItem("Verde")
        'Db_form1.CorIconComboBox.AddItem("Roxo Escuro")
        'Db_form1.CorIconComboBox.AddItem("Verde Escuro")
        'Db_form1.CorIconComboBox.AddItem("Azul Turquesa")
        'Db_form1.CorIconComboBox.AddItem("Azul Escuro")
        'Db_form1.CorIconComboBox.AddItem("Rosa")
        'Db_form1.CorIconComboBox.AddItem("Bege")
        'Db_form1.CorIconComboBox.AddItem("Vermelho Escuro")
        'BtnHomeSmall 0; 38
        'BtnBDSmall 155; 38
        'BtnDetetorSmall 303; 38
        'BtnMapStudioSmall 451; 38
        'BtnOptionsSmall 599; 38
        'BtnAboutSmall 747; 38

        'Db_form1.BringToFront()

        BtnHomeSmall.Visible = 0
        BtnHomeSmall.SendToBack()

        BtnBDSmall.Visible = 0
        BtnBDSmall.SendToBack()

        BtnDetetorSmall.Visible = 0
        BtnDetetorSmall.SendToBack()

        BtnMapStudioSmall.Visible = 0
        BtnMapStudioSmall.SendToBack()

        BtnOptionsSmall.Visible = 0
        BtnOptionsSmall.SendToBack()

        BtnAboutSmall.Visible = 0
        BtnAboutSmall.SendToBack()

        PanelHomeExpanded.Visible = 0
        PanelHomeExpanded.SendToBack()




        BtnHome.Visible = 0 '0; 43
        BtnHome.BringToFront()
        BtnHome.Location = New Point(0, 43)

        PanelHomeOne.Visible = 0 '0; 109
        PanelHomeOne.BringToFront()
        PanelHomeOne.Location = New Point(0, 109)

        BtnBD.Visible = 0 '0; 129
        BtnBD.BringToFront()
        BtnBD.Location = New Point(0, 129)

        BtnDetetor.Visible = 0 '0; 195
        BtnDetetor.BringToFront()
        BtnDetetor.Location = New Point(0, 195)

        BtnMapStudio.Visible = 0 '0; 261
        BtnMapStudio.BringToFront()
        BtnMapStudio.Location = New Point(0, 261)

        BtnOptions.Visible = 0 '0; 327
        BtnOptions.BringToFront()
        BtnOptions.Location = New Point(0, 327)

        BtnAbout.Visible = 0 '0; 393
        BtnAbout.BringToFront()
        BtnAbout.Location = New Point(0, 393)

        PanelHomeTwo.Visible = 0 '0; 459
        PanelHomeTwo.BringToFront()
        PanelHomeTwo.Location = New Point(0, 459)

        activate = False
        activateSmall = False

        Options1.Location = New Point(0, 38)
        Options1.Width = 900
        Options1.Height = 600

        Mapstudio1.Location = New Point(0, 38)
        Mapstudio1.Width = 900
        Mapstudio1.Height = 600

        Db_form1.Location = New Point(0, 38)
        Db_form1.Width = 900
        Db_form1.Height = 600


        SelectorPanel.Height = BtnHome.Height - 1
        SelectorPanel.Top = BtnHome.Top
        SelectorPanel.BringToFront()
        SelectorPanel.Visible = 0
    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        Dim W As Integer = 30
        'BtnHome
        'PanelHomeOne
        'BtnBD
        'BtnDetetor
        'BtnMapStudio
        'BtnOptions
        'BtnAbout
        'PanelHomeTwo
        'Threading.Thread.Sleep(3000)

        'top menu form locations 0; 100
        'top menu form size 900; 600
        If Options1.MenuTopo.Checked Then
            Options1.Location = New Point(0, 100)
            Options1.Width = 900
            Options1.Height = 600

            Db_form1.Location = New Point(0, 100)
            Db_form1.Width = 900
            Db_form1.Height = 600


            Mapstudio1.Location = New Point(0, 100)
            Mapstudio1.Width = 900
            Mapstudio1.Height = 600

            If activateSmall = False Then



                BtnHomeSmall.Visible = 1
                BtnHomeSmall.BringToFront()

                BtnBDSmall.Visible = 1
                BtnBDSmall.BringToFront()

                BtnDetetorSmall.Visible = 1
                BtnDetetorSmall.BringToFront()

                BtnMapStudioSmall.Visible = 1
                BtnMapStudioSmall.BringToFront()

                BtnOptionsSmall.Visible = 1
                BtnOptionsSmall.BringToFront()

                BtnAboutSmall.Visible = 1
                BtnAboutSmall.BringToFront()

                PanelHomeExpanded.Visible = 1
                PanelHomeExpanded.BringToFront()

                activateSmall = True
            Else
                BtnHomeSmall.Visible = 0
                BtnHomeSmall.SendToBack()
                BtnBDSmall.Visible = 0
                BtnBDSmall.SendToBack()

                BtnDetetorSmall.Visible = 0
                BtnDetetorSmall.SendToBack()

                BtnMapStudioSmall.Visible = 0
                BtnMapStudioSmall.SendToBack()

                BtnOptionsSmall.Visible = 0
                BtnOptionsSmall.SendToBack()

                BtnAboutSmall.Visible = 0
                BtnAboutSmall.SendToBack()


                PanelHomeOne.Visible = 0
                PanelHomeOne.SendToBack()

                PanelHomeExpanded.Visible = 0
                PanelHomeExpanded.SendToBack()
                activateSmall = False
            End If
        Else
            If activate = False Then
                W = 30


                PanelHomeTwo.Visible = 0
                Threading.Thread.Sleep(W)
                BtnAbout.Visible = 0
                Threading.Thread.Sleep(W)
                BtnOptions.Visible = 0
                Threading.Thread.Sleep(W)
                BtnMapStudio.Visible = 0
                Threading.Thread.Sleep(W)
                BtnDetetor.Visible = 0
                Threading.Thread.Sleep(W)
                BtnBD.Visible = 0
                Threading.Thread.Sleep(W)
                PanelHomeOne.Visible = 0
                Threading.Thread.Sleep(W)
                BtnHome.Visible = 0
                Threading.Thread.Sleep(W)
                SelectorPanel.Visible = 0
                activate = True

                Options1.Location = New Point(0, 38)
                Options1.Width = 900
                Options1.Height = 600

                Db_form1.Location = New Point(0, 38)
                Db_form1.Width = 900
                Db_form1.Height = 600

                Mapstudio1.Location = New Point(0, 38)
                Mapstudio1.Width = 900
                Mapstudio1.Height = 600



            Else
                W = 10
                'Options1.Left = ""
                'Options1.Top = ""
                Options1.Location = New Point(200, 38)
                Options1.Width = 700
                Options1.Height = 600

                Db_form1.Location = New Point(200, 38)
                Db_form1.Width = 700
                Db_form1.Height = 600

                Mapstudio1.Location = New Point(200, 38)
                Mapstudio1.Width = 700
                Mapstudio1.Height = 600

                SelectorPanel.Visible = 1

                BtnHome.Visible = 1
                Threading.Thread.Sleep(W)
                PanelHomeOne.Visible = 1
                Threading.Thread.Sleep(W)
                BtnBD.Visible = 1
                Threading.Thread.Sleep(W)
                BtnDetetor.Visible = 1
                Threading.Thread.Sleep(W)
                BtnMapStudio.Visible = 1
                Threading.Thread.Sleep(W)
                BtnOptions.Visible = 1
                Threading.Thread.Sleep(W)
                BtnAbout.Visible = 1
                Threading.Thread.Sleep(W)
                PanelHomeTwo.Visible = 1
                Threading.Thread.Sleep(W)
                'For i = -70 To 0
                '    'BtnHome.Location = New Point(i, BtnHome.Location.Y)
                '    BtnHome.Location = New Point(i, BtnHome.Location.Y)
                '    BtnBD.Location = New Point(i, BtnBD.Location.Y)
                '    BtnDetetor.Location = New Point(i, BtnDetetor.Location.Y)
                '    BtnMapStudio.Location = New Point(i, BtnMapStudio.Location.Y)
                '    BtnOptions.Location = New Point(i, BtnOptions.Location.Y)
                '    BtnAbout.Location = New Point(i, BtnAbout.Location.Y)
                '    Threading.Thread.Sleep(20)
                '    Debug.Write(i)
                'Next
                activate = False
                'For i = -70 To 0
                'BtnHome.Location = New Point(i, BtnHome.Location.Y)

                'Threading.Thread.Sleep(W)

                'PanelHomeOne.Location = New Point(i, PanelHomeOne.Location.Y)

                'Threading.Thread.Sleep(W)

                'BtnBD.Location = New Point(i, BtnBD.Location.Y)

                'Threading.Thread.Sleep(W)

                'BtnDetetor.Location = New Point(i, BtnDetetor.Location.Y)

                'Threading.Thread.Sleep(W)

                'BtnMapStudio.Location = New Point(i, BtnMapStudio.Location.Y)

                'Threading.Thread.Sleep(W)

                'BtnOptions.Location = New Point(i, BtnOptions.Location.Y)

                'Threading.Thread.Sleep(W)

                'BtnAbout.Location = New Point(i, BtnAbout.Location.Y)

                'Threading.Thread.Sleep(W)

                'PanelHomeTwo.Location = New Point(i, PanelHomeTwo.Location.Y)


                'Threading.Thread.Sleep(W)
                'Next
                'activate = False
            End If
        End If

    End Sub

    Private Sub BtnOptions_Click(sender As Object, e As EventArgs) Handles BtnOptions.Click
        SelectorPanel.Height = BtnOptions.Height - 1
        SelectorPanel.Top = BtnOptions.Top
        SelectorPanel.BringToFront()

        Db_form1.SendToBack()
        Options1.BringToFront()
    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        SelectorPanel.Height = BtnHome.Height - 1
        SelectorPanel.Top = BtnHome.Top
        SelectorPanel.BringToFront()

       
    End Sub

    Private Sub BtnBD_Click(sender As Object, e As EventArgs) Handles BtnBD.Click
        SelectorPanel.Height = BtnBD.Height - 1
        SelectorPanel.Top = BtnBD.Top
        SelectorPanel.BringToFront()
        Db_form1.Visible = True
        Db_form1.BringToFront()
        Options1.SendToBack()
    End Sub


    Private Sub BtnAbout_Click(sender As Object, e As EventArgs) Handles BtnAbout.Click
        CreateOptions("language = PT", "menu = 1")
    End Sub

    Private Sub BtnBDSmall_Click(sender As Object, e As EventArgs) Handles BtnBDSmall.Click
        Db_form1.Visible = True
        Db_form1.BringToFront()
        Options1.SendToBack()
    End Sub

    Private Sub BtnOptionsSmall_Click(sender As Object, e As EventArgs) Handles BtnOptionsSmall.Click
        Options1.BringToFront()
        Db_form1.Visible = False
        Db_form1.SendToBack()
    End Sub

    Private Sub BtnMapStudio_Click(sender As Object, e As EventArgs) Handles BtnMapStudio.Click
        SelectorPanel.Height = BtnMapStudio.Height - 1
        SelectorPanel.Top = BtnMapStudio.Top
        SelectorPanel.BringToFront()
    End Sub
End Class
