Imports System.Windows.Forms

Public Class PasswordBox
    Dim pass As String
    Dim status As Boolean

    Private Sub PasswordBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Wachtwoord"
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        pass = txtPassword.Text
        status = True
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        status = False
        Me.Close()
    End Sub

    Public ReadOnly Property getPass() As String
        Get
            Return pass
        End Get
    End Property

    Public ReadOnly Property getStatus() As Boolean
        Get
            Return status
        End Get
    End Property

End Class
