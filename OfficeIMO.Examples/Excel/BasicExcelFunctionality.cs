﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeIMO.Excel;
using OfficeIMO.Word;

namespace OfficeIMO.Examples.Excel {
    public class BasicExcelFunctionality {

        public static void BasicExcel_Example1(string filePath, bool openExcel) {
            
            using (ExcelDocument document = ExcelDocument.Create(filePath)) {

                ExcelSheet sheet1 = document.AddWorkSheet("Test");

                ExcelSheet sheet2 = document.AddWorkSheet("Test2");

                ExcelSheet sheet3 = document.AddWorkSheet("Test3");

                document.Save(true);
            }
        }
        public static void BasicExcel_Example2(string filePath, bool openExcel) {
            using (ExcelDocument document = ExcelDocument.Create(filePath, "WorkSheet1")) {

                document.Save(false);
            }
        }

        public static void BasicExcel_Example3(bool openExcel) {
            string documentPaths = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "Templates");
            string filePath = System.IO.Path.Combine(documentPaths, "BasicExcel.xlsx");
            using (ExcelDocument document = ExcelDocument.Load(filePath)) {

                Console.WriteLine("Sheets count:" + document.Sheets.Count);

                document.Save(false);
            }
        }
    }
}
