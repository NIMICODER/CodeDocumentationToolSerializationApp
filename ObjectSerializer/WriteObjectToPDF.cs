using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Linq;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace ObjectSerializer
{
    public static class WriteObjectToPDF
    {

        public static void SerializeToPdfFormat(string textContent, string fileName)
        {

            // Create a new PDF document
            Document document = new Document();

            // Set the page size and margins
            document.SetPageSize(PageSize.A4);
            document.SetMargins(50, 50, 50, 50);

            // Create a new PdfWriter object
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(fileName, FileMode.Create));

            // Open the document for writing
            document.Open();

            // Create a new font and add it to the document
            Font font = new Font(Font.FontFamily.TIMES_ROMAN, 12, Font.NORMAL);
            document.Add(new Paragraph(textContent, font));

            // Close the document
            document.Close();
        }
        public static void SerializeToPdfFormatB()
        {
            //MyClass obj = new MyClass() { Name = "John", Age = 30 };

            // Serialize object to PDF
            using (FileStream stream = new FileStream("object.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document();
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                //pdfDoc.Add(new Paragraph(string.Format("Name: {0}\nAge: {1}", obj.Name, obj.Age)));
                pdfDoc.Close();
            }
        }

       
    }
}
