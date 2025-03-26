namespace FreshCart.Models.DTO
{
	public class SubCategoryDto
	{
			public Guid Id { get; set; }
			public string Name { get; set; }
			public string Slug { get; set; }
			public Guid CategoryId { get; set; } 
			public DateTime CreatedAt { get; set; }
			public DateTime UpdatedAt { get; set; }
		
	}
}
