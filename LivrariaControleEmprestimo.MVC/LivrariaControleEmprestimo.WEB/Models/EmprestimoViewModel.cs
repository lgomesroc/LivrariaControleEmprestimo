using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static LivrariaControleEmprestimo.DATA.Models.Livro_Cliente_Emprestimo;

namespace LivrariaControleEmprestimo.WEB.Models
{
    public class EmprestimoViewModel
    {
        public Livro oLivro { get; set; }
        public Cliente oCliente { get; set; }
        public LivroClienteEmprestimo oLivroClienteEmprestimo { get; set; }



        public List<Cliente> oListCliente { get; set; }
        public List<Livro> oListLivro { get; set; }
    }
}