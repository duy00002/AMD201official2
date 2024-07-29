using System.ComponentModel.DataAnnotations;
namespace AMD201official2.Models
{
	public class Url
	{
		public int Id { get; set; }
		public string OriginalLink { get; set; }
		public string ShortLink { get; set; }
		// We need only 3 type data in our project here
	}
}
