<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmJuego
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmJuego))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnTwist = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPuntos = New System.Windows.Forms.Label()
        Me.lblRonda = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblHora = New System.Windows.Forms.Label()
        Me.btnSonido = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.lblTextoBotones = New System.Windows.Forms.Label()
        Me.btnLastWord = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SteelBlue
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(508, 396)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 44)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "ENTER"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SteelBlue
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(684, 396)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(156, 44)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "CLEAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnTwist
        '
        Me.btnTwist.BackColor = System.Drawing.Color.SteelBlue
        Me.btnTwist.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnTwist.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTwist.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnTwist.Location = New System.Drawing.Point(858, 396)
        Me.btnTwist.Name = "btnTwist"
        Me.btnTwist.Size = New System.Drawing.Size(155, 44)
        Me.btnTwist.TabIndex = 5
        Me.btnTwist.Text = "TWIST"
        Me.btnTwist.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(508, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 27)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "SCORE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(850, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 27)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "TIME:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(703, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 27)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "ROUND:"
        '
        'lblPuntos
        '
        Me.lblPuntos.AutoSize = True
        Me.lblPuntos.BackColor = System.Drawing.Color.DodgerBlue
        Me.lblPuntos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPuntos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblPuntos.ForeColor = System.Drawing.SystemColors.Control
        Me.lblPuntos.Location = New System.Drawing.Point(611, 6)
        Me.lblPuntos.Name = "lblPuntos"
        Me.lblPuntos.Size = New System.Drawing.Size(62, 27)
        Me.lblPuntos.TabIndex = 10
        Me.lblPuntos.Text = "0000"
        '
        'lblRonda
        '
        Me.lblRonda.AutoSize = True
        Me.lblRonda.BackColor = System.Drawing.Color.DodgerBlue
        Me.lblRonda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRonda.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblRonda.ForeColor = System.Drawing.SystemColors.Control
        Me.lblRonda.Location = New System.Drawing.Point(806, 6)
        Me.lblRonda.Name = "lblRonda"
        Me.lblRonda.Size = New System.Drawing.Size(26, 27)
        Me.lblRonda.TabIndex = 11
        Me.lblRonda.Text = "1"
        '
        'Timer1
        '
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.BackColor = System.Drawing.Color.DodgerBlue
        Me.lblHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblHora.ForeColor = System.Drawing.SystemColors.Control
        Me.lblHora.Location = New System.Drawing.Point(929, 6)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(69, 27)
        Me.lblHora.TabIndex = 12
        Me.lblHora.Text = "00:00"
        '
        'btnSonido
        '
        Me.btnSonido.BackColor = System.Drawing.Color.IndianRed
        Me.btnSonido.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSonido.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSonido.ForeColor = System.Drawing.SystemColors.Window
        Me.btnSonido.Location = New System.Drawing.Point(1057, 6)
        Me.btnSonido.Name = "btnSonido"
        Me.btnSonido.Size = New System.Drawing.Size(68, 30)
        Me.btnSonido.TabIndex = 13
        Me.btnSonido.Text = "🔊"
        Me.btnSonido.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.DimGray
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button6.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.SystemColors.Window
        Me.Button6.Location = New System.Drawing.Point(1131, 6)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(76, 30)
        Me.Button6.TabIndex = 14
        Me.Button6.Text = "⚙"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'lblTextoBotones
        '
        Me.lblTextoBotones.AutoSize = True
        Me.lblTextoBotones.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblTextoBotones.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold)
        Me.lblTextoBotones.Location = New System.Drawing.Point(800, 186)
        Me.lblTextoBotones.Name = "lblTextoBotones"
        Me.lblTextoBotones.Size = New System.Drawing.Size(0, 39)
        Me.lblTextoBotones.TabIndex = 15
        '
        'btnLastWord
        '
        Me.btnLastWord.BackColor = System.Drawing.Color.SteelBlue
        Me.btnLastWord.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLastWord.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLastWord.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLastWord.Location = New System.Drawing.Point(1030, 396)
        Me.btnLastWord.Name = "btnLastWord"
        Me.btnLastWord.Size = New System.Drawing.Size(155, 44)
        Me.btnLastWord.TabIndex = 16
        Me.btnLastWord.Text = "LAST WORD"
        Me.btnLastWord.UseVisualStyleBackColor = False
        '
        'frmJuego
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1221, 661)
        Me.Controls.Add(Me.btnLastWord)
        Me.Controls.Add(Me.lblTextoBotones)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.btnSonido)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.lblRonda)
        Me.Controls.Add(Me.lblPuntos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnTwist)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmJuego"
        Me.Text = "frmJuego"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnTwist As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblPuntos As Label
    Friend WithEvents lblRonda As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblHora As Label
    Friend WithEvents btnSonido As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents lblTextoBotones As Label
    Friend WithEvents btnLastWord As Button
End Class
