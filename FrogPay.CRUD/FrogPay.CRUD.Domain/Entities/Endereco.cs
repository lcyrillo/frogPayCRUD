namespace FrogPay.CRUD.Domain.Entities;

public class Endereco
{
    public int IdPessoa { get; set; }
    public string UfEstado { get; set; } = string.Empty;
    public string Cidade { get; set; } = string.Empty;
    public string Bairro { get; set; } = string.Empty;
    public string Logradouro { get; set; } = string.Empty;
    public int Numero { get; set; }
    public string Complemento { get; set; } = string.Empty;
    public Pessoa? Pessoa { get; set; }
}

