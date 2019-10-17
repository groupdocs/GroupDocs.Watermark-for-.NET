// <copyright company="Aspose Pty Ltd">
//   Copyright (C) 2011-2019 GroupDocs. All Rights Reserved.
// </copyright>

namespace GroupDocs.Watermark.Examples.CSharp.AdvancedUsage.AddingWatermarks.AddingTextWatermarks
{
    using Common;
    using Watermarks;

    /// <summary>
    /// This example shows how to consider parent margins.
    /// </summary>
    public static class AddWatermarkWithParentMargin
    {
        public static void Run()
        {
            // Constants.InInputVsdx is an absolute or relative path to your document. Ex: @"C:\Docs\input.vsdx"
            using (Watermarker watermarker = new Watermarker(Constants.InInputVsdx))
            {
                TextWatermark watermark = new TextWatermark("Test watermark", new Font("Arial", 42));
                watermark.HorizontalAlignment = HorizontalAlignment.Right;
                watermark.VerticalAlignment = VerticalAlignment.Top;
                watermark.SizingType = SizingType.ScaleToParentDimensions;
                watermark.ScaleFactor = 1;
                watermark.RotateAngle = 45;
                watermark.ForegroundColor = Color.Red;
                watermark.BackgroundColor = Color.Aqua;

                // Add watermark considering parent margins
                watermark.ConsiderParentMargins = true;

                watermarker.Add(watermark);
                watermarker.Save(Constants.OutInputVsdx);
            }
        }
    }
}