using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_MTS.IRepository
{
    public interface IRepository<T> where T : class
    {
        DataTable GetAll(); 
        void Add(T ado);
        void Update(T ado);
        void Delete(int id);
    }
}
