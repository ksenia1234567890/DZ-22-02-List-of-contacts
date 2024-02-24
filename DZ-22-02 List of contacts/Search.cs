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
    public partial class Search : Form
    {
        NpgsqlCommand cmd;
        NpgsqlConnection con;

        public Search()
        {
            InitializeComponent();
        }

        private void clickUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=cxNTVJas;Database=Contacts");
                string query = "select numberPhone from contacts where surname=@surname and name=@name";
                cmd = new NpgsqlCommand(query, con);
                cmd.Parameters.AddWithValue("@surname", textBox1.Text);
                cmd.Parameters.AddWithValue("@name", textBox2.Text);
                con.Open();
                textBox3.Text = (string)cmd.ExecuteScalar();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
