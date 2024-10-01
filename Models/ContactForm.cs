using System.ComponentModel.DataAnnotations;

namespace ContactFormApp.Models
{
    public class ContactForm
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad Soyad gerekli")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Telefon gerekli")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "E-Posta gerekli")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Departman seçilmesi zorunludur")]
        public string Department { get; set; }

        [Required(ErrorMessage = "Mesaj gerekli")]
        public string Message { get; set; }
    }
}
