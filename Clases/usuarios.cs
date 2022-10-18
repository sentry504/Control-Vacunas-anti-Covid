using System.Collections.Generic;
using System.Linq;
using Control_Vacunas_anti_Covid.Modelo;

namespace Control_Vacunas_anti_Covid.Clases
{
    class usuarios
    {
        Covid_Vacunas_DBEntities db = new Covid_Vacunas_DBEntities();

        //constructor vacio
        public usuarios()
        {
            
        }

        //Atributos
        public string sesion { get; set; }

        //Metodo que valida si las credenciales de usuario son las correctas
        public bool validar(string code, string password)
        {
            var result = db.Usuarios.Where(e => e.Codigo_Usuario == code && e.Password == password); //Optencion de usuarios que coinciden con los criterios
            int count = result.ToList().Count();
            if (count > 0)
            {
                Usuarios user = (from e in db.Usuarios where e.Codigo_Usuario == code select e).FirstOrDefault(); // Obtencion del registro del usuario
                sesion = user.Tipo_Usuario; // se guarda el valor del registro en el atributo para luego ser usado en el formulario principal
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidarID(string code)
        {
            var result = db.Usuarios.Where(e => e.Codigo_Usuario == code);
            int count = result.ToList().Count();
            if (count > 0)
                return true;
            else
                return false;
        }

        public List<Usuarios> GetUsuarios()
        {
            var Query = from varUsuario in db.Usuarios
                        select varUsuario;
            return Query.ToList();
        }

        public void GuardarUsuario(string codigo, string nombre, string ape, string pass, string tipoUsuario)
        {
            Usuarios nuevoUsuario = new Usuarios()
            {
                Codigo_Usuario = codigo,
                Nombre = nombre,
                Apellido = ape,
                Password = pass,
                Tipo_Usuario = tipoUsuario,
            };
            db.Usuarios.Add(nuevoUsuario);
            db.SaveChanges();
        }

        public void EliminarUsuario(string codigo)
        {
            Usuarios empleado = (from e in db.Usuarios where e.Codigo_Usuario == codigo select e).FirstOrDefault();
            db.Usuarios.Remove(empleado);
            db.SaveChanges();
        }

        public void ActualizarUsuario(string codigo, string nombre, string ape, string pass, string tipoUsuario)
        {
            Usuarios actUsuario = (from e in db.Usuarios where e.Codigo_Usuario == codigo select e).FirstOrDefault();
            actUsuario.Nombre = nombre;
            actUsuario.Apellido = ape;
            actUsuario.Password = pass;
            actUsuario.Tipo_Usuario = tipoUsuario;
            db.SaveChanges();
        }

        public List<Usuarios> Encontrar(string codigo)
        {
            var Query = from varUser in db.Usuarios
                        select varUser;
            return Query.Where(e => e.Codigo_Usuario == codigo).ToList();
        }
    }
}
