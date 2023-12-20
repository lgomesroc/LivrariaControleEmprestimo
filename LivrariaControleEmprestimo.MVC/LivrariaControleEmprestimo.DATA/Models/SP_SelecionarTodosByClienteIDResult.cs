using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaControleEmprestimo.DATA.Models
{
    public partial class SP_SelecionarTodosByClienteIDResult
    {
        public string cliCPF { get; set; }
        public string cliNome { get; set; }
        public string livroNome { get; set; }
        public int id { get; set; }
        public int LceIdCliente { get; set; }
        public int LceIdLivro { get; set; }
        public DateTime LceDataEmprestimo { get; set; }
        public DateTime LceDataEntrega { get; set; }
        public bool LceEntregue { get; set; }
    }
}
