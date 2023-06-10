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
using System.Security.Cryptography;
using System.Security.Policy;
using static System.Windows.Forms.Design.AxImporter;

namespace AccesoDatos
{
    public class ReportesD : ConexionSQL
    {

        public void GenerarInformePDF(string rutaArchivoPDF, string tabla, DateTime hasta, DateTime desde, int dato, int dato2, int year, int year2, int option )
        {
            string rutaImagen = "https://res.cloudinary.com/dsiy0tpfx/image/upload/v1685213952/1_depzqp.png";

            Document documento = new Document(PageSize.A4.Rotate());
            documento.SetMargins(20f, 20f, 20f, documento.BottomMargin + 10f); // left, right, up, down

            PdfWriter escritor = PdfWriter.GetInstance(documento, new FileStream(rutaArchivoPDF, FileMode.Create));

            string titulo = "Informe PDF de la tabla " + tabla;

            // Crear el evento de encabezado
            escritor.PageEvent = new HeaderEvent(titulo, rutaImagen);

            documento.Open();

            if (tabla == "Citas")
            {
                if (tabla == "Citas")
                {
                    string mensaje = "Vistar de Citas totales de este perido de tiempo \n\n";
                    Font fuenteTotal = new Font(Font.FontFamily.HELVETICA, 12, Font.BOLD);
                    Paragraph encabezado1 = new Paragraph("" + mensaje, fuenteTotal);
                    encabezado1.Alignment = Element.ALIGN_CENTER;
                    encabezado1.SpacingBefore = 45;
                    documento.Add(encabezado1);
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

                    string fechaFormateadaD = desde.Date.ToString("dd/MM/yyyy");
                    string fechaFormateadaH = hasta.Date.ToString("dd/MM/yyyy");
                    documento.Add(tablaPDF);
                    Font fuenteEncabezado = new Font(Font.FontFamily.HELVETICA, 20, Font.BOLD);
                    Paragraph encabezado = new Paragraph("\n \n Total vendido en el período " + fechaFormateadaD + " hasta: " + fechaFormateadaH + "\nTotal: $" + total, fuenteEncabezado);
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
            }
            else if (tabla == "Ventas")
            {

                if (option == 1) { 

                    string  mensaje = "Durante estos mes del presente año 2023, las ventas han sido sólidas y prometedoras. Nuestro equipo de ventas ha trabajado arduamente para alcanzar y superar nuestros objetivos. Hemos experimentado un aumento constante en la demanda de nuestros servicios, lo que ha impulsado un crecimiento significativo en nuestros ingresos. \n\n";
                    Font fuenteTotal = new Font(Font.FontFamily.HELVETICA, 12, Font.BOLD);
                    Paragraph encabezado = new Paragraph(""+ mensaje, fuenteTotal);
                    encabezado.Alignment = Element.ALIGN_CENTER;
                    encabezado.SpacingBefore = 45;
                    documento.Add(encabezado);


                    #region -> Ventas
                    var table = VentasXMeses(dato, dato2);
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
                else {
                    #region ->VentasYear
                    string mensaje = "Durante estos años, las ventas han sido sólidas y prometedoras. Nuestro equipo de ventas ha trabajado arduamente para alcanzar y superar nuestros objetivos. Hemos experimentado un aumento constante en la demanda de nuestros servicios, lo que ha impulsado un crecimiento significativo en nuestros ingresos.\n \n";
                    Font fuenteTotal = new Font(Font.FontFamily.HELVETICA, 12, Font.BOLD);
                    Paragraph encabezado = new Paragraph("" + mensaje, fuenteTotal);
                    encabezado.Alignment = Element.ALIGN_CENTER;
                    encabezado.SpacingBefore = 45;
                    documento.Add(encabezado);
                    var table = VentasXYear(year, year2);
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

        public DataTable VentasXMeses(int dato, int dato2)
        {

            DataTable table = new DataTable();

            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = @"
                ;WITH Meses AS (
                  SELECT 1 AS MesNum, 'Enero' AS MesNombre
                  UNION ALL
                  SELECT 2 AS MesNum, 'Febrero' AS MesNombre
                  UNION ALL
                  SELECT 3 AS MesNum, 'Marzo' AS MesNombre
                  UNION ALL
                  SELECT 4 AS MesNum, 'Abril' AS MesNombre
                  UNION ALL
                  SELECT 5 AS MesNum, 'Mayo' AS MesNombre
                  UNION ALL
                  SELECT 6 AS MesNum, 'Junio' AS MesNombre
                  UNION ALL
                  SELECT 7 AS MesNum, 'Julio' AS MesNombre
                  UNION ALL
                  SELECT 8 AS MesNum, 'Agosto' AS MesNombre
                  UNION ALL
                  SELECT 9 AS MesNum, 'Septiembre' AS MesNombre
                  UNION ALL
                  SELECT 10 AS MesNum, 'Octubre' AS MesNombre
                  UNION ALL
                  SELECT 11 AS MesNum, 'Noviembre' AS MesNombre
                  UNION ALL
                  SELECT 12 AS MesNum, 'Diciembre' AS MesNombre
                )
                SELECT Meses.MesNombre AS [Nombre Meses], ISNULL(SUM(Citas.Precio), 0) AS [Total Vendido]
                FROM Meses
                LEFT JOIN [dbo].[Citas] ON Meses.MesNum = MONTH([Fecha_HoraCita])
                                        AND YEAR([Fecha_HoraCita]) = YEAR(GETDATE())
                                        AND MONTH([Fecha_HoraCita]) BETWEEN @MesInicial AND @MesFinal
                GROUP BY Meses.MesNum, Meses.MesNombre
                HAVING ISNULL(SUM(Citas.Precio), 0) <> 0
                ORDER BY Meses.MesNum";
                    comando.CommandType = CommandType.Text;
                    comando.Parameters.AddWithValue("@MesInicial", dato);
                    comando.Parameters.AddWithValue("@MesFinal", dato2);
                    SqlDataReader lectura = comando.ExecuteReader();
                    table.Load(lectura);

                    return table;
                }
            }
        }

        public DataTable VentasXYear(int year, int year2) {

            DataTable table = new DataTable();

            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = @"
                ;WITH Meses AS (
  SELECT 1 AS MesNum, 'Enero' AS MesNombre
  UNION ALL
  SELECT 2 AS MesNum, 'Febrero' AS MesNombre
  UNION ALL
  SELECT 3 AS MesNum, 'Marzo' AS MesNombre
  -- Agrega más meses según sea necesario
  UNION ALL
  SELECT 4 AS MesNum, 'Abril' AS MesNombre
  UNION ALL
  SELECT 5 AS MesNum, 'Mayo' AS MesNombre
  UNION ALL
  SELECT 6 AS MesNum, 'Junio' AS MesNombre
  UNION ALL
  SELECT 7 AS MesNum, 'Julio' AS MesNombre
  UNION ALL
  SELECT 8 AS MesNum, 'Agosto' AS MesNombre
  UNION ALL
  SELECT 9 AS MesNum, 'Septiembre' AS MesNombre
  UNION ALL
  SELECT 10 AS MesNum, 'Octubre' AS MesNombre
  UNION ALL
  SELECT 11 AS MesNum, 'Noviembre' AS MesNombre
  UNION ALL
  SELECT 12 AS MesNum, 'Diciembre' AS MesNombre
)
SELECT Meses.MesNombre AS [Nombre Meses], 
       YEAR([Fecha_HoraCita]) AS Año,
       ISNULL(SUM(Citas.Precio), 0) AS Total
FROM Meses
LEFT JOIN [dbo].[Citas] ON MONTH([Fecha_HoraCita]) = Meses.MesNum
WHERE YEAR([Fecha_HoraCita]) BETWEEN @AñoDesde AND @AñoHasta
      AND MONTH([Fecha_HoraCita]) BETWEEN 1 AND 12
GROUP BY Meses.MesNum, Meses.MesNombre, YEAR([Fecha_HoraCita])
HAVING ISNULL(SUM(Citas.Precio), 0) <> 0
ORDER BY Año, Meses.MesNum";
                    comando.CommandType = CommandType.Text;
                    comando.Parameters.AddWithValue("@AñoDesde", year);
                    comando.Parameters.AddWithValue("@AñoHasta", year2);
                    SqlDataReader lectura = comando.ExecuteReader();
                    table.Load(lectura);

                    return table;
                }
            }
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

    
    }
}
