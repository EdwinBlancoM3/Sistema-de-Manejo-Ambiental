Public Class frmControlSalones
    Dim conectado As Boolean
    Dim dato As String = ""
    Dim datoSeparado(10) As String
    Dim led As String
    Dim foco As Integer
    Dim fan As String
    Dim clima As Integer
    Dim Bomba As String
    Private Sub frmControlSalones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectarse()
        Timer2.Enabled = True
        Timer2.Interval = 1000
        Timer2.Start()
        'Cargamos el Combobox con los puertos seriales conectados al PC
        For Each PuertosDisponibles As String In My.Computer.Ports.SerialPortNames
            cbPuerto.Items.Add(PuertosDisponibles)
        Next
        cbPuerto.Text = cbPuerto.Items(0)
        
    End Sub

    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        If Conectado = False Then
            'Si hay algo en la lista del Combobox
            If cbPuerto.Items.Count > 0 Then

                'Cambiamos el texto del combobox


                'Cambiamos el valor del nombre del puerto serial al valor seleccionado en la lista del combobox
                SerialPort1.PortName = cbPuerto.Text

                'Abrimos el puerto serial
                SerialPort1.Open()
                CheckForIllegalCrossThreadCalls = False 'desabilitamos los threadings
                SerialPort1.DiscardInBuffer() 'vaciamos el buffer

                'Activamos los botones "ON" Y "OFF"
                
                btnConectar.Enabled = False
                btnDesconectar.Enabled = True
                MsgBox("CONECTADO")
                'La variable Conectado es true
                conectado = True
                Timer1.Enabled = True
                Timer1.Interval = 5000
                Timer1.Start()
            Else
                'Si no hay puertos mostramos un mensaje
                MsgBox("NINGUN PUERTO ENCONTRADO")
            End If
        Else
            'Al terminar cerramos el puerto
            SerialPort1.Close()
            MsgBox("DESCONECTADO")
            Conectado = False
        End If
       
    End Sub

    Private Sub btnDesconectar_Click(sender As Object, e As EventArgs) Handles btnDesconectar.Click
        SerialPort1.Close()
        MsgBox("Desconectado")
        btnConectar.Enabled = True
        btnDesconectar.Enabled = False
    End Sub
    Private Sub SerialPort1_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        If (SerialPort1.IsOpen) Then
            dato = SerialPort1.ReadLine() 'leemos toda la linea de caracteres hasta que se encuentre un cambio de linea "ln"
            datoseparado = Split(dato, ",") 'lo separamos y lo guardamos en la matriz creada
            If (datoseparado(0) = "a") Then 'comparamos con la posicion (0) del arreglo que tenga una "a"
                If (datoseparado((datoseparado.Length() - 2)) = "b") Then 'comparamos con la posicion 
                    ''If (datoSeparado((datoSeparado.Length() - 3)) = "c") Then 
                    If (datoSeparado(4) > 514) Then
                        ''led = "0"
                        ''foco = 0
                        ''SerialPort1.Write(led)
                        ''SerialPort1.DiscardOutBuffer()
                        picLed.Image = My.Resources.led_apagado
                        txtLuminosidad.Text = "La luz es ideal"
                    Else
                        'led = "1"
                        'foco = 1
                        'SerialPort1.Write(led)
                        'SerialPort1.DiscardOutBuffer()
                        picLed.Image = My.Resources.led_encendido
                        txtLuminosidad.Text = "Muy Oscuro"
                    End If
                    If (datoSeparado(3) < 100) Then
                        txtLuzPatio.Text = "Muy Soleado"
                    Else
                        If (datoSeparado(3) > 100 And datoSeparado(3) < 500) Then
                            txtLuzPatio.Text = "Aun hay luz"
                        Else
                            txtLuzPatio.Text = "Oscuro"
                        End If
                    End If
                    txtTemperatura.Text = datoSeparado(1) & " C°" 'si se cumplen las condiciones quiere decir que todos lo valores
                    lblHumedad.Text = datoSeparado(2)  'son correctos y los desplegamos esto se hace para comprobar datos
                    'txtLuzPatio.Text = datoSeparado(3)
                    Select Case datoSeparado(5)
                        Case Is <= 200
                            txtHumedadPatio.Text = "100%"
                        Case 201 To 399
                            txtHumedadPatio.Text = "80%"
                        Case 400 To 599
                            txtHumedadPatio.Text = "60%"
                        Case 600 To 799
                            txtHumedadPatio.Text = "40%"
                        Case 800 To 900
                            txtHumedadPatio.Text = "20%"
                        Case 901 To 1023
                            txtHumedadPatio.Text = "0%"
                    End Select
                    'txtHumedadPatio.Text = (datoSeparado(5) * 10.23)
                End If
            End If
        End If
        'End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Stop()

        Dim TestStr As String
        TestStr = Format(Now, "dddd,d MMMM " + "" + " yyyy" + "  " + "hh:mm:ss tt")
        'Devuelve "Sábado, 27 de enero 2001".
        Label2.Text = TestStr
        Timer2.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Dim Fecha As String
        Dim Hora As String
        Dim Aula As String
        Dim Humedad As String
        Dim temperatura As String
        Dim luminosidad As String
        


        txthora.Text = Date.Now().ToLongTimeString
        Fecha = Date.Now().ToLongDateString
        Hora = txthora.Text
        Aula = Me.Label3.Text
        Humedad = Me.lblHumedad.Text
        temperatura = Me.txtTemperatura.Text
        luminosidad = Me.txtLuminosidad.Text
        consumokwhfoco()
        consumokwhclima()
        consumoagua()

        cmd.CommandType = CommandType.Text
        cmd.Connection = conn

        sql = "INSERT INTO REGISTROSALON(NUMEROAULA, FECHA,HORAREGISTRO,HUMEDAD,TEMPERATURA,LUMINOSIDAD, FOCOS, CLIMAS) "
        sql += "VALUES('" & Aula & "','" & Fecha & "','" & Hora & "','" & Humedad & "','" & temperatura & "','" & luminosidad & "', '" & costokwhfoco & "', '" & costokwhclima & "')"



        cmd.CommandText = sql

        Try
            cmd.ExecuteNonQuery()
            'MsgBox("registro insertado correctamente")
            'Me.txtcodigo.Text = ""


        Catch ex As Exception
            If ex.ToString.Contains("valores duplicados") Then
                'MsgBox("el registro ya existe en la base de datos")
            Else
                MsgBox(ex.ToString)

            End If


        End Try
        Dim sector As String
        Dim HumedadJardin As String
        Dim luminosidadjardin As String

        sector = lblsector.Text
        HumedadJardin = txtHumedadPatio.Text
        luminosidadjardin = txtLuzPatio.Text

        cmd2.CommandType = CommandType.Text
        cmd2.Connection = conn

        sql2 = "INSERT INTO REGISTROJARDIN(SECTOR, HUMEDAD, LUMINOSIDAD, FECHAREGISTRO, HORAREGISTRO, AGUA) "
        sql2 += "VALUES('" & sector & "','" & HumedadJardin & "','" & luminosidadjardin & "','" & Fecha & "','" & Hora & "','" & costoagua & "')"



        cmd2.CommandText = sql2

        Try
            cmd2.ExecuteNonQuery()
            'MsgBox("registro insertado correctamente")
            'Me.txtcodigo.Text = ""


        Catch ex As Exception
            If ex.ToString.Contains("valores duplicados") Then
                'MsgBox("el registro ya existe en la base de datos")
            Else
                MsgBox(ex.ToString)

            End If


        End Try


        Timer1.Start()

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Timer3.Interval = 10
        txtseg.Text += 1
        If txtseg.Text = 60 Then
            txtmin.Text += 1
            txtseg.Text = 0
        End If
        If txtmin.Text = 60 Then
            txthours.Text += 1
            txtmin.Text = 0
        End If
    End Sub
    Private Sub consumokwhfoco()
        Dim h, m, s As Decimal
        h = txthours.Text
        m = txtmin.Text
        s = txtseg.Text
        m += (s / 60)
        h += (m / 60)
        kwhfoco = (78 * h)
        costokwhfoco = (2 * kwhfoco)

    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Timer4.Interval = 10
        txts2.Text += 1
        If txts2.Text = 60 Then
            txtm2.Text += 1
            txts2.Text = 0
        End If
        If txtm2.Text = 60 Then
            txth2.Text += 1
            txtm2.Text = 0
        End If
    End Sub
    Private Sub consumokwhclima()
        Dim h, m, s As Decimal
        h = txth2.Text
        m = txtm2.Text
        s = txts2.Text
        m += (s / 60)
        h += (m / 60)
        kwhclima = (288 * h)
        costokwhclima = (2 * kwhclima)

    End Sub
    Private Sub consumoagua()
        Dim h, m, s As Decimal
        h = lblh.Text
        m = lblm.Text
        s = lbls.Text
        m += (s / 60)
        h += (m / 60)
        flujoagua = (16 * h)
        costoagua = (148 * flujoagua)

    End Sub

    Private Sub btnOnFocos_Click(sender As Object, e As EventArgs) Handles btnOnFocos.Click
        Dim lumi As Integer
        lumi = datoSeparado(4)
        If (lumi < 514) Then
            led = "1"
            SerialPort1.Write(led)
            SerialPort1.DiscardOutBuffer()
            Timer3.Enabled = True
            Timer3.Start()
            MsgBox("Luces Encendidas")
        Else
            MsgBox("Aun hay luz de dia")
        End If

    End Sub

    Private Sub btnOffFocos_Click(sender As Object, e As EventArgs) Handles btnOffFocos.Click
        Timer3.Stop()
        led = "0"
        SerialPort1.Write(led)
        SerialPort1.DiscardOutBuffer()
        MsgBox("luces apgadas")
    End Sub

    Private Sub btnOnClima_Click(sender As Object, e As EventArgs) Handles btnOnClima.Click


        Dim temp As Integer
        temp = datoSeparado(1)
        If (temp > 23) Then
            fan = "2"
            SerialPort1.Write(fan)
            SerialPort1.DiscardOutBuffer()
            Timer4.Enabled = True
            Timer4.Start()
            MsgBox("Clima Encendido")
        Else
            MsgBox("Temperatura Ideal")
        End If
    End Sub

    Private Sub btnOffClima_Click(sender As Object, e As EventArgs) Handles btnOffClima.Click
        Timer4.Stop()
        fan = "3"
        SerialPort1.Write(fan)
        SerialPort1.DiscardOutBuffer()
        MsgBox("clima apagado")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim lumi, hum As Integer
        lumi = datoSeparado(3)
        hum = datoSeparado(5)


        If (lumi > 600 And hum > 400) Then
            Bomba = "5"
            Timer5.Enabled = True
            Timer5.Start()
            SerialPort1.Write(Bomba)
            SerialPort1.DiscardOutBuffer()
            MsgBox("Aspersores ON")
        Else
            MsgBox("Humedad o luminosidad inadecuadas")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Bomba = "4"
        SerialPort1.Write(Bomba)
        SerialPort1.DiscardOutBuffer()
        Timer5.Stop()
        MsgBox("Aspersores OFF")
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Timer5.Interval = 10
        lbls.Text += 1
        If lbls.Text = 60 Then
            lblm.Text += 1
            lbls.Text = 0
        End If
        If lblm.Text = 60 Then
            lblh.Text += 1
            lblm.Text = 0
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        conn.Close()
        Me.Close()
        frmInicio.Show()
    End Sub
End Class