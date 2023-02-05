using Model.Constans;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Model.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<T> : IEntityRepository<T> where T : class
    {
        private readonly DbContext _context; // Okunabilir bir değer olması için readonly atandı
        private readonly DbSet<T> _dbSet;


        public EfEntityRepositoryBase(DbContext context)
        {
            if (context == null) return;
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public void Insert(T entity)
        {
            _context.Entry(entity).State = EntityState.Added;
        }

        public void Insert(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                _context.Entry(entity).State = EntityState.Added;
            }
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Update(T entity, IEnumerable<string> fields)
        {
            _dbSet.Attach(entity);
            var entry = _context.Entry(entity);
            foreach (var field in fields)
            {
                entry.Property(field).IsModified = true;
            }
        }

        public void Update(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                _context.Entry(entity).State = EntityState.Modified;
            }
        }

        public void Delete(T entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;
        }

        public void Delete(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                _context.Entry(entity).State = EntityState.Deleted;
            }
        }

        public TResult Find<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            return filter == null ? _dbSet.Select(selector).FirstOrDefault() : _dbSet.Where(filter).Select(selector).FirstOrDefault();
        }

        public IQueryable<TResult> Select<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            return filter == null ? _dbSet.Select(selector) : _dbSet.Where(filter).Select(selector);
        }

        public int Count(Expression<Func<T, bool>> filter = null)
        {
            return filter == null ? _dbSet.Count() : _dbSet.Count(filter);
        }

        public string YeniKodVer(KartTuru kartTuru, Expression<Func<T, string>> filter, Expression<Func<T, bool>> where = null)
        {
            // Kayıt Yokken Yeni Oluşturuyoruz
            string Kod()
            {
                string kod = null;
                var kodDizi = kartTuru.ToName().Split(' ');//Boşluğa Göre Böl

                for (int i = 0; i < kodDizi.Length - 1; i++)
                {
                    kod += kodDizi[i];

                    if (i + 1 < kodDizi.Length - 1)
                        kod += "";

                }
                return kod += "-0001";

            }
            //Kayıt varsa yeni kayıt koduna +1 arttıracak
            string YeniKodVer(string kod) //06okul-000001
            {
                var sayisalDegerler = "";
                foreach (var karakter in kod)//000001
                {
                    if (char.IsDigit(karakter))// gelen değer sayısal mı değil mi
                        sayisalDegerler += karakter;
                    else
                        sayisalDegerler = "";
                }
                var artisSonrasiDeger = (int.Parse(sayisalDegerler) + 1).ToString();
                var fark = kod.Length - artisSonrasiDeger.Length;
                if (fark < 0)
                    fark = 0;

                var yeniDeger = kod.Substring(0, fark);
                yeniDeger += artisSonrasiDeger;

                return yeniDeger;
            }
            var maxKod = where == null ? _dbSet.Max(filter) : _dbSet.Where(where).Max(filter);
            return maxKod == null ? Kod() : YeniKodVer(maxKod);

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
