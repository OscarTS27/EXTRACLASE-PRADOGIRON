using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXTRACLASE_PRADOGIRON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
            private void btnAgregar_Click(object sender, EventArgs e)
            {
                string columna1 = txtColumna1.Text.Trim();
                string columna2 = txtColumna2.Text.Trim();
                string columna3 = txtColumna3.Text.Trim();

                
                if (!string.IsNullOrEmpty(columna1) && !string.IsNullOrEmpty(columna2) && !string.IsNullOrEmpty(columna3))
                {
                   
                    dataGridView1.Rows.Add(columna1, columna2, columna3);

                    
                    txtColumna1.Clear();
                    txtColumna2.Clear();
                    txtColumna3.Clear();
                }
                else
                {
                    MessageBox.Show("Debes ingresar datos en todas las columnas.");
                }
            }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
                
                dataGridView1.Columns.Add("AGUA", "AGUA");
                dataGridView1.Columns.Add("LUZ", "LUZ");
                dataGridView1.Columns.Add("GAS", "GAS");
            }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }
    

