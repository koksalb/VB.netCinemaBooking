<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.seatnumberlabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.rbtnCancel = New System.Windows.Forms.RadioButton()
        Me.rbtnReserved = New System.Windows.Forms.RadioButton()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.availableseatslabel = New System.Windows.Forms.Label()
        Me.reservedseatslabel = New System.Windows.Forms.Label()
        Me.totalseatslabel = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstReservation = New System.Windows.Forms.ListBox()
        Me.cmbDisplayOptions = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.seatnumberlabel)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtPrice)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.rbtnCancel)
        Me.GroupBox1.Controls.Add(Me.rbtnReserved)
        Me.GroupBox1.Controls.Add(Me.btnOK)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 158)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Costumer Information"
        '
        'seatnumberlabel
        '
        Me.seatnumberlabel.AutoSize = True
        Me.seatnumberlabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.seatnumberlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.seatnumberlabel.Location = New System.Drawing.Point(109, 15)
        Me.seatnumberlabel.Name = "seatnumberlabel"
        Me.seatnumberlabel.Size = New System.Drawing.Size(21, 27)
        Me.seatnumberlabel.TabIndex = 7
        Me.seatnumberlabel.Text = "-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(181, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Price"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Name"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(184, 94)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(65, 20)
        Me.txtPrice.TabIndex = 4
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(15, 94)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(148, 20)
        Me.txtName.TabIndex = 3
        '
        'rbtnCancel
        '
        Me.rbtnCancel.AutoSize = True
        Me.rbtnCancel.Location = New System.Drawing.Point(132, 47)
        Me.rbtnCancel.Name = "rbtnCancel"
        Me.rbtnCancel.Size = New System.Drawing.Size(83, 17)
        Me.rbtnCancel.TabIndex = 2
        Me.rbtnCancel.TabStop = True
        Me.rbtnCancel.Text = "Cancel Seat"
        Me.rbtnCancel.UseVisualStyleBackColor = True
        '
        'rbtnReserved
        '
        Me.rbtnReserved.AutoSize = True
        Me.rbtnReserved.Location = New System.Drawing.Point(15, 47)
        Me.rbtnReserved.Name = "rbtnReserved"
        Me.rbtnReserved.Size = New System.Drawing.Size(90, 17)
        Me.rbtnReserved.TabIndex = 1
        Me.rbtnReserved.TabStop = True
        Me.rbtnReserved.Text = "Reserve Seat"
        Me.rbtnReserved.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(66, 120)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(127, 32)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "Reserve/Cancel"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.availableseatslabel)
        Me.GroupBox2.Controls.Add(Me.reservedseatslabel)
        Me.GroupBox2.Controls.Add(Me.totalseatslabel)
        Me.GroupBox2.Location = New System.Drawing.Point(25, 197)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(257, 112)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Output Area"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Number of total Seats"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Number of Available Seats:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Number of Reserved Seats:"
        '
        'availableseatslabel
        '
        Me.availableseatslabel.AutoSize = True
        Me.availableseatslabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.availableseatslabel.Location = New System.Drawing.Point(195, 51)
        Me.availableseatslabel.Name = "availableseatslabel"
        Me.availableseatslabel.Size = New System.Drawing.Size(12, 15)
        Me.availableseatslabel.TabIndex = 2
        Me.availableseatslabel.Text = "-"
        '
        'reservedseatslabel
        '
        Me.reservedseatslabel.AutoSize = True
        Me.reservedseatslabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.reservedseatslabel.Location = New System.Drawing.Point(195, 24)
        Me.reservedseatslabel.Name = "reservedseatslabel"
        Me.reservedseatslabel.Size = New System.Drawing.Size(12, 15)
        Me.reservedseatslabel.TabIndex = 1
        Me.reservedseatslabel.Text = "-"
        '
        'totalseatslabel
        '
        Me.totalseatslabel.AutoSize = True
        Me.totalseatslabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.totalseatslabel.Location = New System.Drawing.Point(195, 77)
        Me.totalseatslabel.Name = "totalseatslabel"
        Me.totalseatslabel.Size = New System.Drawing.Size(12, 15)
        Me.totalseatslabel.TabIndex = 0
        Me.totalseatslabel.Text = "-"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.lstReservation)
        Me.GroupBox3.Controls.Add(Me.cmbDisplayOptions)
        Me.GroupBox3.Location = New System.Drawing.Point(311, 27)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(400, 282)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Theater Saloon"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(181, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Make Choice:"
        '
        'lstReservation
        '
        Me.lstReservation.FormattingEnabled = True
        Me.lstReservation.Location = New System.Drawing.Point(26, 76)
        Me.lstReservation.Name = "lstReservation"
        Me.lstReservation.Size = New System.Drawing.Size(355, 186)
        Me.lstReservation.TabIndex = 1
        '
        'cmbDisplayOptions
        '
        Me.cmbDisplayOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDisplayOptions.FormattingEnabled = True
        Me.cmbDisplayOptions.Location = New System.Drawing.Point(260, 19)
        Me.cmbDisplayOptions.Name = "cmbDisplayOptions"
        Me.cmbDisplayOptions.Size = New System.Drawing.Size(121, 21)
        Me.cmbDisplayOptions.TabIndex = 0
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 332)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "MainForm"
        Me.Text = "Cinema Booking System"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents rbtnCancel As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnReserved As System.Windows.Forms.RadioButton
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents availableseatslabel As System.Windows.Forms.Label
    Friend WithEvents reservedseatslabel As System.Windows.Forms.Label
    Friend WithEvents totalseatslabel As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lstReservation As System.Windows.Forms.ListBox
    Friend WithEvents cmbDisplayOptions As System.Windows.Forms.ComboBox
    Friend WithEvents seatnumberlabel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
