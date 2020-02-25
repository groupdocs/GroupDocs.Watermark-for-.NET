// <copyright company="Aspose Pty Ltd">
//   Copyright (C) 2011-2020 GroupDocs. All Rights Reserved.
// </copyright>

namespace GroupDocs.Watermark.Examples.CSharp.AdvancedUsage.AddingWatermarks.AddWatermarksToSpreadsheets
{
    using System.IO;
    using Contents.Spreadsheet;
    using Options.Spreadsheet;

    /// <summary>
    /// This examples shows how to replace the image of the particular shapes in an Excel Worksheet.
    /// </summary>
    public static class SpreadsheetReplaceImageOfParticularShapes
    {
        public static void Run()
        {
            SpreadsheetLoadOptions loadOptions = new SpreadsheetLoadOptions();
            // Constants.InSpreadsheetXlsx is an absolute or relative path to your document. Ex: @"C:\Docs\spreadsheet.xlsx"
            using (Watermarker watermarker = new Watermarker(Constants.InSpreadsheetXlsx, loadOptions))
            {
                SpreadsheetContent content = watermarker.GetContent<SpreadsheetContent>();
                foreach (SpreadsheetShape shape in content.Worksheets[0].Shapes)
                {
                    if (shape.Image != null)
                    {
                        shape.Image = new SpreadsheetWatermarkableImage(File.ReadAllBytes(Constants.TestPng));
                    }
                }

                watermarker.Save(Constants.OutSpreadsheetXlsx);
            }
        }
    }
}