using System;

namespace API.Models
{
    public class FormasDePagamento
    {
        public FormasDePagamento() => CriadoEm = DateTime.Now;
        public int Id { get; set; }
        public String FormaDepagamento { get; set; }
        public bool Parcelavel { get; set; }
        public DateTime CriadoEm { get; set; }

    }
}