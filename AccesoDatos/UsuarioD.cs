using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaComun;
using CapaComun.Cache;
using System.Collections;

namespace AccesoDatos
{
    public class UsuarioD : ConexionSQL
    {

        public bool Acceso(string usuario, string contraseña)
        {
             
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {


                    comando.Connection = conexion;
                    comando.CommandText = "consultar_usuario";
                    comando.Parameters.AddWithValue("@usuario", usuario);
                    comando.Parameters.AddWithValue("@contraseña", contraseña);
                    comando.CommandType = CommandType.StoredProcedure;
                    SqlDataReader lectura = comando.ExecuteReader();
                    if (lectura.HasRows)
                    {
                        while (lectura.Read())
                        {
                            CacheDeUsuario.idUser = lectura.GetString(0);
                            CacheDeUsuario.NonbreUsuario = lectura.GetString(1);
                            CacheDeUsuario.ApellidoUsuario = lectura.GetString(2);
                            CacheDeUsuario.CargoUsuario = lectura.GetString(3);
                            CacheDeUsuario.Contraseña = lectura.GetString(4);

                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }

            }

        }


        public void EditarUsuario(string usuario, string nombre, string apellido, string contraseña)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {


                    comando.Connection = conexion;
                    comando.CommandText = "actualizar_Usuario";
                    comando.Parameters.AddWithValue("@usuario", usuario);
                    comando.Parameters.AddWithValue("@contraseña", contraseña);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@apellido", apellido);

                    comando.CommandType = CommandType.StoredProcedure;
                    SqlDataReader lectura = comando.ExecuteReader();



                }

            }


        }
        ArrayList fecha = new ArrayList();
        ArrayList monto = new ArrayList();
        public void Grafica()
        {

            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {


                    comando.Connection = conexion;
                    //comando.CommandText = " select CAST(MONTH(Fecha_HoraCita) AS VARCHAR(2)),datename(MONTH, CONVERT(date, Fecha_HoraCita)) + ' ' + CONVERT(varchar(50), DATEPART(year, convert(date, Fecha_HoraCita))) as fecha, convert(varchar(50), SUM(Precio)) from Citas group by CAST(MONTH(Fecha_HoraCita) AS VARCHAR(2)),datename(MONTH, CONVERT(date, Fecha_HoraCita)) + ' ' + CONVERT(varchar(50), DATEPART(year, convert(date, Fecha_HoraCita))) order by CAST(MONTH(Fecha_HoraCita) AS VARCHAR(2)) asc ";
                    comando.CommandText = "select CAST(MONTH(Fecha_HoraCita) AS VARCHAR(2)),datename(MONTH,CONVERT(date, Fecha_HoraCita)) + ' ' + CONVERT(varchar(50),DATEPART(year,convert(date,Fecha_HoraCita ))) as fecha, convert(varchar(50), SUM(Precio)) from Citas where Fecha_HoraCita <= SYSDATETIME() group by CAST(MONTH(Fecha_HoraCita) AS VARCHAR(2)),datename(MONTH, CONVERT(date, Fecha_HoraCita)) + ' ' + CONVERT(varchar(50), DATEPART(year, convert(date, Fecha_HoraCita))) order by CAST(MONTH(Fecha_HoraCita) AS VARCHAR(2)) asc";
                    comando.CommandType = CommandType.Text;
                    SqlDataReader lectura = comando.ExecuteReader();
                    while (lectura.Read()) {
                        fecha.Add(lectura.GetString(1));
                        monto.Add(lectura.GetString(2));
                        cahcegrafica.fecha = fecha;
                        cahcegrafica.monto = monto;
                    }



                }

            }

        }
        double Tmonto;
        public double Totalmonto()
        {

            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "select sum(Precio) as Monto from Citas where Fecha_HoraCita <= SYSDATETIME()";
                    comando.CommandType = CommandType.Text;
                    SqlDataReader lectura = comando.ExecuteReader();
                    while (lectura.Read()) {
                        Tmonto= lectura.GetDouble(0);
                    }
                    return Tmonto;
                }

            }

        }
        int totalCitas;
        public int TotalCitas()
        {

            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "select count(Fecha_HoraCita) as TotalCitas from Citas where Fecha_HoraCita <= SYSDATETIME()";
                    comando.CommandType = CommandType.Text;
                    SqlDataReader lectura = comando.ExecuteReader();
                    while (lectura.Read())
                    {
                        totalCitas = lectura.GetInt32(0);
                    }
                    return totalCitas;
                }

            }

        }



    }
}
