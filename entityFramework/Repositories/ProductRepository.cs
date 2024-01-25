using entityFramework.Data;
using entityFramework.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace entityFramework.Repositories
{
	public class ProductRepository : IProductRepository
	{
		private readonly AppDbContext _appDbContext;

		public ProductRepository(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
		}


		public IEnumerable<Product> GetAll()
		{
			var product = _appDbContext.Products.ToArray();
			return product;
		}

		public async Task AddProduct(Product product)
		{
			await _appDbContext.Products.AddAsync(product);
		}

		public async Task<int> DeleteProduct(int id)
		{
			var x = await _appDbContext.Products.FirstOrDefaultAsync(x => x.Id == id);
			if (x == null)
				return 0;
			_appDbContext.Products.Remove(x);
			return 1;
		}

		public async Task Save()
		{
			await _appDbContext.SaveChangesAsync();
		}
	}
}

