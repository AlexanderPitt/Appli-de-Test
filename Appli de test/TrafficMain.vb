Public Class TrafficMain

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick


        ProgressBar1.Value += 1
        textBox1.Text = ProgressBar1.Value & "%"
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Enabled = False
        End If


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        TrafficPlayList.Show()


    End Sub




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim swr As New System.IO.StreamReader("E:\Svn Ninsight\Third Party\PIKO SOCIAL HUB\Piko_URls.txt")


        Do Until swr.Peek = -1
            Dim Ligne As String
            Ligne = swr.ReadLine()
            Me.ComboBox1.Items.Add(Ligne)
        Loop
        Me.ComboBox1.Text = ComboBox1.Items(0)
        swr.Close()
    End Sub
End Class
