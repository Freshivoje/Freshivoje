using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Freshivoje.Custom_Forms;
using Freshivoje.Models;
using MySql.Data.MySqlClient;
using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;
using DocumentFormat.OpenXml.Bibliography;


namespace Freshivoje.Transport
{
    public partial class TransportForm : Form
    {
        public List<TransportItems> transportItems = new List<TransportItems>();
        int fkClientId;
        int idTransport = 0;
        public TransportForm(Client client)
        {
            
            InitializeComponent();
            transportDataGridView.AutoGenerateColumns = false;
            fkClientId = client._id;
            WindowState = FormWindowState.Maximized;
         
        }

        // Disables flickering on FormLoad
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        private void onlyNumerics(object sender, KeyPressEventArgs e)
        {
            // Limit input to numbers only
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            // 2 decimals limit
            if (System.Text.RegularExpressions.Regex.IsMatch((sender as TextBox).Text, @"\.\d\d") && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void blockEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void TransportForm_Load(object sender, EventArgs e)
        {

        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(priceTxtBox.Text) || string.IsNullOrWhiteSpace(quantityTxtBox.Text)
             || string.IsNullOrWhiteSpace(travelTxtBox.Text))
            {
                CustomMessageBox.ShowDialog(this, "Molimo Vas popunite sva polja!");
                return;
            }
            decimal price = Convert.ToDecimal(priceTxtBox.Text);
            decimal quantity = Convert.ToDecimal(quantityTxtBox.Text);
            decimal travel = Convert.ToDecimal(travelTxtBox.Text);
            decimal totalPrice = price * quantity * travel;
            idTransport++;
            transportItems.Add(new TransportItems(fkClientId, price, quantity, travel, totalPrice, idTransport));
            var bindingList = new BindingList<TransportItems>(transportItems);
            var source = new BindingSource(bindingList, null);
            transportDataGridView.DataSource = source;

            priceTxtBox.Text = "";
            quantityTxtBox.Text = "";
            travelTxtBox.Text = "";
        }

        public partial class Footer : PdfPageEventHelper
        {
            public override void OnEndPage(PdfWriter writer, Document doc)
            {
                Paragraph footer = new Paragraph("__________                                                                                                                                __________", FontFactory.GetFont(FontFactory.TIMES, 12, iTextSharp.text.Font.NORMAL));
                footer.Alignment = Element.ALIGN_CENTER;
                PdfPTable footerTbl = new PdfPTable(1);
                footerTbl.TotalWidth = 1000;
                footerTbl.HorizontalAlignment = Element.ALIGN_CENTER;
                PdfPCell cell = new PdfPCell(footer);
                cell.Border = 0;
                cell.PaddingLeft = 0;
                footerTbl.AddCell(cell);
                footerTbl.WriteSelectedRows(0, -1, 50, 50, writer.DirectContent);
            }
        }

        public void exportgridview(DataGridView dgw)
        {
            try
            {
                #region Common Part
                PdfPTable pdfTableBlank = new PdfPTable(1);

                pdfTableBlank.AddCell(new Phrase(" "));
                pdfTableBlank.DefaultCell.Border = 0;
                #endregion
                //#region Page
                #region Section-1

                PdfPTable pdfTable1 = new PdfPTable(1);
                PdfPTable pdfTable2 = new PdfPTable(1);
                PdfPTable pdfTable3 = new PdfPTable(1);
                PdfPTable pdfTable4 = new PdfPTable(4);
                PdfPTable pdfTable5 = new PdfPTable(1);
                PdfPTable pdfTable6 = new PdfPTable(1);
                PdfPTable pdfTable7 = new PdfPTable(1);
                PdfPTable pdfTable8 = new PdfPTable(1);

                //Font Style
                System.Drawing.Font fontH1 = new System.Drawing.Font("Currier", 16);

                //pdfTable1.DefaultCell.Padding = 5;
                pdfTable1.WidthPercentage = 80;
                pdfTable1.DefaultCell.HorizontalAlignment = Element.ALIGN_RIGHT;
                pdfTable1.DefaultCell.VerticalAlignment = Element.ALIGN_RIGHT;
                //pdfTable1.DefaultCell.BackgroundColor = new iTextSharp.text.BaseColor(64, 134, 170);
                pdfTable1.DefaultCell.BorderWidth = 0;


                pdfTable1.DefaultCell.Padding = 5;
                pdfTable2.WidthPercentage = 80;
                pdfTable2.DefaultCell.HorizontalAlignment = Element.ALIGN_RIGHT;
                pdfTable2.DefaultCell.VerticalAlignment = Element.ALIGN_RIGHT;
                //pdfTab2e1.DefaultCell.BackgroundColor = new iTextSharp.text.BaseColor(64, 134, 170);
                pdfTable2.DefaultCell.BorderWidth = 0;

                //pdfTable3.DefaultCell.Padding = 5;
                pdfTable3.WidthPercentage = 80;
                pdfTable3.DefaultCell.BorderWidth = 0;
                pdfTable6.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfTable6.DefaultCell.VerticalAlignment = Element.ALIGN_LEFT;

                pdfTable6.WidthPercentage = 80;
                pdfTable6.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfTable6.DefaultCell.VerticalAlignment = Element.ALIGN_LEFT;
                pdfTable6.DefaultCell.BorderWidth = 0;

                pdfTable7.WidthPercentage = 80;
                pdfTable7.DefaultCell.HorizontalAlignment = Element.ALIGN_RIGHT;
                pdfTable7.DefaultCell.VerticalAlignment = Element.ALIGN_RIGHT;
                pdfTable7.DefaultCell.BorderWidth = 0;

                pdfTable5.DefaultCell.BorderWidth = 0;

                Chunk c1 = new Chunk("REŠIVOJE", FontFactory.GetFont("Times New Roman"));
                c1.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                c1.Font.SetStyle(0);
                c1.Font.Size = 16;
                Phrase p1 = new Phrase();
                p1.Add(c1);
                pdfTable1.AddCell(p1);

                Chunk c3 = new Chunk("Aleksandar Djordjevic", FontFactory.GetFont("Times New Roman"));
                c3.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                c3.Font.SetStyle(0);
                c3.Font.Size = 11;
                Phrase p3 = new Phrase();
                p3.Add(c3);
                pdfTable2.AddCell(p3);

                Chunk c4 = new Chunk("PIB: 1118657152", FontFactory.GetFont("Times New Roman"));
                c3.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                c3.Font.SetStyle(0);
                c3.Font.Size = 11;
                Phrase p4 = new Phrase();
                p4.Add(c4);
                pdfTable2.AddCell(p4);

                Chunk c5 = new Chunk("Maticni broj: 65511037", FontFactory.GetFont("Times New Roman"));
                c3.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                c3.Font.SetStyle(0);
                c3.Font.Size = 11;
                Phrase p5 = new Phrase();
                p5.Add(c5);
                pdfTable2.AddCell(p5);

                Chunk c6 = new Chunk("Tekuci racun: 205-0000000270172-07", FontFactory.GetFont("Times New Roman"));
                c3.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                c3.Font.SetStyle(0);
                c3.Font.Size = 11;
                Phrase p6 = new Phrase();
                p6.Add(c6);
                pdfTable2.AddCell(p6);

                Chunk c7 = new Chunk("Adresa: Jasicki put 9, 37000, Krusevac", FontFactory.GetFont("Times New Roman"));
                c3.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                c3.Font.SetStyle(0);
                c3.Font.Size = 11;
                Phrase p7 = new Phrase();
                p7.Add(c7);
                pdfTable2.AddCell(p7);
                //////////////////////////////////////////////////////////////////////////////////////////////////
                Chunk c8 = new Chunk("Ime Firme", FontFactory.GetFont("Times New Roman"));
                c8.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                c8.Font.SetStyle(0);
                c8.Font.Size = 11;
                Phrase p8 = new Phrase();
                p8.Add(c8);
                pdfTable3.AddCell(p8);

                Chunk c9 = new Chunk("Ime i prezime klijenta", FontFactory.GetFont("Times New Roman"));
                c9.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                c9.Font.SetStyle(0);
                c9.Font.Size = 11;
                Phrase p9 = new Phrase();
                p9.Add(c9);
                pdfTable3.AddCell(p9);

                Chunk c10 = new Chunk("PIB klijenta", FontFactory.GetFont("Times New Roman"));
                c10.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                c10.Font.SetStyle(0);
                c10.Font.Size = 11;
                Phrase p10 = new Phrase();
                p10.Add(c10);
                pdfTable3.AddCell(p10);

                Chunk c11 = new Chunk("Maticni broj klijenta", FontFactory.GetFont("Times New Roman"));
                c11.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                c11.Font.SetStyle(0);
                c11.Font.Size = 11;
                Phrase p11 = new Phrase();
                p11.Add(c11);
                pdfTable3.AddCell(p11);

                Chunk c12 = new Chunk("Tekuci broj klijenta", FontFactory.GetFont("Times New Roman"));
                c12.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                c12.Font.SetStyle(0);
                c12.Font.Size = 11;
                Phrase p12 = new Phrase();
                p12.Add(c12);
                pdfTable3.AddCell(p12);

                Chunk c13 = new Chunk("Adresa klijenta", FontFactory.GetFont("Times New Roman"));
                c13.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                c13.Font.SetStyle(0);
                c13.Font.Size = 11;
                Phrase p13 = new Phrase();
                p13.Add(c13);
                pdfTable3.AddCell(p13);
                #endregion
                #region Section-1
                //PdfPTable pdfTable4 = new PdfPTable(4);
                //pdfTable4.DefaultCell.Padding = 5;
                //pdfTable4.WidthPercentage = 80;
                //pdfTable4.DefaultCell.BorderWidth = 0.0f;

                //pdfTable4.AddCell(new Phrase("JEDINICNA CENA"));
                //pdfTable4.AddCell(new Phrase("KOLICINA"));
                //pdfTable4.AddCell(new Phrase("KILOMETRI"));
                //pdfTable4.AddCell(new Phrase("UKUPNA CENA"));
                #endregion
                #region Section-Image

                string imageURL = "D:\\1.png";
                iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(imageURL);

                //Resize image depend upon your need
                jpg.ScaleToFit(110.0f, 140.0f);
                //Give space before image
                jpg.SpacingBefore = 20.0f;
                //Give some space after the image
                jpg.SpacingAfter = 10.0f;
                jpg.SetAbsolutePosition(70, 680); //40 700
                jpg.Alignment = Element.ALIGN_CENTER;
                #endregion
                #region section Table
                pdfTable4.AddCell(new Phrase("JEDINICNA CENA"));
                pdfTable4.AddCell(new Phrase("KOLICINA"));
                pdfTable4.AddCell(new Phrase("KILOMETRI"));
                pdfTable4.AddCell(new Phrase("UKUPNA CENA"));

                pdfTable5.AddCell(new Phrase(" "));

                foreach (DataGridViewRow row in dgw.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        pdfTable4.AddCell(new Phrase(cell.Value.ToString()));
                    }
                }
                #endregion
                //#endregion
                #region Pdf Generation
                string folderPath = "D:\\PDF\\";
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
 
                //File Name
                int fileCount = Directory.GetFiles("D:\\PDF").Length;
                string strFileName = "Faktura" + (fileCount + 1) + ".pdf";

                using (FileStream stream = new FileStream(folderPath + strFileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    #region PAGE-1
                    pdfDoc.Add(pdfTable1);
                    pdfDoc.Add(pdfTable5);
                    pdfDoc.Add(pdfTable2);
                    pdfDoc.Add(pdfTable5);
                    pdfDoc.Add(pdfTable5);
                    pdfDoc.Add(pdfTable5);
                    pdfDoc.Add(jpg);
                    pdfDoc.Add(pdfTable3);
                    pdfDoc.Add(pdfTable5);  
                    pdfDoc.Add(pdfTable5);
                    pdfDoc.Add(pdfTable4);
                    pdfDoc.Add(pdfTable5);
                    pdfDoc.Add(pdfTable5);
                    pdfDoc.Add(pdfTable5);
                    pdfDoc.Add(pdfTable5);
                    pdfDoc.Add(pdfTable5);
                    pdfDoc.Add(pdfTable5);
                    pdfDoc.Add(pdfTable6);
                    pdfDoc.Add(pdfTable5);
                    writer.PageEvent = new Footer();
                    pdfDoc.NewPage();
                    #endregion
                    pdfDoc.Close();
                    stream.Close();
                }
                #endregion
                #region Display PDF
                System.Diagnostics.Process.Start(folderPath + "\\" + strFileName);
                #endregion

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        private void finishInsertBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = CustomDialog.ShowDialog(this,$"Da li ste sigurni da želite da zavrsite putni nalog?");
            if (result == DialogResult.No || result == DialogResult.Cancel)
            {
                return;
            }
            DbConnection.executeTransportQuery(transportItems);
            CustomMessageBox.ShowDialog(this,$"Uspešno ste kreirali putni nalog!");
            exportgridview(transportDataGridView);
            
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void transportDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 5)
            {
                DialogResult result = CustomDialog.ShowDialog(this, $"Da li ste sigurni da želite da obrišete putni nalog?");
                if (result == DialogResult.No || result == DialogResult.Cancel)
                {
                    return;
                }
                int rowindex = transportDataGridView.CurrentRow.Index;
                int broj = transportItems.Count;
                for (int i = 0; i < transportItems.Count; i++)
                {
                    if((transportItems[i]._id - 1) == rowindex)
                    {
                        transportItems.RemoveAt(Convert.ToInt32(rowindex));
                        var bindingList = new BindingList<TransportItems>(transportItems);
                        var source = new BindingSource(bindingList, null);
                        transportDataGridView.DataSource = source;
                    }
                }
            }
        }
    }
}
