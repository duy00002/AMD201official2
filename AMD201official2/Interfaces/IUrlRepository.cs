using AMD201official2.Models;
namespace AMD201official2.Interfaces
{
	public interface IUrlRepository
	{
		Task<IEnumerable<Url>> GetAllUrls();
		Task<Url> GetUrlById(int id);
		Task<Url> AddUrl(Url url);
		Task<bool> DeleteUrl(int id);

	}
}
