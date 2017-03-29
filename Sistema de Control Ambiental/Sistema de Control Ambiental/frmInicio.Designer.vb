<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicio))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picReportes = New System.Windows.Forms.PictureBox()
        Me.picControlSensores = New System.Windows.Forms.PictureBox()
        Me.btnControlConsumibles = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.picReportes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picControlSensores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnControlConsumibles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(63, 225)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Recursos"
        '
        'picReportes
        '
        Me.picReportes.BackColor = System.Drawing.Color.Transparent
        Me.picReportes.Image = CType(resources.GetObject("picReportes.Image"), System.Drawing.Image)
        Me.picReportes.Location = New System.Drawing.Point(314, 138)
        Me.picReportes.Name = "picReportes"
        Me.picReportes.Size = New System.Drawing.Size(129, 84)
        Me.picReportes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picReportes.TabIndex = 3
        Me.picReportes.TabStop = False
        '
        'picControlSensores
        '
        Me.picControlSensores.BackColor = System.Drawing.Color.Transparent
        Me.picControlSensores.Image = CType(resources.GetObject("picControlSensores.Image"), System.Drawing.Image)
        Me.picControlSensores.Location = New System.Drawing.Point(179, 138)
        Me.picControlSensores.Name = "picControlSensores"
        Me.picControlSensores.Size = New System.Drawing.Size(129, 84)
        Me.picControlSensores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picControlSensores.TabIndex = 2
        Me.picControlSensores.TabStop = False
        '
        'btnControlConsumibles
        '
        Me.btnControlConsumibles.BackColor = System.Drawing.Color.Transparent
        Me.btnControlConsumibles.Image = CType(resources.GetObject("btnControlConsumibles.Image"), System.Drawing.Image)
        Me.btnControlConsumibles.Location = New System.Drawing.Point(44, 138)
        Me.btnControlConsumibles.Name = "btnControlConsumibles"
        Me.btnControlConsumibles.Size = New System.Drawing.Size(129, 84)
        Me.btnControlConsumibles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnControlConsumibles.TabIndex = 1
        Me.btnControlConsumibles.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(205, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Control"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(339, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Reportes"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Red
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSalir.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(209, 315)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(514, 383)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picReportes)
        Me.Controls.Add(Me.picControlSensores)
        Me.Controls.Add(Me.btnControlConsumibles)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tablero de Control"
        CType(Me.picReportes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picControlSensores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnControlConsumibles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnControlConsumibles As System.Windows.Forms.PictureBox
    Friend WithEvents picControlSensores As System.Windows.Forms.PictureBox
    Friend WithEvents picReportes As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
End Class
