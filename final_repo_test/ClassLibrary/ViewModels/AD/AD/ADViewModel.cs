using ClassLibrary.Models;

namespace ClassLibrary.ViewModels.AD.AD
{
	public class ADViewModel
	{

		public List<Partner>? PartnersList
		{ get; set; }
		public int ID { get; set; }
		public string? PartnerName { get; set; }
		public string? Contact { get; set; }
		public string? Email { get; set; }
		public string? Phone { get; set; }
		public string? Note { get; set; }
	}
}