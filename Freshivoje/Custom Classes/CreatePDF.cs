﻿using System;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Windows.Forms;
using Freshivoje.Models;

namespace Freshivoje.Custom_Forms
{
    public class PDF
    {
        private int _fkClientId;
        private string _clientFirstName, _clientLastName, _clientAddress, _clientJMBG, _clientBPG, _clientZipCode, _clientPhone;
        public PDF(Client client)
        {
            _fkClientId = client._id;
            _clientFirstName = client._firstName;
            _clientLastName = client._lastName;
            _clientAddress = client._address;
            _clientJMBG = client._JMBG;
            _clientBPG = client._BPG;
            _clientZipCode = client._zipCode;
            _clientPhone = client._phone;
        }


        public void OnEndPage(PdfWriter writer)
        {
            Paragraph footer = new Paragraph("________________                                                                                               ________________", FontFactory.GetFont(FontFactory.TIMES, 12, iTextSharp.text.Font.NORMAL));
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
            Paragraph footer2 = new Paragraph("Potpis klijenta:                                                                                                       Potpis izdavaoca:", FontFactory.GetFont(FontFactory.TIMES, 12, iTextSharp.text.Font.NORMAL));
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

        public void exportgridview(DataGridView dgw)
        {
            int fileCount;
            decimal finalPrice = 0, totalPrice1;
            string price, quantity, traveled, totalPrice, pictureURL, folderPath, strFileName;
            try
            {
                //pdfTable1.DefaultCell.BackgroundColor = new iTextSharp.text.BaseColor(64, 134, 170);
                //System.Drawing.Font fontH1 = new System.Drawing.Font("Times New Roman", 16);
                #region SECTION-1

                PdfPTable companyName = new PdfPTable(1);
                PdfPTable companyData = new PdfPTable(1);
                PdfPTable clientData = new PdfPTable(1);
                PdfPTable data = new PdfPTable(4);
                PdfPTable blank = new PdfPTable(1);
                PdfPTable invoiceNumber = new PdfPTable(1);
                PdfPTable total = new PdfPTable(4);

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
                data.DefaultCell.HorizontalAlignment = Element.ALIGN_RIGHT;
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

                data.AddCell(new Phrase("JEDINIČNA CENA \n(BR.)"));
                data.AddCell(new Phrase("KOLIČINA \n(KG)"));
                data.AddCell(new Phrase("KILOMETRI \n(KM)"));
                data.AddCell(new Phrase("UKUPNA CENA \n(RSD)"));

                foreach (DataGridViewRow row in dgw.Rows)
                {
                    price = (row.Cells["price"].Value.ToString());
                    quantity = (row.Cells["quantity"].Value.ToString());
                    traveled = (row.Cells["traveled"].Value.ToString());
                    totalPrice = (row.Cells["totalPrice"].Value.ToString());
                    totalPrice1 = Convert.ToDecimal(row.Cells["totalPrice"].Value);
                    data.AddCell(new Phrase(price));
                    data.AddCell(new Phrase(quantity));
                    data.AddCell(new Phrase(traveled));
                    data.AddCell(new Phrase(totalPrice));
                    finalPrice = finalPrice + totalPrice1;
                }

                Chunk c1 = new Chunk("REŠIVOJE", FontFactory.GetFont("Times New Roman"));
                c1.Font.Color = new BaseColor(0, 0, 0);
                c1.Font.SetStyle(0);
                c1.Font.Size = 16;
                Phrase p1 = new Phrase();
                p1.Add(c1);
                companyName.AddCell(p1);
                Chunk c3 = new Chunk("Aleksandar Đorđevic", FontFactory.GetFont("Times New Roman"));
                c3.Font.Color = new BaseColor(0, 0, 0);
                c3.Font.SetStyle(0);
                c3.Font.Size = 11;
                Phrase p3 = new Phrase();
                p3.Add(c3);
                companyData.AddCell(p3);
                Chunk c4 = new Chunk("PIB: 1118657152", FontFactory.GetFont("Times New Roman"));
                c3.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                c3.Font.SetStyle(0);
                c3.Font.Size = 11;
                Phrase p4 = new Phrase();
                p4.Add(c4);
                companyData.AddCell(p4);
                Chunk c5 = new Chunk("Maticni broj: 65511037", FontFactory.GetFont("Times New Roman"));
                c3.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                c3.Font.SetStyle(0);
                c3.Font.Size = 11;
                Phrase p5 = new Phrase();
                p5.Add(c5);
                companyData.AddCell(p5);
                Chunk c6 = new Chunk("Tekuci racun: 205-0000000270172-07", FontFactory.GetFont("Times New Roman"));
                c3.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                c3.Font.SetStyle(0);
                c3.Font.Size = 11;
                Phrase p6 = new Phrase();
                p6.Add(c6);
                companyData.AddCell(p6);
                Chunk c7 = new Chunk("Adresa: Jasicki put 9, 37000, Krusevac", FontFactory.GetFont("Times New Roman"));
                c3.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                c3.Font.SetStyle(0);
                c3.Font.Size = 11;
                Phrase p7 = new Phrase();
                p7.Add(c7);
                companyData.AddCell(p7);
                //////////////////////////////////////////////////////////////////////////////////////////////////
                Chunk c8 = new Chunk(("Ime: ") + _clientFirstName, FontFactory.GetFont("Times New Roman"));
                c8.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                c8.Font.SetStyle(0);
                c8.Font.Size = 11;
                Phrase p8 = new Phrase();
                p8.Add(c8);
                clientData.AddCell(p8);
                Chunk c9 = new Chunk(("Prezime: ") + _clientLastName, FontFactory.GetFont("Times New Roman"));
                c9.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                c9.Font.SetStyle(0);
                c9.Font.Size = 11;
                Phrase p9 = new Phrase();
                p9.Add(c9);
                clientData.AddCell(p9);
                Chunk c10 = new Chunk(("Adresa: ") + _clientAddress, FontFactory.GetFont("Times New Roman"));
                c10.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                c10.Font.SetStyle(0);
                c10.Font.Size = 11;
                Phrase p10 = new Phrase();
                p10.Add(c10);
                clientData.AddCell(p10);
                Chunk c11 = new Chunk(("JMBG: ") + _clientJMBG, FontFactory.GetFont("Times New Roman"));
                c11.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                c11.Font.SetStyle(0);
                c11.Font.Size = 11;
                Phrase p11 = new Phrase();
                p11.Add(c11);
                clientData.AddCell(p11);
                Chunk c12 = new Chunk(("BPG: ") + _clientBPG, FontFactory.GetFont("Times New Roman"));
                c12.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                c12.Font.SetStyle(0);
                c12.Font.Size = 11;
                Phrase p12 = new Phrase();
                p12.Add(c12);
                clientData.AddCell(p12);
                Chunk c13 = new Chunk(("Postanski broj: ") + _clientZipCode, FontFactory.GetFont("Times New Roman"));
                c13.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                c13.Font.SetStyle(0);
                c13.Font.Size = 11;
                Phrase p13 = new Phrase();
                p13.Add(c13);
                clientData.AddCell(p13);
                Chunk c14 = new Chunk(("Telefon: ") + _clientPhone, FontFactory.GetFont("Times New Roman"));
                c14.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                c14.Font.SetStyle(0);
                c14.Font.Size = 11;
                Phrase p14 = new Phrase();
                p14.Add(c14);
                clientData.AddCell(p14);
                //////////////////////////////////////////////////////////////////////////////////////////////////
                Chunk c15 = new Chunk(" ", FontFactory.GetFont("Times New Roman"));
                c15.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                c15.Font.SetStyle(0);
                c15.Font.Size = 20;
                Phrase p15 = new Phrase();
                p15.Add(c15);
                total.AddCell(p15);
                Chunk c16 = new Chunk(" ", FontFactory.GetFont("Times New Roman"));
                c16.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                c16.Font.SetStyle(0);
                c16.Font.Size = 18;
                Phrase p16 = new Phrase();
                p16.Add(c16);
                total.AddCell(p16);
                Chunk c17 = new Chunk("UKUPNO: ", FontFactory.GetFont("Times New Roman"));
                c17.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                c17.Font.SetStyle(0);
                c17.Font.Size = 18;
                Phrase p17 = new Phrase();
                p17.Add(c17);
                total.AddCell(p17);
                Chunk c18 = new Chunk(finalPrice.ToString() + " RSD", FontFactory.GetFont("Times New Roman"));
                c18.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                c18.Font.SetStyle(0);
                c18.Font.Size = 18;
                Phrase p18 = new Phrase();
                p18.Add(c18);
                total.AddCell(p18);
                #endregion
                #region IMAGE SECTION
                pictureURL = "C:\\Users\\KORISNIK\\source\\repos\\Freshivoje\\Freshivoje\\Freshivoje\\Images\\1.png";
                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(pictureURL);
                logo.ScaleToFit(110.0f, 140.0f);
                logo.SpacingBefore = 20.0f;
                logo.SpacingAfter = 10.0f;
                logo.SetAbsolutePosition(70, 680);
                logo.Alignment = Element.ALIGN_CENTER;
                #endregion
                #region PDF
                folderPath = "D:\\PDF\\";
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                fileCount = Directory.GetFiles("D:\\PDF").Length;
                strFileName = (fileCount + 1) + "-2019" + ".pdf";
                invoiceNumber.AddCell("BROJ FAKTURE: TR" + ((fileCount + 1) + "-2019"));
                #endregion
                #region PAGE
                using (FileStream stream = new FileStream(folderPath + strFileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 70f);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(logo);
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
                    pdfDoc.Add(total);
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