Public Partial Class Form_Login
    Inherits Form

    Public Enum States
        Failed
        Success
    End Enum

    Public Sub New()
        InitializeComponent()
        Me.TopLevel = False
        AddHandler buttonLogin.Click, New EventHandler(AddressOf Login)
    End Sub

    Public State As States
    Public OPConnection As ADODB.Connection
    Private config As [Dim]
    Private Configuration As [As] = ConfigurationManager.OpenExeConfiguration([Me].[GetType].Assembly.Location)
    Private userSettings As [Dim]
    Private [New] As [As]
    Private userSettings As ClientSettingsSection = config.SectionGroups.Item("userSettings").Sections("Reports.Settings")

    Private Sub Login(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim Username As String = textUsername.Text
            Dim Password As String = textPassword.Text
            OPConnection = New ADODB.Connection()
            OPConnection.ConnectionString = $"
                                            Provider=SQLOLEDB;
                                            Data Source=192.168.11.155;
                                            Initial Catalog={Password};
                                            User ID=tosadmin;Password=tosadmin;
                                            "
            OPConnection.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class