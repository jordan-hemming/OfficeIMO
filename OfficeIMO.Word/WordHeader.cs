﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace OfficeIMO.Word {
    public class WordHeaders {
        public WordHeader Default {
            get;
            set;
        }
        public WordHeader Even {
            get;
            set;
        }
        public WordHeader First {
            get;
            set;
        }
    }
    public partial class WordHeader : WordHeaderFooter {
        internal WordHeader(WordDocument document, HeaderReference headerReference) {
            _document = document;
            _id = headerReference.Id;
            _type = WordSection.GetType(headerReference.Type);

            var listHeaders = document._wordprocessingDocument.MainDocumentPart.HeaderParts.ToList();
            foreach (HeaderPart headerPart in listHeaders) {
                var id = document._wordprocessingDocument.MainDocumentPart.GetIdOfPart(headerPart);
                if (id == _id) {
                    _headerPart = headerPart;
                    _header = headerPart.Header;
                }
            }

            if (_type == HeaderFooterValues.Default) {
                document._currentSection.Header.Default = this;
            } else if (_type == HeaderFooterValues.Even) {
                document._currentSection.Header.Even = this;
            } else if (_type == HeaderFooterValues.First) {
                document._currentSection.Header.First = this;
            } else {
                throw new InvalidOperationException("Shouldn't happen?");
            }
        }
        internal WordHeader(WordDocument document, HeaderFooterValues type, Header headerPartHeader) {
            _document = document;
            _header = headerPartHeader;
            _type = type;
        }

        public WordPageNumber AddPageNumber(WordPageNumberStyle wordPageNumberStyle) {
            var pageNumber = new WordPageNumber(_document, this, wordPageNumberStyle);
            return pageNumber;
        }

        public static void RemoveHeaders(WordprocessingDocument wordprocessingDocument) {
            var docPart = wordprocessingDocument.MainDocumentPart;
            DocumentFormat.OpenXml.Wordprocessing.Document document = docPart.Document;
            if (docPart.HeaderParts.Any()) {
                // Remove the header
                docPart.DeleteParts(docPart.HeaderParts);

                // First, create a list of all descendants of type
                // HeaderReference. Then, navigate the list and call
                // Remove on each item to delete the reference.
                var headers = document.Descendants<HeaderReference>().ToList();
                foreach (var header in headers) {
                    header.Remove();
                }
            }
        }
    }
}
