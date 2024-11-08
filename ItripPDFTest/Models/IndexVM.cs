using System;
using System.Collections.Generic;
using System.Drawing;
using iTextSharp.text.pdf;
using PdfiumViewer;

namespace ItripPDFTest.Models
{
    public class IndexVM
    {

        public static Object OpenPdf()
        {
            //string pdfFilePath = @"~/Content/Itrip/GeneralInfo.pdf";

            System.Diagnostics.Process.Start(@"https://acrobatservices.adobe.com/view-sdk-demo/PDFs/Bodea%20Brochure.pdf");
            return (object)default;
        }


        //public void ReadPdf()
        //{
        //    string pdfFilePath = "GeneralInfo.pdf";

        //    // List to store pages as Bitmap images
        //    List<Bitmap> pdfPages = new List<Bitmap>();

        //    // Open the PDF file using PdfiumViewer
        //    using (var pdfDocument = PdfDocument.Load(pdfFilePath))
        //    {
        //        int pageCount = pdfDocument.PageCount;

        //        // Loop through all pages in the PDF
        //        for (int pageIndex = 0; pageIndex < pageCount; pageIndex++)
        //        {
        //            // Render page to image
        //            Bitmap pageImage = pdfDocument.Render(pageIndex, 300, 300, true);

        //            // Add the page image to the list
        //            pdfPages.Add(pageImage);

        //            Console.WriteLine($"Page {pageIndex + 1} rendered successfully.");
        //        }
        //    }

        //    // Optionally, save pages to files or perform further processing
        //    Console.WriteLine($"Total pages processed: {pdfPages.Count}");
        //}
    }
}
