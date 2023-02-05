using System;

namespace Model.Attributes
{
    public class Kod : Attribute
    {
        public string Description { get; }
        public string ControlName { get; }

        /// <summary>
        /// Validation(doğrulama) İşlemleri sırasında zorunlu olan alanları işaretlemek için kullanılacak
        /// </summary>
        /// <param name="description">uyarı mesajında gösterilecek olan acıklama</param>
        /// <param name="controlName">uyarı mesajı sonrası focuslanılacak alan</param>
        /// 
        public Kod(string description, string controlName)
        {
            Description = description;
            ControlName = controlName;
        }
    }
}
