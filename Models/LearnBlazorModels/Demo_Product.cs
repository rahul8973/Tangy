using System;
namespace Models.LearnBlazorModels
{
	public class Demo_Product
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public bool IsActive { get; set; }
		public double Price { get; set; }
		public string ActiveString
		{
			get => IsActive ? "Active" : "InActive";
		}

		public List<Demo_ProdProperties> ProdProperties { get; set; }
	}
}

