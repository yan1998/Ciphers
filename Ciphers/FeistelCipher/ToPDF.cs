using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data;

namespace FeistelCipher
{
    class ToPDF
    {
        private DataSet myDataSet = new DataSet();

        //Добалвление новой таблицы
        public void AddTable(DataTable table)
        {
            myDataSet.Tables.Add(table);
        }

        //Вывод всех таблиц в pdf файл
        public void OutToPDFFile()
        {
            //Объект документа пдф
            Document doc = new Document();

            //Создаем объект записи пдф-документа в файл
            PdfWriter.GetInstance(doc, new FileStream("tables.pdf", FileMode.Truncate));

            //Открываем документ
            doc.Open();

            //Определение шрифта необходимо для сохранения кириллического текста
            //Иначе мы не увидим кириллический текст
            //Если мы работаем только с англоязычными текстами, то шрифт можно не указывать
            BaseFont baseFont = BaseFont.CreateFont(@"C:\Windows\Fonts\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);

            //Обход по всем таблицам датасета (хотя в данном случае мы можем опустить
            //Так как в нашей бд только одна таблица)
            for (int i = 0; i < myDataSet.Tables.Count; i++)
            {
                //Создаем объект таблицы и передаем в нее число столбцов таблицы из нашего датасета
                PdfPTable table = new PdfPTable(myDataSet.Tables[i].Rows.Count);

                //Добавим в таблицу общий заголовок
                PdfPCell cell = new PdfPCell(new Phrase((i%4)+1+"   "+myDataSet.Tables[i].TableName, font));
                cell.Rowspan=myDataSet.Tables[i].Columns.Count;
                cell.Colspan = myDataSet.Tables[i].Rows.Count;
                cell.HorizontalAlignment = 1;
                //Убираем границу первой ячейки, чтобы балы как заголовок
                cell.Border = 1;
                table.AddCell(cell);

                //Добавляем все остальные ячейки

                for (int k = 0; k < myDataSet.Tables[i].Columns.Count; k++)
                {
                    for (int j = 0; j < myDataSet.Tables[i].Rows.Count; j++)
                    {
                        PdfPCell cell1 = new PdfPCell(new Phrase(myDataSet.Tables[i].Rows[j][k].ToString(), font));
                        cell.Rowspan = myDataSet.Tables[i].Columns.Count;
                        cell.Colspan = myDataSet.Tables[i].Rows.Count;
                        table.AddCell(cell1);
                    }
                }
                //Добавляем таблицу в документ
                doc.Add(table);
            }
            //Закрываем документ
            doc.Close();

           // MessageBox.Show("Pdf-документ сохранен");
        }
    }
}
