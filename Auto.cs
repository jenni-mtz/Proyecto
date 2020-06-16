using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Proyecto
{
    public partial class Auto : Form
    {
        public Auto()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string pla, mar, mod, col;
            pla = txtPlaca.Text;
            mar = txtMarca.Text;
            mod = txtModelo.Text;
            col = txtColor.Text;

            string query = "Insert into Auto(Placa, Marca, Modelo, Color) VALUES ('" + pla + "','" + mar + "','" + mod + "','" + col + "')";
            OleDbConnection con = new OleDbConnection("Provider = SQLNCLI11; Data Source = IRIS\\SQLEXPRESS; Integrated Security = SSPI; Initial Catalog = Proyecto");
            OleDbCommand cmd = new OleDbCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                txtPlaca.Text = "";
                txtModelo.Text = "";
                txtMarca.Text  = "";
                txtColor.Text = "";
                oleDbDataAdapter1.Fill(dAuto1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string pla, mar, mod, col;
            pla = txtPlaca.Text;
            mar = txtMarca.Text;
            mod = txtModelo.Text;
            col = txtColor.Text;


            OleDbConnection con = new OleDbConnection("Provider = SQLNCLI11; Data Source = IRIS\\SQLEXPRESS; Integrated Security = SSPI; Initial Catalog = Proyecto");
            con.Open();
            string query = "Update Auto Set Marca = '" + txtMarca.Text + "'";
            OleDbCommand cmd = new OleDbCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Modificado");
            con.Close();

        
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string pla, mar, mod, col;
            pla = txtPlaca.Text;
            mar = txtMarca.Text;
            mod = txtModelo.Text;
            col = txtColor.Text;

            
            OleDbConnection con = new OleDbConnection("Provider = SQLNCLI11; Data Source = IRIS\\SQLEXPRESS; Integrated Security = SSPI; Initial Catalog = Proyecto");
            con.Open();
            string query = "Delete from Auto where Placa = '" + txtPlaca.Text + "'";
            OleDbCommand cmd = new OleDbCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Eliminado");
            con.Close();


        }

        private void Auto_Load(object sender, EventArgs e)
        {

        }
    }
}
