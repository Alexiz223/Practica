using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventarioproductoss.Models;

namespace Inventarioproductoss.Presentation
{
    public partial class Frmtabla : Form
    {
        public int? Id;
        Productos oProductos = null;
        public Frmtabla(int? Id=null)
        {
            InitializeComponent();

            this.Id = Id;
            if (Id != null)
                cargadatos();
        }

        private void cargadatos()
        {
            using (InventarioProductosDBEntities db = new InventarioProductosDBEntities())
            {
                oProductos = db.Productos.Find(Id);

                if (oProductos != null)
                {
                    Productotxt.Text = oProductos.Producto;
                    preciotxt.Text = oProductos.Precio.ToString();
                    stocktxt.Text = oProductos.Stock.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (InventarioProductosDBEntities db = new InventarioProductosDBEntities())
            {
                if (Id==null)
                    oProductos = new Productos();

                oProductos.Producto = Productotxt.Text;
                
                if (decimal.TryParse(preciotxt.Text, out decimal precio) &&
                    int.TryParse(stocktxt.Text, out int stock))
                {
                    oProductos.Precio = precio;
                    oProductos.Stock = stock;
                    if (Id == null)
                        db.Productos.Add(oProductos);
                    else {
                        db.Entry(oProductos).State = System.Data.Entity.EntityState.Modified; 
                    }
                        db.SaveChanges();
                    if (Id == null)
                    MessageBox.Show("Producto guardado correctamente");
                    else
                    {
                        MessageBox.Show("Producto modificado correctamente");
                    }
                        this.Close();
                }
                else
                {
                    MessageBox.Show("Precio o Stock invalidos");
                }
            }
        }
    }
}
