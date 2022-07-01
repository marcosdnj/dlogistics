using System.ComponentModel.DataAnnotations;

namespace delfimLogAPI.ViewModels
{
    public class CreateRastreioViewModel
    {
        [Required]
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public string Origem { get; set; }
        public decimal Preco { get; set; }
        public string Destino { get; set; }
        public string Remetente { get; set; }
        public string Destinatario { get; set; }






    }
}
