using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using Windows.UI;

namespace Model.DataAccess.EntityFramework
{
    public class EfUnitOfWorkBase<T> : IUnitOfWork<T> where T : class
    {
        private readonly DbContext _context;

        public EfUnitOfWorkBase(DbContext context)
        {
            if (context == null) return;
            _context = context;
        }

        public IEntityRepository<T> Rep => new EfEntityRepositoryBase<T>(_context);

        public bool save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                var sqlEx = (SqlException)ex.InnerException?.InnerException;
                if (sqlEx == null)
                {
                    Messages.HataMesaji(ex.Message);
                    return false;
                }

                switch (sqlEx.Number)
                {
                    case 208:
                        Messages.HataMesaji("İşlem Yapmak İstediğiniz Tablo Veritabanında Bulunamadı.");
                        break;

                    case 547:
                        Messages.HataMesaji("Seçilen Kartın İşlem Görmüş Hareketleri Var Kart Silinemez.");
                        break;

                    case 2601:
                    case 2627:
                        Messages.HataMesaji("Girmiş Olduğunuz Id Daha Önce Kullanılmıştır.");
                        break;

                    case 4060:
                        Messages.HataMesaji("İşlem Yapmak İstediğiniz Veritabanı Sunucuda Bulunamadı.");
                        break;

                    case 18456:
                        Messages.HataMesaji("Server'a Bağlanılmak İstenilen Kullanıcı Adı ve Şifre Hatalıdır.");
                        break;

                    default:
                        Messages.HataMesaji(sqlEx.Message);
                        break;
                }
                return false;
            }
            catch (Exception ex)
            {
                Messages.HataMesaji(ex.Message);
                return false;
            }
            return true;
        }

        private bool _disposedValue = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    _context.Dispose();
                }

                _disposedValue = true;
            }
        }


        public void Dispose()
        {

            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
