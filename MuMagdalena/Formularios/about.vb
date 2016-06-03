Public NotInheritable Class about

    Private Sub about_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = menuPrincipal
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Dispose()
    End Sub

    Private Sub LabelVersion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelVersion.Click

    End Sub
End Class
