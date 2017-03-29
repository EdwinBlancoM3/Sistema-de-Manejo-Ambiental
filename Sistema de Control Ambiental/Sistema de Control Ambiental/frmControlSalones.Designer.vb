<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControlSalones
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmControlSalones))
        Me.lblHumedad = New System.Windows.Forms.Label()
        Me.cbPuerto = New System.Windows.Forms.ComboBox()
        Me.lblSeleccion = New System.Windows.Forms.Label()
        Me.btnConectar = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.gbSalones = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnOffClima = New System.Windows.Forms.Button()
        Me.btnOnClima = New System.Windows.Forms.Button()
        Me.gbInterruptorFocos = New System.Windows.Forms.GroupBox()
        Me.btnOffFocos = New System.Windows.Forms.Button()
        Me.btnOnFocos = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txts2 = New System.Windows.Forms.Label()
        Me.txtm2 = New System.Windows.Forms.Label()
        Me.txth2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblCronometro = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblsplit = New System.Windows.Forms.Label()
        Me.txtseg = New System.Windows.Forms.Label()
        Me.txtmin = New System.Windows.Forms.Label()
        Me.txthours = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txthora = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picLed = New System.Windows.Forms.PictureBox()
        Me.txtLuminosidad = New System.Windows.Forms.Label()
        Me.txtTemperatura = New System.Windows.Forms.Label()
        Me.TemperaturaAula = New System.Windows.Forms.Label()
        Me.LumiAula = New System.Windows.Forms.Label()
        Me.btnDesconectar = New System.Windows.Forms.Button()
        Me.gbJardin = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbls = New System.Windows.Forms.Label()
        Me.lblm = New System.Windows.Forms.Label()
        Me.lblh = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblsector = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtHumedadPatio = New System.Windows.Forms.Label()
        Me.txtLuzPatio = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.gbSalones.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbInterruptorFocos.SuspendLayout()
        CType(Me.picLed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbJardin.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHumedad
        '
        Me.lblHumedad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHumedad.Location = New System.Drawing.Point(6, 126)
        Me.lblHumedad.Name = "lblHumedad"
        Me.lblHumedad.Size = New System.Drawing.Size(186, 36)
        Me.lblHumedad.TabIndex = 0
        '
        'cbPuerto
        '
        Me.cbPuerto.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPuerto.FormattingEnabled = True
        Me.cbPuerto.Location = New System.Drawing.Point(201, 40)
        Me.cbPuerto.Name = "cbPuerto"
        Me.cbPuerto.Size = New System.Drawing.Size(244, 27)
        Me.cbPuerto.TabIndex = 1
        '
        'lblSeleccion
        '
        Me.lblSeleccion.AutoSize = True
        Me.lblSeleccion.BackColor = System.Drawing.Color.Transparent
        Me.lblSeleccion.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeleccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblSeleccion.Location = New System.Drawing.Point(32, 43)
        Me.lblSeleccion.Name = "lblSeleccion"
        Me.lblSeleccion.Size = New System.Drawing.Size(148, 19)
        Me.lblSeleccion.TabIndex = 2
        Me.lblSeleccion.Text = "Seleccione el Puerto"
        '
        'btnConectar
        '
        Me.btnConectar.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConectar.Location = New System.Drawing.Point(536, 43)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(87, 32)
        Me.btnConectar.TabIndex = 3
        Me.btnConectar.Text = "Conectar"
        Me.btnConectar.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM16"
        '
        'gbSalones
        '
        Me.gbSalones.BackColor = System.Drawing.Color.Transparent
        Me.gbSalones.Controls.Add(Me.GroupBox1)
        Me.gbSalones.Controls.Add(Me.gbInterruptorFocos)
        Me.gbSalones.Controls.Add(Me.Label8)
        Me.gbSalones.Controls.Add(Me.Label9)
        Me.gbSalones.Controls.Add(Me.txts2)
        Me.gbSalones.Controls.Add(Me.txtm2)
        Me.gbSalones.Controls.Add(Me.txth2)
        Me.gbSalones.Controls.Add(Me.Label6)
        Me.gbSalones.Controls.Add(Me.lblCronometro)
        Me.gbSalones.Controls.Add(Me.Label5)
        Me.gbSalones.Controls.Add(Me.lblsplit)
        Me.gbSalones.Controls.Add(Me.txtseg)
        Me.gbSalones.Controls.Add(Me.txtmin)
        Me.gbSalones.Controls.Add(Me.txthours)
        Me.gbSalones.Controls.Add(Me.Label3)
        Me.gbSalones.Controls.Add(Me.txthora)
        Me.gbSalones.Controls.Add(Me.DateTimePicker1)
        Me.gbSalones.Controls.Add(Me.Label1)
        Me.gbSalones.Controls.Add(Me.lblHumedad)
        Me.gbSalones.Controls.Add(Me.picLed)
        Me.gbSalones.Controls.Add(Me.txtLuminosidad)
        Me.gbSalones.Controls.Add(Me.txtTemperatura)
        Me.gbSalones.Controls.Add(Me.TemperaturaAula)
        Me.gbSalones.Controls.Add(Me.LumiAula)
        Me.gbSalones.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSalones.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gbSalones.Location = New System.Drawing.Point(14, 81)
        Me.gbSalones.Name = "gbSalones"
        Me.gbSalones.Size = New System.Drawing.Size(495, 400)
        Me.gbSalones.TabIndex = 5
        Me.gbSalones.TabStop = False
        Me.gbSalones.Text = "Aula"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnOffClima)
        Me.GroupBox1.Controls.Add(Me.btnOnClima)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(348, 272)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(134, 87)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Interruptor Clima"
        '
        'btnOffClima
        '
        Me.btnOffClima.BackColor = System.Drawing.Color.Red
        Me.btnOffClima.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOffClima.Location = New System.Drawing.Point(82, 49)
        Me.btnOffClima.Name = "btnOffClima"
        Me.btnOffClima.Size = New System.Drawing.Size(46, 23)
        Me.btnOffClima.TabIndex = 26
        Me.btnOffClima.Text = "Off"
        Me.btnOffClima.UseVisualStyleBackColor = False
        '
        'btnOnClima
        '
        Me.btnOnClima.BackColor = System.Drawing.Color.Green
        Me.btnOnClima.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOnClima.Location = New System.Drawing.Point(6, 49)
        Me.btnOnClima.Name = "btnOnClima"
        Me.btnOnClima.Size = New System.Drawing.Size(46, 23)
        Me.btnOnClima.TabIndex = 25
        Me.btnOnClima.Text = "On"
        Me.btnOnClima.UseVisualStyleBackColor = False
        '
        'gbInterruptorFocos
        '
        Me.gbInterruptorFocos.Controls.Add(Me.btnOffFocos)
        Me.gbInterruptorFocos.Controls.Add(Me.btnOnFocos)
        Me.gbInterruptorFocos.ForeColor = System.Drawing.Color.White
        Me.gbInterruptorFocos.Location = New System.Drawing.Point(187, 272)
        Me.gbInterruptorFocos.Name = "gbInterruptorFocos"
        Me.gbInterruptorFocos.Size = New System.Drawing.Size(134, 87)
        Me.gbInterruptorFocos.TabIndex = 27
        Me.gbInterruptorFocos.TabStop = False
        Me.gbInterruptorFocos.Text = "Interruptor Foco"
        '
        'btnOffFocos
        '
        Me.btnOffFocos.BackColor = System.Drawing.Color.Red
        Me.btnOffFocos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOffFocos.ForeColor = System.Drawing.Color.White
        Me.btnOffFocos.Location = New System.Drawing.Point(82, 49)
        Me.btnOffFocos.Name = "btnOffFocos"
        Me.btnOffFocos.Size = New System.Drawing.Size(46, 23)
        Me.btnOffFocos.TabIndex = 26
        Me.btnOffFocos.Text = "Off"
        Me.btnOffFocos.UseVisualStyleBackColor = False
        '
        'btnOnFocos
        '
        Me.btnOnFocos.BackColor = System.Drawing.Color.Green
        Me.btnOnFocos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOnFocos.ForeColor = System.Drawing.Color.White
        Me.btnOnFocos.Location = New System.Drawing.Point(6, 49)
        Me.btnOnFocos.Name = "btnOnFocos"
        Me.btnOnFocos.Size = New System.Drawing.Size(46, 23)
        Me.btnOnFocos.TabIndex = 25
        Me.btnOnFocos.Text = "On"
        Me.btnOnFocos.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(419, 234)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(14, 19)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = ":"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(363, 234)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(14, 19)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = ":"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txts2
        '
        Me.txts2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txts2.Location = New System.Drawing.Point(435, 234)
        Me.txts2.Name = "txts2"
        Me.txts2.Size = New System.Drawing.Size(30, 26)
        Me.txts2.TabIndex = 22
        Me.txts2.Text = "00"
        Me.txts2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtm2
        '
        Me.txtm2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtm2.Location = New System.Drawing.Point(383, 234)
        Me.txtm2.Name = "txtm2"
        Me.txtm2.Size = New System.Drawing.Size(30, 26)
        Me.txtm2.TabIndex = 21
        Me.txtm2.Text = "00"
        Me.txtm2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txth2
        '
        Me.txth2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txth2.Location = New System.Drawing.Point(331, 234)
        Me.txth2.Name = "txth2"
        Me.txth2.Size = New System.Drawing.Size(30, 26)
        Me.txth2.TabIndex = 20
        Me.txth2.Text = "00"
        Me.txth2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(306, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(179, 19)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Tiempo Clima Encendido"
        '
        'lblCronometro
        '
        Me.lblCronometro.AutoSize = True
        Me.lblCronometro.Location = New System.Drawing.Point(306, 128)
        Me.lblCronometro.Name = "lblCronometro"
        Me.lblCronometro.Size = New System.Drawing.Size(165, 19)
        Me.lblCronometro.TabIndex = 18
        Me.lblCronometro.Text = "Tiempo Luz Encendida"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(418, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 19)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = ":"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblsplit
        '
        Me.lblsplit.AutoSize = True
        Me.lblsplit.Location = New System.Drawing.Point(362, 164)
        Me.lblsplit.Name = "lblsplit"
        Me.lblsplit.Size = New System.Drawing.Size(14, 19)
        Me.lblsplit.TabIndex = 16
        Me.lblsplit.Text = ":"
        Me.lblsplit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtseg
        '
        Me.txtseg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtseg.Location = New System.Drawing.Point(434, 164)
        Me.txtseg.Name = "txtseg"
        Me.txtseg.Size = New System.Drawing.Size(30, 26)
        Me.txtseg.TabIndex = 15
        Me.txtseg.Text = "00"
        Me.txtseg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtmin
        '
        Me.txtmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtmin.Location = New System.Drawing.Point(382, 164)
        Me.txtmin.Name = "txtmin"
        Me.txtmin.Size = New System.Drawing.Size(30, 26)
        Me.txtmin.TabIndex = 14
        Me.txtmin.Text = "00"
        Me.txtmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txthours
        '
        Me.txthours.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txthours.Location = New System.Drawing.Point(330, 164)
        Me.txthours.Name = "txthours"
        Me.txthours.Size = New System.Drawing.Size(31, 26)
        Me.txthours.TabIndex = 9
        Me.txthours.Text = "00"
        Me.txthours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(472, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 19)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "5"
        '
        'txthora
        '
        Me.txthora.Location = New System.Drawing.Point(389, 59)
        Me.txthora.Name = "txthora"
        Me.txthora.Size = New System.Drawing.Size(100, 27)
        Me.txthora.TabIndex = 12
        Me.txthora.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(289, 18)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 27)
        Me.DateTimePicker1.TabIndex = 9
        Me.DateTimePicker1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 19)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Humedad en el Aula"
        '
        'picLed
        '
        Me.picLed.Location = New System.Drawing.Point(22, 288)
        Me.picLed.Name = "picLed"
        Me.picLed.Size = New System.Drawing.Size(100, 50)
        Me.picLed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLed.TabIndex = 7
        Me.picLed.TabStop = False
        '
        'txtLuminosidad
        '
        Me.txtLuminosidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtLuminosidad.Location = New System.Drawing.Point(6, 205)
        Me.txtLuminosidad.Name = "txtLuminosidad"
        Me.txtLuminosidad.Size = New System.Drawing.Size(186, 36)
        Me.txtLuminosidad.TabIndex = 10
        '
        'txtTemperatura
        '
        Me.txtTemperatura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtTemperatura.Location = New System.Drawing.Point(9, 59)
        Me.txtTemperatura.Name = "txtTemperatura"
        Me.txtTemperatura.Size = New System.Drawing.Size(186, 36)
        Me.txtTemperatura.TabIndex = 9
        '
        'TemperaturaAula
        '
        Me.TemperaturaAula.AutoSize = True
        Me.TemperaturaAula.ForeColor = System.Drawing.Color.White
        Me.TemperaturaAula.Location = New System.Drawing.Point(6, 33)
        Me.TemperaturaAula.Name = "TemperaturaAula"
        Me.TemperaturaAula.Size = New System.Drawing.Size(166, 19)
        Me.TemperaturaAula.TabIndex = 7
        Me.TemperaturaAula.Text = "Temperatura en el aula"
        '
        'LumiAula
        '
        Me.LumiAula.AutoSize = True
        Me.LumiAula.Location = New System.Drawing.Point(6, 180)
        Me.LumiAula.Name = "LumiAula"
        Me.LumiAula.Size = New System.Drawing.Size(169, 19)
        Me.LumiAula.TabIndex = 8
        Me.LumiAula.Text = "Luminosidad en el Aula"
        '
        'btnDesconectar
        '
        Me.btnDesconectar.Enabled = False
        Me.btnDesconectar.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDesconectar.Location = New System.Drawing.Point(631, 43)
        Me.btnDesconectar.Name = "btnDesconectar"
        Me.btnDesconectar.Size = New System.Drawing.Size(104, 32)
        Me.btnDesconectar.TabIndex = 6
        Me.btnDesconectar.Text = "Desconectar"
        Me.btnDesconectar.UseVisualStyleBackColor = True
        '
        'gbJardin
        '
        Me.gbJardin.BackColor = System.Drawing.Color.Transparent
        Me.gbJardin.Controls.Add(Me.Label10)
        Me.gbJardin.Controls.Add(Me.Label11)
        Me.gbJardin.Controls.Add(Me.Label12)
        Me.gbJardin.Controls.Add(Me.lbls)
        Me.gbJardin.Controls.Add(Me.lblm)
        Me.gbJardin.Controls.Add(Me.lblh)
        Me.gbJardin.Controls.Add(Me.GroupBox2)
        Me.gbJardin.Controls.Add(Me.lblsector)
        Me.gbJardin.Controls.Add(Me.Label4)
        Me.gbJardin.Controls.Add(Me.txtHumedadPatio)
        Me.gbJardin.Controls.Add(Me.txtLuzPatio)
        Me.gbJardin.Controls.Add(Me.Label7)
        Me.gbJardin.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbJardin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gbJardin.Location = New System.Drawing.Point(532, 81)
        Me.gbJardin.Name = "gbJardin"
        Me.gbJardin.Size = New System.Drawing.Size(513, 400)
        Me.gbJardin.TabIndex = 7
        Me.gbJardin.TabStop = False
        Me.gbJardin.Text = "Jardin"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(272, 144)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(127, 19)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Tiempo Aspersor"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(384, 180)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(14, 19)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = ":"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(328, 180)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(14, 19)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = ":"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbls
        '
        Me.lbls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbls.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbls.Location = New System.Drawing.Point(400, 180)
        Me.lbls.Name = "lbls"
        Me.lbls.Size = New System.Drawing.Size(30, 26)
        Me.lbls.TabIndex = 33
        Me.lbls.Text = "00"
        Me.lbls.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblm
        '
        Me.lblm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblm.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblm.Location = New System.Drawing.Point(348, 180)
        Me.lblm.Name = "lblm"
        Me.lblm.Size = New System.Drawing.Size(30, 26)
        Me.lblm.TabIndex = 32
        Me.lblm.Text = "00"
        Me.lblm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblh
        '
        Me.lblh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblh.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblh.Location = New System.Drawing.Point(296, 180)
        Me.lblh.Name = "lblh"
        Me.lblh.Size = New System.Drawing.Size(31, 26)
        Me.lblh.TabIndex = 30
        Me.lblh.Text = "00"
        Me.lblh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(39, 257)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(134, 87)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Interruptor Aspersores"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(82, 49)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(46, 23)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Off"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Green
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(6, 49)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(46, 23)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "On"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'lblsector
        '
        Me.lblsector.AutoSize = True
        Me.lblsector.Location = New System.Drawing.Point(290, 49)
        Me.lblsector.Name = "lblsector"
        Me.lblsector.Size = New System.Drawing.Size(74, 19)
        Me.lblsector.TabIndex = 16
        Me.lblsector.Text = "Izquierdo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 19)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Humedad del Jardin"
        '
        'txtHumedadPatio
        '
        Me.txtHumedadPatio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtHumedadPatio.Location = New System.Drawing.Point(17, 48)
        Me.txtHumedadPatio.Name = "txtHumedadPatio"
        Me.txtHumedadPatio.Size = New System.Drawing.Size(186, 36)
        Me.txtHumedadPatio.TabIndex = 12
        '
        'txtLuzPatio
        '
        Me.txtLuzPatio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtLuzPatio.Location = New System.Drawing.Point(17, 127)
        Me.txtLuzPatio.Name = "txtLuzPatio"
        Me.txtLuzPatio.Size = New System.Drawing.Size(186, 36)
        Me.txtLuzPatio.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(169, 19)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Luminosidad del Jardin"
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'Timer4
        '
        '
        'Timer5
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(907, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 19)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Label2"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Red
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSalir.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(471, 488)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'frmControlSalones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1072, 523)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gbJardin)
        Me.Controls.Add(Me.btnDesconectar)
        Me.Controls.Add(Me.cbPuerto)
        Me.Controls.Add(Me.gbSalones)
        Me.Controls.Add(Me.lblSeleccion)
        Me.Controls.Add(Me.btnConectar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmControlSalones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control Salones"
        Me.gbSalones.ResumeLayout(False)
        Me.gbSalones.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.gbInterruptorFocos.ResumeLayout(False)
        CType(Me.picLed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbJardin.ResumeLayout(False)
        Me.gbJardin.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHumedad As System.Windows.Forms.Label
    Friend WithEvents cbPuerto As System.Windows.Forms.ComboBox
    Friend WithEvents lblSeleccion As System.Windows.Forms.Label
    Friend WithEvents btnConectar As System.Windows.Forms.Button
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents gbSalones As System.Windows.Forms.GroupBox
    Friend WithEvents btnDesconectar As System.Windows.Forms.Button
    Friend WithEvents TemperaturaAula As System.Windows.Forms.Label
    Friend WithEvents LumiAula As System.Windows.Forms.Label
    Public WithEvents txtLuminosidad As System.Windows.Forms.Label
    Public WithEvents txtTemperatura As System.Windows.Forms.Label
    Friend WithEvents picLed As System.Windows.Forms.PictureBox
    Friend WithEvents gbJardin As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents txthora As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtHumedadPatio As System.Windows.Forms.Label
    Public WithEvents txtLuzPatio As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblsector As System.Windows.Forms.Label
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents lblCronometro As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblsplit As System.Windows.Forms.Label
    Friend WithEvents txtseg As System.Windows.Forms.Label
    Friend WithEvents txtmin As System.Windows.Forms.Label
    Friend WithEvents txthours As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txts2 As System.Windows.Forms.Label
    Friend WithEvents txtm2 As System.Windows.Forms.Label
    Friend WithEvents txth2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnOffClima As System.Windows.Forms.Button
    Friend WithEvents btnOnClima As System.Windows.Forms.Button
    Friend WithEvents gbInterruptorFocos As System.Windows.Forms.GroupBox
    Friend WithEvents btnOffFocos As System.Windows.Forms.Button
    Friend WithEvents btnOnFocos As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lbls As System.Windows.Forms.Label
    Friend WithEvents lblm As System.Windows.Forms.Label
    Friend WithEvents lblh As System.Windows.Forms.Label
    Friend WithEvents Timer5 As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
End Class
