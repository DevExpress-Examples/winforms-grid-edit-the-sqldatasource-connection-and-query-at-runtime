using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.DataAccess.UI.Sql;

namespace T292798 {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        public Form1() {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e) {
            sqlDataSource1.Fill();
        }

        private void btConfigureConnection_Click(object sender, EventArgs e) {
            SqlDataSourceUIHelper.ConfigureConnection(sqlDataSource1);
        }

        private void btEditQuery_Click(object sender, EventArgs e) {
            SqlDataSourceUIHelper.EditQuery(sqlDataSource1.Queries["DefaultQuery"]);

            sqlDataSource1.Fill();

            gridView1.PopulateColumns();
        }
    }
}
