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
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label2 = New Label()
        Button3 = New Button()
        TextBox3 = New TextBox()
        Label3 = New Label()
        Button4 = New Button()
        Timer1 = New Timer(components)
        Timer2 = New Timer(components)
        Label5 = New Label()
        Button6 = New Button()
        CheckBox1 = New CheckBox()
        Button7 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Microsoft YaHei UI", 26.25F)
        Button1.Location = New Point(256, 252)
        Button1.Name = "Button1"
        Button1.Size = New Size(170, 72)
        Button1.TabIndex = 0
        Button1.Text = "开始抽奖"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Microsoft YaHei UI", 26.25F)
        Button2.Location = New Point(479, 38)
        Button2.Name = "Button2"
        Button2.Size = New Size(147, 60)
        Button2.TabIndex = 1
        Button2.Text = "换一个"
        Button2.UseVisualStyleBackColor = True
        Button2.Visible = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft YaHei UI", 26.25F)
        Label1.Location = New Point(51, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(160, 46)
        Label1.TabIndex = 2
        Label1.Text = "第一小组"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.HighlightText
        TextBox1.Font = New Font("Microsoft YaHei UI", 26.25F)
        TextBox1.Location = New Point(217, 42)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(256, 52)
        TextBox1.TabIndex = 3
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.HighlightText
        TextBox2.Font = New Font("Microsoft YaHei UI", 26.25F)
        TextBox2.Location = New Point(217, 108)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(256, 52)
        TextBox2.TabIndex = 6
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft YaHei UI", 26.25F)
        Label2.Location = New Point(51, 111)
        Label2.Name = "Label2"
        Label2.Size = New Size(160, 46)
        Label2.TabIndex = 5
        Label2.Text = "第二小组"
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Microsoft YaHei UI", 26.25F)
        Button3.Location = New Point(479, 104)
        Button3.Name = "Button3"
        Button3.Size = New Size(147, 60)
        Button3.TabIndex = 4
        Button3.Text = "换一个"
        Button3.UseVisualStyleBackColor = True
        Button3.Visible = False
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.HighlightText
        TextBox3.Font = New Font("Microsoft YaHei UI", 26.25F)
        TextBox3.Location = New Point(217, 174)
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(256, 52)
        TextBox3.TabIndex = 9
        TextBox3.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft YaHei UI", 26.25F)
        Label3.Location = New Point(51, 177)
        Label3.Name = "Label3"
        Label3.Size = New Size(160, 46)
        Label3.TabIndex = 8
        Label3.Text = "第三小组"
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Microsoft YaHei UI", 26.25F)
        Button4.Location = New Point(479, 170)
        Button4.Name = "Button4"
        Button4.Size = New Size(147, 60)
        Button4.TabIndex = 7
        Button4.Text = "换一个"
        Button4.UseVisualStyleBackColor = True
        Button4.Visible = False
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 50
        ' 
        ' Timer2
        ' 
        Timer2.Enabled = True
        Timer2.Interval = 500
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(418, 386)
        Label5.Name = "Label5"
        Label5.Size = New Size(244, 17)
        Label5.TabIndex = 13
        Label5.Text = "code by 陈浩南@第一小组 2024年10月6日"
        Label5.TextAlign = ContentAlignment.TopRight
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(152, 374)
        Button6.Name = "Button6"
        Button6.Size = New Size(107, 23)
        Button6.TabIndex = 14
        Button6.Text = "导出名单到excel"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Checked = True
        CheckBox1.CheckState = CheckState.Checked
        CheckBox1.Location = New Point(106, 330)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(471, 38)
        CheckBox1.TabIndex = 15
        CheckBox1.Text = "尽量避免重复" & vbCrLf & "（已经抽到过的人将不再被抽到，除非程序被重启或那个小组的人都轮换了一遍。）" & vbCrLf
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(17, 374)
        Button7.Name = "Button7"
        Button7.Size = New Size(131, 23)
        Button7.TabIndex = 16
        Button7.Text = "下载最新版和源代码"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(669, 406)
        Controls.Add(Button7)
        Controls.Add(CheckBox1)
        Controls.Add(Button6)
        Controls.Add(Label5)
        Controls.Add(TextBox3)
        Controls.Add(Label3)
        Controls.Add(Button4)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(Button3)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.Fixed3D
        ImeMode = ImeMode.Disable
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "KK集团大组会抽奖"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label5 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button7 As Button
End Class
