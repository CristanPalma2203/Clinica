using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Principal.Factura
{
    public class HeaderEvent : PdfPageEventHelper
    {
        private string titulo;
        private PdfPTable headerTable;
        private int pageNumber;
        public HeaderEvent(string titulo)
        {
            this.titulo = titulo;
   

            // Configurar el encabezado común a todas las páginas
            headerTable = new PdfPTable(1);
            headerTable.TotalWidth = PageSize.A4.Rotate().Width - 40; // Ajustar el ancho de la tabla según tus necesidades
            headerTable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;



            // Celda para el título
            PdfPCell tituloCell = new PdfPCell(new Phrase(titulo));
            tituloCell.Border = PdfPCell.NO_BORDER;
            tituloCell.PaddingTop = 10f;
            tituloCell.VerticalAlignment = Element.ALIGN_MIDDLE;

            headerTable.AddCell(tituloCell);
        }

        public override void OnStartPage(PdfWriter writer, Document document)
        {
            base.OnStartPage(writer, document);

            // Agregar espacio antes de la tabla en las páginas siguientes
            Paragraph space = new Paragraph("\n\n\n");
            document.Add(space);
            document.Add(space);

            // Escribir el encabezado en cada página
            float headerTableHeight = headerTable.TotalHeight;
            float headerTableWidth = headerTable.TotalWidth;

            float headerTableXPosition = (document.PageSize.Width - headerTableWidth) / 2;
            float headerTableYPosition = document.PageSize.Height - document.TopMargin - headerTableHeight;

            headerTable.WriteSelectedRows(0, -1, headerTableXPosition, headerTableYPosition, writer.DirectContent);
        }

        public override void OnEndPage(PdfWriter writer, Document document)
        {
            base.OnEndPage(writer, document);

            // Agregar el número de página en el pie de página
            pageNumber++;
            string pageText = "Página " + pageNumber;
            Rectangle pageSize = document.PageSize;
            BaseFont baseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            float fontHeight = 10f;
            float xPosition = document.LeftMargin;
            float yPosition = document.BottomMargin - 20;

            PdfContentByte canvas = writer.DirectContent;
            canvas.BeginText();
            canvas.SetFontAndSize(baseFont, fontHeight);
            canvas.SetTextMatrix(xPosition, yPosition);
            canvas.ShowText(pageText);
            canvas.EndText();
        }

        public void UpdatePageNumber(int totalPages)
        {
            pageNumber = totalPages;
        }
    }

}
