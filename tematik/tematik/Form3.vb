Public Class Form3
    Dim sqlnya As String
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        TextBox1.Text = Form2.TextBox1.Text
        TextBox2.Text = Form2.TextBox2.Text
        TextBox3.Text = Form2.TextBox3.Text
        TextBox4.Text = Form2.TextBox4.Text
        TextBox5.Text = Form2.Label5.Text

        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = False
    End Sub
    Sub kosongkanform()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub
    Sub panggildata()
        konek()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM tb_tema", conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tb_tema")
        DataGridView1.DataSource = DS.Tables("tb_tema")
        DataGridView1.Enabled = True
    End Sub
    Sub jalan()
        Dim objcmd As New System.Data.OleDb.OleDbCommand
        Call konek()
        objcmd.Connection = conn
        objcmd.CommandType = CommandType.Text
        objcmd.CommandText = sqlnya
        objcmd.ExecuteNonQuery()
        objcmd.Dispose()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub
   
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call panggildata()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sqlnya = "insert into tb_tema(ID,Nama,Umur,JK,Resiko) values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "')"
        Call jalan()
        MsgBox("Data Berhasil Tersimpan")
        Call panggildata()
        Call kosongkanform()
    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        TextBox1.Text = DataGridView1.Item(0, i).Value
        TextBox2.Text = DataGridView1.Item(1, i).Value
        TextBox3.Text = DataGridView1.Item(2, i).Value
        TextBox4.Text = DataGridView1.Item(3, i).Value
        TextBox5.Text = DataGridView1.Item(4, i).Value
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        sqlnya = "delete from tb_tema where Nama='" & TextBox2.Text & "'"
        Call jalan()
        MsgBox("Data Berhasil Terhapus")
        Call panggildata()
        Call kosongkanform()
    End Sub

    Private Sub TextBox6_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox6.TextChanged
        konek()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM tb_tema where Nama like '%" & TextBox6.Text & "%'", conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tb_tema")
        DataGridView1.DataSource = DS.Tables("tb_tema")
    End Sub

    
End Class