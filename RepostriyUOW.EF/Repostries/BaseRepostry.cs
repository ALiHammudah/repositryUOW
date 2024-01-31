using RepostriyUOW.core.Repostries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace RepostriyUOW.EF.Repostries
{
    public class BaseRepostry<T> : IBaseRepostry<T> where T : class
    {
        protected ApplicationDbContext _context;
        public BaseRepostry(ApplicationDbContext context) => _context = context;

        public T GetById(int id)
        {
            _context.Database.EnsureCreated();
           return _context.Set<T>().Find(id);
        }
    }
}