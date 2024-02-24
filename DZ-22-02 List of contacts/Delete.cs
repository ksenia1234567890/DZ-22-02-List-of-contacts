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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace DZ_22_02_List_of_contacts
{
    public partial class Delete : Form
    {
        NpgsqlCommand cmd;
        NpgsqlConnection con;

        public Delete()
        {
            InitializeComponent();
        }

        private void clickDelete_Click(object sender, EventArgs e)
        {
            try { 
            con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=cxNTVJas;Database=Contacts");
            string query = "delete from contacts where numberPhone=@numberPhone";
            cmd = new NpgsqlCommand(query, con);
            cmd.Parameters.AddWithValue("@numberPhone", textBox1.Text);
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
