using Entities.Abstract.Base;

namespace Businesss.Abstract.Interfaces
{
    public interface IBaseGenelBll
    {
        bool Insert(BaseEntity entity);

        bool Update(BaseEntity oldEntity, BaseEntity currentEntity);

        string YeniKodVer();
    }
}
