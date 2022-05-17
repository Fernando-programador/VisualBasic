<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.titulo = New System.Windows.Forms.Label()
        Me.usuario = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.imgUsuario = New System.Windows.Forms.PictureBox()
        Me.senha = New System.Windows.Forms.Label()
        Me.imgSenha = New System.Windows.Forms.PictureBox()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        CType(Me.imgUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSenha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.SystemColors.GrayText
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLogin.Location = New System.Drawing.Point(342, 347)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(142, 41)
        Me.btnLogin.TabIndex = 0
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'titulo
        '
        Me.titulo.AutoSize = True
        Me.titulo.BackColor = System.Drawing.Color.Transparent
        Me.titulo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.titulo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 36.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.titulo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.titulo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.titulo.Location = New System.Drawing.Point(144, 30)
        Me.titulo.Name = "titulo"
        Me.titulo.Size = New System.Drawing.Size(479, 55)
        Me.titulo.TabIndex = 1
        Me.titulo.Text = "Ajeitando Seu Lado"
        Me.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'usuario
        '
        Me.usuario.AutoSize = True
        Me.usuario.BackColor = System.Drawing.Color.Transparent
        Me.usuario.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.usuario.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.usuario.Location = New System.Drawing.Point(316, 87)
        Me.usuario.Name = "usuario"
        Me.usuario.Size = New System.Drawing.Size(145, 47)
        Me.usuario.TabIndex = 2
        Me.usuario.Text = "Usuário"
        Me.usuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtUsuario.Location = New System.Drawing.Point(286, 137)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PlaceholderText = "Digite o usuário ..."
        Me.txtUsuario.Size = New System.Drawing.Size(293, 39)
        Me.txtUsuario.TabIndex = 4
        '
        'imgUsuario
        '
        Me.imgUsuario.BackColor = System.Drawing.Color.Transparent
        Me.imgUsuario.Image = CType(resources.GetObject("imgUsuario.Image"), System.Drawing.Image)
        Me.imgUsuario.Location = New System.Drawing.Point(228, 122)
        Me.imgUsuario.Name = "imgUsuario"
        Me.imgUsuario.Size = New System.Drawing.Size(53, 54)
        Me.imgUsuario.TabIndex = 5
        Me.imgUsuario.TabStop = False
        '
        'senha
        '
        Me.senha.AutoSize = True
        Me.senha.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.senha.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.senha.Location = New System.Drawing.Point(316, 224)
        Me.senha.Name = "senha"
        Me.senha.Size = New System.Drawing.Size(120, 47)
        Me.senha.TabIndex = 6
        Me.senha.Text = "Senha"
        Me.senha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'imgSenha
        '
        Me.imgSenha.Image = CType(resources.GetObject("imgSenha.Image"), System.Drawing.Image)
        Me.imgSenha.Location = New System.Drawing.Point(231, 259)
        Me.imgSenha.Name = "imgSenha"
        Me.imgSenha.Size = New System.Drawing.Size(49, 54)
        Me.imgSenha.TabIndex = 7
        Me.imgSenha.TabStop = False
        '
        'txtSenha
        '
        Me.txtSenha.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtSenha.Location = New System.Drawing.Point(286, 274)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PlaceholderText = "Digite sua Senha ..."
        Me.txtSenha.Size = New System.Drawing.Size(293, 39)
        Me.txtSenha.TabIndex = 8
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(738, 521)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.imgSenha)
        Me.Controls.Add(Me.senha)
        Me.Controls.Add(Me.imgUsuario)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.usuario)
        Me.Controls.Add(Me.titulo)
        Me.Controls.Add(Me.btnLogin)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.imgUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSenha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents titulo As Label
    Friend WithEvents usuario As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents imgUsuario As PictureBox
    Friend WithEvents senha As Label
    Friend WithEvents imgSenha As PictureBox
    Friend WithEvents txtSenha As TextBox
End Class
