using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace dxSample {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        private GridControl _Grid;
        public GridControl Grid {
            get {
                if (_Grid == null) {
                    CreateGridControl();
                }
                return _Grid;
            }
        }
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            Init();
        }
        private void Init() {
            SqlDataSource ds = InitData();
            Grid.DataSource = ds;
            Grid.DataMember = "customQuery1";
        }
        private void CreateGridControl() {
            _Grid = new GridControl();
            GridView view = new GridView();
            _Grid.ViewCollection.Add(view);
            _Grid.MainView = view;
            _Grid.Dock = DockStyle.Fill;
            Controls.Add(_Grid);
        }
        private static SqlDataSource InitData() {
            MsSqlConnectionParameters connectionParameters = new MsSqlConnectionParameters("localhost", "nwind.mdf", "username", "password", MsSqlAuthorizationType.SqlServer);
            SqlDataSource ds = new SqlDataSource(connectionParameters);
            CustomSqlQuery query = new CustomSqlQuery();
            query.Name = "customQuery1";
            query.Sql = "SELECT * FROM Products";
            ds.Queries.Add(query);
            ds.Fill();
            return ds;
        }
    }
}
