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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            string r, nom, dom, tel, co;
            
            r = txtrfc.Text;
            nom = txtNombre.Text;
            dom = txtDomicilio.Text;
            tel = txtTelefono.Text;
            co = txtCorreo.Text;

            string query = "Insert into Cliente(RFC, Nombre, Domicilio, Telefono, Correo) VALUES('" + r + "','" + nom + "','" + dom + "','" + tel + "','" + co + "')";
            OleDbConnection con = new OleDbConnection("Provider = SQLNCLI11; Data Source = IRIS\\SQLEXPRESS; Integrated Security = SSPI; Initial Catalog = Proyecto");
            OleDbCommand cmd = new OleDbCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                txtrfc.Text = "";
                txtNombre.Text = "";
                txtDomicilio.Text = "";
                txtTelefono.Text = "";
                txtCorreo.Text = "";
                oleDbDataAdapter1.Fill(dCliente1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string r, nom, dom, tel, co;
          
            r = txtrfc.Text;
            nom = txtNombre.Text;
            dom = txtDomicilio.Text;
            tel = txtTelefono.Text;
            co = txtCorreo.Text;
            OleDbConnection con = new OleDbConnection("Provider = SQLNCLI11; Data Source = IRIS\\SQLEXPRESS; Integrated Security = SSPI; Initial Catalog = Proyecto");
            con.Open();
            string query = "Update Cliente Set Nombre = '" + txtNombre.Text + "'";
            OleDbCommand cmd = new OleDbCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Modificado");
            con.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string r, nom, dom, tel, co;
          
            r = txtrfc.Text;
           nom = txtNombre.Text;
            dom = txtDomicilio.Text;
            tel = txtTelefono.Text;
            co = txtCorreo.Text;
            OleDbConnection con = new OleDbConnection("Provider = SQLNCLI11; Data Source = IRIS\\SQLEXPRESS; Integrated Security = SSPI; Initial Catalog = Proyecto");
            con.Open();
            string query = "Delete from Cliente where RFC = '" + txtrfc.Text + "'";
            OleDbCommand cmd = new OleDbCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Eliminado");
            con.Close();
        }
    }
}
