Imports System.Windows.Forms.VisualStyles
Imports S7.Net

Public Class Form1

    Function Zerar()
        plc.Write("M0.5", False)
        plc.Write("M6.0", False)
        plc.Write("M7.0", False)
        plc.Write("M8.0", False)
        plc.Write("M9.0", False)
        plc.Write("M10.0", False)
        plc.Write("M11.0", False)
        plc.Write("M12.0", False)
        Return (0)
    End Function
    Private plc As S7.Net.Plc ' Variável para armazenar a instância do PLC
    Private memoriaslc As String
    Public Shared rack As Integer
    Public Shared slot As Integer


    Private Sub Conectbtn_Click(sender As Object, e As EventArgs) Handles Conectbtn.Click
        Try
            rack = Integer.Parse(TextBox4.Text)
            slot = Integer.Parse(TextBox5.Text)
            plc = New S7.Net.Plc(CpuType.S71200, TextBox3.Text, rack, slot)
            plc.Open()
            If plc.IsConnected Then
                Conectbtn.Enabled = False
                Conectbtn.BackColor = Color.Green
                Disconetbtn.Enabled = True
                GroupBox1.Enabled = True
                GroupBox2.Enabled = True
                TextBox3.Enabled = False
                TextBox4.Enabled = False
                TextBox5.Enabled = False
            Else
                MessageBox.Show("Não foi possível conectar ao PLC.")
            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao conectar ao PLC: " & ex.Message)
        End Try
    End Sub

    Private Sub Disconetbtn_Click(sender As Object, e As EventArgs) Handles Disconetbtn.Click
        If plc IsNot Nothing AndAlso plc.IsConnected Then
            plc.Close()
        End If
        Conectbtn.Enabled = True
        Conectbtn.BackColor = Color.White
        Disconetbtn.Enabled = False
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        btnM05.BackColor = Color.Gray
        btnM10.BackColor = Color.Gray
        btnM11.BackColor = Color.Gray
        btnM70.BackColor = Color.Gray
        btnM60.BackColor = Color.Gray
        btnM80.BackColor = Color.Gray
        btnM90.BackColor = Color.Gray
    End Sub

    Private Sub MonitorTimer_Tick(sender As Object, e As EventArgs) Handles MonitorTimer.Tick
        If plc IsNot Nothing AndAlso plc.IsConnected Then
            Try
                btnM05.BackColor = If(CBool(plc.Read("M0.5")), Color.Green, Color.Gray)
                btnM10.BackColor = If(CBool(plc.Read("M10.0")), Color.Green, Color.Gray)
                btnM11.BackColor = If(CBool(plc.Read("M11.0")), Color.Green, Color.Gray)
                btnM70.BackColor = If(CBool(plc.Read("M7.0")), Color.Green, Color.Gray)
                btnM60.BackColor = If(CBool(plc.Read("M6.0")), Color.Green, Color.Gray)
                btnM80.BackColor = If(CBool(plc.Read("M8.0")), Color.Green, Color.Gray)
                btnM90.BackColor = If(CBool(plc.Read("M9.0")), Color.Green, Color.Gray)
            Catch ex As Exception
                MessageBox.Show("Erro ao ler o valor da memória: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MonitorTimer.Interval = 165
        MonitorTimer.Start()
        memoriaslc = "M10.0"
    End Sub

    Private Sub btnVerdade_Click(sender As Object, e As EventArgs) Handles btnVerdade.Click
        plc.Write(memoriaslc, True)
    End Sub

    Private Sub btnFalso_Click(sender As Object, e As EventArgs) Handles btnFalso.Click
        plc.Write(memoriaslc, False)
    End Sub

    Private Sub btnM05_Click(sender As Object, e As EventArgs) Handles btnM05.Click
        memoriaslc = "M0.5"
    End Sub
    Private Sub btnM60_Click(sender As Object, e As EventArgs) Handles btnM60.Click
        memoriaslc = "M6.0"
    End Sub
    Private Sub btnM70_Click(sender As Object, e As EventArgs) Handles btnM70.Click
        memoriaslc = "M7.00"
    End Sub
    Private Sub btnM80_Click(sender As Object, e As EventArgs) Handles btnM80.Click
        memoriaslc = "M8.0"
    End Sub
    Private Sub btnM90_Click(sender As Object, e As EventArgs) Handles btnM90.Click
        memoriaslc = "M9.0"
    End Sub
    Private Sub btnM10_Click(sender As Object, e As EventArgs) Handles btnM10.Click
        memoriaslc = "M10.0"
    End Sub
    Private Sub btnM11_Click(sender As Object, e As EventArgs) Handles btnM11.Click
        memoriaslc = "M11.0"
    End Sub

    Private Sub btnLR1_Click(sender As Object, e As EventArgs) Handles btnLR1.Click
        Zerar()
        plc.Write("M6.0", True)
        plc.Write("M7.0", True)

    End Sub

    Private Sub btnOff_Click(sender As Object, e As EventArgs) Handles btnOff.Click
        Zerar()
    End Sub

    Private Sub btnLR2_Click(sender As Object, e As EventArgs) Handles btnLR2.Click
        Zerar()
        plc.Write("M10.0", True)
    End Sub

    Private Sub btnQR1_Click(sender As Object, e As EventArgs) Handles btnQR1.Click
        Zerar()
        plc.Write("M7.0", True)
    End Sub

    Private Sub btnQR2_Click(sender As Object, e As EventArgs) Handles btnQR2.Click
        Zerar()
        plc.Write("M7.0", True)
        plc.Write("M8.0", True)
    End Sub
End Class
