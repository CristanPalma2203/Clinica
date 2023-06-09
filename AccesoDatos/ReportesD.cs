using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using GUI_Principal.Factura;

namespace AccesoDatos
{

    public class ReportesD : ConexionSQL
    {
    
        public void GenerarInformePDF(string rutaArchivoPDF, string tabla, DateTime hasta, DateTime desde)
        {
            string rutaImagen = "https://res.cloudinary.com/dsiy0tpfx/image/upload/v1685213952/1_depzqp.png";

            Document documento = new Document(PageSize.A4.Rotate());
            documento.SetMargins(20f, 20f, 20f, documento.BottomMargin + 10f); // left, right, up, down

            PdfWriter escritor = PdfWriter.GetInstance(documento, new FileStream(rutaArchivoPDF, FileMode.Create));

            string titulo = "Informe PDF de la tabla " + tabla;

            // Crear el evento de encabezado
            escritor.PageEvent = new HeaderEvent(titulo);

            documento.Open();

            if (tabla == "Citas")
            { 
                #region ->citas
                var table = RetornarTabla2(tabla, hasta, desde);
                int columnas = table.Columns.Count;
                int filas = table.Rows.Count;

                PdfPTable tablaPDF = new PdfPTable(columnas);
                tablaPDF.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                tablaPDF.DefaultCell.Padding = 5f;

                for (int i = 0; i < columnas; i++)
                {
                    tablaPDF.AddCell(table.Columns[i].ColumnName);
                }

                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        tablaPDF.AddCell(table.Rows[i][j].ToString());
                    }
                }
                
                decimal total = 0;
                using (var conexion = GetConnection())
                {
                    conexion.Open();
                    using (var comando = new SqlCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandText = "SELECT SUM(Precio) AS total FROM Citas WHERE Fecha_HoraCreacion BETWEEN @desde AND @hasta";
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.AddWithValue("@desde", desde);
                        comando.Parameters.AddWithValue("@hasta", hasta);

                        using (SqlDataReader lectura = comando.ExecuteReader())
                        {
                            if (lectura.Read())
                            {
                                if (!lectura.IsDBNull(0))
                                {
                                    double valorTotal = lectura.GetDouble(0);
                                    total = Convert.ToDecimal(valorTotal);
                                }
                            }
                        }
                    }
                }

                documento.Add(tablaPDF);
                Font fuenteEncabezado = new Font(Font.FontFamily.HELVETICA, 20, Font.BOLD);
                Paragraph encabezado = new Paragraph("Total vendido en el período " + desde + " hasta: " + hasta + "\nTotal: $" + total, fuenteEncabezado);
                encabezado.Alignment = Element.ALIGN_CENTER;
                encabezado.SpacingBefore = 45;
                documento.Add(encabezado);
                #endregion
            }
            else
            {
                #region -> NoCitas
                var table = RetornarTabla(tabla);
                int columnas = table.Columns.Count;
                int filas = table.Rows.Count;
                PdfPTable tablaPDF2 = new PdfPTable(columnas);

                tablaPDF2.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                tablaPDF2.DefaultCell.Padding = 5f;


                tablaPDF2.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                tablaPDF2.DefaultCell.Padding = 5f;

                for (int i = 0; i < columnas; i++)
                {
                    tablaPDF2.AddCell(table.Columns[i].ColumnName);
                }

                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        tablaPDF2.AddCell(table.Rows[i][j].ToString());
                    }
                    
                }

                documento.Add(tablaPDF2);
                #endregion
            }
            int totalPages = escritor.PageNumber;
            documento.Close();
            escritor.Close();
            Process.Start(rutaArchivoPDF);
        }

        public DataTable RetornarTabla2(string tabla, DateTime hasta, DateTime desde)
        {
            DataTable table = new DataTable();
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {

                    comando.Connection = conexion;
                    comando.CommandText = "SELECT * FROM " + tabla + " WHERE Fecha_HoraCreacion BETWEEN @desde AND @hasta";
                    comando.CommandType = CommandType.Text;

                    // Agregar parámetros y establecer sus valores
                    comando.Parameters.AddWithValue("@desde", desde);
                    comando.Parameters.AddWithValue("@hasta", hasta);

                    SqlDataReader lectura = comando.ExecuteReader();
                    table.Load(lectura);

                    return table;
                }


            }
        }

        public DataTable RetornarTabla(string tabla)
        {
            DataTable table = new DataTable();

            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "select * from " + tabla;
                    comando.CommandType = CommandType.Text;
                    SqlDataReader lectura = comando.ExecuteReader();
                    table.Load(lectura);

                    return table;
                }
            }
        }

        public List<string> Tablas()
        {
            List<string> nombreTablas = new List<string>();
            string consultaSQL = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'";

            using (var conexion = GetConnection())
            {
                conexion.Open();

                using (SqlCommand comando = new SqlCommand(consultaSQL, conexion))
                {
                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            string nombreTabla = lector.GetString(0);
                            nombreTablas.Add(nombreTabla);
                        }
                    }
                }
                conexion.Close();
            }

            return nombreTablas;
        }
      
           
        
    }




    public class NumeradorPagina : PdfPageEventHelper
    {
        private string nombre;
        private float pieAlto;
        private bool primeraPagina = true;

        public NumeradorPagina(string nombre, float pieAlto)
        {
            this.nombre = nombre;
            this.pieAlto = pieAlto;
        }

        public override void OnStartPage(PdfWriter writer, Document document)
        {
            if (primeraPagina)
            {
                string fecha = DateTime.Now.ToString("yyyy-MM-dd");
                string hora = DateTime.Now.ToString("HH:mm:ss");

                PdfContentByte cb = writer.DirectContent;

                BaseFont fuente = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                float tamanoFuente = 10;

                float encabezadoAncho = document.PageSize.Width - document.LeftMargin - document.RightMargin - 45;
                float encabezadoAltura = document.PageSize.Height - document.TopMargin + pieAlto;

                // Cargar la imagen del logo
                string rutaLogo = "https://res.cloudinary.com/dsiy0tpfx/image/upload/v1685213952/1_depzqp.png"; // Reemplaza con la ruta de tu imagen
                Image logo = Image.GetInstance(rutaLogo);
                logo.ScaleToFit(50f, 50f); // Ajusta el tamaño del logo según tus necesidades

                // Posicionar el logo en el encabezado
                float xLogo = document.LeftMargin;
                float yLogo = encabezadoAltura - 50f; // Ajusta la posición vertical del logo

                // Agregar el logo al contenido de la página
                cb.AddImage(logo, logo.Width, 0, 0, logo.Height, xLogo, yLogo);

                float xFecha = encabezadoAncho - fuente.GetWidthPoint(fecha, tamanoFuente);
                float xHora = encabezadoAncho - fuente.GetWidthPoint(hora, tamanoFuente);

                cb.BeginText();
                cb.SetFontAndSize(fuente, tamanoFuente);
                cb.SetTextMatrix(xFecha, encabezadoAltura - 15f);
                cb.ShowText("Fecha : " + fecha);
                cb.EndText();

                cb.BeginText();
                cb.SetFontAndSize(fuente, tamanoFuente);
                cb.SetTextMatrix(xHora, encabezadoAltura - 25f);
                cb.ShowText("Hora : " + hora);
                cb.EndText();

                primeraPagina = false;
            }
        }

        public override void OnEndPage(PdfWriter writer, Document document)
        {
            int numeroPagina = writer.PageNumber;

            PdfContentByte cb = writer.DirectContent;

            BaseFont fuente = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            float tamanoFuente = 10;

            float pieAncho = document.PageSize.Width - document.LeftMargin - document.RightMargin;
            float pieAltura = document.BottomMargin + pieAlto;

            string textoNumeroPagina = "Página " + numeroPagina;

            float xNumeroPagina = pieAncho - fuente.GetWidthPoint(textoNumeroPagina, tamanoFuente);

            cb.BeginText();
            cb.SetFontAndSize(fuente, tamanoFuente);
            cb.SetTextMatrix(xNumeroPagina, pieAltura);
            cb.ShowText(textoNumeroPagina);
            cb.EndText();

            float xNombre = document.Left + 20;

            cb.BeginText();
            cb.SetFontAndSize(fuente, tamanoFuente);
            cb.SetTextMatrix(xNombre, pieAltura);
            cb.ShowText(nombre);
            cb.EndText();

            base.OnEndPage(writer, document);
        }
    }
}
