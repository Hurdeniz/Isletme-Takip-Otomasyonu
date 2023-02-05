using Entitiess.Abstract.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Businesss.Abstract.Interfaces
{
    public interface IBaseHareketSelectBll<T>
    {
        IEnumerable<BaseHareketEntity> List(Expression<Func<T, bool>> filter);
    }
}
