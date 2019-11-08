using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosBravo
{
    public class FactoryRolUsuarioBombero
    {
        public Rol rol;
        public Bombero bombero;
        public Usuario usuario;
        public Sesion sesion;

 /*    public Rol Rol { get => rol; set => rol = value; }
        public Bombero Bombero { get => bombero; set => bombero = value; }
        public Usuario Usuario { get => usuario; set => usuario = value; }
        public Sesion Sesion { get => sesion; set => sesion = value; }
        */
        public void CrearBomberoUsuarioSesion(int op)
        {
            switch (op)
            {
                case 1:
                    rol = new Rol("Encargado de Guardia");
                    bombero = new Bombero();
                    bombero.SetRol(rol);
                    usuario = new Usuario();
                    sesion = new Sesion(usuario);
                    break;
                case 2:
                    rol = new Rol("Cabo");
                    bombero = new Bombero();
                    bombero.SetRol(rol);
                    usuario = new Usuario();
                    sesion = new Sesion(usuario);
                    break;
            }
          
        }
    }
}
