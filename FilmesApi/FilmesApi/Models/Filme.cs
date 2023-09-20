using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models
{
	public class Filme
	{
		[Key]
		[Required]
		public int Id { get; set; }

		[Required(ErrorMessage = "O titulo do filme e obrigatorio")]
		public string? Titulo { get; set; }

		[Required(ErrorMessage = "O genero do filme e obrigatorio")]
		[StringLength(50, ErrorMessage = "O tamanho do genero nao pode exceder 50 caracteres")]
		public string? Genero { get; set; }

		[Required]
		[Range(70, 600, ErrorMessage = "A duracao deve ser entre 70 e 600 minutos.")]
		public int Duracao { get; set; }
		

		/*public Filme(string titulo, string genero, int duracao)
		{
			this.Titulo = titulo;
			this.Genero = genero;
			this.Duracao = duracao;
		}*/
	}
}
