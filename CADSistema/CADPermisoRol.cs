using CADSistema.DSSistemaTableAdapters;

namespace CADSistema
{
    public class CADPermisoRol
    {
        private static PermisoRolTableAdapter adaptador = new PermisoRolTableAdapter();

        public static bool PermisoRolPuedeVer(int IDRol, string Formulario)
        {
            if (adaptador.PuedeVer(IDRol, Formulario) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool PermisoRolPuedeModificar(int IDRol, string Formulario)
        {
            if (adaptador.PuedeModificar(IDRol, Formulario) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool PermisoRolPuedeBorrar(int IDRol, string Formulario)
        {
            if (adaptador.PuedeBorrar(IDRol, Formulario) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
