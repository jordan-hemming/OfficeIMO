﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Wordprocessing;
using OfficeIMO.Word;
using Xunit;

namespace OfficeIMO.Tests {
    public partial class Word {
        [Fact]
        public void Test_CreatingWordDocumentWithPageMargins2() {
            string filePath = Path.Combine(_directoryWithFiles, "CreatedDocumentWithSectionsPageMargins2.docx");
            using (WordDocument document = WordDocument.Create(filePath)) {
                Assert.True(document.Sections[0].PageOrientation == PageOrientationValues.Portrait, "Page orientation should match");
                Assert.True(document.Paragraphs.Count == 0, "Number of paragraphs during creation is wrong. Current: " + document.Paragraphs.Count);
                Assert.True(document.Sections.Count == 1, "Number of sections during creation is wrong.");

                document.AddParagraph("Section 0");
                document.Sections[0].Margins.Type = WordMargin.Normal;

                document.AddSection();
                document.Sections[1].Margins.Type = WordMargin.Narrow;
                document.AddParagraph("Section 1");

                document.AddSection();
                document.Sections[2].Margins.Type = WordMargin.Mirrored;
                document.AddParagraph("Section 2");

                document.AddSection();
                document.Sections[3].Margins.Type = WordMargin.Moderate;
                document.AddParagraph("Section 3");

                document.AddSection();
                document.Sections[4].Margins.Type = WordMargin.Wide;
                document.AddParagraph("Section 4");

                var section = document.AddSection();
                document.AddParagraph("Section 5");

                var section2 = document.AddSection();
                document.AddParagraph("Section 6");

                section2.Margins.Type = WordMargin.Office2003Default;
                section2.Margins.Bottom = 15;
                section.Margins.Type = WordMargin.Office2003Default;

                Assert.True(document.Sections[0].Margins.Type == WordMargin.Normal);
                Assert.True(document.Sections[1].Margins.Type == WordMargin.Narrow);
                Assert.True(document.Sections[2].Margins.Type == WordMargin.Mirrored);
                Assert.True(document.Sections[3].Margins.Type == WordMargin.Moderate);
                Assert.True(document.Sections[4].Margins.Type == WordMargin.Wide);
                Assert.True(document.Sections[5].Margins.Type == WordMargin.Office2003Default);
                Assert.True(document.Sections[6].Margins.Type == WordMargin.Unknown);

                Assert.True(section.Margins.Type == WordMargin.Office2003Default);
                Assert.True(section2.Margins.Type == WordMargin.Unknown);

                Assert.True(section.Paragraphs[0].Text == "Section 5");
                Assert.True(section2.Paragraphs[0].Text == "Section 6");

                document.Save(false);
            }
            using (WordDocument document = WordDocument.Load(Path.Combine(_directoryWithFiles, "CreatedDocumentWithSectionsPageMargins2.docx"))) {

                Assert.True(document.Sections[0].Margins.Type == WordMargin.Normal);
                Assert.True(document.Sections[1].Margins.Type == WordMargin.Narrow);
                Assert.True(document.Sections[2].Margins.Type == WordMargin.Mirrored);
                Assert.True(document.Sections[3].Margins.Type == WordMargin.Moderate);
                Assert.True(document.Sections[4].Margins.Type == WordMargin.Wide);
                Assert.True(document.Sections[5].Margins.Type == WordMargin.Office2003Default);
                Assert.True(document.Sections[6].Margins.Type == WordMargin.Unknown);

                document.Save();
            }
            using (WordDocument document = WordDocument.Load(Path.Combine(_directoryWithFiles, "CreatedDocumentWithSectionsPageMargins2.docx"))) {

                Assert.True(document.Sections[0].Margins.Type == WordMargin.Normal);
                Assert.True(document.Sections[1].Margins.Type == WordMargin.Narrow);
                Assert.True(document.Sections[2].Margins.Type == WordMargin.Mirrored);
                Assert.True(document.Sections[3].Margins.Type == WordMargin.Moderate);
                Assert.True(document.Sections[4].Margins.Type == WordMargin.Wide);
                Assert.True(document.Sections[5].Margins.Type == WordMargin.Office2003Default);
                Assert.True(document.Sections[6].Margins.Type == WordMargin.Unknown);

            }
        }
    }

}
