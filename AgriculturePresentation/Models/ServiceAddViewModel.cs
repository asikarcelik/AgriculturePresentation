using System.ComponentModel.DataAnnotations;

namespace AgriculturePresentation.Models
{
    public class ServiceAddViewModel
    {
        [Display(Name ="Başlık")]
        [Required(ErrorMessage ="Başlık Boş Geçilemez")]
        public string Title { get; set; }

        [Display(Name = "Görsel")]
        [Required(ErrorMessage = "Görsel Değeri Boş Geçilemez")]
        public string Image { get; set; }

        [Display(Name = "Başlık")]
        [Required(ErrorMessage = "Açıklama Boş Geçilemez")]
        public string Description { get; set; }
    }
}
