namespace Core.Entidades;

public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public double Preco { get; set; }
    public override string ToString()
    {
        return $"Id: {Id} - Nome: {Nome} - Preco: {Preco}";
    }
}