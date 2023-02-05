using DataAccess.Concrete.IsletmeTakipMigration;
using Entities.Concrete;
using Entitiess.Concrete;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DataAccess.Concrete.Contexts
{
    public class IsletmeTakipContext : BaseDbContext<IsletmeTakipContext, Configuration>
    {
        public IsletmeTakipContext()
        {
            //istediğimiz sorguyu yapmak için LazyLoadingEnable kapattık
            Configuration.LazyLoadingEnabled = false;
        }

        public IsletmeTakipContext(string connectionString) : base(connectionString)
        {
            Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();//PluralizingTableNameConvention = table isimlerini coğaltıyor devre dışı bırakıyoruz
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();// ilişkili tablolarda bağlı oldukları tabloları sil(il tablosu silinince o ile ait ilçe tablolarıda silinsin) devre dısı bırakıyoruz 
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Entity<Sevkiyat>().HasMany(x => x.IsletmeSevkiyat).WithRequired().WillCascadeOnDelete(true);// sevkiyat Silindiğinde ona bağlı işletmeler silinmesi için
            modelBuilder.Entity<UrunSevkiyat>().HasMany(x => x.UrunSevkiyatHareket).WithRequired().WillCascadeOnDelete(true);// Urunsevkiyat Silindiğinde ona bağlı ürünler silinmesi için
        }

        public DbSet<Isletme> Isletme { get; set; }
        public DbSet<Il> Il { get; set; }
        public DbSet<Ilce> Ilce { get; set; }
        public DbSet<GrupKod> GrupKod { get; set; }
        public DbSet<Pompa> Pompa { get; set; }
        public DbSet<Sevkiyat> Sevkiyat { get; set; }
        public DbSet<Filtre> Filtre { get; set; }
        public DbSet<Arac> Arac { get; set; }
        public DbSet<Sofor> Sofor { get; set; }
        public DbSet<IsletmeSevkiyat> IsletmeSevkiyat { get; set; }
        public DbSet<IsletmeKullaniciKisi> IsletmeKullaniciKisi { get; set; }
        public DbSet<Urun> Urun { get; set; }
        public DbSet<UrunIsletme> UrunIsletme { get; set; }
        public DbSet<UrunSevkiyat> UrunSevkiyat { get; set; }
        public DbSet<UrunSevkiyatHareket> UrunSevkiyatHareket { get; set; }
        public DbSet<KmTonaj> KmTonaj { get; set; }
    }
}
