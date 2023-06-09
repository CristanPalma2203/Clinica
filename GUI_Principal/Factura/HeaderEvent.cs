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


        public HeaderEvent(string titulo)
        {
            this.titulo = titulo;

            // Configurar el encabezado común a todas las páginas
            headerTable = new PdfPTable(1);
            headerTable.TotalWidth = PageSize.A4.Rotate().Width - 40; // Ajustar el ancho de la tabla según tus necesidades
            headerTable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

            PdfPCell cell = new PdfPCell(new Phrase(titulo));
            cell.Border = PdfPCell.NO_BORDER;
            cell.PaddingTop = 10f;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE; // Alineación vertical al centro
            headerTable.AddCell(cell);
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


    }


}
