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
        Button8 = New Button()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Drawing.Font("Microsoft YaHei UI", 26.25F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        Button1.Location = New Drawing.Point(231, 249)
        Button1.Name = "Button1"
        Button1.Size = New Drawing.Size(170, 72)
        Button1.TabIndex = 0
        Button1.Text = "开始抽奖"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Drawing.Font("Microsoft YaHei UI", 26.25F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        Button2.Location = New Drawing.Point(421, 38)
        Button2.Name = "Button2"
        Button2.Size = New Drawing.Size(147, 60)
        Button2.TabIndex = 1
        Button2.Text = "换一个"
        Button2.UseVisualStyleBackColor = True
        Button2.Visible = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Drawing.Font("Microsoft YaHei UI", 26.25F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        Label1.Location = New Drawing.Point(51, 45)
        Label1.Name = "Label1"
        Label1.Size = New Drawing.Size(160, 46)
        Label1.TabIndex = 2
        Label1.Text = "第一小组"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Drawing.SystemColors.HighlightText
        TextBox1.Font = New Drawing.Font("Microsoft YaHei UI", 26.25F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        TextBox1.Location = New Drawing.Point(217, 42)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Drawing.Size(198, 52)
        TextBox1.TabIndex = 3
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Drawing.SystemColors.HighlightText
        TextBox2.Font = New Drawing.Font("Microsoft YaHei UI", 26.25F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        TextBox2.Location = New Drawing.Point(217, 108)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Drawing.Size(198, 52)
        TextBox2.TabIndex = 6
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Drawing.Font("Microsoft YaHei UI", 26.25F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        Label2.Location = New Drawing.Point(51, 111)
        Label2.Name = "Label2"
        Label2.Size = New Drawing.Size(160, 46)
        Label2.TabIndex = 5
        Label2.Text = "第二小组"
        ' 
        ' Button3
        ' 
        Button3.Font = New Drawing.Font("Microsoft YaHei UI", 26.25F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        Button3.Location = New Drawing.Point(421, 104)
        Button3.Name = "Button3"
        Button3.Size = New Drawing.Size(147, 60)
        Button3.TabIndex = 4
        Button3.Text = "换一个"
        Button3.UseVisualStyleBackColor = True
        Button3.Visible = False
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Drawing.SystemColors.HighlightText
        TextBox3.Font = New Drawing.Font("Microsoft YaHei UI", 26.25F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        TextBox3.Location = New Drawing.Point(217, 174)
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Drawing.Size(198, 52)
        TextBox3.TabIndex = 9
        TextBox3.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Drawing.Font("Microsoft YaHei UI", 26.25F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        Label3.Location = New Drawing.Point(51, 177)
        Label3.Name = "Label3"
        Label3.Size = New Drawing.Size(160, 46)
        Label3.TabIndex = 8
        Label3.Text = "第三小组"
        ' 
        ' Button4
        ' 
        Button4.Font = New Drawing.Font("Microsoft YaHei UI", 26.25F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        Button4.Location = New Drawing.Point(421, 170)
        Button4.Name = "Button4"
        Button4.Size = New Drawing.Size(147, 60)
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
        Label5.Location = New Drawing.Point(352, 437)
        Label5.Name = "Label5"
        Label5.Size = New Drawing.Size(244, 17)
        Label5.TabIndex = 13
        Label5.Text = "code by 陈浩南@第一小组 2023年9月21日"
        Label5.TextAlign = Drawing.ContentAlignment.TopRight
        ' 
        ' Button6
        ' 
        Button6.Location = New Drawing.Point(109, 434)
        Button6.Name = "Button6"
        Button6.Size = New Drawing.Size(107, 23)
        Button6.TabIndex = 14
        Button6.Text = "导出名单到excel"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Checked = True
        CheckBox1.CheckState = CheckState.Checked
        CheckBox1.Location = New Drawing.Point(78, 327)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Drawing.Size(471, 38)
        CheckBox1.TabIndex = 15
        CheckBox1.Text = "尽量避免重复" & vbCrLf & "（已经抽到过的人将不再被抽到，除非程序被重启或那个小组的人都轮换了一遍。）" & vbCrLf
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Drawing.Point(12, 406)
        Button7.Name = "Button7"
        Button7.Size = New Drawing.Size(81, 23)
        Button7.TabIndex = 16
        Button7.Text = "下载最新版"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Location = New Drawing.Point(12, 434)
        Button8.Name = "Button8"
        Button8.Size = New Drawing.Size(81, 23)
        Button8.TabIndex = 17
        Button8.Text = "获取源代码"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Drawing.Point(99, 409)
        Label6.Name = "Label6"
        Label6.Size = New Drawing.Size(181, 17)
        Label6.TabIndex = 18
        Label6.Text = "或手动访问kkmeeting.chn.moe"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New Drawing.SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Drawing.Size(608, 464)
        Controls.Add(Label6)
        Controls.Add(Button8)
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
    Friend WithEvents Button8 As Button
    Friend WithEvents Label6 As Label
End Class
