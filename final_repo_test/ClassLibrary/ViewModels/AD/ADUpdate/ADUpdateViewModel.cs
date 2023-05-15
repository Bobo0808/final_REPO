using ClassLibrary.Models;
using System.Collections.Generic;

namespace ClassLibrary.ViewModels.AD.ADUpdate
{
	public class ADUpdateViewModel
	{
		public List<Ads>? AdsList { get; set; }
		public List<Ads_OrderStatus>? OrderStatusesList { get; set; }
		public List<CaseTable>? CaseTablesList { get; set; }
		public List<Map_ADArea>? ADAreaList { get; set; }
		public List<Partner>? PartnersList { get; set; }
		public CaseTable? SelectedCase { get; set; }
	}
}