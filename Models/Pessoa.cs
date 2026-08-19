namespace DesafioProjetoHospedagem.Models;

public class Pessoa
{
    // Propriedades da classe (Acesso controlado aos dados)
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

    // Construtores (Inicializa o objeto)
    public Pessoa() { }

    public Pessoa(string nome)
    {
        Nome = nome;
    }

    public Pessoa(string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
    }

    
}