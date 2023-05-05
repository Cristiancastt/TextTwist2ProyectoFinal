<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TextTwist2.My.Resources.Resources.candado
        Me.PictureBox1.Location = New System.Drawing.Point(44, 57)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label1.Location = New System.Drawing.Point(229, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label2.Location = New System.Drawing.Point(234, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 31)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.75!)
        Me.txtUsername.Location = New System.Drawing.Point(416, 78)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(275, 28)
        Me.txtUsername.TabIndex = 3
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.txtPassword.Location = New System.Drawing.Point(416, 154)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(10041)
        Me.txtPassword.Size = New System.Drawing.Size(275, 31)
        Me.txtPassword.TabIndex = 4
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!, System.Drawing.FontStyle.Bold)
        Me.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLogin.Location = New System.Drawing.Point(154, 258)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(199, 58)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!, System.Drawing.FontStyle.Bold)
        Me.btnRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRegister.Location = New System.Drawing.Point(406, 258)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(199, 58)
        Me.btnRegister.TabIndex = 6
        Me.btnRegister.Text = "REGISTER"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(741, 355)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLogin"
        Me.Text = "LOGIN"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnRegister As Button
End Class
