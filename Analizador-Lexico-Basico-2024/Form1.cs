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
using System.Text.RegularExpressions;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Analizador_Lexico_Basico_2024
{
	public partial class Form1 : Form
	{
		string rutaArchivo = null;

		public static DataTable DiccionarioGlobal { get; set; }
		DICCIONARIO frmDiccionario = new DICCIONARIO();
		public Form1()
		{
			InitializeComponent();
			ResultadoAnalisis = CrearTablaResultado();
			dgTablaSalida.DataSource = ResultadoAnalisis;
		}

		public static DataTable ResultadoAnalisis { get; set; }

		private DataTable CrearTablaResultado()
		{
			DataTable dt = new DataTable();
			dt.Columns.Add("No. de fila", typeof(int));
			dt.Columns.Add("No. de posición en la fila", typeof(int));
			dt.Columns.Add("Categoría", typeof(string));
			dt.Columns.Add("Nombre del Token", typeof(string));
			dt.Columns.Add("Signo del Token", typeof(string));
			return dt;
		}


	   


		private void dICCIONARIOToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void diccionarioToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Title = "Seleccionar archivo de código";
				openFileDialog.Filter = "Archivos de código|*.cs;*.java;*.cpp;*.h;*.hpp;*.c|" +
									   "Archivos C#|*.cs|" +
									   "Archivos Java|*.java|" +
									   "Archivos C/C++|*.cpp;*.c;*.h;*.hpp|" +
									   "Todos los archivos|*.*";
				openFileDialog.FilterIndex = 1;
				openFileDialog.RestoreDirectory = true;


				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					try
					{

						string contenido = File.ReadAllText(openFileDialog.FileName);
						rutaArchivo = openFileDialog.FileName;

						richCodigo.Text = contenido;

						MessageBox.Show($"Archivo cargado: {Path.GetFileName(openFileDialog.FileName)}",
									   "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					catch (Exception ex)
					{
						MessageBox.Show($"Error al cargar el archivo: {ex.Message}", "Error",
									   MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
		{
			pnSalida.Visible = pnSalida.Visible ? false : true;
		}
		private void exportarSalidaToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void diccionarioToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			frmDiccionario.Show();
		}


		private void btnAnalizar_Click(object sender, EventArgs e)
		{

			if (DiccionarioGlobal == null)
			{
				MessageBox.Show("El diccionario no esta cargado o está vacío", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				frmDiccionario.Show();
				return;
			}
			ResultadoAnalisis = CrearTablaResultado();

			string[] lineas = richCodigo.Lines;

			for (int i = 0; i < lineas.Length; i++)
			{
				List<string> tokens = creartokens(lineas[i]);

				for (int j = 0; j < tokens.Count; j++)
				{
					string tokenAnterior = j > 0 ? tokens[j - 1] : null;
					DataRow dr = AnalizarToken(tokens[j], tokenAnterior, i + 1, j + 1);

					if (dr != null)
					{
						Form1.ResultadoAnalisis.Rows.Add(dr);
					}
				}
			}

			dgTablaSalida.DataSource = Form1.ResultadoAnalisis;
			toolStripSalida.Text = "Salida (Lineas: " + richCodigo.Lines.Length.ToString() + ")";
			pnSalida.Visible = true;
		}


		private List<string> creartokens(string linea)
		{
			List<string> tokens = new List<string>();
			string acumulador = "";

			foreach (char c in linea)
			{
				if (char.IsWhiteSpace(c))
				{
					if (acumulador != "")
					{
						tokens.Add(acumulador);
						acumulador = "";
					}
				}
				else if ("(){}[]+-*/;,".Contains(c))
				{
					if (acumulador != "")
					{
						tokens.Add(acumulador);
						acumulador = "";
					}
					tokens.Add(c.ToString());
				}
				else
				{
					acumulador += c;
				}
			}

			if (acumulador != "")
				tokens.Add(acumulador);

			return tokens;
		}

		private bool EsPalabraReservada(string token)
		{
			foreach (DataRow row in Form1.DiccionarioGlobal.Rows)
			{
				if (row["Categoría"].ToString() == "Palabras reservadas" &&
					row["Signo del Token"].ToString().Equals(token, StringComparison.OrdinalIgnoreCase))
				{
					return true;
				}
			}
			return false;
		}


		private DataRow AnalizarToken(string token, string tokenAnterior, int fila, int posicion)
		{
			foreach (DataRow row in DiccionarioGlobal.Rows)
			{
				if (row["Signo del Token"].ToString() == token ||
					row["Signo del Token"].ToString().Equals(token, StringComparison.OrdinalIgnoreCase))
				{
					DataRow dr = ResultadoAnalisis.NewRow();
					dr["No. de fila"] = fila;
					dr["No. de posición en la fila"] = posicion;
					dr["Categoría"] = row["Categoría"];
					dr["Nombre del Token"] = row["Nombre del Token"];
					dr["Signo del Token"] = row["Signo del Token"];
					return dr;
				}
			}

			if (!string.IsNullOrWhiteSpace(token))
			{
				if (EsPalabraReservada(tokenAnterior))
				{
					DataRow dr = ResultadoAnalisis.NewRow();
					dr["No. de fila"] = fila;
					dr["No. de posición en la fila"] = posicion;
					dr["Categoría"] = "Variable";
					dr["Nombre del Token"] = "Identificador";
					dr["Signo del Token"] = token;
					return dr;
				}
			}

			return null;
		}

		private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog guardarArchivo = new SaveFileDialog();

			guardarArchivo.Title = "Guardar archivo de código";
			guardarArchivo.Filter = "Archivos C#|*.cs|Archivos Java|*.java|Archivos C++|*.cpp|Todos los archivos|*.*";
			guardarArchivo.FilterIndex = 1;
			guardarArchivo.AddExtension = true;

			if (guardarArchivo.ShowDialog() == DialogResult.OK)
			{
				try
				{
					File.WriteAllText(guardarArchivo.FileName, richCodigo.Text, Encoding.UTF8);

					MessageBox.Show("Archivo guardado correctamente", "Éxito",
								  MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error al guardar el archivo: " + ex.Message, "Error",
								  MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			guardarArchivo.Dispose();
		}

		private void guardarCódigoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(rutaArchivo))
			{
				try
				{
					File.WriteAllText(rutaArchivo, richCodigo.Text, Encoding.UTF8);
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


		public static void ExportarAPDF(DataGridView dGDatos)
		{
			SaveFileDialog saveDialog = new SaveFileDialog();
			saveDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
			saveDialog.Title = "Guardar como PDF";
			saveDialog.DefaultExt = "pdf";
			saveDialog.AddExtension = true;

			if (saveDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{

					Document doc = new Document();

					PdfWriter.GetInstance(doc, new FileStream(saveDialog.FileName, FileMode.Create));
					doc.Open();


					PdfPTable table = new PdfPTable(dGDatos.Columns.Count);
					table.WidthPercentage = 100; 

					foreach (DataGridViewColumn col in dGDatos.Columns)
					{
						PdfPCell cell = new PdfPCell(new Phrase(col.HeaderText));
						cell.BackgroundColor = new BaseColor(240, 240, 240);
						table.AddCell(cell);
					}

					foreach (DataGridViewRow row in dGDatos.Rows)
					{
						foreach (DataGridViewCell cell in row.Cells)
						{
							table.AddCell(cell.Value?.ToString() ?? "");
						}
					}

					doc.Add(table);
					doc.Close();

					MessageBox.Show("Datos exportados a PDF correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
				}
			}
		}

		private void pDFToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ExportarAPDF(dgTablaSalida);
		}

		private void cSVToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (ResultadoAnalisis == null || ResultadoAnalisis.Rows.Count == 0)
			{
				MessageBox.Show("No hay resultados para guardar.");
				return;
			}

			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "CSV (*.csv)|*.csv";
			sfd.FileName = "resultado.csv";

			if (sfd.ShowDialog() == DialogResult.OK)
			{
				GuardarAnalisisCSV(ResultadoAnalisis, sfd.FileName);
				MessageBox.Show("Archivo guardado correctamente.");
			}
		}

		private void GuardarAnalisisCSV(DataTable dt, string rutaArchivo)
		{
			using (StreamWriter sw = new StreamWriter(rutaArchivo, false, Encoding.UTF8))
			{
				var columnNames = dt.Columns.Cast<DataColumn>().Select(col => col.ColumnName);
				sw.WriteLine(string.Join(",", columnNames));

				foreach (DataRow row in dt.Rows)
				{
					var fields = row.ItemArray.Select(field => field.ToString());
					sw.WriteLine(string.Join(",", fields));
				}
			}
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{

		
			Application.Exit();
		}
	}


}
