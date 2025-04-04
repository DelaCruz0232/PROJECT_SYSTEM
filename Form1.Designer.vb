<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Panel1 = New Panel()
        Button5 = New Button()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        UnameTB = New TextBox()
        PasswordTB = New TextBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Tan
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(403, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(449, 446)
        Panel1.TabIndex = 0
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Tan
        Button5.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = SystemColors.ControlText
        Button5.Location = New Point(405, 0)
        Button5.Name = "Button5"
        Button5.Size = New Size(42, 35)
        Button5.TabIndex = 7
        Button5.Text = "X"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlText
        Label3.Location = New Point(100, 69)
        Label3.Name = "Label3"
        Label3.Size = New Size(244, 38)
        Label3.TabIndex = 3
        Label3.Text = "TARA KAPE TAYO"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.istockphoto_1267682472_612x612_Photoroom
        PictureBox1.Location = New Point(0, 89)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(449, 356)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlText
        Label1.Location = New Point(37, 152)
        Label1.Name = "Label1"
        Label1.Size = New Size(156, 38)
        Label1.TabIndex = 1
        Label1.Text = "Username:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlText
        Label2.Location = New Point(37, 228)
        Label2.Name = "Label2"
        Label2.Size = New Size(147, 38)
        Label2.TabIndex = 2
        Label2.Text = "Password:"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(232, 294)
        Button1.Name = "Button1"
        Button1.Size = New Size(118, 40)
        Button1.TabIndex = 4
        Button1.Text = "Log in"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' UnameTB
        ' 
        UnameTB.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UnameTB.Location = New Point(208, 152)
        UnameTB.Name = "UnameTB"
        UnameTB.Size = New Size(166, 38)
        UnameTB.TabIndex = 5
        ' 
        ' PasswordTB
        ' 
        PasswordTB.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PasswordTB.Location = New Point(208, 228)
        PasswordTB.Name = "PasswordTB"
        PasswordTB.Size = New Size(166, 38)
        PasswordTB.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SaddleBrown
        ClientSize = New Size(849, 443)
        Controls.Add(PasswordTB)
        Controls.Add(UnameTB)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents UnameTB As TextBox
    Friend WithEvents PasswordTB As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button5 As Button

End Class
