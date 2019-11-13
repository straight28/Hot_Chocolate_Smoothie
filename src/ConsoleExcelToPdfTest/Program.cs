using Spire.Pdf;
using Spire.Xls;
using System;

namespace ConsoleExcelToPdfTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Excel 생성 Closed.xml
            //using(var workbook = new XLWorkbook())
            //{
            //    var worksheet = workbook.Worksheets.Add("sample sheet");
            //    worksheet.Cell("A1").Value = "안뇽하세요";
            //    worksheet.Cell("C1").FormulaA1 = "=MID(A1, 7, 5)";
            //    workbook.SaveAs("test.xlsx");
            //}

            //이상하게 뽑힘 FreeSpire.xml
            //Workbook workbook = new Workbook();
            //workbook.LoadFromFile(@"C:\Users\smkwon\Downloads\.xlsx");
            //workbook.SaveToFile(".pdf", Spire.Xls.FileFormat.PDF);





        }
    }
}
