using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeliveryApp.Modelos; //Son los modelos

namespace DeliveryApp
{
    public partial class Pantalla_Principal : Form
    {
        Usuario Tu = new Usuario();
        public Pantalla_Principal(Usuario User)
        {
            
            Tu = User;
            InitializeComponent();
        }
        
        private void Pantalla_Principal_Load(object sender, EventArgs e)
        {
            lbxUser.Text =Tu.Correo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ltbxUser.Items.Clear();
            ltbxUser.Items.Add("id:"+Tu.IdPersona);
            ltbxUser.Items.Add("correo:" + Tu.Correo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //LoginUsuario Volver = new LoginUsuario();
            this.Hide();
            //Volver.ShowDialog();
            this.Close();
        }
    }
}
