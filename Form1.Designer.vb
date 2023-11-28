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
        components = New ComponentModel.Container()
        ProgressBar1 = New ProgressBar()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        lblpercent = New Label()
        Timer1 = New Timer(components)
        Timer2 = New Timer(components)
        lblProcessing = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(172, 520)
        ProgressBar1.Margin = New Padding(4)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(1092, 65)
        ProgressBar1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.istockphoto_1127929107_612x612
        PictureBox1.Location = New Point(412, 106)
        PictureBox1.Margin = New Padding(4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(617, 298)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(602, 466)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(143, 32)
        Label1.TabIndex = 2
        Label1.Text = "LOADING..."
        ' 
        ' lblpercent
        ' 
        lblpercent.AutoSize = True
        lblpercent.Location = New Point(748, 467)
        lblpercent.Margin = New Padding(4, 0, 4, 0)
        lblpercent.Name = "lblpercent"
        lblpercent.Size = New Size(56, 32)
        lblpercent.TabIndex = 3
        lblpercent.Text = "000"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' Timer2
        ' 
        Timer2.Enabled = True
        ' 
        ' lblProcessing
        ' 
        lblProcessing.AutoSize = True
        lblProcessing.Location = New Point(657, 423)
        lblProcessing.Name = "lblProcessing"
        lblProcessing.Size = New Size(148, 32)
        lblProcessing.TabIndex = 4
        lblProcessing.Text = "Pocessing..."
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(14F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        ClientSize = New Size(1318, 634)
        Controls.Add(lblProcessing)
        Controls.Add(lblpercent)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(ProgressBar1)
        Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "Form1"
        Text = "Splash Screen"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblpercent As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents lblProcessing As Label
End Class
