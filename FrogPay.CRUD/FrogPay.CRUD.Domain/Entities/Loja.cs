namespace FrogPay.CRUD.Domain.Entities;

public class Loja
{
    public int Id { get; set; }
    public int IdPessoa { get; set; }
    public string NomeFantasia { get; set; } = string.Empty;
    public string RazaoSocial { get; set; } = string.Empty;
    public string Cnpj { get; set; } = string.Empty;
    public DateTime DataAbertura { get; set; }
    public Pessoa? Pessoa { get; set; }
}

