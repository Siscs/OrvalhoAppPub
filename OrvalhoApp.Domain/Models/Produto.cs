namespace OrvalhoApp.Domain.Models
{
    public class Produto : Entity 
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public double Quantidade { get; set; }
        public bool Bloqueado { get; set; }
        public long CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
        public long UnidadeMedidaId { get; set; }
        public virtual UnidadeMedida UnidadeMedida { get; set; }

        public Produto()
        {
        }

    }
}