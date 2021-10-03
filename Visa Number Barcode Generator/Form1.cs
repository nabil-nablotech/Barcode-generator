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
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Visa_Number_Barcode_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateBarcodeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                
                Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                pictureBox1.Image = barcode.Draw(visaNumberTextBox.Text, 50);
                visaNumberBarcodeLabel.Text = visaNumberTextBox.Text;
            }

            catch(Exception exe)
            {
                MessageBox.Show("An error has occurred while generating barcode","Generating barcode error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                exe.ToString();
            }
        }

        private void generatePdfBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Document doc = new Document(PageSize.LETTER, 10, 10, 42, 35);
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = fullNameTextBox.Text + " " + passportNoTextBox.Text;
                saveFileDialog.Filter = "Pdf Files | *.pdf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    PdfWriter pdfWriter = PdfWriter.GetInstance(doc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                    doc.Open();
                    MemoryStream ms = new MemoryStream();
                    int width = pictureBox1.Size.Width;
                    int height = pictureBox1.Size.Height;
                    pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] buff = ms.GetBuffer();
                    iTextSharp.text.Image barcode = iTextSharp.text.Image.GetInstance(buff);
                    pictureBox1.Width = width;
                    pictureBox1.Height = height;
                    barcode.ScaleToFit(120, 20f);
                    Chunk chunk = new Chunk("                                                                               " + visaNumberBarcodeLabel.Text+"     Sponsor Name: "+ sponsorNameTextBox.Text, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 9, iTextSharp.text.Font.BOLD));
                    barcode.ScaleAbsoluteWidth(120);
                    barcode.SetAbsolutePosition(150f, doc.PageSize.Height - 30f);
                    chunk.SetTextRise(3);
                    doc.Add(barcode);
                    doc.Add(chunk);
                    doc.Close();
                    MessageBox.Show("Success!", "Generating pdf sucessfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception exe)
            {
                MessageBox.Show("An error has occurred while generating pdf","Generating pdf error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                exe.ToString();
            }
        }
    }
}
