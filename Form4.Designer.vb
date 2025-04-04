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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Panel1 = New Panel()
        Label1 = New Label()
        Panel5 = New Panel()
        Button4 = New Button()
        PictureBox4 = New PictureBox()
        Panel4 = New Panel()
        Button3 = New Button()
        PictureBox3 = New PictureBox()
        Panel3 = New Panel()
        Button1 = New Button()
        PictureBox2 = New PictureBox()
        Panel2 = New Panel()
        Button2 = New Button()
        PictureBox1 = New PictureBox()
        Button5 = New Button()
        HelpProvider1 = New HelpProvider()
        Panel1.SuspendLayout()
        Panel5.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Tan
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(16, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1283, 652)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(561, 447)
        Label1.Name = "Label1"
        Label1.Size = New Size(165, 38)
        Label1.TabIndex = 10
        Label1.Text = "HOT COFFE"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Sienna
        Panel5.Controls.Add(Button4)
        Panel5.Controls.Add(PictureBox4)
        Panel5.Location = New Point(966, 98)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(285, 328)
        Panel5.TabIndex = 1
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Tan
        Button4.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(1, 270)
        Button4.Name = "Button4"
        Button4.Size = New Size(281, 56)
        Button4.TabIndex = 10
        Button4.Text = "Americano"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Tan
        PictureBox4.Image = My.Resources.Resources.images__2__Photoroom
        PictureBox4.Location = New Point(17, 20)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(250, 236)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 2
        PictureBox4.TabStop = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Sienna
        Panel4.Controls.Add(Button3)
        Panel4.Controls.Add(PictureBox3)
        Panel4.Location = New Point(652, 98)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(285, 328)
        Panel4.TabIndex = 1
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Tan
        Button3.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(4, 268)
        Button3.Name = "Button3"
        Button3.Size = New Size(278, 59)
        Button3.TabIndex = 9
        Button3.Text = "Chocolate Mocha"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Tan
        PictureBox3.Image = My.Resources.Resources.WhiteChocolateMocha_Photoroom
        PictureBox3.Location = New Point(15, 21)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(250, 236)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 2
        PictureBox3.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Sienna
        Panel3.Controls.Add(Button1)
        Panel3.Controls.Add(PictureBox2)
        Panel3.Location = New Point(339, 97)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(285, 327)
        Panel3.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Tan
        Button1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(4, 268)
        Button1.Name = "Button1"
        Button1.Size = New Size(278, 56)
        Button1.TabIndex = 8
        Button1.Text = "Dark Chocolate"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Tan
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(16, 21)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(253, 236)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Sienna
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Location = New Point(30, 98)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(285, 327)
        Panel2.TabIndex = 0
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Tan
        Button2.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(1, 268)
        Button2.Name = "Button2"
        Button2.Size = New Size(281, 56)
        Button2.TabIndex = 7
        Button2.Text = "Mocha"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Tan
        PictureBox1.Image = My.Resources.Resources.imageset_caffe_mocha__caffe_mocha_Photoroom
        PictureBox1.Location = New Point(17, 20)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(250, 236)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Black
        Button5.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = SystemColors.ButtonHighlight
        Button5.Location = New Point(1257, 0)
        Button5.Name = "Button5"
        Button5.Size = New Size(42, 34)
        Button5.TabIndex = 3
        Button5.Text = "X"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(1297, 649)
        Controls.Add(Button5)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form4"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel5.ResumeLayout(False)
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
