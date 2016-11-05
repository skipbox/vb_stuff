<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.txtSend = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SerialText = New System.Windows.Forms.TextBox()
        Me.text_auto_com = New System.Windows.Forms.TextBox()
        Me.text_auto_select = New System.Windows.Forms.Button()
        Me.textComPort = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.butFindPort = New System.Windows.Forms.Button()
        Me.but_check_port = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSend
        '
        Me.btnSend.Font = New System.Drawing.Font("Facebook Letter Faces", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSend.Location = New System.Drawing.Point(643, 139)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(259, 56)
        Me.btnSend.TabIndex = 0
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'txtSend
        '
        Me.txtSend.Location = New System.Drawing.Point(643, 207)
        Me.txtSend.Name = "txtSend"
        Me.txtSend.Size = New System.Drawing.Size(259, 22)
        Me.txtSend.TabIndex = 1
        Me.txtSend.Text = "1"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(524, 80)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(223, 24)
        Me.ComboBox1.TabIndex = 2
        '
        'SerialText
        '
        Me.SerialText.Location = New System.Drawing.Point(498, 245)
        Me.SerialText.Multiline = True
        Me.SerialText.Name = "SerialText"
        Me.SerialText.Size = New System.Drawing.Size(198, 145)
        Me.SerialText.TabIndex = 3
        '
        'text_auto_com
        '
        Me.text_auto_com.Location = New System.Drawing.Point(165, 61)
        Me.text_auto_com.Multiline = True
        Me.text_auto_com.Name = "text_auto_com"
        Me.text_auto_com.Size = New System.Drawing.Size(143, 132)
        Me.text_auto_com.TabIndex = 16
        '
        'text_auto_select
        '
        Me.text_auto_select.Location = New System.Drawing.Point(12, 296)
        Me.text_auto_select.Name = "text_auto_select"
        Me.text_auto_select.Size = New System.Drawing.Size(147, 49)
        Me.text_auto_select.TabIndex = 15
        Me.text_auto_select.Text = "text_auto_select"
        Me.text_auto_select.UseVisualStyleBackColor = True
        '
        'textComPort
        '
        Me.textComPort.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.textComPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textComPort.Location = New System.Drawing.Point(12, 193)
        Me.textComPort.Name = "textComPort"
        Me.textComPort.Size = New System.Drawing.Size(145, 36)
        Me.textComPort.TabIndex = 14
        Me.textComPort.Text = "textComPort"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(12, 61)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(147, 132)
        Me.ListBox1.TabIndex = 13
        '
        'butFindPort
        '
        Me.butFindPort.Location = New System.Drawing.Point(12, 12)
        Me.butFindPort.Name = "butFindPort"
        Me.butFindPort.Size = New System.Drawing.Size(147, 49)
        Me.butFindPort.TabIndex = 12
        Me.butFindPort.Text = "butFindPort"
        Me.butFindPort.UseVisualStyleBackColor = True
        '
        'but_check_port
        '
        Me.but_check_port.Location = New System.Drawing.Point(12, 230)
        Me.but_check_port.Name = "but_check_port"
        Me.but_check_port.Size = New System.Drawing.Size(147, 45)
        Me.but_check_port.TabIndex = 17
        Me.but_check_port.Text = "check_port"
        Me.but_check_port.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 424)
        Me.Controls.Add(Me.but_check_port)
        Me.Controls.Add(Me.text_auto_com)
        Me.Controls.Add(Me.text_auto_select)
        Me.Controls.Add(Me.textComPort)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.butFindPort)
        Me.Controls.Add(Me.SerialText)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.txtSend)
        Me.Controls.Add(Me.btnSend)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSend As Button
    Friend WithEvents txtSend As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents SerialText As TextBox
    Friend WithEvents text_auto_com As TextBox
    Friend WithEvents text_auto_select As Button
    Friend WithEvents textComPort As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents butFindPort As Button
    Friend WithEvents but_check_port As Button
End Class
