Imports MaterialSkin

Public Class Register
    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue900, Primary.Cyan500, Primary.Blue50, Accent.LightBlue200, TextShade.WHITE)

    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Login.Show()
        Me.Close()
    End Sub
End Class