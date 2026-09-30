using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 

namespace Analizador_Lexico_Basico_2024
{
    public partial class DICCIONARIO : Form
    {

        string diccionarioActual = null;
        public DICCIONARIO()
        {
            InitializeComponent();
            dgDiccionario.DataSource = Form1.DiccionarioGlobal;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

        }
        private DataTable LeerDiccionario(string filePath)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Categoría");
            dt.Columns.Add("Nombre del Token");
            dt.Columns.Add("Signo del Token");

            string[] lineas = File.ReadAllLines(filePath);
            for (int i = 1; i < lineas.Length; i++)
            {
                string[] valores = lineas[i].Split(',');
                if (valores.Length == 3)
                {
                    dt.Rows.Add(valores[0], valores[1], valores[2]);
                }
            }

            return dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbCategoria.Text) || string.IsNullOrWhiteSpace(txtSigno.Text) || string.IsNullOrWhiteSpace(txtToken.Text) )
            {
                MessageBox.Show("Debe completar todos los campos antes de agregar.");
                return;
            }
            if (Form1.DiccionarioGlobal == null)
            {
                Form1.DiccionarioGlobal = CrearDiccionarioVacio();
            }

            DataRow nuevaFila = Form1.DiccionarioGlobal.NewRow();
            nuevaFila["Categoría"] = cbCategoria.Text;
            nuevaFila["Nombre del Token"] = txtToken.Text;
            nuevaFila["Signo del Token"] = txtSigno.Text;

            Form1.DiccionarioGlobal.Rows.Add(nuevaFila);

            MessageBox.Show("Elemento agregado correctamente.");
            dgDiccionario.DataSource = Form1.DiccionarioGlobal;

        }
        private DataTable CrearDiccionarioVacio()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Categoría");
            dt.Columns.Add("Nombre del Token");
            dt.Columns.Add("Signo del Token");
            return dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
         
        }
        private void GuardarDiccionario(DataTable dt, string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath, false))
            {
                sw.WriteLine("Categoría,Nombre del Token,Signo del Token");
                foreach (DataRow row in dt.Rows)
                {
                    sw.WriteLine($"{row["Categoría"]},{row["Nombre del Token"]},{row["Signo del Token"]}");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void diccionarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Form1.DiccionarioGlobal = LeerDiccionario(ofd.FileName);
                dgDiccionario.DataSource = Form1.DiccionarioGlobal;
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            sfd.FileName = "diccionario.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                GuardarDiccionario(Form1.DiccionarioGlobal, sfd.FileName);
                MessageBox.Show("Diccionario guardado correctamente.");
            }
        }

        private void guardarCódigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(diccionarioActual))
            {
                try
                {
                    GuardarDiccionario(Form1.DiccionarioGlobal, diccionarioActual);
                    MessageBox.Show("Archivo guardado correctamente", "Éxito",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar: " + ex.Message, "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                guardarComoToolStripMenuItem_Click(sender, e);
            }
        }
    }
}

