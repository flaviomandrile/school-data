using System.ComponentModel.DataAnnotations;

namespace SchoolData.Models
{
	public class FormClassStudenti
	{
		# "Creazione del form per il caricamento degli studenti seguendo "
		public int? CodStudente { get; set; }
		public string? Nome { get; set; }
		public string? Cognome { get; set; }
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
		public DateTime? DataNascita { get; set; }
		public string? Classe { get; set;}
		public int? MediaVoti { get; set; }
	}
}
