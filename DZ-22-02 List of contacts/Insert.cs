using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace DZ_22_02_List_of_contacts
{
    public partial class Insert : Form
    {
        NpgsqlCommand cmd;
        NpgsqlConnection con;

        public Insert()
        {
            InitializeComponent();
        }

        private void clickInsert_Click(object sender, EventArgs e)
        {
            try { 
            con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=cxNTVJas;Database=Contacts");
            string query = "Insert into contacts(numberPhone,surname,name) values (@numberPhone,@surname,@name)"; 
            cmd = new NpgsqlCommand(query, con);
            cmd.Parameters.AddWithValue("@numberPhone", textBox3.Text);
            cmd.Parameters.AddWithValue("@surname", textBox1.Text);
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            con.Open();
            cmd.ExecuteNonQuery();
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
