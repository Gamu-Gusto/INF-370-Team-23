using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artech_API_370.Interfaces
{
    public interface IIdentifier<TEntity> where TEntity : class
    {
        TEntity getUser(string UserName);
    }
}
