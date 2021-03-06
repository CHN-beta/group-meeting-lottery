Public Class Form1
    Private Students_() As List(Of String) =
    {
        New List(Of String) From
        {
            "蔡文为", "蔡叶杭", "陈秉桓", "陈柏逸", "陈瀚", "陈浩南", "陈俊鑫", "陈心路", "付星瑞", "郭斌", "郭中丽",
            "胡汛", "江莹", "李鹏岗", "林泽锋", "刘国振", "刘璐", "刘志强", "卢诗强", "邱鸿伟", "沈鹏", "石澜", "唐锐凡",
            "唐燕", "王豪", "王丽兰", "王永嘉", "项磊磊", "闫金健", "杨谦益", "张宏烨", "赵珊珊", "赵政仰", "钟志白", "周其程"
        },
        New List(Of String) From
        {
            "邓铁龙", "杜颖", "黄鑫", "林高翔", "楼伟涛", "曲真魁", "萨娜", "沈晓鑫", "汤昊", "吐尔洪江 吾拉木 ", "王小丹",
            "王紫云", "向阳", "邢欢", "许书逸", "张晓娟", "赵经天", "郑力诚"
        },
        New List(Of String) From
        {
            "曾鑫龙", "常青", "陈晨", "陈铭禹", "陈子龙", "范洋涛", "费煜晨", "高扬钧", "胡玮琳", "黄飞鸿", "黄家新",
            "蓝进肾", "李光容", "李锦安", "李迎秋", "林建平", "刘海洋", "刘兴宜", "柳梦宇", "莫炳杰", "聂思晴", "平坦",
            "曲善直", "檀鹏", "唐唯卿", "万景", "吴建峰", "吴启鹏", "吴维", "吴雪峰", "徐聪卉", "徐望舒", "杨成彪", "叶晓芳",
            "张爱忠", "张腾", "张耀宗", "张裕祥", "张宗南", "周小龙"
        },
        New List(Of String) From {"赵三", "赵四", "赵五"}
    }

    Private TextBox_(3) As TextBox
    Private ButtonRegenerate_(3) As Button

    Public Sub New()
        ' 此调用是设计器所必需的。
        InitializeComponent()
        ' 在 InitializeComponent() 调用之后添加任何初始化。
        TextBox_ = {TextBox1, TextBox2, TextBox3, TextBox4}
        ButtonRegenerate_ = {Button2, Button3, Button4, Button5}
    End Sub

    Private Sub set_select_name(i As Integer)
        Dim rand As New Random
        Dim current_text = TextBox_(i).Text
        While current_text = TextBox_(i).Text
            TextBox_(i).Text = Students_(i)(rand.Next(0, Students_(i).Count))
        End While
        TextBox_(i).Refresh()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'For i As Integer = 0 To 3
        For i As Integer = 0 To 2
            set_select_name(i)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Timer1.Enabled) Then
            Timer1.Enabled = False
            Button1.Text = "再来一次"
            'For i As Integer = 0 To 3
            For i As Integer = 0 To 2
                ButtonRegenerate_(i).Visible = True
            Next
        Else
            Timer1.Enabled = True
            Button1.Text = "停！"
            'For i As Integer = 0 To 3
            For i As Integer = 0 To 2
                ButtonRegenerate_(i).Visible = False
            Next
        End If
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles Button2.Click, Button3.Click, Button4.Click, Button5.Click
        'For i As Integer = 0 To 3
        For i As Integer = 0 To 2
            If sender Is ButtonRegenerate_(i) Then
                set_select_name(i)
            End If
        Next
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Not Timer1.Enabled AndAlso TextBox_(0).Text.StartsWith("陈浩") Then
            TextBox_(0).Text = "陈浩" + New List(Of String) From {"东", "西", "南", "北"}((New Random).Next(0, 4))
            TextBox_(0).Refresh()
        End If
        ' If Me.Text = "" Then
        '     Me.Text = "激★情★大★抽★奖"
        ' Else
        '     Me.Text = ""
        ' End If
    End Sub

    Private Sub Label5_DoubleClick(sender As Object, e As EventArgs) Handles Label5.DoubleClick
        Try
            Process.Start(New ProcessStartInfo("https://kkmeeting.chn.moe") With {.UseShellExecute = True})
        Catch ex As Exception
            MsgBox("调用浏览器失败，请手动使用浏览器访问kkmeeting.chn.moe。")
        End Try
    End Sub
End Class
