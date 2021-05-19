using System;         
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMarkUpdation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Server=DESKTOP-C0MLP28\SQLEXPRESS;Database=StudentMangementSystem;Trusted_Connection=true;");
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "StudentSave";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("Name", tbxName.Text);
            command.Parameters.AddWithValue("Malyalam",tbxMalayalam.Text);
            command.Parameters.AddWithValue("English", tbxEnglish.Text);
            command.Parameters.AddWithValue("Hindi", tbxHindi.Text);
            command.Parameters.AddWithValue("Address", txbxAddress.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Done");
        }
    }
}
