using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace DZ_22_02_List_of_contacts
{
    public partial class Contact : Form
    {
        NpgsqlConnection con;
        NpgsqlDataAdapter da;
        DataSet ds;

        public Contact()
        {
            InitializeComponent();
        }
        public void ContactDb()
        {
            try { 
            con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=cxNTVJas;Database=Contacts");
            da = new NpgsqlDataAdapter("SELECT *FROM contacts", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "contacts");
            dataGridView1.DataSource = ds.Tables["contacts"];
            con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Contact_Load(object sender, EventArgs e)
        {
            ContactDb();
        }

        private void bInsert_Click(object sender, EventArgs e)
        {
            Insert data = new Insert();
            data.ShowDialog();
        }

        private void bRefresh_Click(object sender, EventArgs e)
        {
            ContactDb();
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            Update data = new Update();
            data.ShowDialog();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            Delete data = new Delete();
            data.ShowDialog();
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            Search data = new Search();
            data.ShowDialog();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
