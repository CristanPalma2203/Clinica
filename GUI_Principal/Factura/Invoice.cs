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
using GUI_Principal.Formularios_Acciones;

namespace GUI_Principal.Factura
{
    public class Invoice : ConexionSQL
    {
        public void GeneratePDFInvoice(string rutaArchivoPDF, string dui)
        {
            string rutaImagen = "https://res.cloudinary.com/dsiy0tpfx/image/upload/v1685213952/1_depzqp.png";

            // Agregar título
       
            Document documento = new Document(PageSize.A4.Rotate());
            documento.SetMargins(5f, 5f, 5f, documento.BottomMargin ); // left, right, up, down

            PdfWriter escritor = PdfWriter.GetInstance(documento, new FileStream(rutaArchivoPDF, FileMode.Create));


    
            documento.Open();

            #region -> datos

            string consultaSQL = "SELECT p.Nombre_Paciente, p.Apellidos_Paciente, p.Telefono_Paciente, p.Direccion_Paciente, c.Fecha_HoraCreacion, c.CreadoPor, c.num_cita, c.Motivo, c.Precio FROM Paciente p JOIN Citas c ON p.Dui = c.dui WHERE c.dui = @dui;";

            #region -> variables

            int clienteId = Convert.ToInt32(dui.ToString());
            string nombreCliente = "";
            string apellidoCliente = "";
            int telefonoCliente = 1;
            string direccionClient = "";
            DateTime dateCreation = DateTime.MinValue;
            string creadaPor = "";
            string motivoCons = "";
            int idCita = 1;
            decimal precio = 0;
            DateTime dateTime = DateTime.Now;

            #endregion


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
                            creadaPor = lector.GetString(5);
                            idCita = Convert.ToInt32(lector.GetValue(6));
                            motivoCons = lector.GetString(7);
                            precio = Convert.ToDecimal(lector.GetValue(8));
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
            Font Information2 = new Font(Font.FontFamily.HELVETICA, 12, Font.NORMAL);
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
            tableDatos.WidthPercentage = 90;
            tableDatos.SpacingBefore = 18;
            tableDatos.PaddingTop = 40f;
            // Establecer el color de las líneas en blanco
            tableDatos.DefaultCell.Border = Rectangle.NO_BORDER;

            // Agregar los pares de datos a la tabla
            PdfPCell cell1 = new PdfPCell(new Phrase("Nombre: " + nombreCliente, Information2));
            cell1.PaddingBottom = 8f;

            cell1.Border = Rectangle.NO_BORDER;
            tableDatos.AddCell(cell1);

            PdfPCell cell2 = new PdfPCell(new Phrase("Apellido: "+ apellidoCliente, Information2));
            cell2.PaddingBottom = 8f;
            cell2.Border = Rectangle.NO_BORDER;
            tableDatos.AddCell(cell2);

            PdfPCell cell5 = new PdfPCell(new Phrase("DUI: " + clienteId, Information2));
            cell5.PaddingBottom = 8f;
            cell5.Border = Rectangle.NO_BORDER;
            tableDatos.AddCell(cell5);

            PdfPCell cell3 = new PdfPCell(new Phrase("Dirección: "+ direccionClient, Information2));
            cell3.PaddingBottom = 8f;
            cell3.Border = Rectangle.NO_BORDER;
            tableDatos.AddCell(cell3);

            PdfPCell cell4 = new PdfPCell(new Phrase("Teléfono: "+ telefonoCliente, Information2));
            cell4.PaddingBottom = 8f;
            cell4.Border = Rectangle.NO_BORDER;
            tableDatos.AddCell(cell4);

            PdfPCell cell6 = new PdfPCell(new Phrase("Fecha de cita: "+ dateCreation.ToString(), Information2));
            cell6.PaddingBottom = 8f;
            cell6.Border = Rectangle.NO_BORDER;
            tableDatos.AddCell(cell6);

            PdfPCell cell7 = new PdfPCell(new Phrase("Fecha de factura: "+dateTime, Information2));
            cell7.PaddingBottom = 8f;
            cell7.Border = Rectangle.NO_BORDER; 
            tableDatos.AddCell(cell7);

            PdfPCell cell8 = new PdfPCell(new Phrase("Creada por: " + creadaPor, Information2));
            cell8.PaddingBottom = 8f;
            cell8.Border = Rectangle.NO_BORDER;
            tableDatos.AddCell(cell8);

            // Añadir la tabla al documento
            documento.Add(tableDatos);

            #endregion

            Paragraph espacio = new Paragraph(" "); // Párrafo vacío
            espacio.SpacingAfter = 10;
            documento.Add(espacio);

            #region -> dataBody

            PdfPTable tablaDetalles = new PdfPTable(4); // Añadimos una columna adicional
            tablaDetalles.WidthPercentage = 90;
            tablaDetalles.PaddingTop = 25f;
            
           
            tablaDetalles.SetWidths(new float[] { 1f, 4f, 1f, 1f }); 

                        // Ajustar tamaño de fuente y separación
            Font fuenteDetalles1 = new Font(Font.FontFamily.HELVETICA, 14, Font.BOLD);
            Font fuenteCliente1 = new Font(Font.FontFamily.HELVETICA, 12);
            fuenteDetalles.Color = BaseColor.BLACK;
            fuenteCliente.Color = BaseColor.BLACK;
            float spacingAfter = 10;

            // Agregar encabezados de columna
            PdfPCell codigoConsulta = new PdfPCell(new Phrase("Codigo", fuenteDetalles1));
            codigoConsulta.Padding = 6f;
            codigoConsulta.HorizontalAlignment = Element.ALIGN_CENTER;


            PdfPCell celdaProducto = new PdfPCell(new Phrase("Descripcion", fuenteDetalles1));
            celdaProducto.Padding = 6f;
            celdaProducto.HorizontalAlignment = Element.ALIGN_CENTER;

            PdfPCell celdaCantidad = new PdfPCell(new Phrase("Cantidad", fuenteDetalles1));
            celdaCantidad.Padding = 6f;
            celdaCantidad.HorizontalAlignment = Element.ALIGN_CENTER;

            PdfPCell celdaPrecio = new PdfPCell(new Phrase("Precio", fuenteDetalles1));
            celdaPrecio.Padding = 6f;
            celdaPrecio.HorizontalAlignment = Element.ALIGN_CENTER;

            codigoConsulta.BackgroundColor = new BaseColor(192, 192, 192);
            celdaProducto.BackgroundColor = new BaseColor(192, 192, 192);
            celdaCantidad.BackgroundColor = new BaseColor(192, 192, 192);
            celdaPrecio.BackgroundColor = new BaseColor(192, 192, 192);
            tablaDetalles.AddCell(codigoConsulta);
            tablaDetalles.AddCell(celdaProducto);
            tablaDetalles.AddCell(celdaCantidad);
            tablaDetalles.AddCell(celdaPrecio);

            // Agregar la información del cliente como filas de la tabla
            PdfPCell idCitaCell = new PdfPCell(new Phrase(idCita.ToString(), fuenteCliente1));
            idCitaCell.PaddingTop = 10f; 
            idCitaCell.PaddingBottom = 10f;

            PdfPCell motivoConsCell = new PdfPCell(new Phrase(motivoCons, fuenteCliente1));
            motivoConsCell.PaddingTop = 10f; 
            motivoConsCell.PaddingBottom = 10f;

            PdfPCell cantidadCell = new PdfPCell(new Phrase("1", fuenteCliente1));
            cantidadCell.PaddingTop = 10f;
            cantidadCell.PaddingBottom = 10f;

            PdfPCell precioCell = new PdfPCell(new Phrase("$ " + precio.ToString(), fuenteCliente1));
            precioCell.PaddingTop = 10f;
            precioCell.PaddingBottom = 10f;

            tablaDetalles.AddCell(idCitaCell);
            tablaDetalles.AddCell(motivoConsCell);
            tablaDetalles.AddCell(cantidadCell);
            tablaDetalles.AddCell(precioCell);

            documento.Add(tablaDetalles);

            BaseColor redColor = BaseColor.RED;
            Font fuenteTotal1 = new Font(Font.FontFamily.HELVETICA, 16, Font.BOLD, redColor);

            Paragraph totalInfo = new Paragraph("Total: $"+precio , fuenteTotal1);
            totalInfo.Alignment = Element.ALIGN_RIGHT;
            totalInfo.SpacingBefore = 30; // Aumentar separación
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



 
    }
}
