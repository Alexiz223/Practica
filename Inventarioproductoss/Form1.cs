using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventarioproductoss.Models;
using Inventarioproductoss.Presentation;

namespace Inventarioproductoss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region helper
        private void Refrescar()
        {
            using (InventarioProductosDBEntities db = new InventarioProductosDBEntities())
            {
                var lst = from d in db.Productos
                          select d;

                dataGridView1.DataSource = lst.ToList();
            }
        }

        private int? GetId()
        {
            try
            {
                if (dataGridView1.CurrentRow == null)
                    return null;

                return Convert.ToInt32(
                    dataGridView1.CurrentRow.Cells[0].Value
                );
            }
            catch
            {
                return null;
            }
        }


        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void Nuevobtn_Click(object sender, EventArgs e)
        {
            Presentation.Frmtabla oFrmtabla = new Presentation.Frmtabla();
            oFrmtabla.ShowDialog();

            Refrescar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        int? Id = GetId();
            if (Id != null)
            { 
            Presentation.Frmtabla ofrmtabla = new Presentation.Frmtabla(Id);
                ofrmtabla.ShowDialog();

                Refrescar();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int? Id = GetId();
            if (Id != null)
            {
                using (InventarioProductosDBEntities db = new InventarioProductosDBEntities())
                {
                    Productos oProductos = db.Productos.Find(Id);
                    db.Productos.Remove(oProductos);
                    MessageBox.Show("Producto eliminado correctamente");
                    db.SaveChanges();
                        }

                    Refrescar();
            }
        }
    }
    }

