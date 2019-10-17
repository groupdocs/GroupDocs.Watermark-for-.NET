// <copyright company="Aspose Pty Ltd">
//   Copyright (C) 2011-2019 GroupDocs. All Rights Reserved.
// </copyright>

namespace GroupDocs.Watermark.Examples.CSharp.AdvancedUsage.AddingWatermarks.AddWatermarksToPdf
{
    using Common;
    using Contents.Pdf;
    using Options.Pdf;
    using Watermarks;

    /// <summary>
    /// This example shows how to add a watermark to image annotations in PDF documents.
    /// </summary>
    public static class PdfAddWatermarkToAnnotationImages
    {
        public static void Run()
        {
            PdfLoadOptions loadOptions = new PdfLoadOptions();
            // Constants.InDocumentPdf is an absolute or relative path to your document. Ex: @"C:\Docs\document.pdf"
            using (Watermarker watermarker = new Watermarker(Constants.InDocumentPdf, loadOptions))
            {
                PdfContent pdfContent = watermarker.GetContent<PdfContent>();

                // Initialize image or text watermark
                TextWatermark watermark = new TextWatermark("Protected image", new Font("Arial", 8));
                watermark.HorizontalAlignment = HorizontalAlignment.Center;
                watermark.VerticalAlignment = VerticalAlignment.Center;
                watermark.RotateAngle = 45;
                watermark.SizingType = SizingType.ScaleToParentDimensions;
                watermark.ScaleFactor = 1;

                foreach (PdfPage page in pdfContent.Pages)
                {
                    foreach (PdfAnnotation annotation in page.Annotations)
                    {
                        if (annotation.Image != null)
                        {
                            // Add watermark to the image
                            annotation.Image.Add(watermark);
                        }
                    }
                }

                watermarker.Save(Constants.OutDocumentPdf);
            }
        }
    }
}