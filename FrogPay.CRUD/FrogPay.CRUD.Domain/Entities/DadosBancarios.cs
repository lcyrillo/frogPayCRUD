namespace FrogPay.CRUD.Domain.Entities;

public class DadosBancarios
{
    public int Id { get; set; }
    public int IdPessoa { get; set; }
    public string CodigoBanco { get; set; } = string.Empty;
    public string Agencia { get; set; } = string.Empty;
    public string Conta { get; set; } = string.Empty;
    public string DigitoConta { get; set; } = string.Empty;
    public Pessoa? Pessoa { get; set; }
}