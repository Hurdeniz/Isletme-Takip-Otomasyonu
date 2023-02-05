using System;

namespace Model.DataAccess
{
    public interface IUnitOfWork <T> : IDisposable where T : class
    {
        IEntityRepository<T> Rep { get; }
        bool save();
    }
}
