// <copyright company="Aspose Pty Ltd">
//   Copyright (C) 2011-2019 GroupDocs. All Rights Reserved.
// </copyright>

namespace GroupDocs.Watermark.Examples.CSharp.AdvancedUsage.AddingWatermarks.AddWatermarksToWordProcessing
{
    using Contents;
    using Options.WordProcessing;
    using Watermarks;

    /// <summary>
    /// This example shows how to apply some text effects to the shape watermarks.
    /// </summary>
    public static class WordProcessingAddWatermarkWithTextEffects
    {
        public static void Run()
        {
            WordProcessingLoadOptions loadOptions = new WordProcessingLoadOptions();
            // Constants.InDocumentDocx is an absolute or relative path to your document. Ex: @"C:\Docs\document.docx"
            using (Watermarker watermarker = new Watermarker(Constants.InDocumentDocx, loadOptions))
            {
                TextWatermark watermark = new TextWatermark("Test watermark", new Font("Arial", 19));

                WordProcessingTextEffects effects = new WordProcessingTextEffects();
                effects.LineFormat.Enabled = true;
                effects.LineFormat.Color = Color.Red;
                effects.LineFormat.DashStyle = OfficeDashStyle.DashDotDot;
                effects.LineFormat.LineStyle = OfficeLineStyle.Triple;
                effects.LineFormat.Weight = 1;

                WordProcessingWatermarkSectionOptions options = new WordProcessingWatermarkSectionOptions();
                options.Effects = effects;

                watermarker.Add(watermark, options);
                watermarker.Save(Constants.OutDocumentDocx);
            }
        }
    }
}