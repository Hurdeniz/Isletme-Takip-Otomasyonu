using DataAccess.Concrete.Contexts;
using System.Data.Entity.Migrations;

namespace DataAccess.Concrete.IsletmeTakipMigration
{
    public class Configuration : DbMigrationsConfiguration<IsletmeTakipContext>
    {
        public Configuration()
        {
            // migrations işlemleri otomatik yap
            AutomaticMigrationsEnabled = true;
            // veri kaybına izin verme
            AutomaticMigrationDataLossAllowed = true;
        }
    }
}
