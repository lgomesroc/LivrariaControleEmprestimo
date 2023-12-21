using LivrariaControleEmprestimo.DATA.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace LivrariaControleEmprestimo.WEB.Controllers
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