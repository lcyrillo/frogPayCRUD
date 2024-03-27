using System;

namespace FrogPay.CRUD.Domain.Entities;

public class Pessoa
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Cpf { get; set; } = string.Empty;
    public DateTime DataNascimento { get; set; }
    public bool Ativo { get; set; }
    public DateTime DataCriacao { get; set; }
}

