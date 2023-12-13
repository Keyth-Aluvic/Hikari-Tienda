Module Estilo

    Public Sub TemaPrincipal(ByRef form As System.Windows.Forms.Form)
        With form
            .BackColor = Color.DarkOrchid
            .ForeColor = Color.Black
            .MaximizeBox = False
            .StartPosition = FormStartPosition.CenterScreen
            .FormBorderStyle = FormBorderStyle.FixedSingle
        End With

    End Sub

    Public Sub TemaForm(ByRef form As System.Windows.Forms.Form)
        With form
            .BackColor = Color.DarkOrchid
            .ForeColor = Color.Black
            .ShowIcon = False
            .MinimizeBox = False
            .MaximizeBox = False
            .StartPosition = FormStartPosition.CenterScreen
            .FormBorderStyle = FormBorderStyle.FixedSingle
        End With
    End Sub

End Module
