using Dave_E_commerce_website.Models;

namespace Dave_E_commerce_website.ViewModel
{
	public class NewProductViewModel
	{	
	  public IEnumerable<Category>? Category { get; set; }
	  public Product? Product { get; set; }
	  public IFormFile? Picture { get; set; }
	}
}

