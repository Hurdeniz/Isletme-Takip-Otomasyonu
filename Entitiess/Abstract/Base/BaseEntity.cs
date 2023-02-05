using Entities.Abstract.Interfaces;
using Model.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Abstract.Base
{
    public class BaseEntity : IBaseEntity
    {
        [Column(Order = 0), Key, DatabaseGenerated(DatabaseGeneratedOption.None)]//ıd  kolonunu en üste yerleştir-- ıd birincil anahatar yap-- otomatik olarak arttırma
        public long Id { get; set; }

        [Column(Order = 1), Required, StringLength(30),Kod("Kod", "txtKod"), ZorunluAlan("Kod", "txtKod")]//zorunlu alan ve 30 karakter
        public virtual string Kod { get; set; }
    }
}
