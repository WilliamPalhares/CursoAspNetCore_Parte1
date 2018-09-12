using CursoAspNetCoreParte1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoAspNetCoreParte1.Repositories
{
    public class BaseRepository<T> where T : BaseModel
    {
        protected readonly DbSet<T> dbSet;
        protected readonly ApplicationContext context;

        public BaseRepository(ApplicationContext context)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
        }
    }
}
