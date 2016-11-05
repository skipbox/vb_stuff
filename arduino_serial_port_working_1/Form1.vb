Public Class Form1
    Dim WithEvents SerialPort As New IO.Ports.SerialPort

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        butFindPort_Click(sender, e)

        'ConnectSerial("hhh_000")
    End Sub

    Private Sub ConnectSerial(port_to_try As String)
        Try
            SerialPort.BaudRate = 9600
            'SerialPort.PortName = "COM5" 'notice how the ports are named? they HAVE to have COM in front of the number
            SerialPort.PortName = port_to_try 'notice how the ports are named? they HAVE to have COM in front of the number
            SerialPort.Open()
            SerialPort.Write("1") 'write a one for testing
            text_auto_select.Text = "success"
            'it will error if it is already open
        Catch
            SerialPort.Close()
            text_auto_select.Text = "error"
        End Try

        'need 2 success frist that port is available
        'then if NO error ... check if you got a 1 back from the arduino

    End Sub

    Delegate Sub myMethodDelegate(ByVal [text] As String)
    Dim myD1 As New myMethodDelegate(AddressOf myShowStringMethod)

    Sub myShowStringMethod(ByVal myString As String)
        'display text to our textbox called SerialText
        SerialText.AppendText(myString)
    End Sub

    Private Sub SerialPort_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort.DataReceived
        Dim str As String = SerialPort.ReadExisting()
        Invoke(myD1, str)
    End Sub

    Private Sub btnSend_Click_1(sender As Object, e As EventArgs) Handles btnSend.Click
        If SerialPort.IsOpen Then
            SerialPort.Write(txtSend.Text)
        Else
            ConnectSerial(textComPort.Text) 'key
            SerialPort.Write(txtSend.Text)
        End If
    End Sub

    '============================
    Private Sub butFindPort_Click(sender As Object, e As EventArgs) Handles butFindPort.Click
        ListBox1.Items.Add("COM_fake_1")
        ListBox1.Items.Add("COM_fake_2")
        Dim i As Integer
        For i = 0 To My.Computer.Ports.SerialPortNames.Count - 1
            ListBox1.Items.Add(My.Computer.Ports.SerialPortNames(i))
            ListBox1.Items.Add("COM1")
            ListBox1.Items.Add("COM2")
        Next



        'ListBox1.Items.Add("ASf")
    End Sub

    Dim list_index_counter As Integer = -1

    Private Sub but_check_port_Click(sender As Object, e As EventArgs) Handles but_check_port.Click
        '' text_auto_com.Text = textComPort.Text
        'test_port(text_auto_com.Text)

        If (list_index_counter < (ListBox1.Items.Count - 1)) Then
            list_index_counter = list_index_counter + 1
            ListBox1.SelectedIndex = list_index_counter

            text_auto_com.Text = textComPort.Text
            ConnectSerial(text_auto_com.Text)
            'need 2 success frist that port is available
            'then if NO error ... check if you got a 1 back from the arduino


        Else
            'ListBox1.SelectedIndex = list_index_counter
            list_index_counter = -1
        End If

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        textComPort.Text = ListBox1.Text
        'SerialPortSetUp()
        'Dim i As Integer
        ' For i = 0 To ListBox1.Items.Count - 1
        ' text_auto_com.Text = text_auto_com.Text + ListBox1.Items(i) + vbCrLf
        ' Next

        ' For my_list_index As Integer = 0 To ListBox1.Items.Count - 1
        'Dim l_text As String = CStr(ListBox1.Items(my_list_index))
        '  Next


    End Sub



End Class
