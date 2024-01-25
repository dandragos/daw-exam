using entityFramework.Models;
using Microsoft.AspNetCore.Mvc;

namespace entityFramework.Repositories
{
	public interface IProductRepository
	{
		IEnumerable<Product> GetAll();

		Task AddProduct(Product product);

		Task<int> DeleteProduct(int id);

		Task Save();
    }
}

