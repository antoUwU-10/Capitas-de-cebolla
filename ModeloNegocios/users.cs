using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt;

namespace ModeloNegocios
{
    public class users
    {
        public static List<Datoss.Usuarios> get()
        {
            using (Datoss.capasEntities db = new Datoss.capasEntities())
            { 
                return db.Usuarios.ToList();
            }
        }

        public static void insert(Datoss.Usuarios usuario)
        {
            using (Datoss.capasEntities db = new Datoss.capasEntities())
            {
                db.Usuarios.Add(usuario);
                db.SaveChanges();
            }
        }

        public static void deleteByName(string userName)
        {
            using (Datoss.capasEntities db = new Datoss.capasEntities())
            {
                var userToDelete = db.Usuarios.FirstOrDefault(u => u.Nombre == userName);
                if (userToDelete != null)
                {
                    db.Usuarios.Remove(userToDelete);
                    db.SaveChanges();
                }
                // Handle the case where the user to be deleted is not found
            }
        }

        public static void update(Datoss.Usuarios usuario)
        {
            using (Datoss.capasEntities db = new Datoss.capasEntities())
            {
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(usuario.Contraseña);
                var existingUser = db.Usuarios.Find(usuario.ID);
                if (existingUser != null)
                {
                    // Actualiza las propiedades del usuario existente con los valores del nuevo usuario
                    existingUser.Nombre = usuario.Nombre;
                    existingUser.Apellido = usuario.Apellido;
                    existingUser.Estado = usuario.Estado;
                    existingUser.Email = usuario.Email;
                    existingUser.Contraseña = hashedPassword;

                    db.SaveChanges();
                }
                // Handle the case where the user to be updated is not found
            }
        }





    }
}
