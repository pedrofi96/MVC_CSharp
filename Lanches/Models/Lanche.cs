using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lanches.Models
{
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }
        [StringLength(80,MinimumLength =10, ErrorMessage = "O {0} deve ter no minimo {1} e no máximo {2} ")]
        [Required(ErrorMessage = "O nome do Lanche deve ser informado.")]
        [Display(Name = "Nome do Lanche")]
        public string Name { get; set; }

       
        [Required(ErrorMessage = "O nome do Lanche deve ser informado.")]
        [Display(Name = "Descrição")]
        [MinLength(20,ErrorMessage ="Descrição deve ter no minimo {1} caracteres")]
        [MaxLength(200, ErrorMessage ="Descrição não pode exceder {1} caracteres")]
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "O nome do Lanche deve ser informado.")]
        [Display(Name = "Nome do Lanche")]
        [MinLength(20, ErrorMessage = "Descrição deve ter no minimo {1} caracteres")]
        [MaxLength(600, ErrorMessage = "Descrição não pode exceder {1} caracteres")]
        public string DescricaoDetalhada { get; set; }
        [Required(ErrorMessage ="Informe o preço do laanhce.")]
        [Display(Name ="Preço")]
        [Column(TypeName ="decimal(10,2)")]
        [Range(1,999.99 ,ErrorMessage ="O preço deve estar entre 1 e 999,99")]
        public decimal Preco { get; set; }
        [Display(Name ="Caminho Imagem Normal")]
        [StringLength(200, ErrorMessage ="O {0} deve ter no máximo {1} caracteres")]
        public string ImgemUrl { get; set; }
        [Display(Name = "Caminho Imagem Normal")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImagemThumbnailUrl { get; set; }
        [Display(Name ="Lanche preferido?")]
        public bool IsLanchePreferido { get; set; }
        [Display(Name ="Estoque.")]
        public bool EmEstoque { get; set; }
        public int CategoriaID { get; set; }
        public virtual Categoria Categoria { get; set; }


    }
}
