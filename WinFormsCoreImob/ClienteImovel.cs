using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsCoreImob
{
    public class ClienteImovel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string ImovelVendendo { get; set; }
        public decimal Valor { get; set; }
        public string ImovelComprando { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Observacoes { get; set; }
    }
}
