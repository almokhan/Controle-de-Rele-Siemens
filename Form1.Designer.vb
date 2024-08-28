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
        Conectbtn = New Button()
        Disconetbtn = New Button()
        GroupBox1 = New GroupBox()
        btnFalso = New Button()
        btnVerdade = New Button()
        btnM80 = New Button()
        btnM70 = New Button()
        btnM60 = New Button()
        btnM90 = New Button()
        btnM10 = New Button()
        btnM11 = New Button()
        btnM05 = New Button()
        Label2 = New Label()
        TextBox3 = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        MonitorTimer = New Timer(components)
        btnLR2 = New Button()
        btnLR1 = New Button()
        btnQR1 = New Button()
        btnQR2 = New Button()
        btnOff = New Button()
        GroupBox2 = New GroupBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Conectbtn
        ' 
        Conectbtn.Location = New Point(14, 12)
        Conectbtn.Name = "Conectbtn"
        Conectbtn.Size = New Size(79, 37)
        Conectbtn.TabIndex = 0
        Conectbtn.Text = "Conectar"
        Conectbtn.UseVisualStyleBackColor = True
        ' 
        ' Disconetbtn
        ' 
        Disconetbtn.Enabled = False
        Disconetbtn.Location = New Point(122, 12)
        Disconetbtn.Name = "Disconetbtn"
        Disconetbtn.Size = New Size(82, 37)
        Disconetbtn.TabIndex = 1
        Disconetbtn.Text = "Desconectar"
        Disconetbtn.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnFalso)
        GroupBox1.Controls.Add(btnVerdade)
        GroupBox1.Controls.Add(btnM80)
        GroupBox1.Controls.Add(btnM70)
        GroupBox1.Controls.Add(btnM60)
        GroupBox1.Controls.Add(btnM90)
        GroupBox1.Controls.Add(btnM10)
        GroupBox1.Controls.Add(btnM11)
        GroupBox1.Controls.Add(btnM05)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Enabled = False
        GroupBox1.Location = New Point(43, 183)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(374, 203)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Enviar / Receber"
        ' 
        ' btnFalso
        ' 
        btnFalso.Location = New Point(152, 131)
        btnFalso.Name = "btnFalso"
        btnFalso.Size = New Size(53, 24)
        btnFalso.TabIndex = 13
        btnFalso.Text = "0"
        btnFalso.UseVisualStyleBackColor = True
        ' 
        ' btnVerdade
        ' 
        btnVerdade.Location = New Point(79, 131)
        btnVerdade.Name = "btnVerdade"
        btnVerdade.Size = New Size(53, 24)
        btnVerdade.TabIndex = 12
        btnVerdade.Text = "1"
        btnVerdade.UseVisualStyleBackColor = True
        ' 
        ' btnM80
        ' 
        btnM80.Location = New Point(142, 37)
        btnM80.Name = "btnM80"
        btnM80.Size = New Size(53, 24)
        btnM80.TabIndex = 11
        btnM80.Text = "M.80"
        btnM80.UseVisualStyleBackColor = True
        ' 
        ' btnM70
        ' 
        btnM70.Location = New Point(99, 37)
        btnM70.Name = "btnM70"
        btnM70.Size = New Size(53, 24)
        btnM70.TabIndex = 9
        btnM70.Text = "M7.0"
        btnM70.UseVisualStyleBackColor = True
        ' 
        ' btnM60
        ' 
        btnM60.Location = New Point(52, 37)
        btnM60.Name = "btnM60"
        btnM60.Size = New Size(53, 24)
        btnM60.TabIndex = 8
        btnM60.Text = "M6.0"
        btnM60.UseVisualStyleBackColor = True
        ' 
        ' btnM90
        ' 
        btnM90.Location = New Point(191, 37)
        btnM90.Name = "btnM90"
        btnM90.Size = New Size(53, 24)
        btnM90.TabIndex = 9
        btnM90.Text = "M9.0"
        btnM90.UseVisualStyleBackColor = True
        ' 
        ' btnM10
        ' 
        btnM10.Location = New Point(239, 37)
        btnM10.Name = "btnM10"
        btnM10.Size = New Size(53, 24)
        btnM10.TabIndex = 6
        btnM10.Text = "M10.0"
        btnM10.UseVisualStyleBackColor = True
        ' 
        ' btnM11
        ' 
        btnM11.Location = New Point(286, 37)
        btnM11.Name = "btnM11"
        btnM11.Size = New Size(53, 24)
        btnM11.TabIndex = 7
        btnM11.Text = "M11.0"
        btnM11.UseVisualStyleBackColor = True
        ' 
        ' btnM05
        ' 
        btnM05.Location = New Point(6, 37)
        btnM05.Name = "btnM05"
        btnM05.Size = New Size(53, 24)
        btnM05.TabIndex = 5
        btnM05.Text = "M0.5"
        btnM05.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(28, 136)
        Label2.Name = "Label2"
        Label2.Size = New Size(22, 15)
        Label2.TabIndex = 3
        Label2.Text = "PC"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(43, 66)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(169, 23)
        TextBox3.TabIndex = 3
        TextBox3.Text = "192.168.0.10"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(14, 69)
        Label3.Name = "Label3"
        Label3.Size = New Size(17, 15)
        Label3.TabIndex = 4
        Label3.Text = "IP"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(313, 389)
        Label4.Name = "Label4"
        Label4.Size = New Size(148, 15)
        Label4.TabIndex = 5
        Label4.Text = "Conversadores de PLC INC"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(218, 66)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(48, 23)
        TextBox4.TabIndex = 6
        TextBox4.Text = "0"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(272, 66)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(48, 23)
        TextBox5.TabIndex = 7
        TextBox5.Text = "1"
        ' 
        ' MonitorTimer
        ' 
        MonitorTimer.Enabled = True
        MonitorTimer.Interval = 1
        ' 
        ' btnLR2
        ' 
        btnLR2.Location = New Point(65, 22)
        btnLR2.Name = "btnLR2"
        btnLR2.Size = New Size(53, 24)
        btnLR2.TabIndex = 8
        btnLR2.Text = "Rele 2"
        btnLR2.UseVisualStyleBackColor = True
        ' 
        ' btnLR1
        ' 
        btnLR1.Location = New Point(6, 22)
        btnLR1.Name = "btnLR1"
        btnLR1.Size = New Size(53, 24)
        btnLR1.TabIndex = 9
        btnLR1.Text = "Rele 1"
        btnLR1.UseVisualStyleBackColor = True
        ' 
        ' btnQR1
        ' 
        btnQR1.Location = New Point(124, 22)
        btnQR1.Name = "btnQR1"
        btnQR1.Size = New Size(63, 24)
        btnQR1.TabIndex = 10
        btnQR1.Text = "Piscar 1"
        btnQR1.UseVisualStyleBackColor = True
        ' 
        ' btnQR2
        ' 
        btnQR2.Location = New Point(193, 22)
        btnQR2.Name = "btnQR2"
        btnQR2.Size = New Size(89, 24)
        btnQR2.TabIndex = 11
        btnQR2.Text = "Piscar Ambos"
        btnQR2.UseVisualStyleBackColor = True
        ' 
        ' btnOff
        ' 
        btnOff.Location = New Point(286, 23)
        btnOff.Name = "btnOff"
        btnOff.Size = New Size(75, 23)
        btnOff.TabIndex = 12
        btnOff.Text = "Desligar"
        btnOff.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnLR1)
        GroupBox2.Controls.Add(btnOff)
        GroupBox2.Controls.Add(btnLR2)
        GroupBox2.Controls.Add(btnQR1)
        GroupBox2.Controls.Add(btnQR2)
        GroupBox2.Enabled = False
        GroupBox2.Location = New Point(43, 116)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(374, 61)
        GroupBox2.TabIndex = 13
        GroupBox2.TabStop = False
        GroupBox2.Text = "Receitas"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(464, 406)
        Controls.Add(GroupBox2)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(TextBox3)
        Controls.Add(GroupBox1)
        Controls.Add(Disconetbtn)
        Controls.Add(Conectbtn)
        Name = "Form1"
        Text = "Conversador"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Conectbtn As Button
    Friend WithEvents Disconetbtn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents MonitorTimer As Timer
    Friend WithEvents btnM11 As Button
    Friend WithEvents btnM10 As Button
    Friend WithEvents btnM05 As Button
    Friend WithEvents btnM60 As Button
    Friend WithEvents btnM70 As Button
    Friend WithEvents btnM80 As Button
    Friend WithEvents btnM90 As Button
    Friend WithEvents btnFalso As Button
    Friend WithEvents btnVerdade As Button
    Friend WithEvents btnLR2 As Button
    Friend WithEvents btnLR1 As Button
    Friend WithEvents btnQR1 As Button
    Friend WithEvents btnQR2 As Button
    Friend WithEvents btnOff As Button
    Friend WithEvents GroupBox2 As GroupBox
End Class
