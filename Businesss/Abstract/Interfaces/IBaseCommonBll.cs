using Entities.Abstract.Base;

namespace Businesss.Concrete
{
    public interface IBaseCommonBll
    {
        bool Delete(BaseEntity entity);
    }
}