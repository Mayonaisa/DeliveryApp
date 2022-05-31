using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeliveryApp.Modelos;
using DeliveryApp.Recursos;
using DeliveryApp.Vista;

namespace DeliveryApp.Recursos
{
    class PanelProducto : Panel
    {
        private PictureBox Imagen;
        private Label lblprincipal;
        private Label lblmonto;
        private botonRedondo BRcantidad;
        private botonRedondo BRprincipal;
        private botonRedondo BRsecundario;
        private botonRedondo BRmas;
        private botonRedondo BRmenos;
        public string idProducto = "";
        string nombreP = "";
        int montoP = 0;

        public Producto prod;
        public DetalleTieneProducto detProd = new DetalleTieneProducto();
        Detalle det;
        public MenuCliente MenuV;
        public Panel contenedor;

        CarritoC Carro;

        public PanelProducto(int idnum, CarritoC c)
        {
            //idProducto = id;
            //idProducto = idProducto.Trim();
            prod = new Producto(idnum);
            Carro = c;

            //inicio una conexion y le doy los valores a nombreP y montoP
        }

        public PanelProducto(CarritoC c)
        {
            Carro = c;
        }

        public void Crear_Panel_menu(string imagen, /*string producto, string monto,*/ int x, int y)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryApp.Properties.Resources));

            this.Size = new System.Drawing.Size(801, 156);
            this.Location = new Point(x, y);
            this.BorderStyle = BorderStyle.FixedSingle;
            this.BackColor = Color.White;

            Imagen = new PictureBox();
            this.Controls.Add(this.Imagen);

            imagen = imagen.Replace(' ', '_');

            this.Imagen.Image = ((System.Drawing.Image)(resources.GetObject(imagen)));
            //this.Imagen.Image = Image.FromFile(Server.MapPath("~/Image/undefinedProfileImage.png"));
            this.Imagen.Location = new System.Drawing.Point(3, 3);
            this.Imagen.Name = "PictureBox1";
            this.Imagen.Size = new System.Drawing.Size(148, 148);
            this.Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imagen.TabIndex = 34;
            this.Imagen.TabStop = false;

            lblprincipal = new Label();
            this.Controls.Add(this.lblprincipal);
            this.lblprincipal.AutoSize = true;
            this.lblprincipal.Name = "lblnombre";
            this.lblprincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprincipal.ForeColor = Color.Black;
            this.lblprincipal.Location = new System.Drawing.Point(182, 26);
            this.lblprincipal.Size = new System.Drawing.Size(219, 29);
            this.lblprincipal.Text = /*producto;*/prod.Nombre;

            lblmonto = new Label();
            this.Controls.Add(this.lblmonto);
            this.lblmonto.AutoSize = true;
            this.lblmonto.Name = "lblmonto";
            this.lblmonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmonto.ForeColor = Color.FromArgb(0, 184, 49);
            this.lblmonto.Location = new System.Drawing.Point(182, 67);
            this.lblmonto.Size = new System.Drawing.Size(219, 29);
            this.lblmonto.Text = /*monto;*/prod.Precio.ToString();

            BRcantidad = new botonRedondo();
            this.Controls.Add(this.BRcantidad);
            this.BRcantidad.BackColor = Color.FromArgb(236, 236, 236);
            this.BRcantidad.FlatStyle = FlatStyle.Flat;
            this.BRcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRcantidad.Location = new Point(496, 18);
            this.BRcantidad.Size = new System.Drawing.Size(43, 46);
            this.BRcantidad.Text = "1";
            this.BRcantidad.FlatAppearance.BorderSize = 0;

            BRmenos = new botonRedondo();
            BRmenos.Click += new System.EventHandler(btn_menos_click);
            this.Controls.Add(this.BRmenos);
            this.BRmenos.BackColor = Color.White;
            this.BRmenos.FlatStyle = FlatStyle.Flat;
            this.BRmenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRmenos.Location = new Point(447, 18);
            this.BRmenos.Size = new System.Drawing.Size(43, 46);
            this.BRmenos.Text = "-";
            this.BRmenos.FlatAppearance.BorderSize = 0;

            BRmas = new botonRedondo();
            BRmas.Click += new System.EventHandler(btn_mas_click);
            this.Controls.Add(this.BRmas);
            this.BRmas.BackColor = Color.White;
            this.BRmas.FlatStyle = FlatStyle.Flat;
            this.BRmas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRmas.Location = new Point(544, 18);
            this.BRmas.Size = new System.Drawing.Size(43, 46);
            this.BRmas.Text = "+";
            this.BRmas.FlatAppearance.BorderSize = 0;

            BRprincipal = new botonRedondo();
            BRprincipal.Click += new System.EventHandler(btn_agregar_click);
            this.Controls.Add(this.BRprincipal);
            this.BRprincipal.BackColor = Color.FromArgb(255, 36, 36);
            this.BRprincipal.FlatStyle = FlatStyle.Flat;
            this.BRprincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRprincipal.ForeColor = Color.White;
            this.BRprincipal.Location = new Point(593, 18);
            this.BRprincipal.Size = new System.Drawing.Size(189, 46);
            this.BRprincipal.Text = "Agregar";
            this.BRprincipal.FlatAppearance.BorderSize = 0;
            if (Carro.estatus == "nulo")
            {
                this.BRprincipal.Enabled = true;
            }
            else
                this.BRprincipal.Enabled = false;

            BRsecundario = new botonRedondo();
            BRsecundario.Click += new System.EventHandler(btn_consultar_click);
            this.Controls.Add(this.BRsecundario);
            this.BRsecundario.BackColor = Color.White;
            this.BRsecundario.FlatStyle = FlatStyle.Flat;
            this.BRsecundario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRsecundario.ForeColor = Color.Black;
            this.BRsecundario.Location = new Point(593, 81);
            this.BRsecundario.Size = new System.Drawing.Size(189, 46);
            this.BRsecundario.Text = "Consultar";
            this.BRsecundario.FlatAppearance.BorderSize = 0;

        }

        public void Crear_Panel_carrito(string texto, string monto,string cantidad, int x, int y)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryApp.Properties.Resources));

            this.Size = new System.Drawing.Size(801, 82);
            this.Location = new Point(x, y);
            this.BorderStyle = BorderStyle.FixedSingle;

            lblprincipal = new Label();
            this.Controls.Add(this.lblprincipal);
            this.lblprincipal.AutoSize = true;
            this.lblprincipal.Name = "lblnombre";
            this.lblprincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprincipal.ForeColor = Color.Black;
            this.lblprincipal.Location = new System.Drawing.Point(17, 26);
            this.lblprincipal.Size = new System.Drawing.Size(219, 29);
            this.lblprincipal.Text = texto;

            lblmonto = new Label();
            this.Controls.Add(this.lblmonto);
            this.lblmonto.AutoSize = true;
            this.lblmonto.Name = "lblmonto";
            this.lblmonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmonto.ForeColor = Color.FromArgb(0, 184, 49);
            this.lblmonto.Location = new System.Drawing.Point(408, 26);
            this.lblmonto.Size = new System.Drawing.Size(219, 29);
            this.lblmonto.Text = monto;

            BRcantidad = new botonRedondo();
            this.Controls.Add(this.BRcantidad);
            this.BRcantidad.BackColor = Color.FromArgb(236, 236, 236);
            this.BRcantidad.FlatStyle = FlatStyle.Flat;
            this.BRcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRcantidad.Location = new Point(334, 18);
            this.BRcantidad.Size = new System.Drawing.Size(43, 46);
            this.BRcantidad.Text = cantidad;
            this.BRcantidad.FlatAppearance.BorderSize = 0;

            BRprincipal = new botonRedondo();
            BRprincipal.Click += new System.EventHandler(btn_principal_click);
            this.Controls.Add(this.BRprincipal);
            this.BRprincipal.BackColor = Color.FromArgb(255, 36, 36);
            this.BRprincipal.FlatStyle = FlatStyle.Flat;
            this.BRprincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRprincipal.ForeColor = Color.White;
            this.BRprincipal.Location = new Point(593, 18);
            this.BRprincipal.Size = new System.Drawing.Size(189, 46);
            this.BRprincipal.Text = "Quitar";
            this.BRprincipal.FlatAppearance.BorderSize = 0;
        }

        //////////////////////////////////////////////////////////////////////LOS BOTONES////////////////////////////////////////////////////////////////////////////
        private void btn_menos_click(object sender, EventArgs e)
        {
            if(true)
            {
                int cantidad = int.Parse(BRcantidad.Text);
                //bruh nibba text here
                if (cantidad > 1)
                {
                    cantidad--;
                    BRcantidad.Text = cantidad.ToString();
                }
            }
        }

        private void btn_mas_click(object sender, EventArgs e)
        {
            if (true)
            {
                int cantidad = int.Parse(BRcantidad.Text);
                if (cantidad < 9)
                {
                    cantidad++;
                    BRcantidad.Text = cantidad.ToString();
                }
            }
        }

        private void btn_agregar_click(object sender, EventArgs e)
        {
            if (true)
            {
                //si idDetalle de orden es nulo, entonces llamo a la clase Detalle para crear una y se la asigno a orden, luego hago un metodo externo en esta clase que llame a Detalle tiene pedido y le asigno el contenido del panel ahí a la par que calcula el monto en detalle
                //caso contrario solo se llama al metodo. También se crea en CarritoC un elemento tipo detalle para almacenarlo ahí
                if(Carro.idDetalle == "nulo")
                {
                    //MessageBox.Show("nulo");
                    det = new Detalle(Carro);
                    Carro.update(det.IdDetalle, Carro.estatus);
                    detProd = new DetalleTieneProducto(det.IdDetalle);
                    Carro.DetTProd = detProd;
                    Carro.detalle = det;
                }
                else
                {
                    det = Carro.detalle;
                    detProd = Carro.DetTProd;
                }
                agregar();
            }
        }

        private void agregar()
        {
            detProd.nuevoProd(int.Parse(BRcantidad.Text), prod.IdProducto);
            //metodo que recalcule el monto en detalle
            SqlSingle precio = int.Parse(BRcantidad.Text) * prod.Precio;
            det.sumarMonto(precio);
            Carro.AgregarElemento(prod.Nombre, BRcantidad.Text, precio.ToString());
        }

        private void btn_consultar_click(object sender, EventArgs e)
        {
            if (true)
            {
                ProductoV ProdV = new ProductoV(contenedor, Carro);
                ProdV.Prod = prod;
                MenuV.Hide();
                MenuV.Desplegar(ProdV);
                
                MenuV.Close();
            }
        }

        private void btn_principal_click(object sender, EventArgs e)
        {
            if (true)
            {
                //metodo de borrar un registro en DetalleTieneProducto basado en el idproducto y detalle
                //ya luego un metodo para sumar al registro en caso de haber agregado al carrito el mismo producto
            }
        }
    }
}
