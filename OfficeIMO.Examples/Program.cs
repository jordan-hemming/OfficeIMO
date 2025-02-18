﻿using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DocumentFormat.OpenXml.Packaging;
using OfficeIMO.Examples.Excel;
using OfficeIMO.Examples.Word;
using OfficeIMO.Word;
using Color = SixLabors.ImageSharp.Color;

namespace OfficeIMO.Examples {
    internal static class Program {
        private static void Setup(string path) {
            if (!Directory.Exists(path)) {
                Directory.CreateDirectory(path);
            } else {
                // Directory.Delete(path, true);
                // Directory.CreateDirectory(path);
            }
        }

        static void Main(string[] args) {
            //string folderPath = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "documents");
            string templatesPath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "Documents");
            string folderPath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "Documents");
            Setup(folderPath);

            //BasicDocument.Example_BasicEmptyWord(folderPath, false);
            //BasicDocument.Example_BasicWord(folderPath, true);
            //BasicDocument.Example_BasicWord2(folderPath, true);

            //BasicDocument.Example_BasicDocument(folderPath, true);
            //BasicDocument.Example_BasicDocumentSaveAs1(folderPath, true);
            //BasicDocument.Example_BasicDocumentSaveAs2(folderPath, true);
            //BasicDocument.Example_BasicDocumentSaveAs3(folderPath, true);
            //BasicDocument.Example_BasicDocumentWithoutUsing(folderPath, true);

            //Lists.Example_BasicLists(folderPath, true);
            //Lists.Example_BasicLists6(folderPath, true);
            //Lists.Example_BasicLists2(folderPath, false);
            //Lists.Example_BasicLists3(folderPath, false);
            //Lists.Example_BasicLists4(folderPath, false);
            //Lists.Example_BasicLists2Load(folderPath, false);
            //Tables.Example_BasicTables1(folderPath, false);
            //Tables.Example_BasicTablesLoad1(folderPath, false);
            //Tables.Example_AllTables(folderPath, false);
            //Tables.Example_Tables(folderPath, false);


            //PageSettings.Example_BasicSettings(folderPath, true);


            //Console.WriteLine("[*] Creating standard document with multiple paragraphs, with some formatting");
            //filePath = System.IO.Path.Combine(folderPath, "AdvancedParagraphs.docx");
            //Example_MultipleParagraphsViaDifferentWays(filePath, false);

            //Console.WriteLine("[*] Creating standard document with some Images");
            //filePath = System.IO.Path.Combine(folderPath, "BasicDocumentWithImages.docx");
            //Example_AddingImages(filePath, true);



            //Console.WriteLine("[*] Read Basic Word with Images");
            //Example_ReadWordWithImages();

            //Console.WriteLine("[*] Creating standard document with page breaks and removing them");
            //filePath = System.IO.Path.Combine(folderPath, "Basic Document with some page breaks.docx");
            //Example_PageBreaks(filePath, true);

            //Console.WriteLine("[*] Creating standard document with page breaks and removing them");
            //filePath = System.IO.Path.Combine(folderPath, "Basic Document with some page breaks1.docx");
            //Example_PageBreaks1(filePath, true);

            //Console.WriteLine("[*] Creating standard document with sections");
            //filePath = System.IO.Path.Combine(folderPath, "Basic Document with some sections.docx");
            //Example_BasicSections(filePath, true);

            //Console.WriteLine("[*] Creating standard document with Sections");
            //filePath = System.IO.Path.Combine(folderPath, "Basic Document with Sections.docx");
            //Example_BasicWordWithSections(filePath, true);

            //Console.WriteLine("[*] Creating standard document with Headers and Footers");
            //filePath = System.IO.Path.Combine(folderPath, "Basic Document with Headers and Footers.docx");
            //Example_BasicWordWithHeaderAndFooterWithoutSections(filePath, false);

            //Console.WriteLine("[*] Creating standard document with Page Orientation");
            //filePath = System.IO.Path.Combine(folderPath, "Basic Document with PageOrientationChange.docx");
            //Example_PageOrientation(filePath, true);

            //Console.WriteLine("[*] Creating standard document with Headers and Footers");
            //filePath = System.IO.Path.Combine(folderPath, "Basic Document with Headers and Footers Default.docx");
            //Example_BasicWordWithHeaderAndFooter0(filePath, true);

            //Console.WriteLine("[*] Creating standard document with Headers and Footers including Sections");
            //filePath = System.IO.Path.Combine(folderPath, "Basic Document with Headers and Footers.docx");
            //Example_BasicWordWithHeaderAndFooter(filePath, true);


            //Console.WriteLine("[*] Creating standard document with paragraphs");
            //filePath = System.IO.Path.Combine(folderPath, "Basic Document with some paragraphs.docx");
            //Example_BasicParagraphs(filePath, true);


            //Console.WriteLine("[*] Creating standard document with Paragraph Styles");
            //filePath = System.IO.Path.Combine(folderPath, "Document with Paragraph Styles.docx");
            //Example_BasicParagraphStyles(filePath, false);

            //Console.WriteLine("[*] Creating standard document with TOC - 1");
            //filePath = System.IO.Path.Combine(folderPath, "Document with TOC1.docx");
            //Example_BasicTOC1(filePath, false);

            //Console.WriteLine("[*] Creating standard document with TOC - 2");
            //filePath = System.IO.Path.Combine(folderPath, "Document with TOC2.docx");
            //Example_BasicTOC2(filePath, false);


            //Console.WriteLine("[*] Creating standard document with Page Numbers 1");
            //filePath = System.IO.Path.Combine(folderPath, "Document with PageNumbers.docx");
            //Example_PageNumbers1(filePath, true);


            //Console.WriteLine("[*] Creating standard document with sections 2");
            //filePath = System.IO.Path.Combine(folderPath, "Basic Document with some sections 1.docx");
            //Example_BasicSections2(filePath, true);


            //Console.WriteLine("[*] Creating standard document with sections 3 and columns");
            //filePath = System.IO.Path.Combine(folderPath, "Basic Document with some sections 2.docx");
            //Example_BasicSections3WithColumns(filePath, true);

            //Console.WriteLine("[*] Creating standard document with sections 4");
            //filePath = System.IO.Path.Combine(folderPath, "Basic Document with some sections 3.docx");
            //Example_SectionsWithParagraphs(filePath, true);


            //Console.WriteLine("[*] Creating standard document with sections and headers / footers");
            //filePath = System.IO.Path.Combine(folderPath, "Basic Document with some sections and headers footers testing.docx");
            //Example_SectionsWithHeadersDefault(filePath, true);

            //Console.WriteLine("[*] Creating standard document with sections and headers / footers");
            //filePath = System.IO.Path.Combine(folderPath, "Basic Document with some sections and headers footers.docx");
            //Example_SectionsWithHeaders(filePath, true);


            //Console.WriteLine("[*] Creating standard document with comments");
            //filePath = System.IO.Path.Combine(folderPath, "Basic Document with comments.docx");
            //Example_PlayingWithComments(filePath, true);

            //Console.WriteLine("[*] Excel - Creating standard Excel Document 1");
            //filePath = System.IO.Path.Combine(folderPath, "Basic Excel 1.xlsx");
            //BasicExcelFunctionality.BasicExcel_Example1(filePath, true);


            //Console.WriteLine("[*] Excel - Creating standard Excel Document 2");
            //filePath = System.IO.Path.Combine(folderPath, "Basic Excel 2.xlsx");
            //BasicExcelFunctionality.BasicExcel_Example2(filePath, true);

            //Console.WriteLine("[*] Excel - Reading standard Excel Document 1");
            //BasicExcelFunctionality.BasicExcel_Example3(true);


            //Console.WriteLine("[*] Creating standard document with margins and sizes");
            //filePath = System.IO.Path.Combine(folderPath, "Basic Document with page margins.docx");
            //Example_BasicWordMarginsSizes(filePath, true);

            //Console.WriteLine("[*] Creating standard document with watermark");
            //filePath = System.IO.Path.Combine(folderPath, "Basic Document with watermark.docx");
            //Example_BasicWordWatermark(filePath, true);


            //Console.WriteLine("[*] Creating standard document with page borders 1");
            //filePath = System.IO.Path.Combine(folderPath, "Basic Document with page borders 1.docx");
            //Example_BasicPageBorders1(filePath, true);

            //Console.WriteLine("[*] Creating standard document with page borders 2");
            //filePath = System.IO.Path.Combine(folderPath, "Basic Document with page borders 2.docx");
            //Example_BasicPageBorders2(filePath, true);


            //Console.WriteLine("[*] Creating standard document with bookmarks");
            //filePath = System.IO.Path.Combine(folderPath, "BasicDocumentWithBookmarks.docx");
            //Example_BasicWordWithBookmarks(filePath, true);


            //Console.WriteLine("[*] Creating standard document with hyperlinks");
            //filePath = System.IO.Path.Combine(folderPath, "BasicDocumentHyperlinks.docx");
            //Example_BasicWordWithHyperLinks(filePath, true);

            //Console.WriteLine("[*] Creating standard document with Fields");
            //filePath = System.IO.Path.Combine(folderPath, "Basic Document with Fields.docx");
            //Example_AddingFields(filePath, true);

            //Console.WriteLine("[*] Creating standard document with Watermark 2");
            //filePath = System.IO.Path.Combine(folderPath, "Basic Document with Watermark 2.docx");
            //Example_BasicWordWatermark2(filePath, true);

            //CoverPages.Example_AddingCoverPage(folderPath, true);
            CoverPages.Example_AddingCoverPage2(folderPath, true);

            //LoadDocuments.LoadWordDocument_Sample1(true);
            //LoadDocuments.LoadWordDocument_Sample2(true);
            //LoadDocuments.LoadWordDocument_Sample3(true);

            //CustomAndBuiltinProperties.Example_BasicDocumentProperties(folderPath, true);
            //CustomAndBuiltinProperties.Example_ReadWord(true);
            //CustomAndBuiltinProperties.Example_BasicCustomProperties(folderPath, true);
            //CustomAndBuiltinProperties.Example_ValidateDocument(folderPath);
            //CustomAndBuiltinProperties.Example_ValidateDocument_BeforeSave();
            //CustomAndBuiltinProperties.Example_LoadDocumentWithProperties(true);
            //CustomAndBuiltinProperties.Example_Load(true);

            //HyperLinks.EasyExample(folderPath, true);

            //HeadersAndFooters.Sections1(folderPath, true);
        }

        private static void Example_BasicWordWatermark2(string filePath, bool openWord) {
            using (WordDocument document = WordDocument.Create(filePath)) {
                document.AddParagraph("Section 0");
                document.AddHeadersAndFooters();
                document.Sections[0].SetMargins(WordMargin.Normal);

                Console.WriteLine(document.Sections[0].Margins.Left.Value);
                Console.WriteLine(document.Sections[0].Margins.Right.Value);

                Console.WriteLine(document.Sections[0].Margins.Type);

                document.Sections[0].Margins.Type = WordMargin.Wide;


                Console.WriteLine(document.Sections[0].Margins.Type);

                document.Sections[0].AddWatermark(WordWatermarkStyle.Text, "Watermark");

                document.AddSection();
                document.Sections[1].AddHeadersAndFooters();
                document.Sections[1].Margins.Type = WordMargin.Narrow;

                Console.WriteLine("----");
                document.Sections[1].AddWatermark(WordWatermarkStyle.Text, "Draft");

                Console.WriteLine(document.Sections[0].Margins.Left.Value);
                Console.WriteLine(document.Sections[0].Margins.Right.Value);

                Console.WriteLine(document.Sections[1].Margins.Left.Value);
                Console.WriteLine(document.Sections[1].Margins.Right.Value);

                Console.WriteLine(document.Sections[1].Margins.Type);


                document.Settings.SetBackgroundColor(Color.Azure);

                document.Save(openWord);
            }
        }



        private static void Example_AddingFields(string filePath, bool openWord) {
            using (WordDocument document = WordDocument.Create(filePath)) {
                document.BuiltinDocumentProperties.Title = "This is my title";
                document.AddParagraph("This is my test");

                document.AddParagraph("This is page number ").AddField(WordFieldType.Page);

                document.AddParagraph("Our title is ").AddField(WordFieldType.Title, WordFieldFormat.Caps);

                var para = document.AddParagraph("Our author is ").AddField(WordFieldType.Author);
                Console.WriteLine("----");
                Console.WriteLine(document.Fields[0].FieldFormat);
                Console.WriteLine(document.Fields[0].FieldType);
                Console.WriteLine(document.Fields[0].Field);
                Console.WriteLine("----");
                Console.WriteLine(document.Fields[1].FieldFormat);
                Console.WriteLine(document.Fields[1].FieldType);
                Console.WriteLine(document.Fields[1].Field);
                Console.WriteLine("----");
                Console.WriteLine(document.Fields[2].FieldFormat);
                Console.WriteLine(document.Fields[2].FieldType);
                Console.WriteLine(document.Fields[2].Field);
                Console.WriteLine("----");
                Console.WriteLine(document.Fields.Count);
                Console.WriteLine("----");
                document.Fields[1].Remove();
                Console.WriteLine(document.Fields.Count);
                Console.WriteLine("----");
                // document.Settings.UpdateFieldsOnOpen = true;
                document.Save(openWord);
            }
        }

        private static void Example_BasicWordWithHyperLinks(string filePath, bool openWord) {
            using (WordDocument document = WordDocument.Create(filePath)) {
                document.AddParagraph("Test 1");

                document.AddParagraph("Hello users! Please visit ").AddHyperLink("bookmark below", "TestBookmark", true, "This is link to bookmark below shown within Tooltip");
                Console.WriteLine(document.HyperLinks.Count);
                Console.WriteLine(document.Sections[0].ParagraphsHyperLinks.Count);
                Console.WriteLine(document.ParagraphsHyperLinks.Count);
                Console.WriteLine(document.Sections[0].HyperLinks.Count);
                document.AddParagraph("Test HYPERLINK ").AddHyperLink(" to website?", new Uri("https://evotec.xyz"));

                document.AddParagraph("Test Email Address ").AddHyperLink("Przemysław Klys", new Uri("mailto:kontakt@evotec.pl?subject=Test Subject"));

                document.AddPageBreak();
                document.AddPageBreak();

                document.AddParagraph("Test HYPERLINK ").AddHyperLink(" to website?", new Uri("https://evotec.xyz"));
                document.AddParagraph("Test HYPERLINK ").AddHyperLink(" to website?", new Uri("https://evotec.pl"));

                //document.HyperLinks.Last().Remove();

                document.AddParagraph("Test 2").AddBookmark("TestBookmark");


                document.AddParagraph("Hello users! Please visit ").AddHyperLink("bookmark below", "TestBookmark", true, "This is link to bookmark below shown within Tooltip");


                document.HyperLinks.Last().Uri = new Uri("https://evotec.pl");
                document.HyperLinks.Last().Anchor = "";

                Console.WriteLine(document.HyperLinks.Count);

                document.Save(openWord);
            }
        }

        private static void Example_BasicWordWithBookmarks(string filePath, bool openWord) {
            using (WordDocument document = WordDocument.Create(filePath)) {
                document.AddParagraph("Test 1").AddBookmark("Start");

                var paragraph = document.AddParagraph("This is text");
                foreach (string text in new List<string>() { "text1", "text2", "text3" }) {
                    paragraph = paragraph.AddText(text);
                    paragraph.Bold = true;
                    paragraph.Italic = true;
                    paragraph.Underline = UnderlineValues.DashDotDotHeavy;
                }

                document.AddPageBreak();
                document.AddPageBreak();

                document.AddParagraph("Test 2").AddBookmark("Middle1");

                paragraph.AddText("OK baby");

                document.AddPageBreak();
                document.AddPageBreak();

                document.AddParagraph("Test 3").AddBookmark("Middle0");

                document.AddPageBreak();
                document.AddPageBreak();

                document.AddParagraph("Test 4").AddBookmark("EndOfDocument");

                document.Bookmarks[2].Remove();

                document.AddPageBreak();
                document.AddPageBreak();

                document.AddParagraph("Test 5");

                document.PageBreaks[7].Remove(includingParagraph: false);
                document.PageBreaks[6].Remove();

                Console.WriteLine(document.DocumentIsValid);
                Console.WriteLine(document.DocumentValidationErrors.Count);

                document.Save(openWord);
            }
        }

        private static void Example_MultipleParagraphsViaDifferentWays(string filePath, bool openWord) {
            using (WordDocument document = WordDocument.Create()) {
                var paragraph = document.AddParagraph("This paragraph starts with some text");
                paragraph.Bold = true;
                paragraph.Text = "0th This paragraph started with some other text and was overwritten and made bold.";

                paragraph = document.AddParagraph("1st Test Second Paragraph");

                paragraph = document.AddParagraph();
                paragraph.Text = "2nd Test Third Paragraph, ";
                paragraph.Underline = UnderlineValues.None;
                var paragraph2 = paragraph.AddText("3rd continuing?");
                paragraph2.Underline = UnderlineValues.Double;
                paragraph2.Bold = true;
                paragraph2.Spacing = 200;

                document.AddParagraph().SetText("4th Fourth paragraph with text").Bold = true;

                WordParagraph paragraph1 = new WordParagraph() {
                    Text = "Fifth paragraph",
                    Italic = true,
                    Bold = true
                };
                document.AddParagraph(paragraph1);

                paragraph = document.AddParagraph("5th Test gmarmmar, this shouldnt show up as baddly written.");
                paragraph.DoNotCheckSpellingOrGrammar = true;
                paragraph.CapsStyle = CapsStyle.Caps;

                paragraph = document.AddParagraph("6th Test gmarmmar, this should show up as baddly written.");
                paragraph.DoNotCheckSpellingOrGrammar = false;
                paragraph.CapsStyle = CapsStyle.SmallCaps;

                paragraph = document.AddParagraph("7th Highlight me?");
                paragraph.Highlight = HighlightColorValues.Yellow;
                paragraph.FontSize = 15;
                paragraph.ParagraphAlignment = JustificationValues.Center;


                paragraph = document.AddParagraph("8th This text should be colored.");
                paragraph.Bold = true;
                paragraph.Color = "4F48E2";
                paragraph.IndentationAfter = 1400;


                paragraph = document.AddParagraph("This is very long line that we will use to show indentation that will work across multiple lines and more and more and even more than that. One, two, three, don't worry baby.");
                paragraph.Bold = true;
                paragraph.Color = "#FF0000";
                paragraph.IndentationBefore = 720;
                paragraph.IndentationFirstLine = 1400;


                paragraph = document.AddParagraph("9th This text should be colored and Arial.");
                paragraph.Bold = true;
                paragraph.Color = "4F48E2";
                paragraph.FontFamily = "Arial";
                paragraph.VerticalCharacterAlignmentOnLine = VerticalTextAlignmentValues.Bottom;

                paragraph = document.AddParagraph("10th This text should be colored and Tahoma.");
                paragraph.Bold = true;
                paragraph.Color = "4F48E2";
                paragraph.FontFamily = "Tahoma";
                paragraph.FontSize = 20;
                paragraph.LineSpacingBefore = 300;

                paragraph = document.AddParagraph("12th This text should be colored and Tahoma and text direction changed");
                paragraph.Bold = true;
                paragraph.Color = "4F48E2";
                paragraph.FontFamily = "Tahoma";
                paragraph.FontSize = 10;
                paragraph.TextDirection = TextDirectionValues.TopToBottomRightToLeftRotated;

                paragraph = document.AddParagraph("Spacing Test 1");
                paragraph.Bold = true;
                paragraph.Color = "4F48E2";
                paragraph.FontFamily = "Tahoma";
                paragraph.LineSpacingAfter = 720;

                paragraph = document.AddParagraph("Spacing Test 2");
                paragraph.Bold = true;
                paragraph.Color = "4F48E2";
                paragraph.FontFamily = "Tahoma";


                paragraph = document.AddParagraph("Spacing Test 3");
                paragraph.Bold = true;
                paragraph.Color = "4F48E2";
                paragraph.FontFamily = "Tahoma";
                paragraph.ParagraphAlignment = JustificationValues.Center;
                paragraph.LineSpacing = 1500;

                Console.WriteLine("Found paragraphs in document: " + document.Paragraphs.Count);

                document.Save(filePath, openWord);
            }
        }

        private static void Example_AddingImages(string filePath, bool openWord) {
            //string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            //string imagePaths = System.IO.Path.Combine(baseDirectory, "Images");
            string imagePaths = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "Images");

            WordDocument document = WordDocument.Create(filePath);
            document.BuiltinDocumentProperties.Title = "This is sparta";
            document.BuiltinDocumentProperties.Creator = "Przemek";

            var paragraph = document.AddParagraph("This paragraph starts with some text");
            paragraph.Text = "0th This paragraph started with some other text and was overwritten and made bold.";

            // lets add image to paragraph
            paragraph.AddImage(System.IO.Path.Combine(imagePaths, "PrzemyslawKlysAndKulkozaurr.jpg"), 22, 22);
            //paragraph.Image.WrapText = true; // WrapSideValues.Both;

            var paragraph5 = paragraph.AddText("and more text");
            paragraph5.Bold = true;


            document.AddParagraph("This adds another picture with 500x500");

            var filePathImage = System.IO.Path.Combine(imagePaths, "Kulek.jpg");
            WordParagraph paragraph2 = document.AddParagraph();
            paragraph2.AddImage(filePathImage, 500, 500);
            //paragraph2.Image.BlackWiteMode = BlackWhiteModeValues.GrayWhite;
            paragraph2.Image.Rotation = 180;
            paragraph2.Image.Shape = ShapeTypeValues.ActionButtonMovie;


            document.AddParagraph("This adds another picture with 100x100");

            WordParagraph paragraph3 = document.AddParagraph();
            paragraph3.AddImage(filePathImage, 100, 100);

            // we add paragraph with an image
            WordParagraph paragraph4 = document.AddParagraph();
            paragraph4.AddImage(filePathImage);

            // we can get the height of the image from paragraph
            Console.WriteLine("This document has image, which has height of: " + paragraph4.Image.Height + " pixels (I think) ;-)");

            // we can also overwrite height later on
            paragraph4.Image.Height = 50;
            paragraph4.Image.Width = 50;
            // this doesn't work
            paragraph4.Image.HorizontalFlip = true;

            // or we can get any image and overwrite it's size
            document.Images[0].Height = 200;
            document.Images[0].Width = 200;

            string fileToSave = System.IO.Path.Combine(imagePaths, "OutputPrzemyslawKlysAndKulkozaurr.jpg");
            document.Images[0].SaveToFile(fileToSave);

            document.Save(true);
        }



        private static void Example_ReadWordWithImages() {
            string outputPath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "Documents");
            string documentPaths = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "Templates");

            WordDocument document = WordDocument.Load(System.IO.Path.Combine(documentPaths, "BasicDocumentWithImages.docx"), true);
            Console.WriteLine("+ Document paragraphs: " + document.Paragraphs.Count);
            Console.WriteLine("+ Document images: " + document.Images.Count);

            document.Images[0].SaveToFile(System.IO.Path.Combine(outputPath, "random.jpg"));
        }

        private static void Example_PageBreaks(string filePath, bool openWord) {
            using (WordDocument document = WordDocument.Create(filePath)) {
                document.BuiltinDocumentProperties.Title = "This is my title";
                document.BuiltinDocumentProperties.Creator = "Przemysław Kłys";
                document.BuiltinDocumentProperties.Keywords = "word, docx, test";

                var paragraph = document.AddParagraph("Test 1");

                //paragraph = new WordParagraph(document);
                //WordSection section = new WordSection(document, paragraph);


                //document._document.Body.Append(PageBreakParagraph);
                //document._document.Body.InsertBefore(PageBreakParagraph, paragraph._paragraph);

                document.AddPageBreak();

                paragraph.Text = "Test 2";

                paragraph = document.AddParagraph("Test 2");

                // Now lets remove paragraph with page break
                document.Paragraphs[1].Remove();

                // Now lets remove 1st paragraph
                document.Paragraphs[0].Remove();

                document.AddPageBreak();

                document.AddParagraph().Text = "Some text on next page";

                var paragraph1 = document.AddParagraph("Test").AddText("Test2");
                paragraph1.Color = SixLabors.ImageSharp.Color.Red.ToHexColor();
                paragraph1.AddText("Test3");

                paragraph = document.AddParagraph("Some paragraph");
                paragraph.Bold = true;
                paragraph = paragraph.AddText(" continue?");
                paragraph.Underline = UnderlineValues.DashLong;

                document.AddPageBreak();

                paragraph = document.AddParagraph("Basic paragraph");
                paragraph.ParagraphAlignment = JustificationValues.Center;
                paragraph.Color = SixLabors.ImageSharp.Color.Red.ToHexColor();

                paragraph = document.AddParagraph("2nd paragraph");
                paragraph.Bold = true;
                paragraph = paragraph.AddText(" continue?");
                paragraph.Underline = UnderlineValues.DashLong;
                paragraph = paragraph.AddText(" More text");
                paragraph.Color = SixLabors.ImageSharp.Color.CornflowerBlue.ToHexColor();

                // remove last paragraph
                document.Paragraphs.Last().Remove();

                paragraph = document.AddParagraph("2nd paragraph");
                paragraph.Bold = true;
                paragraph = paragraph.AddText(" continue?");
                paragraph.Underline = UnderlineValues.DashLong;
                paragraph = paragraph.AddText(" More text");
                paragraph.Color = SixLabors.ImageSharp.Color.CornflowerBlue.ToHexColor();

                // remove paragraph
                int countParagraphs = document.Paragraphs.Count;
                document.Paragraphs[countParagraphs - 2].Remove();

                // remove first page break
                document.PageBreaks[0].Remove(true);

                document.Save(openWord);
            }
        }

        private static void Example_PageBreaks1(string filePath, bool openWord) {
            using (WordDocument document = WordDocument.Create(filePath)) {
                var paragraph = document.AddParagraph("Test 1");
                paragraph.Text = "Test 2";

                document.AddPageBreak();

                document.AddPageBreak();

                var paragraph1 = document.AddParagraph("Test 1");
                paragraph1.Text = "Test 3";


                document.Save(openWord);
            }
        }

        private static void Example_BasicWordWithHeaderAndFooter0(string filePath, bool openWord) {
            using (WordDocument document = WordDocument.Create(filePath)) {
                document.AddHeadersAndFooters();

                document.Header.Default.AddParagraph().SetColor(Color.Red).SetText("Test Header");

                document.Footer.Default.AddParagraph().SetColor(Color.Blue).SetText("Test Footer");

                Console.WriteLine("Header Default Count: " + document.Header.Default.Paragraphs.Count);
                Console.WriteLine("Header Even Count: " + document.Header.Even.Paragraphs.Count);
                Console.WriteLine("Header First Count: " + document.Header.First.Paragraphs.Count);

                Console.WriteLine("Header text: " + document.Header.Default.Paragraphs[0].Text);

                Console.WriteLine("Footer Default Count: " + document.Footer.Default.Paragraphs.Count);
                Console.WriteLine("Footer Even Count: " + document.Footer.Even.Paragraphs.Count);
                Console.WriteLine("Footer First Count: " + document.Footer.First.Paragraphs.Count);

                Console.WriteLine("Footer text: " + document.Footer.Default.Paragraphs[0].Text);

                document.Save();
            }

            using (WordDocument document = WordDocument.Load(filePath)) {
                Console.WriteLine("Header Default Count: " + document.Header.Default.Paragraphs.Count);
                Console.WriteLine("Header Even Count: " + document.Header.Even.Paragraphs.Count);
                Console.WriteLine("Header First Count: " + document.Header.First.Paragraphs.Count);

                Console.WriteLine("Header text: " + document.Header.Default.Paragraphs[0].Text);

                Console.WriteLine("Footer Default Count: " + document.Footer.Default.Paragraphs.Count);
                Console.WriteLine("Footer Even Count: " + document.Footer.Even.Paragraphs.Count);
                Console.WriteLine("Footer First Count: " + document.Footer.First.Paragraphs.Count);

                Console.WriteLine("Footer text: " + document.Footer.Default.Paragraphs[0].Text);

                document.Save(openWord);
            }
        }

        private static void Example_BasicWordWithHeaderAndFooter1(string filePath, bool openWord) {
            using (WordDocument document = WordDocument.Create(filePath)) {
                document.Sections[0].ColumnsSpace = 50;
                Console.WriteLine("+ Settings Zoom Preset: " + document.Settings.ZoomPreset);
                Console.WriteLine("+ Settings Zoom Percent: " + document.Settings.ZoomPercentage);

                //document.Settings.ZoomPreset = PresetZoomValues.BestFit;
                //document.Settings.ZoomPercentage = 30;

                Console.WriteLine("+ Settings Zoom Preset: " + document.Settings.ZoomPreset);
                Console.WriteLine("+ Settings Zoom Percent: " + document.Settings.ZoomPercentage);

                document.AddHeadersAndFooters();
                document.DifferentFirstPage = true;
                //document.DifferentOddAndEvenPages = false;
                //var paragraphInFooter = document.Footer.Default.InsertParagraph();
                //paragraphInFooter.Text = "This is a test on odd pages (aka default if no options are set)";

                var paragraphInHeader = document.Header.Default.AddParagraph();
                paragraphInHeader.Text = "Default Header / Section 0";

                paragraphInHeader = document.Header.First.AddParagraph();
                paragraphInHeader.Text = "First Header / Section 0";

                //var paragraphInFooterFirst = document.Footer.First.InsertParagraph();
                //paragraphInFooterFirst.Text = "This is a test on first";

                //var count = document.Footer.First.Paragraphs.Count;

                //var paragraphInFooterOdd = document.Footer.Odd.InsertParagraph();
                //paragraphInFooterOdd.Text = "This is a test odd";


                //var paragraphHeader = document.Header.Odd.InsertParagraph();
                //paragraphHeader.Text = "Header - ODD";

                //var paragraphInFooterEven = document.Footer.Even.InsertParagraph();
                //paragraphInFooterEven.Text = "This is a test - Even";


                var paragraph = document.AddParagraph("Basic paragraph - Page 1");
                paragraph.ParagraphAlignment = JustificationValues.Center;
                paragraph.Color = SixLabors.ImageSharp.Color.Red.ToHexColor();

                //paragraph = document.InsertPageBreak();

                paragraph = document.AddParagraph("Basic paragraph - Page 2");
                paragraph.ParagraphAlignment = JustificationValues.Center;
                paragraph.Color = SixLabors.ImageSharp.Color.Red.ToHexColor();

                //paragraph = document.InsertPageBreak();

                paragraph = document.AddParagraph("Basic paragraph - Page 3");
                paragraph.ParagraphAlignment = JustificationValues.Center;
                paragraph.Color = SixLabors.ImageSharp.Color.Red.ToHexColor();

                //paragraph = document.InsertPageBreak();

                paragraph = document.AddParagraph("Basic paragraph - Page 4");
                paragraph.ParagraphAlignment = JustificationValues.Center;
                paragraph.Color = SixLabors.ImageSharp.Color.Red.ToHexColor();

                //paragraph = document.InsertPageBreak();

                paragraph = document.AddParagraph("Basic paragraph - Page 5");
                paragraph.ParagraphAlignment = JustificationValues.Center;
                paragraph.Color = SixLabors.ImageSharp.Color.Red.ToHexColor();

                //var section2 = document.InsertSection(SectionMarkValues.NextPage);
                var section2 = document.AddSection();
                section2.AddHeadersAndFooters();
                section2.DifferentFirstPage = true;


                // Add header to section
                //var paragraghInHeaderSection = section2.Header.First.InsertParagraph();
                //paragraghInHeaderSection.Text = "Ok, work please?";

                var paragraghInHeaderSection1 = section2.Header.Default.AddParagraph();
                paragraghInHeaderSection1.Text = "Weird shit? 1";

                paragraghInHeaderSection1 = section2.Header.First.AddParagraph();
                paragraghInHeaderSection1.Text = "Weird shit 2?";
                // paragraghInHeaderSection1.InsertText("ok?");

                paragraghInHeaderSection1 = section2.Header.Even.AddParagraph();
                paragraghInHeaderSection1.Text = "Weird shit? 3";

                paragraph = document.AddParagraph("Basic paragraph - Page 6");
                paragraph.ParagraphAlignment = JustificationValues.Center;
                paragraph.Color = SixLabors.ImageSharp.Color.Red.ToHexColor();

                paragraph = document.AddPageBreak();

                paragraph = document.AddParagraph("Basic paragraph - Page 7");
                paragraph.ParagraphAlignment = JustificationValues.Center;
                paragraph.Color = SixLabors.ImageSharp.Color.Red.ToHexColor();


                paragraph = document.AddParagraph("Basic paragraph - Section 3.1");
                paragraph.ParagraphAlignment = JustificationValues.Center;
                paragraph.Color = SixLabors.ImageSharp.Color.Red.ToHexColor();

                paragraph = document.AddPageBreak();

                paragraph = document.AddParagraph("Basic paragraph - Section 3.2");
                paragraph.ParagraphAlignment = JustificationValues.Center;
                paragraph.Color = SixLabors.ImageSharp.Color.Red.ToHexColor();

                paragraph = document.AddPageBreak();

                //paragraph = document.Footer.Odd.InsertParagraph();
                //paragraph.Text = "Lets see";

                // 2 section, 9 paragraphs + 7 pagebreaks = 15 paragraphs, 7 pagebreaks
                Console.WriteLine("+ Paragraphs: " + document.Paragraphs.Count);
                Console.WriteLine("+ PageBreaks: " + document.PageBreaks.Count);
                Console.WriteLine("+ Sections: " + document.Sections.Count);

                // primary section (for the whole document)
                Console.WriteLine("+ Paragraphs section 0: " + document.Sections[0].Paragraphs.Count);
                // additional sections
                Console.WriteLine("+ Paragraphs section 1: " + document.Sections[1].Paragraphs.Count);
                //Console.WriteLine("+ Paragraphs section 2: " + document.Sections[0].Paragraphs.Count);
                //Console.WriteLine("+ Paragraphs section 3: " + document.Sections[0].Paragraphs.Count);
                document.Save(openWord);
            }
        }

        private static void Example_PageOrientation(string filePath, bool openWord) {
            using (WordDocument document = WordDocument.Create(filePath)) {
                Console.WriteLine("+ Page Orientation (starting): " + document.PageOrientation);

                document.Sections[0].PageOrientation = PageOrientationValues.Landscape;

                Console.WriteLine("+ Page Orientation (middle): " + document.PageOrientation);

                document.PageOrientation = PageOrientationValues.Portrait;

                Console.WriteLine("+ Page Orientation (ending): " + document.PageOrientation);

                document.AddParagraph("Test");

                document.Save(openWord);
            }
        }

        private static void Example_BasicWordWithHeaderAndFooterWithoutSections(string filePath, bool openWord) {
            using (WordDocument document = WordDocument.Create(filePath)) {
                document.BuiltinDocumentProperties.Title = "This is a test for Title";
                document.BuiltinDocumentProperties.Category = "This is a test for Category";

                document.AddHeadersAndFooters();
                document.DifferentOddAndEvenPages = true;


                var paragraph = document.AddParagraph("Basic paragraph - Page 1");
                paragraph.ParagraphAlignment = JustificationValues.Center;
                paragraph.Color = SixLabors.ImageSharp.Color.Red.ToHexColor();

                var paragraphInHeaderO = document.Header.Default.AddParagraph();
                paragraphInHeaderO.Text = "Odd Header / Section 0";

                var paragraphInHeaderE = document.Header.Even.AddParagraph();
                paragraphInHeaderE.Text = "Even Header / Section 0";

                document.AddPageBreak();

                paragraph = document.AddParagraph("Basic paragraph - Page 2");
                paragraph.ParagraphAlignment = JustificationValues.Center;
                paragraph.Color = SixLabors.ImageSharp.Color.Red.ToHexColor();

                document.AddPageBreak();

                paragraph = document.AddParagraph("Basic paragraph - Page 3");
                paragraph.ParagraphAlignment = JustificationValues.Center;
                paragraph.Color = SixLabors.ImageSharp.Color.Red.ToHexColor();

                // 2 section, 9 paragraphs + 7 pagebreaks = 15 paragraphs, 7 pagebreaks
                Console.WriteLine("+ Paragraphs: " + document.Paragraphs.Count);
                Console.WriteLine("+ PageBreaks: " + document.PageBreaks.Count);
                Console.WriteLine("+ Sections: " + document.Sections.Count);

                // primary section (for the whole document)
                Console.WriteLine("+ Paragraphs section 0: " + document.Sections[0].Paragraphs.Count);
                // additional sections
                document.Save(openWord);
            }
        }

        private static void Example_BasicSections(string filePath, bool openWord) {
            using (WordDocument document = WordDocument.Create(filePath)) {
                document.AddParagraph("Test 1 - Should be before 1st section").SetColor(Color.LightPink);

                var section1 = document.AddSection();
                section1.AddParagraph("Test 1 - Should be after 1st section").SetFontFamily("Tahoma").SetFontSize(20);

                document.AddParagraph("Test 2 - Should be after 1st section");
                var section2 = document.AddSection();

                document.AddParagraph("Test 3 - Should be after 2nd section");
                document.AddParagraph("Test 4 - Should be after 2nd section").SetBold().AddText(" more text").SetColor(Color.DarkSalmon);

                var section3 = document.AddSection();

                var para = document.AddParagraph("Test 5 -");
                para = para.AddText(" and more text");
                para.Bold = true;

                document.AddPageBreak();

                var paragraph = document.AddParagraph("Basic paragraph - Page 3");
                paragraph.ParagraphAlignment = JustificationValues.Center;
                paragraph.Color = SixLabors.ImageSharp.Color.Blue.ToHexColor();

                paragraph.SetBold().SetFontFamily("Tahoma");
                paragraph.AddText(" This is continuation").SetUnderline(UnderlineValues.Double).SetHighlight(HighlightColorValues.DarkGreen).SetFontSize(15).SetColor(Color.Aqua);

                paragraph = document.AddParagraph("Basic paragraph - Page 4");
                paragraph.ParagraphAlignment = JustificationValues.Center;
                paragraph.Color = SixLabors.ImageSharp.Color.Blue.ToHexColor();

                paragraph.SetBold().SetFontFamily("Tahoma");
                paragraph.AddText(" This is continuation").SetUnderline(UnderlineValues.Double).SetHighlight(HighlightColorValues.DarkGreen).SetFontSize(15).SetColor(Color.Yellow);


                Console.WriteLine("+ Paragraphs: " + document.Paragraphs.Count);
                Console.WriteLine("+ PageBreaks: " + document.PageBreaks.Count);
                Console.WriteLine("+ Sections: " + document.Sections.Count);

                // primary section (for the whole document)
                Console.WriteLine("+ Paragraphs section 0: " + document.Sections[0].Paragraphs.Count);
                Console.WriteLine("+ Paragraphs section 1: " + document.Sections[1].Paragraphs.Count);
                Console.WriteLine("+ Paragraphs section 2: " + document.Sections[2].Paragraphs.Count);
                Console.WriteLine("+ Paragraphs section 3: " + document.Sections[3].Paragraphs.Count);

                document.Save();
            }

            using (WordDocument document = WordDocument.Load(filePath)) {
                Console.WriteLine("+ Paragraphs: " + document.Paragraphs.Count);
                Console.WriteLine("+ PageBreaks: " + document.PageBreaks.Count);
                Console.WriteLine("+ Sections: " + document.Sections.Count);

                // primary section (for the whole document)
                Console.WriteLine("+ Paragraphs section 0: " + document.Sections[0].Paragraphs.Count);
                Console.WriteLine("+ Paragraphs section 1: " + document.Sections[1].Paragraphs.Count);
                Console.WriteLine("+ Paragraphs section 2: " + document.Sections[2].Paragraphs.Count);
                Console.WriteLine("+ Paragraphs section 3: " + document.Sections[3].Paragraphs.Count);

                document.Save(openWord);
            }
        }

        private static void Example_BasicParagraphs(string filePath, bool openWord) {
            using (WordDocument document = WordDocument.Create(filePath)) {
                var paragraph = document.AddParagraph("Basic paragraph - Page 4");
                paragraph.ParagraphAlignment = JustificationValues.Center;
                paragraph.Color = SixLabors.ImageSharp.Color.Blue.ToHexColor();

                paragraph.AddText(" This is continuation").SetUnderline(UnderlineValues.Double).SetFontSize(15).SetColor(Color.Yellow).SetHighlight(HighlightColorValues.DarkGreen);


                Console.WriteLine("+ Color: " + paragraph.Color);
                Console.WriteLine("+ Color 0: " + document.Paragraphs[0].Color);
                Console.WriteLine("+ Color 1: " + document.Paragraphs[1].Color);
                Console.WriteLine("+ Paragraphs: " + document.Paragraphs.Count);
                Console.WriteLine("+ PageBreaks: " + document.PageBreaks.Count);
                Console.WriteLine("+ Sections: " + document.Sections.Count);

                // primary section (for the whole document)
                Console.WriteLine("+ Paragraphs section 0: " + document.Sections[0].Paragraphs.Count);

                document.Save();
            }

            using (WordDocument document = WordDocument.Load(filePath)) {
                Console.WriteLine("+ Color 0: " + document.Paragraphs[0].Color);
                Console.WriteLine("+ Color 1: " + document.Paragraphs[1].Color);
                Console.WriteLine("+ Paragraphs: " + document.Paragraphs.Count);
                Console.WriteLine("+ PageBreaks: " + document.PageBreaks.Count);
                Console.WriteLine("+ Sections: " + document.Sections.Count);

                // primary section (for the whole document)
                Console.WriteLine("+ Paragraphs section 0: " + document.Sections[0].Paragraphs.Count);
                document.Save(openWord);
            }
        }

        private static void Example_BasicWordWithHeaderAndFooter(string filePath, bool openWord) {
            using (WordDocument document = WordDocument.Create(filePath)) {
                document.AddHeadersAndFooters();

                document.Sections[0].PageOrientation = PageOrientationValues.Landscape;

                var paragraphInHeader = document.Header.Default.AddParagraph();
                paragraphInHeader.Text = "Default Header / Section 0";

                document.AddPageBreak();

                var paragraph = document.AddParagraph("Basic paragraph - Page 1");
                paragraph.ParagraphAlignment = JustificationValues.Center;
                paragraph.Color = SixLabors.ImageSharp.Color.Red.ToHexColor();

                var section2 = document.AddSection();
                section2.AddHeadersAndFooters();

                var paragraghInHeaderSection1 = section2.Header.Default.AddParagraph();
                paragraghInHeaderSection1.Text = "Weird shit? 1";

                paragraph = document.AddParagraph("Basic paragraph - Page 2");
                paragraph.ParagraphAlignment = JustificationValues.Center;
                paragraph.Color = SixLabors.ImageSharp.Color.Red.ToHexColor();

                var section3 = document.AddSection();
                section3.AddHeadersAndFooters();

                var paragraghInHeaderSection3 = section3.Header.Default.AddParagraph();
                paragraghInHeaderSection3.Text = "Weird shit? 2";

                paragraph = document.AddParagraph("Basic paragraph - Page 3");
                paragraph.ParagraphAlignment = JustificationValues.Center;
                paragraph.Color = SixLabors.ImageSharp.Color.Red.ToHexColor();

                // 2 section, 9 paragraphs + 7 pagebreaks = 15 paragraphs, 7 pagebreaks
                Console.WriteLine("+ Paragraphs: " + document.Paragraphs.Count);
                Console.WriteLine("+ PageBreaks: " + document.PageBreaks.Count);
                Console.WriteLine("+ Sections: " + document.Sections.Count);

                // primary section (for the whole document)
                Console.WriteLine("+ Paragraphs section 0: " + document.Sections[0].Paragraphs.Count);
                // additional sections
                Console.WriteLine("+ Paragraphs section 1: " + document.Sections[1].Paragraphs.Count);
                //Console.WriteLine("+ Paragraphs section 2: " + document.Sections[0].Paragraphs.Count);
                //Console.WriteLine("+ Paragraphs section 3: " + document.Sections[0].Paragraphs.Count);
                document.Save(openWord);
            }
        }

        private static void Example_BasicWordWithSections(string filePath, bool openWord) {
            using (WordDocument document = WordDocument.Create(filePath)) {
                document.AddParagraph("Test 1");
                var section1 = document.AddSection(SectionMarkValues.NextPage);

                document.AddParagraph("Test 2");
                var section2 = document.AddSection(SectionMarkValues.Continuous);

                document.AddParagraph("Test 3");
                var section3 = document.AddSection(SectionMarkValues.NextPage);
                section3.AddParagraph("Paragraph added to section number 3");
                section3.AddParagraph("Continue adding paragraphs to section 3");

                // 4 section, 5 paragraphs, 0 pagebreaks
                Console.WriteLine("+ Paragraphs: " + document.Paragraphs.Count);
                Console.WriteLine("+ PageBreaks: " + document.PageBreaks.Count);
                Console.WriteLine("+ Sections: " + document.Sections.Count);

                // primary section (for the whole document)
                Console.WriteLine("+ Paragraphs section 0: " + document.Sections[0].Paragraphs.Count);
                // additional sections
                Console.WriteLine("+ Paragraphs section 1: " + document.Sections[1].Paragraphs.Count);
                Console.WriteLine("+ Paragraphs section 2: " + document.Sections[2].Paragraphs.Count);
                Console.WriteLine("+ Paragraphs section 3: " + document.Sections[3].Paragraphs.Count);

                // change same paragraph using section
                document.Sections[1].Paragraphs[0].Bold = true;
                // or Paragraphs list for the whole document
                document.Paragraphs[1].Color = "7178a8";

                var paragraph = section1.AddParagraph("We missed paragraph on 1 section (2nd page)");
                var newParagraph = paragraph.AddParagraphAfterSelf();
                newParagraph.Text = "Some more text, after paragraph we just added.";
                newParagraph.Bold = true;


                Console.WriteLine("+ Paragraphs (repeated): " + document.Paragraphs.Count);
                Console.WriteLine("+ PageBreaks (repeated): " + document.PageBreaks.Count);
                Console.WriteLine("+ Sections   (repeated): " + document.Sections.Count);
                // primary section (for the whole document)
                Console.WriteLine("+ Paragraphs section 0 (repeated): " + document.Sections[0].Paragraphs.Count);
                // additional sections
                Console.WriteLine("+ Paragraphs section 1 (repeated): " + document.Sections[1].Paragraphs.Count);
                Console.WriteLine("+ Paragraphs section 2 (repeated): " + document.Sections[2].Paragraphs.Count);
                Console.WriteLine("+ Paragraphs section 3 (repeated): " + document.Sections[3].Paragraphs.Count);


                document.Save(openWord);
            }
        }

        private static void Example_BasicParagraphStyles(string filePath, bool openWord) {
            using (WordDocument document = WordDocument.Create(filePath)) {
                var listOfStyles = (WordParagraphStyles[])Enum.GetValues(typeof(WordParagraphStyles));
                foreach (var style in listOfStyles) {
                    var paragraph = document.AddParagraph(style.ToString());
                    paragraph.ParagraphAlignment = JustificationValues.Center;
                    paragraph.Style = style;
                }

                document.Save(openWord);
            }
            //using (WordDocument document = WordDocument.Load(filePath)) {


            //    document.Save(openWord);
            //}
        }


        private static void Example_BasicTOC1(string filePath, bool openWord) {
            using (WordDocument document = WordDocument.Create(filePath)) {
                // Standard way to open document and be asked about Updating Fields including TOC
                document.Settings.UpdateFieldsOnOpen = true;

                WordTableOfContent wordTableContent = document.AddTableOfContent(TableOfContentStyle.Template1);
                wordTableContent.Text = "This is Table of Contents";
                wordTableContent.TextNoContent = "Ooopsi, no content";

                document.AddPageBreak();

                var paragraph = document.AddParagraph("Test");
                paragraph.Style = WordParagraphStyles.Heading1;

                Console.WriteLine(wordTableContent.Text);
                Console.WriteLine(wordTableContent.TextNoContent);

                //// i am not sure if this is even working properly, seems so, but seems bad idea
                //wordTableContent.Update();

                document.Save();
            }

            using (WordDocument document = WordDocument.Load(filePath)) {
                document.Save(openWord);
            }
        }

        private static void Example_BasicTOC2(string filePath, bool openWord) {
            using (WordDocument document = WordDocument.Create(filePath)) {
                // Standard way to open document and be asked about Updating Fields including TOC
                document.Settings.UpdateFieldsOnOpen = true;

                WordTableOfContent wordTableContent = document.AddTableOfContent(TableOfContentStyle.Template1);
                wordTableContent.Text = "This is Table of Contents";
                wordTableContent.TextNoContent = "Ooopsi, no content";

                document.AddPageBreak();

                WordList wordList = document.AddList(WordListStyle.Headings111);
                wordList.AddItem("Text 1").Style = WordParagraphStyles.Heading1;

                document.AddPageBreak();

                wordList.AddItem("Text 2.1", 1).SetColor(Color.Brown).Style = WordParagraphStyles.Heading2;

                document.Save();
            }

            using (WordDocument document = WordDocument.Load(filePath)) {
                document.Save(openWord);
            }
        }


        private static void Example_PageNumbers1(string filePath, bool openWord) {
            using (WordDocument document = WordDocument.Create(filePath)) {
                document.Settings.UpdateFieldsOnOpen = true;
                document.AddTableOfContent(tableOfContentStyle: TableOfContentStyle.Template2);
                document.AddHeadersAndFooters();
                //var pageNumber = document.Header.Default.AddPageNumber(WordPageNumberStyle.Circle);
                var pageNumber = document.Footer.Default.AddPageNumber(WordPageNumberStyle.VerticalOutline2);
                pageNumber.ParagraphAlignment = JustificationValues.Center;

                document.AddPageBreak();

                document.AddHorizontalLine(BorderValues.Double);

                document.Sections[0].AddHorizontalLine();

                var wordListToc = document.AddTableOfContentList(WordListStyle.Headings111);

                wordListToc.AddItem("This is first item");

                wordListToc.AddItem("This is second item");

                document.AddPageBreak();

                wordListToc.AddItem("Text 2.1", 1);

                wordListToc.AddItem("Text 2.1", 1);

                wordListToc.AddItem("Text 2.1", 1);

                wordListToc.AddItem("Text 2.2", 2);

                var para = document.AddParagraph("Let's show everyone how to create a list within already defined list");
                para.CapsStyle = CapsStyle.Caps;
                para.Highlight = HighlightColorValues.DarkMagenta;

                var wordList = document.AddList(WordListStyle.Bulleted);

                wordList.AddItem("List Item 1");
                wordList.AddItem("List Item 2");
                wordList.AddItem("List Item 3");
                wordList.AddItem("List Item 3.1", 1);
                wordList.AddItem("List Item 3.2", 1);
                wordList.AddItem("List Item 3.3", 2);

                wordListToc.AddItem("Text 2.3", 2);

                wordListToc.AddItem("Text 3.3", 3);

                document.Save();
            }

            using (WordDocument document = WordDocument.Load(filePath)) {
                // we loaded document, lets add some text to continue
                document.AddParagraph().SetColor(Color.CornflowerBlue).SetText("This is some text");

                // we loaded document, lets add page break to continue
                document.AddPageBreak();

                // lets find a list which has items which suggest it's a TOC attached list
                WordList wordListToc = null;
                foreach (var list in document.Lists) {
                    if (list.IsToc) {
                        wordListToc = list;
                    }
                }

                // finally lets add another list item
                if (wordListToc != null) {
                    wordListToc.AddItem("Text 4.4", 2);
                }

                document.Settings.UpdateFieldsOnOpen = true;
                document.Save(openWord);
            }
        }

        private static void Example_BasicSections2(string filePath, bool openWord) {
            using (WordDocument document = WordDocument.Create(filePath)) {
                document.Sections[0].PageOrientation = PageOrientationValues.Landscape;
                document.AddParagraph("Test 1 - Should be before 1st section").SetColor(Color.LightPink);

                var section1 = document.AddSection();

                section1.PageOrientation = PageOrientationValues.Portrait;

                section1.AddParagraph("Test 1 - Should be after 1st section").SetFontFamily("Tahoma").SetFontSize(20);

                var section2 = document.AddSection();

                section2.AddParagraph("Test 2 - Should be after 2nd section").SetFontFamily("Tahoma").SetFontSize(20);

                section2.PageOrientation = PageOrientationValues.Landscape;

                //// primary section (for the whole document)
                Console.WriteLine("+ Paragraphs section 0: " + document.Sections[0].Paragraphs.Count);
                Console.WriteLine("+ Paragraphs section 1: " + document.Sections[1].Paragraphs.Count);
                Console.WriteLine("+ Paragraphs section 2: " + document.Sections[2].Paragraphs.Count);

                Console.WriteLine("+ PageOrientation section 0: " + document.Sections[0].PageOrientation);
                Console.WriteLine("+ PageOrientation section 1: " + document.Sections[1].PageOrientation);
                Console.WriteLine("+ PageOrientation section 2: " + document.Sections[2].PageOrientation);

                document.Save();
            }

            using (WordDocument document = WordDocument.Load(filePath)) {
                Console.WriteLine("Loaded document information:");
                Console.WriteLine("+ Paragraphs section 0: " + document.Sections[0].Paragraphs.Count);
                Console.WriteLine("+ Paragraphs section 1: " + document.Sections[1].Paragraphs.Count);
                Console.WriteLine("+ Paragraphs section 2: " + document.Sections[2].Paragraphs.Count);

                Console.WriteLine("+ PageOrientation section 0: " + document.Sections[0].PageOrientation);
                Console.WriteLine("+ PageOrientation section 1: " + document.Sections[1].PageOrientation);
                Console.WriteLine("+ PageOrientation section 2: " + document.Sections[2].PageOrientation);


                var section1 = document.AddSection();
                section1.AddParagraph("Test Section4");

                var section2 = document.AddSection();
                section2.AddParagraph("Test Section5");

                var section3 = document.AddSection();
                section3.AddParagraph("Test Section6");
                section3.PageOrientation = PageOrientationValues.Portrait;

                Console.WriteLine("Loaded document information:");
                Console.WriteLine("+ Paragraphs section 0: " + document.Sections[0].Paragraphs.Count);
                Console.WriteLine("+ Paragraphs section 1: " + document.Sections[1].Paragraphs.Count);
                Console.WriteLine("+ Paragraphs section 2: " + document.Sections[2].Paragraphs.Count);
                Console.WriteLine("+ Paragraphs section 3: " + document.Sections[3].Paragraphs.Count);
                Console.WriteLine("+ Paragraphs section 4: " + document.Sections[4].Paragraphs.Count);
                Console.WriteLine("+ Paragraphs section 5: " + document.Sections[5].Paragraphs.Count);

                Console.WriteLine("+ PageOrientation section 0: " + document.Sections[0].PageOrientation);
                Console.WriteLine("+ PageOrientation section 1: " + document.Sections[1].PageOrientation);
                Console.WriteLine("+ PageOrientation section 2: " + document.Sections[2].PageOrientation);
                Console.WriteLine("+ PageOrientation section 3: " + document.Sections[3].PageOrientation);
                Console.WriteLine("+ PageOrientation section 4: " + document.Sections[4].PageOrientation);
                Console.WriteLine("+ PageOrientation section 5: " + document.Sections[5].PageOrientation);


                section1.AddParagraph("This goes to section 4");

                Console.WriteLine("+ Paragraphs section 3 Text: " + document.Sections[3].Paragraphs[0].Text);
                Console.WriteLine("+ Paragraphs section 3 Count: " + document.Sections[3].Paragraphs.Count);

                document.Save(openWord);
            }
        }

        private static void Example_BasicSections3WithColumns(string filePath, bool openWord) {
            using (WordDocument document = WordDocument.Create(filePath)) {
                document.Sections[0].PageOrientation = PageOrientationValues.Landscape;
                document.AddParagraph("Test 1 - Should be before 1st section").SetColor(Color.LightPink);

                var section1 = document.AddSection();
                section1.AddParagraph("This is a text in 2nd section");
                section1.PageOrientation = PageOrientationValues.Portrait;
                section1.ColumnCount = 2;
                for (int i = 0; i < 10; i++) {
                    section1.AddParagraph("Test 3 - Should be in 2nd section");
                }

                section1.AddParagraph("Test5");

                var section2 = document.AddSection();

                section2.AddParagraph("Test 2 - Should be after 2nd section").SetFontFamily("Tahoma").SetFontSize(20);

                section2.PageOrientation = PageOrientationValues.Landscape;

                //// primary section (for the whole document)
                Console.WriteLine("+ Paragraphs section 0: " + document.Sections[0].Paragraphs.Count);
                Console.WriteLine("+ Paragraphs section 1: " + document.Sections[1].Paragraphs.Count);
                Console.WriteLine("+ Paragraphs section 2: " + document.Sections[2].Paragraphs.Count);

                Console.WriteLine("+ PageOrientation section 0: " + document.Sections[0].PageOrientation);
                Console.WriteLine("+ PageOrientation section 1: " + document.Sections[1].PageOrientation);
                Console.WriteLine("+ PageOrientation section 2: " + document.Sections[2].PageOrientation);

                Console.WriteLine("+ ColumnCount section 0: " + document.Sections[0].ColumnCount);
                Console.WriteLine("+ ColumnCount section 1: " + document.Sections[1].ColumnCount);

                document.Save(false);
            }

            using (WordDocument document = WordDocument.Load(filePath)) {
                Console.WriteLine("Loaded document information:");
                Console.WriteLine("+ Paragraphs section 0: " + document.Sections[0].Paragraphs.Count);
                Console.WriteLine("+ Paragraphs section 1: " + document.Sections[1].Paragraphs.Count);
                Console.WriteLine("+ Paragraphs section 2: " + document.Sections[2].Paragraphs.Count);

                var section1 = document.AddSection();
                section1.AddParagraph("This is a text in 2nd section");
                section1.PageOrientation = PageOrientationValues.Portrait;
                section1.ColumnCount = 2;
                for (int i = 0; i < 10; i++) {
                    section1.AddParagraph("Test 3 - Should be in 2nd section");
                }

                for (int i = 0; i < 11; i++) {
                    Console.WriteLine(document.Sections[3].Paragraphs[i].Text);
                }

                Console.WriteLine("+ Paragraphs section 3: " + document.Sections[3].Paragraphs.Count);

                document.Save(openWord);
            }
        }

        private static void Example_SectionsWithParagraphs(string filePath, bool openWord) {
            using (WordDocument document = WordDocument.Create(filePath)) {
                document.Sections[0].PageOrientation = PageOrientationValues.Landscape;
                document.AddParagraph("Test Section0").SetColor(Color.LightPink);

                var section1 = document.AddSection();
                section1.PageOrientation = PageOrientationValues.Portrait;

                section1.AddParagraph("Test Section1").SetFontFamily("Tahoma").SetFontSize(20);

                var section2 = document.AddSection();

                section2.AddParagraph("Test Section2").SetFontFamily("Tahoma").SetFontSize(20);

                section2.PageOrientation = PageOrientationValues.Landscape;


                Console.WriteLine("Section 0 - Text 0: " + document.Sections[0].Paragraphs[0].Text);
                Console.WriteLine("Section 1 - Text 0: " + document.Sections[1].Paragraphs[0].Text);
                Console.WriteLine("Section 2 - Text 0: " + document.Sections[2].Paragraphs[0].Text);

                document.Save(false);
            }

            using (WordDocument document = WordDocument.Load(filePath)) {
                Console.WriteLine("-----");
                Console.WriteLine("Section 0 - Text 0: " + document.Sections[0].Paragraphs[0].Text);
                Console.WriteLine("Section 1 - Text 0: " + document.Sections[1].Paragraphs[0].Text);
                Console.WriteLine("Section 2 - Text 0: " + document.Sections[2].Paragraphs[0].Text);


                var section3 = document.AddSection();
                section3.AddParagraph("Test Section3");
                Console.WriteLine("Section 3 - Text 0: " + document.Sections[3].Paragraphs[0].Text);
                section3.AddParagraph("Test Section3-Par1");
                Console.WriteLine("Section 3 - Text 1: " + document.Sections[3].Paragraphs[1].Text);
                var section4 = document.AddSection();
                section4.AddParagraph("Test Section4");
                var section5 = document.AddSection();
                section5.AddParagraph("Test Section5");
                section5.PageOrientation = PageOrientationValues.Portrait;

                document.AddParagraph("Test Section5-Par1");
                document.AddParagraph("Test Section5-Par2");
                section3.AddParagraph("Test Section3-Par2");

                Console.WriteLine("-----");
                Console.WriteLine("Section 0 - Text 0: " + document.Sections[0].Paragraphs[0].Text);
                Console.WriteLine("Section 1 - Text 0: " + document.Sections[1].Paragraphs[0].Text);
                Console.WriteLine("Section 2 - Text 0: " + document.Sections[2].Paragraphs[0].Text);
                Console.WriteLine("Section 3 - Text 0: " + document.Sections[3].Paragraphs[0].Text);
                Console.WriteLine("Section 4 - Text 0: " + document.Sections[4].Paragraphs[0].Text);
                Console.WriteLine("Section 5 - Text 0: " + document.Sections[5].Paragraphs[0].Text);
                Console.WriteLine("Section 5 - Text 1: " + document.Sections[5].Paragraphs[1].Text);
                Console.WriteLine("Section 5 - Text 2: " + document.Sections[5].Paragraphs[2].Text);
                Console.WriteLine("Section 3 - Text 1: " + document.Sections[3].Paragraphs[1].Text);
                Console.WriteLine("Section 3 - Text 2: " + document.Sections[3].Paragraphs[2].Text);
                document.Save(true);
            }
        }

        private static void Example_SectionsWithHeadersDefault(string filePath, bool openWord) {
            using (WordDocument document = WordDocument.Create(filePath)) {
                document.Settings.Language = "pl-PL";

                document.Sections[0].PageOrientation = PageOrientationValues.Portrait;
                document.AddParagraph("Test Section0");
                document.AddHeadersAndFooters();
                document.DifferentFirstPage = true;
                document.DifferentOddAndEvenPages = true;

                document.Sections[0].Header.Default.AddParagraph().SetText("Test Section 0 - Header");
                document.Sections[0].Header.First.AddParagraph().SetText("Test Section 0 - First Header");
                document.Sections[0].Header.Even.AddParagraph().SetText("Test Section 0 - Even");

                document.Sections[0].Paragraphs[0].AddComment("Przemysław Kłys", "PK", "This should be a comment");

                document.AddPageBreak();
                document.AddPageBreak();
                document.AddPageBreak();
                document.AddPageBreak();

                document.AddSection();
                document.Sections[1].PageOrientation = PageOrientationValues.Landscape;

                document.AddPageBreak();
                document.AddPageBreak();
                document.AddPageBreak();
                document.AddPageBreak();

                //Console.WriteLine("Section 0 - Text 0: " + document.Sections[0].Paragraphs[0].Text);
                //Console.WriteLine("Section 1 - Text 0: " + document.Sections[1].Paragraphs[0].Text);
                //Console.WriteLine("Section 2 - Text 0: " + document.Sections[2].Paragraphs[0].Text);
                //Console.WriteLine("Section 2 - Text 1: " + document.Sections[2].Paragraphs[1].Text);
                //Console.WriteLine("Section 3 - Text 0: " + document.Sections[3].Paragraphs[0].Text);

                //Console.WriteLine("Section 0 - Text 0: " + document.Sections[0].Header.Default.Paragraphs[0].Text);
                //Console.WriteLine("Section 1 - Text 0: " + document.Sections[1].Header.Default.Paragraphs[0].Text);
                //Console.WriteLine("Section 2 - Text 0: " + document.Sections[2].Header.Default.Paragraphs[0].Text);
                //Console.WriteLine("Section 3 - Text 0: " + document.Sections[3].Header.Default.Paragraphs[0].Text);
                document.Save(false);
            }

            using (WordDocument document = WordDocument.Load(filePath)) {
                document.Sections[1].AddHeadersAndFooters();
                document.Sections[1].Header.Default.AddParagraph().SetText("Test Section 1 - Header");
                document.Sections[1].Footer.Default.AddParagraph().SetText("Test Section 1 - Header");

                document.Sections[1].DifferentFirstPage = true;
                document.Sections[1].Header.First.AddParagraph().SetText("Test Section 1 - First Header");
                document.Sections[1].Footer.First.AddParagraph().SetText("Test Section 1 - First Footer");

                document.Sections[1].DifferentOddAndEvenPages = true;

                document.Sections[1].Header.Even.AddParagraph().SetText("Test Section 1 - Even Header");
                document.Sections[1].Footer.Even.AddParagraph().SetText("Test Section 1 - Even Footer");

                document.Settings.ProtectionPassword = "ThisIsTest";
                document.Settings.ProtectionType = DocumentProtectionValues.ReadOnly;
                document.Settings.RemoveProtection();
                document.Save(openWord);
            }
        }

        private static void Example_SectionsWithHeaders(string filePath, bool openWord) {
            using (WordDocument document = WordDocument.Create(filePath)) {
                document.Sections[0].PageOrientation = PageOrientationValues.Landscape;
                document.AddParagraph("Test Section0");
                document.AddHeadersAndFooters();
                document.DifferentFirstPage = true;
                document.DifferentOddAndEvenPages = true;

                document.Sections[0].Header.First.AddParagraph().SetText("Test Section 0 - First Header");
                document.Sections[0].Header.Default.AddParagraph().SetText("Test Section 0 - Header");
                document.Sections[0].Header.Even.AddParagraph().SetText("Test Section 0 - Even");

                document.AddPageBreak();


                document.AddPageBreak();


                document.AddPageBreak();


                document.AddPageBreak();


                var section1 = document.AddSection();
                section1.PageOrientation = PageOrientationValues.Portrait;
                section1.AddParagraph("Test Section1");
                section1.AddHeadersAndFooters();
                section1.Header.Default.AddParagraph().SetText("Test Section 1 - Header");
                section1.DifferentFirstPage = true;
                section1.Header.First.AddParagraph().SetText("Test Section 1 - First Header");


                document.AddPageBreak();


                document.AddPageBreak();


                document.AddPageBreak();


                document.AddPageBreak();


                var section2 = document.AddSection();
                section2.AddParagraph("Test Section2");
                section2.PageOrientation = PageOrientationValues.Landscape;
                section2.AddHeadersAndFooters();
                section2.Header.Default.AddParagraph().SetText("Test Section 2 - Header");

                document.AddParagraph("Test Section2 - Paragraph 1");


                var section3 = document.AddSection();
                section3.AddParagraph("Test Section3");
                section3.AddHeadersAndFooters();
                section3.Header.Default.AddParagraph().SetText("Test Section 3 - Header");


                Console.WriteLine("Section 0 - Text 0: " + document.Sections[0].Paragraphs[0].Text);
                Console.WriteLine("Section 1 - Text 0: " + document.Sections[1].Paragraphs[0].Text);
                Console.WriteLine("Section 2 - Text 0: " + document.Sections[2].Paragraphs[0].Text);
                Console.WriteLine("Section 2 - Text 1: " + document.Sections[2].Paragraphs[1].Text);
                Console.WriteLine("Section 3 - Text 0: " + document.Sections[3].Paragraphs[0].Text);

                Console.WriteLine("Section 0 - Text 0: " + document.Sections[0].Header.Default.Paragraphs[0].Text);
                Console.WriteLine("Section 1 - Text 0: " + document.Sections[1].Header.Default.Paragraphs[0].Text);
                Console.WriteLine("Section 2 - Text 0: " + document.Sections[2].Header.Default.Paragraphs[0].Text);
                Console.WriteLine("Section 3 - Text 0: " + document.Sections[3].Header.Default.Paragraphs[0].Text);
                document.Save(false);
            }

            using (WordDocument document = WordDocument.Load(filePath)) {
                Console.WriteLine("-----");
                Console.WriteLine("Section 0 - Text 0: " + document.Sections[0].Paragraphs[0].Text);
                Console.WriteLine("Section 1 - Text 0: " + document.Sections[1].Paragraphs[0].Text);
                Console.WriteLine("Section 2 - Text 0: " + document.Sections[2].Paragraphs[0].Text);
                Console.WriteLine("Section 2 - Text 1: " + document.Sections[2].Paragraphs[1].Text);
                Console.WriteLine("Section 3 - Text 0: " + document.Sections[3].Paragraphs[0].Text);
                Console.WriteLine("Section 0 - Text 0: " + document.Sections[0].Header.Default.Paragraphs[0].Text);
                Console.WriteLine("Section 1 - Text 0: " + document.Sections[1].Header.Default.Paragraphs[0].Text);
                Console.WriteLine("Section 2 - Text 0: " + document.Sections[2].Header.Default.Paragraphs[0].Text);
                Console.WriteLine("Section 3 - Text 0: " + document.Sections[3].Header.Default.Paragraphs[0].Text);
                Console.WriteLine("-----");
                document.Sections[1].Header.Default.AddParagraph().SetText("Test Section 1 - Header-Par1");
                Console.WriteLine("Section 1 - Text 1: " + document.Sections[1].Header.Default.Paragraphs[1].Text);
                document.Save(true);
            }
        }

        private static void Example_PlayingWithComments(string filePath, bool openWord) {
            using (WordDocument document = WordDocument.Create(filePath)) {
                document.AddParagraph("Test Section");

                document.Paragraphs[0].AddComment("Przemysław", "PK", "This is my comment");


                document.AddParagraph("Test Section - another line");

                document.Paragraphs[1].AddComment("Przemysław", "PK", "More comments");

                document.Save(false);
            }

            using (WordDocument document = WordDocument.Load(filePath)) {
                document.Save(true);
            }
        }

        private static void Example_BasicWordMarginsSizes(string filePath, bool openWord) {
            using (WordDocument document = WordDocument.Create(filePath)) {
                document.AddParagraph("Section 0");
                document.Sections[0].SetMargins(WordMargin.Normal);

                document.AddSection();
                document.Sections[1].SetMargins(WordMargin.Narrow);
                document.AddParagraph("Section 1");

                document.AddSection();
                document.Sections[2].SetMargins(WordMargin.Mirrored);
                document.AddParagraph("Section 2");

                document.AddSection();
                document.Sections[3].SetMargins(WordMargin.Moderate);
                document.AddParagraph("Section 3");

                document.AddSection();
                document.Sections[4].SetMargins(WordMargin.Wide);
                document.AddParagraph("Section 4");

                //Console.WriteLine("+ Page Orientation (starting): " + document.PageOrientation);

                //document.Sections[0].PageOrientation = PageOrientationValues.Landscape;

                //Console.WriteLine("+ Page Orientation (middle): " + document.PageOrientation);

                //document.PageOrientation = PageOrientationValues.Portrait;

                //Console.WriteLine("+ Page Orientation (ending): " + document.PageOrientation);

                //document.AddParagraph("Test");

                document.Save(openWord);
            }
        }

        private static void Example_BasicWordWatermark(string filePath, bool openWord) {
            using (WordDocument document = WordDocument.Create(filePath)) {
                document.AddParagraph("Section 0");
                document.AddHeadersAndFooters();
                document.Sections[0].SetMargins(WordMargin.Normal);

                Console.WriteLine(document.Sections[0].Margins.Left.Value);
                Console.WriteLine(document.Sections[0].Margins.Right.Value);

                document.Sections[0].AddWatermark(WordWatermarkStyle.Text, "Confidential");

                document.AddSection();
                document.Sections[1].AddHeadersAndFooters();
                document.Sections[1].SetMargins(WordMargin.Moderate);

                Console.WriteLine("----");
                //document.Sections[1].AddWatermark(WordWatermarkStyle.Image);

                Console.WriteLine(document.Sections[0].Margins.Left.Value);
                Console.WriteLine(document.Sections[0].Margins.Right.Value);

                Console.WriteLine(document.Sections[1].Margins.Left.Value);
                Console.WriteLine(document.Sections[1].Margins.Right.Value);

                document.Settings.SetBackgroundColor(Color.Azure);

                document.Save(openWord);
            }
        }

        private static void Example_BasicPageBorders1(string filePath, bool openWord) {
            using (WordDocument document = WordDocument.Create(filePath)) {
                document.AddParagraph("Section 0");

                document.Sections[0].Borders.LeftStyle = BorderValues.PalmsColor;
                document.Sections[0].Borders.LeftColor = SixLabors.ImageSharp.Color.Aqua;
                document.Sections[0].Borders.LeftSpace = 24;
                document.Sections[0].Borders.LeftSize = 24;

                document.Sections[0].Borders.RightStyle = BorderValues.BabyPacifier;
                document.Sections[0].Borders.RightColor = SixLabors.ImageSharp.Color.Red;
                document.Sections[0].Borders.RightSize = 12;

                document.Sections[0].Borders.TopStyle = BorderValues.SharksTeeth;
                document.Sections[0].Borders.TopColor = SixLabors.ImageSharp.Color.GreenYellow;
                document.Sections[0].Borders.TopSize = 10;

                document.Sections[0].Borders.BottomStyle = BorderValues.Thick;
                document.Sections[0].Borders.BottomColor = SixLabors.ImageSharp.Color.Blue;
                document.Sections[0].Borders.BottomSize = 15;

                document.Save(openWord);
            }
        }

        private static void Example_BasicPageBorders2(string filePath, bool openWord) {
            using (WordDocument document = WordDocument.Create(filePath)) {
                document.Background.SetColor(Color.DarkSeaGreen);

                document.AddParagraph("Section 0");

                document.Sections[0].SetBorders(WordBorder.Box);

                document.AddSection();
                document.Sections[1].SetBorders(WordBorder.Shadow);

                Console.WriteLine(document.Sections[1].Borders.Type);

                document.Save(openWord);
            }
        }
    }
}