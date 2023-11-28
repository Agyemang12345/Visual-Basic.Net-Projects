<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        GroupBox1 = New GroupBox()
        txtnumberofMonths = New TextBox()
        txtDownPayment = New TextBox()
        txtVehicleCost = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        radUsed = New RadioButton()
        radNew = New RadioButton()
        GroupBox3 = New GroupBox()
        lstPrincipalPayment = New ListBox()
        Label4 = New Label()
        lblInterestRate = New Label()
        btnCalculate = New Button()
        btnClear = New Button()
        btnExit = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtnumberofMonths)
        GroupBox1.Controls.Add(txtDownPayment)
        GroupBox1.Controls.Add(txtVehicleCost)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(17, 15)
        GroupBox1.Margin = New Padding(4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4)
        GroupBox1.Size = New Size(585, 324)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Vehicle && Loan Information"
        ' 
        ' txtnumberofMonths
        ' 
        txtnumberofMonths.Location = New Point(347, 201)
        txtnumberofMonths.Margin = New Padding(4)
        txtnumberofMonths.Name = "txtnumberofMonths"
        txtnumberofMonths.Size = New Size(208, 39)
        txtnumberofMonths.TabIndex = 5
        ' 
        ' txtDownPayment
        ' 
        txtDownPayment.Location = New Point(347, 116)
        txtDownPayment.Margin = New Padding(4)
        txtDownPayment.Name = "txtDownPayment"
        txtDownPayment.Size = New Size(208, 39)
        txtDownPayment.TabIndex = 4
        ' 
        ' txtVehicleCost
        ' 
        txtVehicleCost.Location = New Point(347, 50)
        txtVehicleCost.Margin = New Padding(4)
        txtVehicleCost.Name = "txtVehicleCost"
        txtVehicleCost.Size = New Size(208, 39)
        txtVehicleCost.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(64, 208)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(240, 32)
        Label3.TabIndex = 2
        Label3.Text = "Number of Months:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(8, 111)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(325, 32)
        Label2.TabIndex = 1
        Label2.Text = "Amount fo Down Payment:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(115, 36)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(189, 32)
        Label1.TabIndex = 0
        Label1.Text = "Cost of Vehicle:"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(radUsed)
        GroupBox2.Controls.Add(radNew)
        GroupBox2.Location = New Point(610, 32)
        GroupBox2.Margin = New Padding(4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(4)
        GroupBox2.Size = New Size(224, 307)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "New or Used"
        ' 
        ' radUsed
        ' 
        radUsed.AutoSize = True
        radUsed.Location = New Point(58, 168)
        radUsed.Margin = New Padding(4)
        radUsed.Name = "radUsed"
        radUsed.Size = New Size(95, 36)
        radUsed.TabIndex = 1
        radUsed.TabStop = True
        radUsed.Text = "Used"
        radUsed.UseVisualStyleBackColor = True
        ' 
        ' radNew
        ' 
        radNew.AutoSize = True
        radNew.Location = New Point(58, 73)
        radNew.Margin = New Padding(4)
        radNew.Name = "radNew"
        radNew.Size = New Size(90, 36)
        radNew.TabIndex = 0
        radNew.TabStop = True
        radNew.Text = "New"
        radNew.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(lstPrincipalPayment)
        GroupBox3.Location = New Point(25, 360)
        GroupBox3.Margin = New Padding(4)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(4)
        GroupBox3.Size = New Size(1084, 417)
        GroupBox3.TabIndex = 2
        GroupBox3.TabStop = False
        GroupBox3.Text = "Interest and Principal Payments"
        ' 
        ' lstPrincipalPayment
        ' 
        lstPrincipalPayment.FormattingEnabled = True
        lstPrincipalPayment.ItemHeight = 32
        lstPrincipalPayment.Location = New Point(8, 31)
        lstPrincipalPayment.Margin = New Padding(4)
        lstPrincipalPayment.Name = "lstPrincipalPayment"
        lstPrincipalPayment.Size = New Size(1068, 388)
        lstPrincipalPayment.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(899, 51)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(256, 32)
        Label4.TabIndex = 3
        Label4.Text = "Annual Interest Rate:"
        ' 
        ' lblInterestRate
        ' 
        lblInterestRate.BorderStyle = BorderStyle.Fixed3D
        lblInterestRate.Location = New Point(978, 109)
        lblInterestRate.Margin = New Padding(4, 0, 4, 0)
        lblInterestRate.Name = "lblInterestRate"
        lblInterestRate.Size = New Size(160, 49)
        lblInterestRate.TabIndex = 4
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(297, 801)
        btnCalculate.Margin = New Padding(4)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(161, 60)
        btnCalculate.TabIndex = 5
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(559, 801)
        btnClear.Margin = New Padding(4)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(152, 60)
        btnClear.TabIndex = 6
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(837, 801)
        btnExit.Margin = New Padding(4)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(158, 60)
        btnExit.TabIndex = 7
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(14F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1260, 874)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnCalculate)
        Controls.Add(lblInterestRate)
        Controls.Add(Label4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Margin = New Padding(4)
        Name = "Form5"
        Text = "Form5"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtnumberofMonths As TextBox
    Friend WithEvents txtDownPayment As TextBox
    Friend WithEvents txtVehicleCost As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radUsed As RadioButton
    Friend WithEvents radNew As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblInterestRate As Label
    Friend WithEvents lstPrincipalPayment As ListBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
