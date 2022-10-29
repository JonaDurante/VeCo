using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VeCo.Model;

//namespace VeCo.Data
//{
//    public class UsuarioHandler
//    {
//        private VecoContext _dbContext;

//        public UsuarioHandler(VecoContext dbContext)
//        {
//            _dbContext = dbContext;
//        }

//        public static async Task<ICollection<Usuarios>> GetAllUsers()
//        {
//            var User = await _dbContext.Usuarios.AsNoTracking().ToListAsync();
//               return User;
//        }
//    }
//}
