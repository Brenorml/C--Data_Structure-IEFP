using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMySQL
{
    public partial class FormListarFormando : Form
    {
        DBConnect conn = new DBConnect();
        public FormListarFormando()
        {
            InitializeComponent();
        }

        private void FormListarFormando_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Columns.Add("codID", "ID");
            dataGridView1.Columns.Add("nome", "Nome");
            dataGridView1.Columns.Add("iban", "IBAN");
            dataGridView1.Columns.Add("datanascimento", "Data nasc.");
            dataGridView1.Columns.Add("genero", "Género");

            conn.PreencherDataGridViewFormandos(ref dataGridView1, ' ', "");
            lblRegistos.Text = "N.º de Registos: " + dataGridView1.Rows.Count;

            rbTodos.Checked = true;

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            conn.PreencherDataGridViewFormandos(ref dataGridView1, Genero(), txtNome.Text);
            lblRegistos.Text = "N.º de Registos: " + dataGridView1.Rows.Count;
        }

        private char Genero()
        {
            char genero = 'T';
            if (rbFeminino.Checked)
            {
                genero = 'F';
            }
            else if (rbMasculino.Checked)
            {
                genero = 'M';
            }
            else if (rbOutro.Checked)
            {
                genero = 'O';
            }
            return genero;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Formandos.PDF";
                bool fileError = false;
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Impossível de apagar o ficheiro!");
                        }
                    }
                }
                if (!fileError)
                {
                    try
                    {
                        PdfPTable pdfPTable = new PdfPTable(dataGridView1.Columns.Count);
                        pdfPTable.DefaultCell.Padding = 3;
                        pdfPTable.WidthPercentage = 100;
                        pdfPTable.HorizontalAlignment = Element.ALIGN_LEFT;

                        foreach (DataGridViewColumn column in dataGridView1.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                            pdfPTable.AddCell(cell);
                        }
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                pdfPTable.AddCell(cell.Value.ToString());
                            }
                        }
                        FileStream stream = new FileStream(sfd.FileName, FileMode.Create);

                        Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        pdfDoc.Add(pdfPTable);
                        pdfDoc.Close();
                        stream.Close();

                        MessageBox.Show("Imprimiu com sucesso!");
                    }
                    catch (Exception ex) 
                    {
                        MessageBox.Show("ERROR: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Não existe registo!");
            }
        }
    }
}
