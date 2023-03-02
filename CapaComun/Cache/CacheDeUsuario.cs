using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaComun.Cache
{
    public static class CacheDeUsuario
    {
        public static string idUser { get; set; }
        public static string NonbreUsuario { get; set; }
        public static string ApellidoUsuario { get; set; }
        public static string CargoUsuario { get; set; }
        public static string Contraseña { get; set; }
    }
   

    public static class CachePaciente
    {
        //Paciente
        public static int Dui { get; set; }
        public static string NombrePaciente { get; set; }
        public static string ApellidoPaciente { get; set; }
        public static string SexoPaciente { get; set; }
        public static int TelefonoPaciente { get; set; }
        public static string DirrecionPaciente { get; set; }
        public static string EstadoCivilPaciente { get; set; }
        public static DateTime FechaNacimientoPaciente { get; set; }

    }

    public static class CacheExpediente
    {
        public static int NumExpediente { get; set; }
        public static DateTime FechaCreacionExpediente { get; set; }
        public static string AntecedentesClinicos { get; set; }
        public static string MedicamentosPreEscritos { get; set; }
        public static string TipoSangre { get; set; }

    }

    public static class CacheCita {

        public static int numCita { get; set; }
        public static DateTime fechaCreacion { get; set; }
        public static DateTime fechaCita { get; set; }
        public static string motivo { get; set; }
        public static string CreadoPor { get; set; }
        public static double Precio { get; set; }
    }

    public static class CacheDiagnostico {

        public static int id { get; set; }
        public static string estado { get; set; }
        public static string enfermead { get; set; }
        public static double peso { get; set; }
        public static double estatura { get; set; }
        public static double presion { get; set; }
        public static DateTime fechaCreacion { get; set; }
        public static double temperatura { get; set; }
        public static string detalles { get; set; }
        public static string recomendaciones { get; set; }

    }
    public static class cahcegrafica{

        public static ArrayList fecha { get; set; }
        public static ArrayList monto { get; set; }


    }



}
