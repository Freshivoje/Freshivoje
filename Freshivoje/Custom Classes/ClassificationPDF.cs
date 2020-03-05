using System;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Windows.Forms;
using Freshivoje.Models;

namespace Freshivoje.Custom_Classes
{
    public class ClassificationPDF
    {
        private string firstName, lastName, status, articleName, sort, organic, category, palletNumber;
        private decimal quantity;

        Font font = new Font();
        Font font2 = new Font();
        public ClassificationPDF()
        {
            font = GetTahoma();
            font2 = GetTahomaa();
        }
        public static Font GetTahoma()
        {
            var fontName = "Tahoma";
            if (!FontFactory.IsRegistered(fontName))
            {
                var fontPath = Environment.GetEnvironmentVariable("SystemRoot") + "\\fonts\\tahoma.ttf";
                FontFactory.Register(fontPath);
            }
            return FontFactory.GetFont(fontName, BaseFont.CP1250, 8, Font.NORMAL);
        }
        public static Font GetTahomaa()
        {
            var fontName = "Tahoma";
            if (!FontFactory.IsRegistered(fontName))
            {
                var fontPath = Environment.GetEnvironmentVariable("SystemRoot") + "\\fonts\\tahoma.ttf";
                FontFactory.Register(fontPath);
            }
            return FontFactory.GetFont(fontName, BaseFont.CP1250, 70, Font.NORMAL);
        }

        public void exportgridview(DataGridView dgw)
        {
            int fileCount;
            decimal price, finalPrice = 0;
            string pictureURL, folderPath, strFileName;
            try
            {
                #region SECTION-1

                PdfPTable palleteId = new PdfPTable(1);
                PdfPTable companyData = new PdfPTable(1);
                PdfPTable clientData = new PdfPTable(1);
                PdfPTable data = new PdfPTable(8);
                PdfPTable blank = new PdfPTable(1);
                PdfPTable invoiceNumber = new PdfPTable(1);
                PdfPTable total = new PdfPTable(7);

                palleteId.DefaultCell.Padding = 5;
                palleteId.WidthPercentage = 80;
                palleteId.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                palleteId.DefaultCell.VerticalAlignment = Element.ALIGN_CENTER;
                palleteId.DefaultCell.BorderWidth = 0;
                companyData.WidthPercentage = 80;
                companyData.DefaultCell.HorizontalAlignment = Element.ALIGN_RIGHT;
                companyData.DefaultCell.VerticalAlignment = Element.ALIGN_RIGHT;
                companyData.DefaultCell.BorderWidth = 0;
                clientData.WidthPercentage = 80;
                clientData.DefaultCell.BorderWidth = 0;
                clientData.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;
                clientData.DefaultCell.VerticalAlignment = Element.ALIGN_LEFT;
                data.WidthPercentage = 80;
                data.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                data.DefaultCell.VerticalAlignment = Element.ALIGN_RIGHT;
                data.DefaultCell.Padding = 3;
                blank.DefaultCell.BorderWidth = 0;
                blank.AddCell(new Phrase(" "));
                invoiceNumber.WidthPercentage = 80;
                invoiceNumber.DefaultCell.BorderWidth = 0;
                invoiceNumber.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                invoiceNumber.DefaultCell.VerticalAlignment = Element.ALIGN_CENTER;
                total.WidthPercentage = 80;
                total.DefaultCell.BorderWidth = 0;
                total.DefaultCell.HorizontalAlignment = Element.ALIGN_RIGHT;
                total.DefaultCell.VerticalAlignment = Element.ALIGN_RIGHT;

                fileCount = Directory.GetFiles("C:\\PDF").Length;
                palleteId.AddCell(new Phrase("K-" + (fileCount + 1), font2));

                data.AddCell(new Phrase("IME", font));
                data.AddCell(new Phrase("PREZIME", font));
                data.AddCell(new Phrase("KOLIČINA", font));
                data.AddCell(new Phrase("IME ARTIKLA", font));
                data.AddCell(new Phrase("SORTA", font));
                data.AddCell(new Phrase("KONTROLISANA PROIZVODNJA", font));
                data.AddCell(new Phrase("KATEGORIJA", font));
                data.AddCell(new Phrase("BROJ PALETE", font));

                foreach (DataGridViewRow row in dgw.Rows)
                {

                    //    article = row.Cells["article"].Value.ToString();
                    //    articlequantity = Convert.ToDecimal(row.Cells["articleQuantity"].Value);
                    //    packaging = row.Cells["packaging"].Value.ToString();
                    //    packagingQuantity = Convert.ToDecimal(row.Cells["packagingQuantity"].Value);
                    //    packagingDebt = row.Cells["packagingDebt"].Value.ToString();
                    //    packagingOwnership = row.Cells["packagingOwnership"].Value.ToString();
                    //    articlePrice = Convert.ToDecimal(row.Cells["articlePrice"].Value);
                    //    finalPrice = finalPrice + articlePrice;

                firstName = row.Cells["first_name"].Value.ToString();
                lastName = row.Cells["last_name"].Value.ToString();
                quantity = Convert.ToDecimal(row.Cells["quantity"].Value);
                articleName = row.Cells["Articlename"].Value.ToString();
                sort = row.Cells["sort"].Value.ToString();
                organic = row.Cells["organic"].Value.ToString();
                category = row.Cells["category"].Value.ToString();
                palletNumber = row.Cells["palletnumber"].Value.ToString();

                    //    string text = article;
                    //    string text2 = packaging;
                    //    string[] separator = text.Split('/');
                    //    string[] separator2 = text2.Split('/');
                    //    article = separator[0];
                    //    sort = separator[1];
                    //    controled_production = separator[2];
                    //    classs = separator[3];
                    //    payloadP = separator2[0];
                    //    categoryP = separator2[1];
                    //    weightP = separator2[2];
                    //    manufacturerP = separator2[3];
                    //    stateP = separator2[4];

                data.AddCell(new Phrase(firstName, font));
                data.AddCell(new Phrase(lastName, font));
                data.AddCell(new Phrase(quantity.ToString("0.00"), font));
                data.AddCell(new Phrase(articleName, font));
                data.AddCell(new Phrase(sort, font));
                data.AddCell(new Phrase(organic, font));
                data.AddCell(new Phrase(category, font));
                data.AddCell(new Phrase(palletNumber, font));
                }
                #endregion
                #region IMAGE SECTION
                // pictureURL = "C:\\Users\\KORISNIK\\source\\repos\\Freshivoje\\Freshivoje\\Freshivoje\\Images\\1.png";
                //iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(pictureURL);
                //logo.ScaleToFit(110.0f, 140.0f);
                //logo.SpacingBefore = 20.0f;
                //logo.SpacingAfter = 10.0f;
                //logo.SetAbsolutePosition(70, 680);
                //logo.Alignment = Element.ALIGN_CENTER;
                #endregion
                #region PDF
                folderPath = "C:\\PDF\\";
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                strFileName = (fileCount + 1) + "-2019" + ".pdf";
                invoiceNumber.AddCell("BROJ FAKTURE: ARTIKLI" + ((fileCount + 1) + "-2019"));
                #endregion
                #region PAGE
                using (FileStream stream = new FileStream(folderPath + strFileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4.Rotate(), 10f, 10f, 10f, 70f);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    //pdfDoc.Add(logo);
                    pdfDoc.Add(blank);
                    pdfDoc.Add(blank);
                    pdfDoc.Add(palleteId);
                    pdfDoc.Add(blank);
                    pdfDoc.Add(blank);
                    pdfDoc.Add(blank);
                    pdfDoc.Add(data);
                    pdfDoc.Add(blank);
                    pdfDoc.Add(blank);
                    pdfDoc.Add(total);
                    pdfDoc.Add(blank);
                    pdfDoc.NewPage();
                    pdfDoc.Close();
                    stream.Close();
                }
                System.Diagnostics.Process.Start(folderPath + "\\" + strFileName);
                #endregion
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

