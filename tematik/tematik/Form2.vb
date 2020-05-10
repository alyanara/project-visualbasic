Public Class Form2
    Dim sqlnya, type, luar, dalam, imun As String
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False

        TextBox1.Text = Form1.TextBox1.Text
        TextBox2.Text = Form1.TextBox2.Text
        TextBox3.Text = Form1.TextBox3.Text
        TextBox4.Text = Form1.ComboBox1.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True Then
            RichTextBox1.Text = Val(RichTextBox1.Text) + 1
        End If
        If CheckBox2.Checked = True Then
            RichTextBox1.Text = Val(RichTextBox1.Text) + 1
        End If
        If CheckBox3.Checked = True Then
            RichTextBox1.Text = Val(RichTextBox1.Text) + 1
        End If
        If CheckBox4.Checked = True Then
            RichTextBox1.Text = Val(RichTextBox1.Text) + 1
        End If
        If CheckBox5.Checked = True Then
            RichTextBox1.Text = Val(RichTextBox1.Text) + 1
        End If
        If CheckBox6.Checked = True Then
            RichTextBox1.Text = Val(RichTextBox1.Text) + 1
        End If
        If CheckBox7.Checked = True Then
            RichTextBox1.Text = Val(RichTextBox1.Text) + 1
        End If
        If CheckBox8.Checked = True Then
            RichTextBox1.Text = Val(RichTextBox1.Text) + 1
        End If
        If CheckBox9.Checked = True Then
            RichTextBox1.Text = Val(RichTextBox1.Text) + 1
        End If
        If CheckBox10.Checked = True Then
            RichTextBox1.Text = Val(RichTextBox1.Text) + 1
        End If
        If CheckBox11.Checked = True Then
            RichTextBox1.Text = Val(RichTextBox1.Text) + 1
        End If
        If CheckBox12.Checked = True Then
            RichTextBox1.Text = Val(RichTextBox1.Text) + 1
        End If
        If CheckBox13.Checked = True Then
            RichTextBox1.Text = Val(RichTextBox1.Text) + 1
        End If
        If CheckBox14.Checked = True Then
            RichTextBox1.Text = Val(RichTextBox1.Text) + 1
        End If
        If CheckBox15.Checked = True Then
            RichTextBox1.Text = Val(RichTextBox1.Text) + 1
        End If
        If CheckBox16.Checked = True Then
            RichTextBox1.Text = Val(RichTextBox1.Text) + 1
        End If
        If CheckBox17.Checked = True Then
            RichTextBox1.Text = Val(RichTextBox1.Text) + 1
        End If
        If CheckBox18.Checked = True Then
            RichTextBox1.Text = Val(RichTextBox1.Text) + 1
        End If
        If CheckBox19.Checked = True Then
            RichTextBox1.Text = Val(RichTextBox1.Text) + 1
        End If
        If CheckBox20.Checked = True Then
            RichTextBox1.Text = Val(RichTextBox1.Text) + 1
        End If
        If CheckBox21.Checked = True Then
            RichTextBox1.Text = Val(RichTextBox1.Text) + 1
        End If

        Label5.Text = Type
        If RichTextBox1.Text < 8 Then
            Label5.Text = "Rendah"
        ElseIf RichTextBox1.Text < 15 Then
            Label5.Text = "Sedang"
        ElseIf RichTextBox1.Text < 22 Then
            Label5.Text = "Tinggi"
        End If

        Label14.Text = luar
        If CheckBox1.Checked = True Then
            Label14.Text = Val(Label14.Text) + 1
        End If
        If CheckBox2.Checked = True Then
            Label14.Text = Val(Label14.Text) + 1
        End If
        If CheckBox3.Checked = True Then
            Label14.Text = Val(Label14.Text) + 1
        End If
        If CheckBox4.Checked = True Then
            Label14.Text = Val(Label14.Text) + 1
        End If
        If CheckBox5.Checked = True Then
            Label14.Text = Val(Label14.Text) + 1
        End If
        If CheckBox6.Checked = True Then
            Label14.Text = Val(Label14.Text) + 1
        End If
        If CheckBox7.Checked = True Then
            Label14.Text = Val(Label14.Text) + 1
        End If
        If CheckBox8.Checked = True Then
            Label14.Text = Val(Label14.Text) + 1
        End If
        If CheckBox9.Checked = True Then
            Label14.Text = Val(Label14.Text) + 1
        End If
        If CheckBox10.Checked = True Then
            Label14.Text = Val(Label14.Text) + 1
        End If

        Label15.Text = dalam
        If CheckBox11.Checked = True Then
            Label15.Text = Val(Label15.Text) + 1
        End If
        If CheckBox12.Checked = True Then
            Label15.Text = Val(Label15.Text) + 1
        End If
        If CheckBox13.Checked = True Then
            Label15.Text = Val(Label15.Text) + 1
        End If
        If CheckBox14.Checked = True Then
            Label15.Text = Val(Label15.Text) + 1
        End If
        If CheckBox15.Checked = True Then
            Label15.Text = Val(Label15.Text) + 1
        End If
        If CheckBox16.Checked = True Then
            Label15.Text = Val(Label15.Text) + 1
        End If

        Label16.Text = imun
        If CheckBox17.Checked = True Then
            Label16.Text = Val(Label16.Text) + 1
        End If
        If CheckBox18.Checked = True Then
            Label16.Text = Val(Label16.Text) + 1
        End If
        If CheckBox19.Checked = True Then
            Label16.Text = Val(Label16.Text) + 1
        End If
        If CheckBox20.Checked = True Then
            Label16.Text = Val(Label16.Text) + 1
        End If
        If CheckBox21.Checked = True Then
            Label16.Text = Val(Label16.Text) + 1
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If RichTextBox1.Text = "" Or Label5.Text = "" Then
            MsgBox("Harap isilah kuesioner terlebih dahulu")
        Else
            Me.Hide()
            Form3.Show()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False
        CheckBox9.Checked = False
        CheckBox10.Checked = False
        CheckBox11.Checked = False
        CheckBox12.Checked = False
        CheckBox13.Checked = False
        CheckBox14.Checked = False
        CheckBox15.Checked = False
        CheckBox16.Checked = False
        CheckBox17.Checked = False
        CheckBox18.Checked = False
        CheckBox19.Checked = False
        CheckBox20.Checked = False
        CheckBox21.Checked = False

        RichTextBox1.Text = ""
        Label5.Text = "Tahapan"
        Label14.Text = 0
        Label15.Text = 0
        Label16.Text = 0
    End Sub


End Class