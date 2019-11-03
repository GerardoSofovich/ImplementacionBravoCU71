using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosBravo
{
    public class FactoryRolUsuarioBombero
    {
        Rol rol;
        Bombero bombero;
        Usuario usuario;
        Sesion sesion;

        public Rol Rol { get => rol; set => rol = value; }
        public Bombero Bombero { get => bombero; set => bombero = value; }
        public Usuario Usuario { get => usuario; set => usuario = value; }
        public Sesion Sesion { get => sesion; set => sesion = value; }

        public void CrearBomberoUsuarioSesion(int op)
        {
            switch (op)
            {
                case 1:
                    Rol = new Rol("Encargado de Guardia");
                    Bombero = new Bombero();
                    Bombero.SetRol(Rol);
                    Usuario = new Usuario();
                    Sesion = new Sesion(Usuario);
                    break;
                case 2:
                    Rol = new Rol("Cabo");
                    Bombero = new Bombero();
                    bombero.SetRol(Rol);
                    Usuario = new Usuario();
                    Sesion = new Sesion(usuario);
                    break;
            }
          
        }
    }
}
