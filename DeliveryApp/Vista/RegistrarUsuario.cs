using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeliveryApp;
using DeliveryApp.Controladores;
using DeliveryApp.Vista;
using DeliveryApp.Modelos; //Son los modelos



namespace DeliveryApp
{
    public partial class RegistrarUsuario : Form
    {
        private int fase = 0;
        System.Windows.Forms.Panel contenedor = new System.Windows.Forms.Panel();
        Usuario usuario = new Usuario();
        public RegistrarUsuario(System.Windows.Forms.Panel p)
        {
            contenedor = p;
            
            InitializeComponent();
        }

        public void Desplegar(Form f)
        {
            if (contenedor.Controls.Count > 0)
            {
                contenedor.Controls.RemoveAt(0);
            }
            contenedor.Width = f.Width;
            contenedor.Height = f.Height;
            f.FormBorderStyle = FormBorderStyle.None;
            f.TopLevel = false;
            contenedor.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            switch (fase)
            {
                case 0:
                    PantallaInicio menu = new PantallaInicio(contenedor);
                    Desplegar(menu);
                    break;
                case 1:
                    Point p2 = registro2.Location;
                    registro2.Location = registro1.Location;
                    registro1.Location = p2;
                    fase--;
                    break;
                case 2:
                    Point p3 = registro3.Location;
                    registro3.Location = registro2.Location;
                    registro2.Location = p3;
                    fase--;
                    break;
            }
        }

        private void pnlSuperior_Paint(object sender, PaintEventArgs e)
        {
            Color c = Color.FromArgb(241, 241, 241);
            ControlPaint.DrawBorder(e.Graphics, pnlSuperior.ClientRectangle,
                c, 0, ButtonBorderStyle.Solid, // left
                c, 0, ButtonBorderStyle.Solid, // top
                c, 0, ButtonBorderStyle.Solid, // right
                c, 1, ButtonBorderStyle.Solid);// bottom
        }

        private void pnlInferior_Paint(object sender, PaintEventArgs e)
        {
            Color c = Color.FromArgb(241, 241, 241);
            ControlPaint.DrawBorder(e.Graphics, pnlSuperior.ClientRectangle,
                c, 0, ButtonBorderStyle.Solid, // left
                c, 1, ButtonBorderStyle.Solid, // top
                c, 0, ButtonBorderStyle.Solid, // right
                c, 0, ButtonBorderStyle.Solid);// bottom
        }

        private void btinSiguiente_Click(object sender, EventArgs e)
        {
            switch(fase)
            {
                case 0:
                    Point p1 = registro1.Location;
                    registro1.Location = registro2.Location;
                    registro2.Location = p1;
                    fase++;
                    break;
                case 1:
                    Point p2 = registro2.Location;
                    registro2.Location = registro3.Location;
                    registro3.Location = p2;
                    fase++;
                    break;
                case 2:
                    Point p3 = registro2.Location;
                    registro3.Location = registro1.Location;
                    registro1.Location = p3;
                    fase=0;

                    int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
                    int dob = int.Parse(dtpFechaNacim.Value.ToString("yyyyMMdd"));
                    int age = (now - dob) / 10000;

                    string msg = DeliveryApp.Controladores.RegistrarUsuario.registrar(tbxContraseña.Texts, tbxCorreo.Texts, cbxPais.Texts, cbxEstado.Texts, cbxCiudad.Texts, cbxCalle1.Texts, cbxCalle2.Texts, cbxColonia.Texts, cbxNumCasa.Texts, tbxNombre.Texts, " ", tbxApaterno.Texts, tbxAmaterno.Texts, tbxTelefono.Texts, dtpFechaNacim.Value.ToString(), age, cbxSexo.Texts);
                    MessageBox.Show(msg);

                    PantallaInicio menu = new PantallaInicio(contenedor);
                    Desplegar(menu);
                    break;
            }
        }
    }
}
