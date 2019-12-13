using Freshivoje.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Freshivoje.Custom_Forms;
using Freshivoje.Insert_Form;

namespace Freshivoje.Custom_Classes
{
    class StoragePDF
    {
        private int _fkClientId;
        private string _clientFirstName, _clientLastName, _clientAddress, _clientJMBG, _clientPIB, _clientZipCode, _clientPhone, _clientCompanyName, _clientSPO, nameQuantityPackages, selectionName, articleQuantity, numberOfPackages, rentingDataPicker, endDataOfRentPicker, price;

        Font font = new Font();
        public StoragePDF(Client client)
        {
            font = GetTahoma();
            _fkClientId = client._id;
            _clientFirstName = client._firstName;
            _clientLastName = client._lastName;
            _clientAddress = client._address;
            _clientJMBG = client._JMBG;
            _clientPIB = client._PIB;
            _clientZipCode = client._zipCode;
            _clientPhone = client._phone;
            _clientCompanyName = client._companyName;
            _clientSPO = client._SPO;
        }

        public static Font GetTahoma()
        {
            var fontName = "Tahoma";
            if (!FontFactory.IsRegistered(fontName))
            {
                var fontPath = Environment.GetEnvironmentVariable("SystemRoot") + "\\fonts\\tahoma.ttf";
                FontFactory.Register(fontPath);
            }
            return FontFactory.GetFont(fontName, BaseFont.CP1250, 9, Font.NORMAL);
        }

        public void OnEndPage(PdfWriter writer)
        {
            Paragraph footer = new Paragraph("________________                                                                                                             ________________", font);
            footer.Alignment = Element.ALIGN_CENTER;
            PdfPTable footerTbl = new PdfPTable(1);
            footerTbl.TotalWidth = 1000;
            footerTbl.HorizontalAlignment = Element.ALIGN_CENTER;
            PdfPCell cell = new PdfPCell(footer);
            cell.Border = 0;
            cell.PaddingLeft = 0;
            footerTbl.AddCell(cell);
            footerTbl.WriteSelectedRows(0, -1, 60, 50, writer.DirectContent);
        }
        public void OnEndPage1(PdfWriter writer)
        {
            Paragraph footer2 = new Paragraph("Potpis klijenta:                                                                                                                    Potpis izdavaoca:", font);
            footer2.Alignment = Element.ALIGN_CENTER;
            PdfPTable footerTb2 = new PdfPTable(1);
            footerTb2.TotalWidth = 1000;
            footerTb2.HorizontalAlignment = Element.ALIGN_CENTER;
            PdfPCell cell = new PdfPCell(footer2);
            cell.Border = 0;
            cell.PaddingLeft = 0;
            footerTb2.AddCell(cell);
            footerTb2.WriteSelectedRows(0, -1, 60, 75, writer.DirectContent);
        }

        public void exportgridview(params string[] values)
        {
            int fileCount;
            decimal finalPrice = 0;
            string pictureURL, folderPath, strFileName;
            try
            {
                #region SECTION-1
                PdfPTable companyName = new PdfPTable(1);
                PdfPTable companyData = new PdfPTable(1);
                PdfPTable clientData = new PdfPTable(1);
                PdfPTable data = new PdfPTable(6);
                PdfPTable blank = new PdfPTable(1);
                PdfPTable invoiceNumber = new PdfPTable(1);
                PdfPTable total = new PdfPTable(7);

                companyName.DefaultCell.Padding = 5;
                companyName.WidthPercentage = 80;
                companyName.DefaultCell.HorizontalAlignment = Element.ALIGN_RIGHT;
                companyName.DefaultCell.VerticalAlignment = Element.ALIGN_RIGHT;
                companyName.DefaultCell.BorderWidth = 0;
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

                data.AddCell(new Phrase("IME\nODELJKA", font));
                data.AddCell(new Phrase("KOLIČINA\nARTIKLA", font));
                data.AddCell(new Phrase("BROJ\nAMBALAŽA", font));
                data.AddCell(new Phrase("DATUM\nPOČETKA\nIZNAMLJIVANJA", font));
                data.AddCell(new Phrase("DATUM\nKRAJA\nIZNAMLJIVANJA", font));
                data.AddCell(new Phrase("CENA\n(RSD)", font));

                nameQuantityPackages = values[0];
                string[] separator = nameQuantityPackages.Split('/');
                selectionName = separator[0];
                articleQuantity = separator[1];
                numberOfPackages = separator[2];
                rentingDataPicker = values[1];
                endDataOfRentPicker = values[2];
                price = values[3];

                data.AddCell(new Phrase(selectionName, font));
                data.AddCell(new Phrase(articleQuantity, font));
                data.AddCell(new Phrase(numberOfPackages, font));
                data.AddCell(new Phrase(rentingDataPicker, font));
                data.AddCell(new Phrase(endDataOfRentPicker, font));
                data.AddCell(new Phrase(price, font));

                Chunk c1 = new Chunk("REŠIVOJE", font);
                c1.Font.Color = new BaseColor(0, 0, 0);
                c1.Font.SetStyle(0);
                Phrase p1 = new Phrase();
                p1.Add(c1);
                companyName.AddCell(p1);
                Chunk c3 = new Chunk("Aleksandar Đorđević", font);
                c3.Font.Color = new BaseColor(0, 0, 0);
                c3.Font.SetStyle(0);

                Phrase p3 = new Phrase();
                p3.Add(c3);
                companyData.AddCell(p3);
                Chunk c4 = new Chunk("PIB: 1118657152", font);
                c3.Font.Color = new BaseColor(0, 0, 0);
                c3.Font.SetStyle(0);

                Phrase p4 = new Phrase();
                p4.Add(c4);
                companyData.AddCell(p4);
                Chunk c5 = new Chunk("Matični broj: 65511037", font);
                c3.Font.Color = new BaseColor(0, 0, 0);
                c3.Font.SetStyle(0);

                Phrase p5 = new Phrase();
                p5.Add(c5);
                companyData.AddCell(p5);
                Chunk c6 = new Chunk("Tekući račun: 205-0000000270172-07", font);
                c3.Font.Color = new BaseColor(0, 0, 0);
                c3.Font.SetStyle(0);
                Phrase p6 = new Phrase();
                p6.Add(c6);
                companyData.AddCell(p6);

                Chunk c7 = new Chunk("Adresa: Jasički put 9, 37000, Kruševac", font);
                c3.Font.Color = new BaseColor(0, 0, 0);
                c3.Font.SetStyle(0);
                Phrase p7 = new Phrase();
                p7.Add(c7);
                companyData.AddCell(p7);
                //////////////////////////////////////////////////////////////////////////////////////////////////
                Chunk c8 = new Chunk(("Ime: ") + _clientFirstName, font);
                c8.Font.Color = new BaseColor(0, 0, 0);
                c8.Font.SetStyle(0);
                Phrase p8 = new Phrase();
                p8.Add(c8);
                clientData.AddCell(p8);
                Chunk c9 = new Chunk(("Prezime: ") + _clientLastName, font);
                c9.Font.Color = new BaseColor(0, 0, 0);
                c9.Font.SetStyle(0);
                Phrase p9 = new Phrase();
                p9.Add(c9);
                clientData.AddCell(p9);
                Chunk c10 = new Chunk(("Adresa: ") + _clientAddress, font);
                c10.Font.Color = new BaseColor(0, 0, 0);
                c10.Font.SetStyle(0);
                Phrase p10 = new Phrase();
                p10.Add(c10);
                clientData.AddCell(p10);
                Chunk c11 = new Chunk(("JMBG: ") + _clientJMBG, font);
                c11.Font.Color = new BaseColor(0, 0, 0);
                c11.Font.SetStyle(0);
                Phrase p11 = new Phrase();
                p11.Add(c11);
                clientData.AddCell(p11);
                Chunk c12 = new Chunk(("PIB: ") + _clientPIB, font);
                c12.Font.Color = new BaseColor(0, 0, 0);
                c12.Font.SetStyle(0);
                Phrase p12 = new Phrase();
                p12.Add(c12);
                clientData.AddCell(p12);
                Chunk c13 = new Chunk(("Poštanski broj: ") + _clientZipCode, font);
                c13.Font.Color = new BaseColor(0, 0, 0);
                c13.Font.SetStyle(0);
                Phrase p13 = new Phrase();
                p13.Add(c13);
                clientData.AddCell(p13);
                Chunk c14 = new Chunk(("Telefon: ") + _clientPhone, font);
                c14.Font.Color = new BaseColor(0, 0, 0);
                c14.Font.SetStyle(0);
                Phrase p14 = new Phrase();
                p14.Add(c14);
                clientData.AddCell(p14);
                Chunk c15 = new Chunk(("Ime firme: ") + _clientCompanyName, font);
                c15.Font.Color = new BaseColor(0, 0, 0);
                c15.Font.SetStyle(0);
                Phrase p15 = new Phrase();
                p15.Add(c15);
                clientData.AddCell(p15);
                Chunk c16 = new Chunk(("SPO: ") + _clientSPO, font);
                c16.Font.Color = new BaseColor(0, 0, 0);
                c16.Font.SetStyle(0);
                Phrase p16 = new Phrase();
                p16.Add(c16);
                clientData.AddCell(p16);

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

                fileCount = Directory.GetFiles("C:\\PDF").Length;
                strFileName = (fileCount + 1) + "-2019" + ".pdf";
                invoiceNumber.AddCell("BROJ FAKTURE: ARTIKLI" + ((fileCount + 1) + "-2019"));
                #endregion
                #region PAGE
                using (FileStream stream = new FileStream(folderPath + strFileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 70f);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    //pdfDoc.Add(logo);
                    pdfDoc.Add(blank);
                    pdfDoc.Add(companyName);
                    pdfDoc.Add(blank);
                    pdfDoc.Add(blank);
                    pdfDoc.Add(companyData);
                    pdfDoc.Add(blank);
                    pdfDoc.Add(clientData);
                    pdfDoc.Add(blank);
                    pdfDoc.Add(blank);
                    pdfDoc.Add(data);
                    pdfDoc.Add(blank);
                    pdfDoc.Add(blank);
                    OnEndPage(writer);
                    OnEndPage1(writer);
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
