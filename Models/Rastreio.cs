using System;

namespace delfimLogAPI.Models
{
    public class Rastreio
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Origem { get; set; }
        public decimal Preco { get; set; }
        public string Destino { get; set; }
        public string Remetente { get; set; }
        public string Destinatario { get; set; }
        public DateTime Data { get; set; } = DateTime.Now;
    }
}
