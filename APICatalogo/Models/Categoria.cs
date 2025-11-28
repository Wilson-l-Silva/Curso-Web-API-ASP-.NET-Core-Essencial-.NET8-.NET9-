using System.Collections.ObjectModel;

namespace APICatalogo.Models; //scoped namespace, se por ; no final não precisa usar as chaves do namespace

//Classes anemicas, ela só tem propriedades e não tem comportamento (Metodos)

public class Categoria
{
    public Categoria()
    {
        Produtos = new Collection<Produto>();
    }
    public int CategoriaId { get; set; }
    public string? Nome { get; set; }
    public string? ImagemUrl { get; set; }

    public ICollection<Produto>? Produtos { get; set; }
}
