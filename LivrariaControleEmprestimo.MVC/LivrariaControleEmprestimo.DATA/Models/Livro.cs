﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

#nullable disable

namespace LivrariaControleEmprestimo.DATA.Models
{
    public partial class Livro
    {
        public Livro()
        {
            LivroClienteEmprestimo = new HashSet<Livro_Cliente_Emprestimo>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("livroNome")]
        [StringLength(50)]
        public string LivroNome { get; set; }
        [Required]
        [Column("livroAutor")]
        [StringLength(200)]
        public string LivroAutor { get; set; }
        [Required]
        [Column("livroEditora")]
        [StringLength(100)]
        public string LivroEditora { get; set; }
        [Column("livroAnoPublicacao", TypeName = "datetime")]
        public DateTime LivroAnoPublicacao { get; set; }
        [Required]
        [Column("livroEdicao")]
        [StringLength(50)]
        public string LivroEdicao { get; set; }

        [InverseProperty("LceIdLivroNavigation")]
        public virtual ICollection<Livro_Cliente_Emprestimo> LivroClienteEmprestimo { get; set; }
    }
}