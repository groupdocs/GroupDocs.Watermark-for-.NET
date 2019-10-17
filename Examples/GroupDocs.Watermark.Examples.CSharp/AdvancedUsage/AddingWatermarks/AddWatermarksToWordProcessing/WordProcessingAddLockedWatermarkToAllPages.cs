// <copyright company="Aspose Pty Ltd">
//   Copyright (C) 2011-2019 GroupDocs. All Rights Reserved.
// </copyright>

namespace GroupDocs.Watermark.Examples.CSharp.AdvancedUsage.AddingWatermarks.AddWatermarksToWordProcessing
{
    using Options.WordProcessing;
    using Watermarks;

    /// <summary>
    /// This example shows how to lock watermark in all pages.
    /// </summary>
    public static class WordProcessingAddLockedWatermarkToAllPages
    {
        public static void Run()
        {
            WordProcessingLoadOptions loadOptions = new WordProcessingLoadOptions();
            // Constants.InDocumentDocx is an absolute or relative path to your document. Ex: @"C:\Docs\document.docx"
            using (Watermarker watermarker = new Watermarker(Constants.InDocumentDocx, loadOptions))
            {
                TextWatermark watermark = new TextWatermark("Watermark text", new Font("Arial", 19));
                watermark.ForegroundColor = Color.Red;

                WordProcessingWatermarkPagesOptions options = new WordProcessingWatermarkPagesOptions();
                options.IsLocked = true;
                options.LockType = WordProcessingLockType.AllowOnlyFormFields;

                // To protect with password
                //options.Password = "7654321";

                watermarker.Add(watermark, options);

                watermarker.Save(Constants.OutDocumentDocx);
            }
        }
    }
}