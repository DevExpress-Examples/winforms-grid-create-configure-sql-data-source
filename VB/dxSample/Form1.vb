Imports System
Imports System.Windows.Forms
Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.DataAccess.Sql
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid

Namespace dxSample

    Public Partial Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Private _Grid As GridControl

        Public ReadOnly Property Grid As GridControl
            Get
                If _Grid Is Nothing Then
                    CreateGridControl()
                End If

                Return _Grid
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            Init()
        End Sub

        Private Sub Init()
            Dim ds As SqlDataSource = InitData()
            Grid.DataSource = ds
            Grid.DataMember = "customQuery1"
        End Sub

        Private Sub CreateGridControl()
            _Grid = New GridControl()
            Dim view As GridView = New GridView()
            _Grid.ViewCollection.Add(view)
            _Grid.MainView = view
            _Grid.Dock = DockStyle.Fill
            Controls.Add(_Grid)
        End Sub

        Private Shared Function InitData() As SqlDataSource
            Dim connectionParameters As MsSqlConnectionParameters = New MsSqlConnectionParameters("localhost", "nwind.mdf", "username", "password", MsSqlAuthorizationType.SqlServer)
            Dim ds As SqlDataSource = New SqlDataSource(connectionParameters)
            Dim query As CustomSqlQuery = New CustomSqlQuery()
            query.Name = "customQuery1"
            query.Sql = "SELECT * FROM Products"
            ds.Queries.Add(query)
            ds.Fill()
            Return ds
        End Function
    End Class
End Namespace
