using AccesoDatos;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System
    ;using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI_Principal.Properties;
using System.Resources;
using System.Xml.Linq;
using System.Windows.Forms.Design;
using Dominio;
using System.Data.SqlClient;

namespace GUI_Principal.Factura
{
    public class Invoice : ConexionSQL
    {
        public void GeneratePDFInvoice(string rutaArchivoPDF, string dui)
        {
            string rutaImagen = "https://res.cloudinary.com/dsiy0tpfx/image/upload/v1685213952/1_depzqp.png";

            // Agregar título
            float pieAlto = 10f;

            Document documento = new Document(PageSize.A4.Rotate());
            documento.SetMargins(5f, 5f, 5f, documento.BottomMargin + pieAlto); // left, right, up, down

            PdfWriter escritor = PdfWriter.GetInstance(documento, new FileStream(rutaArchivoPDF, FileMode.Create));


            escritor.PageEvent = new NumeradorPagina("Desarrollado por G.E.I.J", -5);

            documento.Open();

            #region -> datos
            string consultaSQL = "SELECT p.Nombre_Paciente, p.Apellidos_Paciente, p.Telefono_Paciente, p.Direccion_Paciente, c.Fecha_HoraCreacion, c.CreadoPor FROM Paciente p\r\nJOIN Citas c ON p.Dui = c.dui WHERE c.dui = @dui;"; // Reemplaza "Paciente" por el nombre de tu tabla y "dui" por el nombre de tu columna de identificación del cliente
            int clienteId = Convert.ToInt32(dui.ToString());
            string nombreCliente = "";
            string apellidoCliente = "";
            int telefonoCliente = 1;
            string direccionClient = "";
            DateTime dateCreation = DateTime.MinValue;
            
            string creadaPor = "";

            DateTime dateTime = DateTime.Now;
            using (var conexion = GetConnection())
            {
                conexion.Open();

                using (SqlCommand comando = new SqlCommand(consultaSQL, conexion))
                {
                    comando.Parameters.AddWithValue("@dui", clienteId); // Reemplaza "clienteId" con el valor del DUI del cliente que deseas obtener

                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            nombreCliente = lector.GetString(0);
                            apellidoCliente = lector.GetString(1);
                            telefonoCliente = Convert.ToInt32(lector.GetValue(2));
                            direccionClient = lector.GetString(3);
                            dateCreation = lector.GetDateTime(4);
                        }
                    }
                }

                conexion.Close();
            }
            #endregion


            #region-> DataHead


            Font fuenteEncabezado = new Font(Font.FontFamily.HELVETICA, 20, Font.BOLD);
            Font fuenteCliente = new Font(Font.FontFamily.HELVETICA, 12, Font.NORMAL);
            Font Infortation = new Font(Font.FontFamily.HELVETICA, 12, Font.NORMAL);
            Font fuenteDetalles = new Font(Font.FontFamily.HELVETICA, 10, Font.NORMAL);
            Font fuenteTotal = new Font(Font.FontFamily.HELVETICA, 12, Font.BOLD);

            // Agregar imagen
            Image imagen = Image.GetInstance(rutaImagen);
            imagen.Alignment = Element.ALIGN_LEFT;
            imagen.ScaleToFit(100f, 100f); // Ajusta el tamaño de la imagen según tus necesidades
            imagen.SetAbsolutePosition(documento.Left, documento.Top - imagen.ScaledHeight); // Ajusta la posición de la imagen

            documento.Add(imagen);

            // Agregar el encabezado
            Paragraph encabezado = new Paragraph("Hospital Privado Buena Vida", fuenteEncabezado);
            encabezado.Alignment = Element.ALIGN_CENTER;
            encabezado.SpacingBefore = 45;
            documento.Add(encabezado);

            Paragraph Information1 = new Paragraph("NIT: 155464168468-1", Infortation);
            Information1.Alignment = Element.ALIGN_CENTER;
            Information1.SpacingAfter = 10;
            documento.Add(Information1);

            Paragraph Information = new Paragraph("Soyapango, calle principal, San Salvador", Infortation);
            Information.Alignment = Element.ALIGN_CENTER;
            Information.SpacingAfter = -5;
            documento.Add(Information);

            Paragraph InformationPhone = new Paragraph("Teléfono: 7848-4868 3287-4863", Infortation);
            InformationPhone.Alignment = Element.ALIGN_CENTER;
            InformationPhone.SpacingAfter = 8;
            documento.Add(InformationPhone);

            #endregion

            #region -> datoUser
            // Datos
            PdfPTable tableDatos = new PdfPTable(2); // 2 columnas para los pares de datos
            tableDatos.SpacingAfter = 8;
            tableDatos.SpacingBefore = 18;
            // Establecer el color de las líneas en blanco
            tableDatos.DefaultCell.Border = Rectangle.NO_BORDER;

            // Agregar los pares de datos a la tabla

            // Agregar los pares de datos a la tabla
            ModeloPaciente p = new ModeloPaciente();
            string nombre = "test";
            PdfPCell cell1 = new PdfPCell(new Phrase("Nombre: " + nombreCliente, Infortation));
            cell1.PaddingBottom = 8f;

            cell1.Border = Rectangle.NO_BORDER;
            tableDatos.AddCell(cell1);

            PdfPCell cell2 = new PdfPCell(new Phrase("Apellido: "+ apellidoCliente, Infortation));
            cell2.PaddingBottom = 8f;
            cell2.Border = Rectangle.NO_BORDER;
            tableDatos.AddCell(cell2);

            PdfPCell cell3 = new PdfPCell(new Phrase("Dirección: "+ direccionClient, Infortation));
            cell3.PaddingBottom = 8f;
            cell3.Border = Rectangle.NO_BORDER;
            tableDatos.AddCell(cell3);

            PdfPCell cell4 = new PdfPCell(new Phrase("Teléfono: "+ telefonoCliente, Infortation));
            cell4.PaddingBottom = 8f;
            cell4.Border = Rectangle.NO_BORDER;
            tableDatos.AddCell(cell4);

            PdfPCell cell5 = new PdfPCell(new Phrase("DUI: "+clienteId, Infortation));
            cell5.PaddingBottom = 8f;
            cell5.Border = Rectangle.NO_BORDER;
            tableDatos.AddCell(cell5);

            PdfPCell cell6 = new PdfPCell(new Phrase("Fecha de cita: "+ dateCreation.ToString(), Infortation));
            cell6.PaddingBottom = 8f;
            cell6.Border = Rectangle.NO_BORDER;
            tableDatos.AddCell(cell6);

            PdfPCell cell7 = new PdfPCell(new Phrase("Fecha de factura: "+dateTime, Infortation));
            cell7.PaddingBottom = 8f;
            cell7.Border = Rectangle.NO_BORDER; 
            tableDatos.AddCell(cell7);

            PdfPCell cell8 = new PdfPCell(new Phrase("Creada por: " + creadaPor, Infortation));
            cell8.PaddingBottom = 8f;
            cell8.Border = Rectangle.NO_BORDER;
            tableDatos.AddCell(cell8);

            // Añadir la tabla al documento
            documento.Add(tableDatos);
            #endregion

            #region -> dataBody
            // Agregar la tabla de detalles de la factura
            PdfPTable tablaDetalles = new PdfPTable(4); // 4 columnas: codigo, conulta,cantidad, precio, 
            tablaDetalles.WidthPercentage = 100;
            tablaDetalles.SetWidths(new float[] { 1f, 3f, 2f, 1f});

            // Agregar encabezados de columna
            PdfPCell codigoConsulta = new PdfPCell(new Phrase("Codigo", fuenteDetalles));
            PdfPCell celdaProducto = new PdfPCell(new Phrase("Descripcion", fuenteDetalles));
            PdfPCell celdaCantidad = new PdfPCell(new Phrase("Cantidad", fuenteDetalles));
            PdfPCell celdaPrecio = new PdfPCell(new Phrase("Precio", fuenteDetalles));
            codigoConsulta.BackgroundColor = new BaseColor(192, 192, 192);
            celdaProducto.BackgroundColor = new BaseColor(192, 192, 192); // Color de fondo para el encabezado
            celdaCantidad.BackgroundColor = new BaseColor(192, 192, 192);
            celdaPrecio.BackgroundColor = new BaseColor(192, 192, 192);
            tablaDetalles.AddCell(codigoConsulta);
            tablaDetalles.AddCell(celdaProducto);
            tablaDetalles.AddCell(celdaCantidad);
            tablaDetalles.AddCell(celdaPrecio);

            documento.Add(tablaDetalles);

            // Agregar la información del cliente
            Paragraph clienteInfo = new Paragraph("test", fuenteCliente);
            clienteInfo.SpacingAfter = 10;
            documento.Add(clienteInfo);

            Paragraph direccionInfo = new Paragraph("test", fuenteCliente);
            direccionInfo.SpacingAfter = 20;
            documento.Add(direccionInfo);

            BaseColor redColor = BaseColor.RED;
            fuenteTotal = new Font(Font.FontFamily.HELVETICA, 12, Font.BOLD, redColor);

            Paragraph totalInfo = new Paragraph("Total ", fuenteTotal);
            totalInfo.Alignment = Element.ALIGN_RIGHT;
            totalInfo.SpacingBefore = 20;
            documento.Add(totalInfo);

            #endregion

            #region -> linea   
            
            PdfContentByte underContent = escritor.DirectContent;

            // Definir los puntos de inicio y fin de la línea
            float linePositionY1 = 100; // Posición vertical de la línea (ajusta según tus necesidades)
            float lineStartX1 = documento.LeftMargin; // Posición horizontal de inicio de la línea
            float lineEndX1 = documento.PageSize.Width - documento.RightMargin; // Posición horizontal de fin de la línea

            // Configurar el color y grosor de la línea
            underContent.SetRGBColorStroke(0, 0, 0); // Color de la línea (negro en este caso)
            underContent.SetLineWidth(1); // Grosor de la línea (ajusta según tus necesidades)

            // Dibujar la línea
            underContent.MoveTo(lineStartX1, linePositionY1); // Mover a la posición de inicio de la línea
            underContent.LineTo(lineEndX1, linePositionY1); // Dibujar la línea hasta la posición de fin
            underContent.Stroke(); //

            #endregion


            documento.Close();

            Process.Start(rutaArchivoPDF);
        }




        private void addTableDetail()
        {
           // Reemplaza esto con la cadena de conexión a tu base de datos
           

        }
    }
}
