<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        radseniorcitizen = New RadioButton()
        radStudent = New RadioButton()
        radChild = New RadioButton()
        radAdult = New RadioButton()
        GroupBox2 = New GroupBox()
        chkTrainer = New CheckBox()
        chkKarate = New CheckBox()
        chkYoga = New CheckBox()
        GroupBox3 = New GroupBox()
        Label1 = New Label()
        txtMonths = New TextBox()
        GroupBox4 = New GroupBox()
        lblTotal = New Label()
        lblMonthlyFees = New Label()
        Label3 = New Label()
        Label2 = New Label()
        btnCalculate = New Button()
        btnClear = New Button()
        btnExit = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.Info
        GroupBox1.Controls.Add(radseniorcitizen)
        GroupBox1.Controls.Add(radStudent)
        GroupBox1.Controls.Add(radChild)
        GroupBox1.Controls.Add(radAdult)
        GroupBox1.Location = New Point(17, 15)
        GroupBox1.Margin = New Padding(4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4)
        GroupBox1.Size = New Size(567, 326)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Type of Membership"
        ' 
        ' radseniorcitizen
        ' 
        radseniorcitizen.AutoSize = True
        radseniorcitizen.Location = New Point(56, 252)
        radseniorcitizen.Margin = New Padding(4)
        radseniorcitizen.Name = "radseniorcitizen"
        radseniorcitizen.Size = New Size(197, 36)
        radseniorcitizen.TabIndex = 3
        radseniorcitizen.TabStop = True
        radseniorcitizen.Text = "Senior Citizen"
        radseniorcitizen.UseVisualStyleBackColor = True
        ' 
        ' radStudent
        ' 
        radStudent.AutoSize = True
        radStudent.Location = New Point(56, 187)
        radStudent.Margin = New Padding(4)
        radStudent.Name = "radStudent"
        radStudent.Size = New Size(127, 36)
        radStudent.TabIndex = 2
        radStudent.TabStop = True
        radStudent.Text = "Student"
        radStudent.UseVisualStyleBackColor = True
        ' 
        ' radChild
        ' 
        radChild.AutoSize = True
        radChild.Location = New Point(56, 115)
        radChild.Margin = New Padding(4)
        radChild.Name = "radChild"
        radChild.Size = New Size(245, 36)
        radChild.TabIndex = 1
        radChild.TabStop = True
        radChild.Text = "Child(12 && under)"
        radChild.UseVisualStyleBackColor = True
        ' 
        ' radAdult
        ' 
        radAdult.AutoSize = True
        radAdult.Location = New Point(56, 52)
        radAdult.Margin = New Padding(4)
        radAdult.Name = "radAdult"
        radAdult.Size = New Size(211, 36)
        radAdult.TabIndex = 0
        radAdult.TabStop = True
        radAdult.Text = "Standard &Adult"
        radAdult.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.Info
        GroupBox2.Controls.Add(chkTrainer)
        GroupBox2.Controls.Add(chkKarate)
        GroupBox2.Controls.Add(chkYoga)
        GroupBox2.Location = New Point(609, 15)
        GroupBox2.Margin = New Padding(4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(4)
        GroupBox2.Size = New Size(490, 326)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Options"
        ' 
        ' chkTrainer
        ' 
        chkTrainer.AutoSize = True
        chkTrainer.Location = New Point(90, 204)
        chkTrainer.Margin = New Padding(4)
        chkTrainer.Name = "chkTrainer"
        chkTrainer.Size = New Size(225, 36)
        chkTrainer.TabIndex = 2
        chkTrainer.Text = "Personal Trainer"
        chkTrainer.UseVisualStyleBackColor = True
        ' 
        ' chkKarate
        ' 
        chkKarate.AutoSize = True
        chkKarate.Location = New Point(90, 115)
        chkKarate.Margin = New Padding(4)
        chkKarate.Name = "chkKarate"
        chkKarate.Size = New Size(114, 36)
        chkKarate.TabIndex = 1
        chkKarate.Text = "Karate"
        chkKarate.UseVisualStyleBackColor = True
        ' 
        ' chkYoga
        ' 
        chkYoga.AutoSize = True
        chkYoga.Location = New Point(90, 38)
        chkYoga.Margin = New Padding(4)
        chkYoga.Name = "chkYoga"
        chkYoga.Size = New Size(96, 36)
        chkYoga.TabIndex = 0
        chkYoga.Text = "Yoga"
        chkYoga.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = SystemColors.Info
        GroupBox3.Controls.Add(Label1)
        GroupBox3.Controls.Add(txtMonths)
        GroupBox3.Location = New Point(17, 349)
        GroupBox3.Margin = New Padding(4)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(4)
        GroupBox3.Size = New Size(567, 271)
        GroupBox3.TabIndex = 2
        GroupBox3.TabStop = False
        GroupBox3.Text = "Membership Length"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(56, 67)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(346, 32)
        Label1.TabIndex = 1
        Label1.Text = "Enter the number of Months:"
        ' 
        ' txtMonths
        ' 
        txtMonths.Location = New Point(69, 154)
        txtMonths.Margin = New Padding(4)
        txtMonths.Name = "txtMonths"
        txtMonths.Size = New Size(276, 39)
        txtMonths.TabIndex = 0
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackColor = SystemColors.Info
        GroupBox4.Controls.Add(lblTotal)
        GroupBox4.Controls.Add(lblMonthlyFees)
        GroupBox4.Controls.Add(Label3)
        GroupBox4.Controls.Add(Label2)
        GroupBox4.Location = New Point(609, 349)
        GroupBox4.Margin = New Padding(4)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Padding = New Padding(4)
        GroupBox4.Size = New Size(490, 272)
        GroupBox4.TabIndex = 3
        GroupBox4.TabStop = False
        GroupBox4.Text = "Membership Fees"
        ' 
        ' lblTotal
        ' 
        lblTotal.BorderStyle = BorderStyle.Fixed3D
        lblTotal.Location = New Point(267, 175)
        lblTotal.Margin = New Padding(4, 0, 4, 0)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(153, 32)
        lblTotal.TabIndex = 7
        ' 
        ' lblMonthlyFees
        ' 
        lblMonthlyFees.BorderStyle = BorderStyle.Fixed3D
        lblMonthlyFees.Location = New Point(267, 81)
        lblMonthlyFees.Margin = New Padding(4, 0, 4, 0)
        lblMonthlyFees.Name = "lblMonthlyFees"
        lblMonthlyFees.Size = New Size(153, 32)
        lblMonthlyFees.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(182, 175)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 32)
        Label3.TabIndex = 3
        Label3.Text = "Total:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(97, 81)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(162, 32)
        Label2.TabIndex = 1
        Label2.Text = "Monthly Fee:"
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(330, 687)
        btnCalculate.Margin = New Padding(4)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(156, 53)
        btnCalculate.TabIndex = 4
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(590, 687)
        btnClear.Margin = New Padding(4)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(160, 53)
        btnClear.TabIndex = 5
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(847, 687)
        btnExit.Margin = New Padding(4)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(173, 53)
        btnExit.TabIndex = 6
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(14F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1141, 760)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnCalculate)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Margin = New Padding(4)
        Name = "Form4"
        Text = "Form4"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radseniorcitizen As RadioButton
    Friend WithEvents radStudent As RadioButton
    Friend WithEvents radChild As RadioButton
    Friend WithEvents radAdult As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkTrainer As CheckBox
    Friend WithEvents chkKarate As CheckBox
    Friend WithEvents chkYoga As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMonths As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblMonthlyFees As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
