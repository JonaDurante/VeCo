namespace VeCo.DataBase
{
    public class UserHandler : DBHandler
    {
        public static bool UserExist(string UsName, string Psw)
        {
            var exist = true;
            using (var db = new DBHandler())
            {
                var User = db.Usuarios.Single(x => x.NombreUsuario == UsName && x.Contrasena == Psw);
                if (User == null)
                {
                    exist = false;
                }
                return exist;
            }
        }
    }
}
