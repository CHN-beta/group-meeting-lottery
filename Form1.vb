Imports Accessibility

Public Class Form1
    Private Students_ As New List(Of List(Of String)) From
    {
        New List(Of String) From
        {
            "李鹏岗", "沈鹏", "陈心路", "林科闯", "黄敏", "闫金健", "江莹", "陈浩南", "李冠錡", "项磊磊",
            "邱鸿伟", "杨谦益", "王豪", "陈柏逸", "刘志强", "刘祥炜", "赵政仰", "付星瑞", "王轶蒙", "杨仕铌",
            "余路成", "朱玲俐", "杨攀", "高郁捷", "莫梦月", "徐溢聪", "张林珏", "陈芳琦", "许腾飞", "黄研培",
            "厉亚凯", "谈奇灵", "马雯", "姚隽祺", "张恩铭", "娄亚筱", "杨卯伟", "刘才育", "洪家闽", "郭欣宜",
            "林桢坤", "吴莉莉", "杨玲芳", "杨鑫雨", "胡泽楷", "张梦琦", "黄泽龙"
        },
        New List(Of String) From
        {
            "吐尔洪江·吾拉木", "萨娜", "王小丹", "林高翔", "邓铁龙", "杜颖", "楼伟涛", "周亮", "汤昊", "向阳",
            "鲁浩伟", "梁雁彤", "杨仁琪", "陈豪飞", "张润涵", "林梓淇", "翁小蒙", "马修益", "封辉", "陈子涵"
        },
        New List(Of String) From
        {
            "莫炳杰", "张宗南", "张裕祥", "蓝进肾", "常青", "姚文龙", "叶晓芳", "张为智", "周江鹏", "柳梦宇",
            "龚彬", "黄金理", "高扬钧", "曲善直", "陈子龙", "陈铭禹", "李锦安", "吴维", "张腾", "张爱忠",
            "张耀宗", "黄昱祺", "黄家新", "郑一帆", "马梦薇", "程安琪", "张晨昊", "危永平", "叶颖", "周博语",
            "刘敏", "吴世明", "刘源", "程可扬", "宋欣格", "李文翔", "廖桂敏", "黄健", "赖麒鸿", "任思豪",
            "张文琴", "曹硕", "程舒仪", "李洪树", "蒋中升", "王颖萌", "周鑫", "陈阳", "刘世林", "曹宇"
        }
    }
    Private StudentsUsed_ As New List(Of List(Of String)) From {New List(Of String), New List(Of String), New List(Of String)}

    Private TextBox_(2) As TextBox
    Private ButtonRegenerate_(2) As Button

    Public Sub New()
        ' 此调用是设计器所必需的。
        InitializeComponent()
        ' 在 InitializeComponent() 调用之后添加任何初始化。
        TextBox_ = {TextBox1, TextBox2, TextBox3}
        ButtonRegenerate_ = {Button2, Button3, Button4}
        OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial
    End Sub

    Private Sub set_select_name(i As Integer)
        Dim rand As New Random
        Dim current_text = TextBox_(i).Text
        While TextBox_(i).Text = current_text And (Students_(i).Count > 1 Or TextBox_(i).Text <> Students_(i)(0))
            TextBox_(i).Text = Students_(i)(rand.Next(0, Students_(i).Count))
        End While
        TextBox_(i).Refresh()
    End Sub

    Private Sub move_to_used(i As Integer, name As String)
        If CheckBox1.Checked And Students_(i).Contains(name) Then
            If Students_(i).Count > 1 Then
                Students_(i).Remove(name)
                StudentsUsed_(i).Add(name)
            Else
                Students_(i).AddRange(StudentsUsed_(i))
                StudentsUsed_(i).Clear()
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        For i As Integer = 0 To 2
            set_select_name(i)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Timer1.Enabled) Then
            Timer1.Enabled = False
            For i As Integer = 0 To 2
                move_to_used(i, TextBox_(i).Text)
            Next
            Button1.Text = "再来一次"
            For i As Integer = 0 To 2
                ButtonRegenerate_(i).Visible = True
            Next
        Else
            Timer1.Enabled = True
            Button1.Text = "停！"
            For i As Integer = 0 To 2
                ButtonRegenerate_(i).Visible = False
            Next
        End If
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles Button2.Click, Button3.Click, Button4.Click
        For i As Integer = 0 To 2
            If sender Is ButtonRegenerate_(i) Then
                set_select_name(i)
                move_to_used(i, TextBox_(i).Text)
            End If
        Next
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Not Timer1.Enabled Then
            If TextBox_(0).Text.StartsWith("陈浩") Then
                TextBox_(0).Text = "陈浩" + New List(Of String) From {"东", "西", "南", "北"}((New Random).Next(0, 4))
                TextBox_(0).Refresh()
            ElseIf TextBox_(0).Text.StartsWith("陈心") Then
                If (New Random).Next(0, 4) = 0 Then
                    TextBox_(0).Text = "陈心街"
                Else
                    TextBox_(0).Text = "陈心路"
                End If
                TextBox_(0).Refresh()
            ElseIf TextBox_(0).Text = "闫金健" Or TextBox_(0).Text = "闫银健" Then
                If (New Random).Next(0, 4) = 0 Then
                    TextBox_(0).Text = "闫银健"
                Else
                    TextBox_(0).Text = "闫金健"
                End If
                TextBox_(0).Refresh()
            ElseIf TextBox_(0).Text = "杨鑫雨" Or TextBox_(0).Text = "杨嘉乐" Then
                If (New Random).Next(0, 4) = 0 Then
                    TextBox_(0).Text = "杨嘉乐"
                Else
                    TextBox_(0).Text = "杨鑫雨"
                End If
                TextBox_(0).Refresh()
            ElseIf TextBox_(0).Text.Length = 3 AndAlso TextBox_(0).Text(0) = "项" AndAlso TextBox_(0).Text(1) = TextBox_(0).Text(2) Then
                If (New Random).Next(0, 4) = 0 Then
                    Dim alternate_chars As New List(Of Char) From {CChar("鑫"), CChar("森"), CChar("淼"), CChar("焱"), CChar("垚")}
                    Dim alternate_char = alternate_chars((New Random).Next(0, alternate_chars.Count))
                    TextBox_(0).Text = "项" + alternate_char + alternate_char
                Else
                    TextBox_(0).Text = "项磊磊"
                End If
                TextBox_(0).Refresh()
            End If
        End If
        ' If Me.Text = "" Then
        '     Me.Text = "激★情★大★抽★奖"
        ' Else
        '     Me.Text = ""
        ' End If
    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim dialog As New SaveFileDialog With {.Filter = "Excel 工作簿|*.xlsx", .Title = "保存为excel", .FileName = "成员名单"}
        Dim result = dialog.ShowDialog()
        Dim students As New List(Of List(Of String))
        students = Students_
        For i As Integer = 0 To 2
            students(i).AddRange(StudentsUsed_(i))
        Next
        If result = DialogResult.OK Then
            Try
                If FileIO.FileSystem.FileExists(dialog.FileName) Then FileIO.FileSystem.DeleteFile(dialog.FileName)
                Dim file As New OfficeOpenXml.ExcelPackage(dialog.FileName)
                Dim sheet = file.Workbook.Worksheets.Add("分组名单")
                For i As Integer = 0 To 2
                    Dim c = Chr(Asc("A"c) + i)
                    sheet.Cells(c + "1").Value = "第" + Convert.ToString(i + 1) + "小组"
                    For j As Integer = 0 To students(i).Count - 1
                        sheet.Cells(c + Convert.ToString(j + 2)).Value = students(i)(j)
                    Next
                Next
                file.Save()
                MsgBox("保存成功")
            Catch ex As Exception
                MsgBox("保存失败")
            End Try
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            Process.Start(New ProcessStartInfo("https://kkmeeting.chn.moe") With {.UseShellExecute = True})
        Catch ex As Exception
            MsgBox("调用浏览器失败，请手动使用浏览器访问kkmeeting.chn.moe。")
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            Process.Start(New ProcessStartInfo("https://github.com/CHN-beta/group-meeting-lottery") With {.UseShellExecute = True})
        Catch ex As Exception
            MsgBox("调用浏览器失败，请手动使用浏览器访问kkmeeting.chn.moe。")
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        For i As Integer = 0 To 2
            Students_(i).AddRange(StudentsUsed_(i))
            StudentsUsed_(i).Clear()
        Next
    End Sub
End Class
