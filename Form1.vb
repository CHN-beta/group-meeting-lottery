Public Class Form1
    Private Students_() As List(Of String) =
    {
        New List(Of String) From {"张三", "张四", "张五"},
        New List(Of String) From {"李三", "李四", "李五"},
        New List(Of String) From {"王三", "王四", "王五"},
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

    Private Sub egg_try_visible()
        PictureBox1.Visible = TextBox_(0).Text = "陈浩南"
    End Sub
    Private Sub egg_invisible()
        PictureBox1.Visible = False
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
        For i As Integer = 0 To 3
            set_select_name(i)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Timer1.Enabled) Then
            Timer1.Enabled = False
            Button1.Text = "再来一次"
            egg_try_visible()
        Else
            Timer1.Enabled = True
            Button1.Text = "停！"
            egg_invisible()
        End If
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles Button2.Click, Button3.Click, Button4.Click, Button5.Click
        For i As Integer = 0 To 3
            If sender Is ButtonRegenerate_(i) Then
                set_select_name(i)
            End If
        Next
        egg_try_visible()
    End Sub

End Class
