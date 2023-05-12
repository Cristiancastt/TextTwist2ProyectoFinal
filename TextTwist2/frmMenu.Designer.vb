<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTimed = New System.Windows.Forms.Button()
        Me.btnUntimed = New System.Windows.Forms.Button()
        Me.btnSound = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lstRanking = New System.Windows.Forms.ListBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(82, 308)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1152, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "REARRANGE LETTERS TO MAKE AS MANY WORDS AS YOU CAN!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnTimed
        '
        Me.btnTimed.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnTimed.BackColor = System.Drawing.Color.SteelBlue
        Me.btnTimed.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnTimed.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold)
        Me.btnTimed.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnTimed.Location = New System.Drawing.Point(457, 410)
        Me.btnTimed.Name = "btnTimed"
        Me.btnTimed.Size = New System.Drawing.Size(376, 55)
        Me.btnTimed.TabIndex = 2
        Me.btnTimed.Text = "TIMED"
        Me.btnTimed.UseVisualStyleBackColor = False
        '
        'btnUntimed
        '
        Me.btnUntimed.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUntimed.BackColor = System.Drawing.Color.SteelBlue
        Me.btnUntimed.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnUntimed.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold)
        Me.btnUntimed.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUntimed.Location = New System.Drawing.Point(457, 471)
        Me.btnUntimed.Name = "btnUntimed"
        Me.btnUntimed.Size = New System.Drawing.Size(376, 60)
        Me.btnUntimed.TabIndex = 3
        Me.btnUntimed.Text = "UNTIMED"
        Me.btnUntimed.UseVisualStyleBackColor = False
        '
        'btnSound
        '
        Me.btnSound.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSound.BackColor = System.Drawing.Color.IndianRed
        Me.btnSound.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.25!)
        Me.btnSound.ForeColor = System.Drawing.Color.White
        Me.btnSound.Location = New System.Drawing.Point(1179, 668)
        Me.btnSound.Name = "btnSound"
        Me.btnSound.Size = New System.Drawing.Size(67, 53)
        Me.btnSound.TabIndex = 5
        Me.btnSound.Text = "🔊"
        Me.btnSound.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLogin.BackColor = System.Drawing.Color.Coral
        Me.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold)
        Me.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLogin.Location = New System.Drawing.Point(457, 537)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(376, 60)
        Me.btnLogin.TabIndex = 6
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackgroundImage = Global.TextTwist2.My.Resources.Resources._81Y2lHoTFqL_transformed_transformed
        Me.PictureBox1.Image = Global.TextTwist2.My.Resources.Resources._81Y2lHoTFqL_transformed_transformed
        Me.PictureBox1.Location = New System.Drawing.Point(89, -51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(774, 340)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblUsuario
        '
        Me.lblUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.lblUsuario.Location = New System.Drawing.Point(1102, 9)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(0, 25)
        Me.lblUsuario.TabIndex = 7
        '
        'lstRanking
        '
        Me.lstRanking.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstRanking.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lstRanking.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstRanking.FormattingEnabled = True
        Me.lstRanking.ItemHeight = 24
        Me.lstRanking.Location = New System.Drawing.Point(102, 363)
        Me.lstRanking.Name = "lstRanking"
        Me.lstRanking.Size = New System.Drawing.Size(330, 316)
        Me.lstRanking.TabIndex = 8
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1272, 742)
        Me.Controls.Add(Me.lstRanking)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnSound)
        Me.Controls.Add(Me.btnUntimed)
        Me.Controls.Add(Me.btnTimed)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMenu"
        Me.Text = "TextTwist2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnTimed As Button
    Friend WithEvents btnUntimed As Button
    Friend WithEvents btnSound As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblUsuario As Label
    Friend WithEvents lstRanking As ListBox
    Friend WithEvents Timer1 As Timer
End Class
