﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using static LivrariaControleEmprestimo.DATA.Models.LivroClienteEmprestimo;

#nullable disable

namespace LivrariaControleEmprestimo.DATA.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            LivroClienteEmprestimo = new HashSet<LivroClienteEmprestimo>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("cliCPF")]
        [StringLength(14)]
        public string CliCpf { get; set; }
        [Required]
        [Column("cliNome")]
        [StringLength(200)]
        public string CliNome { get; set; }
        [Required]
        [Column("cliEndereco")]
        [StringLength(200)]
        public string CliEndereco { get; set; }
        [Required]
        [Column("cliCidade")]
        [StringLength(100)]
        public string CliCidade { get; set; }
        [Required]
        [Column("cliBairro")]
        [StringLength(100)]
        public string CliBairro { get; set; }
        [Required]
        [Column("cliNumero")]
        [StringLength(50)]
        public string CliNumero { get; set; }
        [Required]
        [Column("cliTelefoneCelular")]
        [StringLength(14)]
        public string CliTelefoneCelular { get; set; }
        [Required]
        [Column("cliTelefoneFixo")]
        [StringLength(13)]
        public string CliTelefoneFixo { get; set; }

        [InverseProperty("LceIdClienteNavigation")]
        public virtual ICollection<LivroClienteEmprestimo> LivroClienteEmprestimo { get; set; }
    }



}