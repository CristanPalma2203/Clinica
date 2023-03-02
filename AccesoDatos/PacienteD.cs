using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaComun.Cache;
using CapaComun;
using System.Data.SqlClient;
using System.Data;

namespace AccesoDatos
{
    public class PacienteD : ConexionSQL
    {
        public bool BusquedadPaciente(int dui)
        {
            using (var Conexion = GetConnection())
            {

                Conexion.Open();
                using (var Comando = new SqlCommand()) {

                    Comando.Connection = Conexion;
                    Comando.CommandText = "Consultar";
                    Comando.Parameters.AddWithValue("@dui", dui);
                    Comando.CommandType = CommandType.StoredProcedure;

                    SqlDataReader Lectura = Comando.ExecuteReader();

                    if (Lectura.HasRows) {
                        while (Lectura.Read())
                        {
                            CacheExpediente.NumExpediente = Lectura.GetInt32(0);
                            CacheExpediente.FechaCreacionExpediente = Lectura.GetDateTime(1);
                            CacheExpediente.AntecedentesClinicos = Lectura.GetString(2);
                            CacheExpediente.MedicamentosPreEscritos = Lectura.GetString(3);
                            CacheExpediente.TipoSangre = Lectura.GetString(4);
                            CachePaciente.Dui = Lectura.GetInt32(6);
                            CachePaciente.NombrePaciente = Lectura.GetString(7);
                            CachePaciente.ApellidoPaciente = Lectura.GetString(8);
                            CachePaciente.SexoPaciente = Lectura.GetString(9);
                            CachePaciente.TelefonoPaciente = Lectura.GetInt32(10);
                            CachePaciente.DirrecionPaciente = Lectura.GetString(11);
                            CachePaciente.EstadoCivilPaciente = Lectura.GetString(12);
                            CachePaciente.FechaNacimientoPaciente = Lectura.GetDateTime(13);
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
        public bool BusquedadPacienteCita(int dui)
        {
            using (var Conexion = GetConnection())
            {

                Conexion.Open();
                using (var Comando = new SqlCommand())
                {

                    Comando.Connection = Conexion;
                    Comando.CommandText = "Citass";
                    Comando.Parameters.AddWithValue("@dui", dui);
                    Comando.CommandType = CommandType.StoredProcedure;

                    SqlDataReader Lectura = Comando.ExecuteReader();

                    if (Lectura.HasRows)
                    {
                        while (Lectura.Read())
                        {
               
                            
                            CachePaciente.Dui = Lectura.GetInt32(0);
                            CachePaciente.NombrePaciente = Lectura.GetString(1);
                            CachePaciente.ApellidoPaciente = Lectura.GetString(2);
                            CacheCita.numCita = Lectura.GetInt32(8);
                            CacheCita.fechaCreacion = Lectura.GetDateTime(9);
                            CacheCita.fechaCita = Lectura.GetDateTime(10);
                            CacheCita.motivo = Lectura.GetString(11);
                            CacheCita.CreadoPor = Lectura.GetString(12);
                            CacheCita.Precio = Lectura.GetDouble(13);
                            

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
        public void CrearDianostico(int NumExped, string EnfermedadP, string EstadoP, float pesoP, float estaturaP, float presionP, float temperaturaP, string detallesP, string recomendacionesP)
        {

            using (var Conexion = GetConnection())
            {

                Conexion.Open();
                
                using (var Comando = new SqlCommand())
                {

                    Comando.Connection = Conexion;
                    Comando.CommandText = "insercion_Diagnostico";
                    Comando.Parameters.AddWithValue("@Expe", NumExped);
                    Comando.Parameters.AddWithValue("@Enfermedad", EnfermedadP);
                    Comando.Parameters.AddWithValue("@Estado", EstadoP);
                    Comando.Parameters.AddWithValue("@peso", pesoP);
                    Comando.Parameters.AddWithValue("@estatura", estaturaP);
                    Comando.Parameters.AddWithValue("@presion", presionP);
                    Comando.Parameters.AddWithValue("@temperatura", temperaturaP);
                    Comando.Parameters.AddWithValue("@detalles", detallesP);
                    Comando.Parameters.AddWithValue("@recomendaciones", recomendacionesP);
                    Comando.CommandType = CommandType.StoredProcedure;
                    Comando.ExecuteNonQuery();

                }
                
            }


        }

        public void CrearCita(string motivo, DateTime fechaCita, string CreadoPor, double Precio, int dui)
        {

            using (var Conexion = GetConnection())
            {

                Conexion.Open();
                using (var Comando = new SqlCommand())
                {

                    Comando.Connection = Conexion;
                    Comando.CommandText = "insercion_Citas";
                    Comando.Parameters.AddWithValue("@fechaCita", fechaCita);
                    Comando.Parameters.AddWithValue("@motivo", motivo);
                    Comando.Parameters.AddWithValue("@dui", dui);
                    Comando.Parameters.AddWithValue("@Precio", Precio);
                    Comando.Parameters.AddWithValue("@CreadoPor", CreadoPor);
                    Comando.CommandType = CommandType.StoredProcedure;
                    Comando.ExecuteNonQuery();

                }
            }


        }
        public void actualizarCita(string motivo, DateTime fechaCita, string CreadoPor, double Precio, int dui)
        {

            using (var Conexion = GetConnection())
            {

                Conexion.Open();
                using (var Comando = new SqlCommand())
                {

                    Comando.Connection = Conexion;

                    Comando.CommandText = "Actualizar_Citas";
                    Comando.Parameters.AddWithValue("@fechaCita", fechaCita);
                    Comando.Parameters.AddWithValue("@motivo", motivo);
                    Comando.Parameters.AddWithValue("@dui", dui);
                    Comando.Parameters.AddWithValue("@Precio", Precio);
                    Comando.Parameters.AddWithValue("@CreadoPor", CreadoPor);
                    Comando.CommandType = CommandType.StoredProcedure;
                    Comando.ExecuteNonQuery();

                }
            }


        }
        public void BusquedadPacienteCitaSinfecha(int dui)
        {
            using (var Conexion = GetConnection())
            {

                Conexion.Open();
                using (var Comando = new SqlCommand())
                {

                    Comando.Connection = Conexion;
                    Comando.CommandText = "select * from citas where dui = @dui";
                    Comando.Parameters.AddWithValue("@dui", dui);
                    Comando.CommandType = CommandType.Text;

                    SqlDataReader Lectura = Comando.ExecuteReader();

                 
    
                }

            }


        }
        DataTable tablaExpedientes = new DataTable();
        public DataTable BusquedadExpedientes()
        {
            using (var Conexion = GetConnection())
            {
                Conexion.Open();
                using (var Comando = new SqlCommand())
                {
                    Comando.Connection = Conexion;
                    Comando.CommandText = "select Id_Diagnostico as Consulta,P.Dui,Nombre_Paciente as Nombre,P.Apellidos_Paciente as Apellido,fechaDiagnostico as FechaConsulta,E.Num_Expediente as Expediente from Expediente  E inner join Paciente P on E.dui = P.Dui inner join Diagnostico D on D.Num_Expediente = E.Num_Expediente";
                    Comando.CommandType = CommandType.Text;
                    SqlDataReader Lectura = Comando.ExecuteReader();
                    tablaExpedientes.Load(Lectura);
                    return tablaExpedientes;
                }

            }


        }

        DataTable tablaExpedientesDui = new DataTable();
        public DataTable BusquedadExpedientes(int dui)
        {
            using (var Conexion = GetConnection())
            {
                Conexion.Open();
                using (var Comando = new SqlCommand())
                {
                    Comando.Connection = Conexion;
                    Comando.CommandText = "select Id_Diagnostico as Consulta,P.Dui,Nombre_Paciente as Nombre,P.Apellidos_Paciente as Apellido,fechaDiagnostico as FechaConsulta,E.Num_Expediente as Expediente from Expediente  E inner join Paciente P on E.dui = P.Dui inner join Diagnostico D on D.Num_Expediente = E.Num_Expediente where P.Dui = @dui";
                    Comando.CommandType = CommandType.Text;
                    Comando.Parameters.AddWithValue("@dui", dui);
                    SqlDataReader Lectura = Comando.ExecuteReader();
                    tablaExpedientesDui.Load(Lectura);
                    return tablaExpedientesDui;
                }

            }


        }
        
        public void BusquedadDiagnostico(int dui, int id)
        {
            using (var Conexion = GetConnection())
            {
                Conexion.Open();
                using (var Comando = new SqlCommand())
                {
                    Comando.Connection = Conexion;
                    
                   
                    Comando.CommandText = "select * from Expediente  E inner join Paciente P on E.dui = P.Dui inner join Diagnostico D on D.Num_Expediente = E.Num_Expediente where P.Dui = @dui   and Id_Diagnostico = @id_Diagnostico";
                    Comando.Parameters.AddWithValue("@dui", dui);
                    Comando.Parameters.AddWithValue("@id_Diagnostico", id);
                    Comando.CommandType = CommandType.Text;
                   

                    SqlDataReader Lectura = Comando.ExecuteReader();
                    if (Lectura.HasRows)
                    {
                        while (Lectura.Read())
                        {
                            CacheExpediente.NumExpediente = Lectura.GetInt32(0);
                            CachePaciente.Dui = Lectura.GetInt32(6);
                            CachePaciente.NombrePaciente = Lectura.GetString(7);
                            CachePaciente.ApellidoPaciente = Lectura.GetString(8);
                            CacheDiagnostico.id = Lectura.GetInt32(14);
                            CacheDiagnostico.estado = Lectura.GetString(15);
                            CacheDiagnostico.enfermead = Lectura.GetString(16);
                            CacheDiagnostico.peso = Lectura.GetDouble(17);
                            CacheDiagnostico.estatura = Lectura.GetDouble(18);
                            CacheDiagnostico.presion = Lectura.GetDouble(19);
                            CacheDiagnostico.fechaCreacion = Lectura.GetDateTime(20);
                            CacheDiagnostico.temperatura = Lectura.GetDouble(21);
                            CacheDiagnostico.detalles = Lectura.GetString(22);
                            CacheDiagnostico.recomendaciones = Lectura.GetString(23);
                        }
                        
                    }

                }

            }


        }

        public void actualizarExpedinte(string Antecedentes, string medicamentos, string tipoSangre, int dui)
        {

            using (var Conexion = GetConnection())
            {

                Conexion.Open();
                using (var Comando = new SqlCommand())
                {
                    Comando.Connection = Conexion;
                    Comando.CommandText = "update Expediente set Antecedentes_Clinicos = @antecendetes, Medicamentos_Escritos= @medicamentos, tipo_sangre= @sangre where dui = @dui ";
                    Comando.Parameters.AddWithValue("@antecendetes", Antecedentes);
                    Comando.Parameters.AddWithValue("@medicamentos", medicamentos);
                    Comando.Parameters.AddWithValue("@sangre", tipoSangre);
                    Comando.Parameters.AddWithValue("@dui", dui);
                    Comando.CommandType = CommandType.Text;
                    Comando.ExecuteNonQuery();

                }
            }



        }

        public void actualizarPaciente(int DuiP, string nombreP, string apellidosP, string SexoP, int numeroTeleP, string DireccionP, string EstadoCivilP, DateTime FechaNaciemientoP)
        {

            using (var Conexion = GetConnection())
            {

                Conexion.Open();
                using (var Comando = new SqlCommand())
                {
                    Comando.Connection = Conexion;
                    Comando.CommandText = "update Paciente set Nombre_Paciente= @nombre , Apellidos_Paciente = @apellido , Sexo_Paciente = @sexo, Telefono_Paciente = @telefono, Direccion_Paciente = @direccion ,EstadoCivil = @estadocivil , FechaNacimiento =@fechanac where dui = @dui";
                    Comando.Parameters.AddWithValue("@nombre", nombreP);
                    Comando.Parameters.AddWithValue("@apellido", apellidosP);
                    Comando.Parameters.AddWithValue("@sexo", SexoP);
                    Comando.Parameters.AddWithValue("@telefono", numeroTeleP);
                    Comando.Parameters.AddWithValue("@direccion", DireccionP);
                    Comando.Parameters.AddWithValue("@estadocivil", EstadoCivilP);
                    Comando.Parameters.AddWithValue("@fechanac", FechaNaciemientoP);
                    Comando.Parameters.AddWithValue("@dui", DuiP);
                    Comando.CommandType = CommandType.Text;
                    Comando.ExecuteNonQuery();

                }
            }



        }
        public void crearPaciente(int DuiP, string nombreP, string apellidosP, string SexoP, int numeroTeleP, string DireccionP, string EstadoCivilP, DateTime FechaNaciemientoP)
        {
            using (var Conexion = GetConnection())
            {
                Conexion.Open();
                using (var comando = new SqlCommand()) {


                    comando.Connection = Conexion;

                    comando.CommandText = "Insert into Paciente values(@dui,@nombre,@apellido,@sexo,@telefono,@direccion,@estadocivil,@fechanac)";
                    comando.Parameters.AddWithValue("@dui", DuiP);
                    comando.Parameters.AddWithValue("@nombre", nombreP);
                    comando.Parameters.AddWithValue("@apellido", apellidosP);
                    comando.Parameters.AddWithValue("@sexo", SexoP);
                    comando.Parameters.AddWithValue("@telefono", numeroTeleP);
                    comando.Parameters.AddWithValue("@direccion", DireccionP);
                    comando.Parameters.AddWithValue("@estadocivil", EstadoCivilP);
                    comando.Parameters.AddWithValue("@fechanac", FechaNaciemientoP);
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();

                }

            }

        }
        public void crearExpedinte(string Antecedentes, string medicamentos, string tipoSangre, int dui)
        {

            using (var Conexion = GetConnection())
            {

                Conexion.Open();
                using (var Comando = new SqlCommand())
                {
                    Comando.Connection = Conexion;
                    Comando.CommandText = "insert into Expediente values (SYSDATETIME(),@antecendetes,@medicamentos,@sangre,@dui)";
                    Comando.Parameters.AddWithValue("@antecendetes", Antecedentes);
                    Comando.Parameters.AddWithValue("@medicamentos", medicamentos);
                    Comando.Parameters.AddWithValue("@sangre", tipoSangre);
                    Comando.Parameters.AddWithValue("@dui", dui);
                    Comando.CommandType = CommandType.Text;
                    Comando.ExecuteNonQuery();

                }
            }
        }

        public void EliminarExp(int dui,int numExpe)
        {

            using (var Conexion = GetConnection())
            {

                Conexion.Open();
                using (var Comando = new SqlCommand())
                {
                    Comando.Connection = Conexion;
                    Comando.CommandText = "delete from Citas where dui = @dui ; delete from Diagnostico where Num_Expediente = @numExpe ;delete from Expediente where dui = @dui ; delete from Paciente where Dui = @dui;";
                    Comando.Parameters.AddWithValue("@dui", dui);
                    Comando.Parameters.AddWithValue("@numExpe", numExpe);
                    Comando.CommandType = CommandType.Text;
                    Comando.ExecuteNonQuery();
                }
            }
        }

        public int eliminarcita(int dui,DateTime fechaCita) {

            using (var Conexion = GetConnection())
            {

                Conexion.Open();
                using (var Comando = new SqlCommand())
                {

                    Comando.Connection = Conexion;

                    Comando.CommandText = "delete from citas where dui = @dui and Fecha_HoraCita=(select min(Fecha_HoraCita) from Citas where Fecha_HoraCita >= SYSDATETIME() and dui =@dui)";
                    Comando.Parameters.AddWithValue("@fechaCita", fechaCita);
                    Comando.Parameters.AddWithValue("@dui", dui);
                    Comando.CommandType = CommandType.Text;
                    return Comando.ExecuteNonQuery();

                }
            }

        }
        public int eliminarcitasinfecha(int dui, DateTime fechaCita)
        {

            using (var Conexion = GetConnection())
            {

                Conexion.Open();
                using (var Comando = new SqlCommand())
                {

                    Comando.Connection = Conexion;

                    Comando.CommandText = "delete from citas where dui = @dui and Fecha_HoraCita= @fechacita";
                    Comando.Parameters.AddWithValue("@fechaCita", fechaCita);
                    Comando.Parameters.AddWithValue("@dui", dui);
                    Comando.CommandType = CommandType.Text;
                    return Comando.ExecuteNonQuery();

                }
            }

        }

        DataTable tablaCitas = new DataTable();
        public DataTable MostrarCitas()
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "select Nombre_Paciente as Nombre,Apellidos_Paciente as Apellido ,P.dui as Dui,num_cita as Cita,Fecha_HoraCita as Fecha ,Fecha_HoraCreacion as Creada ,Motivo,CreadoPor,Precio  from Citas C inner join Paciente P on C.dui = P.Dui ";
                    comando.CommandType = CommandType.Text;
                    SqlDataReader lectura = comando.ExecuteReader();
                    tablaCitas.Load(lectura);
                    return tablaCitas;
                }

            }

        }
        DataTable tablaCitasFecha = new DataTable();
        public DataTable MostrarCitasFecha(DateTime fecha)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "select Nombre_Paciente as Nombre,Apellidos_Paciente as Apellido ,P.dui as Dui,num_cita as Cita,Fecha_HoraCita as Fecha ,Fecha_HoraCreacion as Creada ,Motivo,CreadoPor,Precio  from Citas C inner join Paciente P on C.dui = P.Dui where CONVERT(VARCHAR(10), Fecha_HoraCita, 103) = @fecha";
                    comando.Parameters.AddWithValue("@fecha", fecha);
                    comando.CommandType = CommandType.Text;
                    SqlDataReader lectura = comando.ExecuteReader();
                    tablaCitasFecha.Load(lectura);
                    return tablaCitasFecha;
                }

            }

        }
        DataTable tablaCitasFechaPersona = new DataTable();
        public DataTable MostrarCitasFechaPersona(DateTime fecha,int id)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "select Nombre_Paciente as Nombre,Apellidos_Paciente as Apellido ,P.dui as Dui,num_cita as Cita,Fecha_HoraCita as Fecha ,Fecha_HoraCreacion as Creada ,Motivo,CreadoPor,Precio  from Citas C inner join Paciente P on C.dui = P.Dui where P.dui = @dui and CONVERT(VARCHAR(10), Fecha_HoraCita, 103) = @fecha";
                    comando.CommandType = CommandType.Text;
                    comando.Parameters.AddWithValue("@dui", id);
                    comando.Parameters.AddWithValue("@fecha", fecha);
                    SqlDataReader lectura = comando.ExecuteReader();
                    tablaCitasFechaPersona.Load(lectura);
                    return tablaCitasFechaPersona;
                }

            }

        }
        public bool BusquedadCitasEnPacientes(DateTime fecha, int id)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "select *  from Citas where dui = @dui and Fecha_HoraCita = @fecha";
                    comando.CommandType = CommandType.Text;
                    comando.Parameters.AddWithValue("@dui", id);
                    comando.Parameters.AddWithValue("@fecha", fecha);
                    SqlDataReader lectura = comando.ExecuteReader();
                    if (lectura.HasRows) {
                        return true;
                    }
                    else
                    {

                        return false;
                    }
                    
                }

            }

        }
        DataTable tablaCitasPersona = new DataTable();
        public DataTable MostrarCitasPersona( int id)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "select Nombre_Paciente as Nombre,Apellidos_Paciente as Apellido ,P.dui as Dui,num_cita as Cita,Fecha_HoraCita as Fecha ,Fecha_HoraCreacion as Creada ,Motivo,CreadoPor,Precio from Citas C inner join Paciente P on C.dui = P.Dui where P.dui = @dui";
                    comando.CommandType = CommandType.Text;
                    comando.Parameters.AddWithValue("@dui", id);
                    SqlDataReader lectura = comando.ExecuteReader();
                    tablaCitasPersona.Load(lectura);
                    return tablaCitasPersona;
                }

            }

        }

    }
}
