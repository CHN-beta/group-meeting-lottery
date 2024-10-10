Public Class Form1
    Private Students_ As New List(Of List(Of String)) From
    {
        New List(Of String) From
        {
            "万文杰", "余路成", "刘才育", "周鑫", "唐甜", "姚隽祺", "娄亚筱", "张恩铭", "张梦琦", "朱玲俐",
            "杨仕铌", "杨卯伟", "杨攀", "杨玲芳", "杨鑫雨", "梁纤璐", "王瑶", "王轶蒙", "王鹏", "胡泽楷",
            "谈奇灵", "谢琳洋", "郑嘉钰", "郑杰", "陆玉鑫", "陈心路", "陈浩南", "项磊磊", "马雯", "高郁捷",
            "黄嘉芃", "黄敏", "黄泽龙", "龚树想"
        },
        New List(Of String) From
        {
            "刘辉强", "吐尔洪江·吾拉木", "宿一曼", "封辉", "张思晴", "张润涵", "李昊天", "杜颖", "杨仁琪", "林梓淇",
            "林高翔", "梁雁彤", "王小丹", "翁小蒙", "莫仕弟", "萨娜", "邓铁龙", "陈子涵", "陈豪飞", "马修益",
            "鲁浩伟"
        },
        New List(Of String) From
        {
            "任思豪", "刘世林", "刘启霖", "刘敏", "刘文博", "刘源 ", "刘金华", "危永平", "叶晓芳", "叶颖",
            "吴世明", "周博语", "周江鹏", "姚文龙", "宋欣格", "常青", "廖桂敏", "张为智", "张姝卿", "张宗南",
            "张文琴", "张晨昊", "张灵辉", "张耀宗", "张艺腾", "张裕祥", "曹宇", "曹硕", "曾国清", "李彦君",
            "李文翔", "李欣如", "李洪树", "杨镇泽", "林旺康", "柳梦宇", "王必成", "王曼", "王颖萌", "程可扬",
            "程安琪", "程舒仪", "莫炳杰", "蒋中升", "蓝进肾", "詹永萍", "赖麒鸿", "赵志国", "郑一帆", "郭叁育",
            "陈垚", "陈子龙", "陈玮健", "陈紫怡", "陈阳", "马梦薇", "高扬钧", "黄健", "黄金理", "龚彬"
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
            Process.Start(New ProcessStartInfo("https://blog.chn.moe/docs/stuff/lottery") With {.UseShellExecute = True})
        Catch ex As Exception
            MsgBox("调用浏览器失败，请手动使用浏览器访问https://blog.chn.moe/docs/stuff/lottery。")
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        For i As Integer = 0 To 2
            Students_(i).AddRange(StudentsUsed_(i))
            StudentsUsed_(i).Clear()
        Next
    End Sub
End Class
