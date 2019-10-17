// <copyright company="Aspose Pty Ltd">
//   Copyright (C) 2011-2019 GroupDocs. All Rights Reserved.
// </copyright>

namespace GroupDocs.Watermark.Examples.CSharp.AdvancedUsage.AddingWatermarks.AddWatermarksToSpreadsheets
{
    using Common;
    using Options.Spreadsheet;
    using Watermarks;

    /// <summary>
    /// This example shows how to add watermark to worksheet's header or footer.
    /// </summary>
    public static class SpreadsheetAddImageWatermarkIntoHeaderFooter
    {
        public static void Run()
        {
            SpreadsheetLoadOptions loadOptions = new SpreadsheetLoadOptions();
            // Constants.InSpreadsheetXlsx is an absolute or relative path to your document. Ex: @"C:\Docs\spreadsheet.xlsx"
            using (Watermarker watermarker = new Watermarker(Constants.InSpreadsheetXlsx, loadOptions))
            {
                using (ImageWatermark watermark = new ImageWatermark(Constants.LogoPng))
                {
                    watermark.VerticalAlignment = VerticalAlignment.Top;
                    watermark.HorizontalAlignment = HorizontalAlignment.Center;
                    watermark.SizingType = SizingType.ScaleToParentDimensions;
                    watermark.ScaleFactor = 1;

                    SpreadsheetWatermarkHeaderFooterOptions options = new SpreadsheetWatermarkHeaderFooterOptions();
                    options.WorksheetIndex = 0;

                    watermarker.Add(watermark, options);
                }

                watermarker.Save(Constants.OutSpreadsheetXlsx);
            }
        }
    }
}