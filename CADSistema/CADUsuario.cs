using CADSistema.DSSistemaTableAdapters;
using System;

namespace CADSistema
{
    public class CADUsuario
    {
        public string IDUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Clave { get; set; }
        public DateTime FechaModificacionClave { get; set; }
        public int IDRol { get; set; }
        public string Correo { get; set; }
        public bool Activo { get; set; }



        private static UsuarioTableAdapter adaptador = new UsuarioTableAdapter();
        public static bool ValidaUsuario(string IDUsuario, string Clave)
        {
            if (adaptador.ValidaUsuario(IDUsuario, Clave) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static DSSistema.UsuarioDataTable GetData()
        {
            return adaptador.GetData();
        }

        public static bool ExisteUsuario(string IDUsuario)
        {
            if (adaptador.ExisteUsuario(IDUsuario) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void UsuarioInsert(
            string IDUsuario,
            string Nombre,
            string Apellido,
            string Clave,
            int IDRol,
            string Correo)
        {
            adaptador.UsuarioInsert(IDUsuario, Nombre, Apellido, Clave, DateTime.Now, IDRol, Correo, true);
        }

        public static void UsuarioUpdate(
            string IDUsuario,
            string Nombre,
            string Apellido,
            string Clave,
            DateTime FechaModicicacionClave,
            int IDRol,
            string Correo,
            bool Activo)
        {
            adaptador.UsuarioUpdate(IDUsuario, Nombre, Apellido, Clave, FechaModicicacionClave, IDRol, Correo, Activo);
        }

        public static void UsuarioDelete(string IDUsuario)
        {
            adaptador.UsuarioDelete(IDUsuario);
        }

        public static CADUsuario GetUsuario(string IDUsuario)
        {
            CADUsuario miUsuario = null;
            DSSistema.UsuarioDataTable miTabla = adaptador.GetUsuario(IDUsuario);
            if (miTabla.Rows.Count == 0) return miUsuario;

            DSSistema.UsuarioRow miRegistro = (DSSistema.UsuarioRow) miTabla.Rows[0];
            miUsuario = new CADUsuario();
            miUsuario.IDUsuario = miRegistro.IDUsuario;
            miUsuario.IDRol = miRegistro.IDRol;
            miUsuario.Nombre = miRegistro.Nombre;
            miUsuario.Apellido = miRegistro.Apellido;
            miUsuario.Clave = miRegistro.Clave;
            miUsuario.FechaModificacionClave = miRegistro.FechaModificacionClave;
            miUsuario.Correo = miRegistro.Correo;
            miUsuario.Activo = miRegistro.Activo;

            return miUsuario;
        }

        public static void UsuarioUpdateClave(
            string Clave,
            string IDUsuario
            )
        {
            adaptador.UsuarioUpdateClave(Clave, DateTime.Now, IDUsuario);
        }

    }
}


