using Entitiess.Abstract.Base;
using System.Collections.Generic;

namespace Businesss.Abstract.Interfaces
{
    public interface IBaseHareketGenelBll
    {
        bool Insert(IList<BaseHareketEntity> entities);

        bool Update(IList<BaseHareketEntity> entities);

        bool Delete(IList<BaseHareketEntity> entities);
    }
}
