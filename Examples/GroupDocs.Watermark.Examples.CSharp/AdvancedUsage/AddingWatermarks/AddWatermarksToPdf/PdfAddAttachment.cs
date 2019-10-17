// <copyright company="Aspose Pty Ltd">
//   Copyright (C) 2011-2019 GroupDocs. All Rights Reserved.
// </copyright>

namespace GroupDocs.Watermark.Examples.CSharp.AdvancedUsage.AddingWatermarks.AddWatermarksToPdf
{
    using System.IO;
    using Contents.Pdf;
    using Options.Pdf;

    /// <summary>
    /// This example shows how to add attachments to the PDF document.
    /// </summary>
    public static class PdfAddAttachment
    {
        public static void Run()
        {
            PdfLoadOptions loadOptions = new PdfLoadOptions();
            // Constants.InDocumentPdf is an absolute or relative path to your document. Ex: @"C:\Docs\document.pdf"
            using (Watermarker watermarker = new Watermarker(Constants.InDocumentPdf, loadOptions))
            {
                PdfContent pdfContent = watermarker.GetContent<PdfContent>();

                // Add the attachment
                pdfContent.Attachments.Add(File.ReadAllBytes(Constants.InSampleDocx), "sample doc", "sample doc as attachment");

                // Save changes
                watermarker.Save(Constants.OutDocumentPdf);
            }
        }
    }
}