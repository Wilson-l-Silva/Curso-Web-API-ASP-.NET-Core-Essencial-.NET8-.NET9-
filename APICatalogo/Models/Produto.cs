using System.Reflection.Metadata.Ecma335;

namespace APICatalogo.Models;

//Classes anemicas, ela só tem propriedades e não tem comportamento (Metodos)
public class Produto
{
    public int ProdutoId { get; set; }
    public string? Nome { get; set; }
    public string? Descricao { get; set; }
    public decimal Preco { get; set; }
    public string? ImagemUrl { get; set; }
    public float Estoque { get; set; }
    public DateTime DataCadastro { get; set; }

}
