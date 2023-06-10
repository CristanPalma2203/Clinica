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

        public HeaderEvent(string titulo, string rutaImagen)
        {
            // Configurar el encabezado común a todas las páginas
            headerTable = new PdfPTable(1);
            headerTable.TotalWidth = PageSize.A4.Rotate().Width - 40; // Ajustar el ancho de la tabla según tus necesidades
            headerTable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

            // Tabla interna para el título y la imagen
            PdfPTable innerTable = new PdfPTable(1);

            // Celda para el título
            PdfPCell tituloCell = new PdfPCell(new Phrase(titulo));
            tituloCell.Border = PdfPCell.NO_BORDER;
            tituloCell.HorizontalAlignment = Element.ALIGN_CENTER;
            tituloCell.VerticalAlignment = Element.ALIGN_MIDDLE;

            // Agregar espacio antes del título
            tituloCell.PaddingTop = 10f;

            // Agregar la celda del título a la tabla interna
            innerTable.AddCell(tituloCell);

            // Celda para la imagen
            PdfPCell imagenCell = new PdfPCell();
            imagenCell.Border = PdfPCell.NO_BORDER;
            imagenCell.VerticalAlignment = Element.ALIGN_MIDDLE;

            // Cargar la imagen desde la ruta
            iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(rutaImagen);

            // Ajustar el tamaño de la imagen
            imagen.ScaleToFit(100, 100); // Ajusta los valores de ancho y alto según tus necesidades

            // Agregar la imagen a la celda
            imagenCell.AddElement(imagen);

            // Agregar la celda de imagen a la tabla interna
            innerTable.AddCell(imagenCell);

            // Celda para la tabla interna
            PdfPCell innerTableCell = new PdfPCell(innerTable);
            innerTableCell.Border = PdfPCell.NO_BORDER;

            // Agregar la celda de la tabla interna al encabezado
            headerTable.AddCell(innerTableCell);
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
            headerTable.WriteSelectedRows(0, -1, document.Left, document.Top, writer.DirectContent);
         
        }

        public override void OnEndPage(PdfWriter writer, Document document)
        {
            base.OnEndPage(writer, document);

            // Obtener el número total de páginas
            int totalPages = writer.PageNumber;

            // Obtener el número de la página actual
            int currentPage = writer.CurrentPageNumber;

            // Construir el texto de la página
            string pageText = $"{currentPage} de {totalPages}";

            // Establecer el tamaño y la fuente del texto
            float fontSize = 10f;
            BaseFont baseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            PdfContentByte canvas = writer.DirectContent;
            canvas.BeginText();
            canvas.SetFontAndSize(baseFont, fontSize);

            // Calcular la posición x y y del texto
            float xPosition = document.LeftMargin;
            float yPosition = document.PageSize.GetTop(document.TopMargin) + 10;

            // Escribir el texto de la página en el encabezado
            canvas.SetTextMatrix(xPosition, yPosition);
            canvas.ShowTextAligned(Element.ALIGN_CENTER, pageText, document.PageSize.Width / 2, yPosition, 0);
            canvas.EndText();
        }

    }

}
