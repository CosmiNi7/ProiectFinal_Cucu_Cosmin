using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using ProiectFinal_Cucu_Cosmin.Models;
using SQLite;
using SQLiteNetExtensions.Attributes;


namespace ProiectFinal_Cucu_Cosmin.Colectii
{
	public class ListaProduseFavorite
	{
		readonly SQLiteAsyncConnection _database;
		public ListaProduseFavorite(string dbPath)
		{
			_database = new SQLiteAsyncConnection(dbPath);
			_database.CreateTableAsync<ProduseFavorite>().Wait();
			_database.CreateTableAsync<Telefoane>().Wait();
			_database.CreateTableAsync<MarcaProdus>().Wait();
		}
		public Task<int> SaveProductAsync(Telefoane telefoane)
		{
			if (telefoane.ID != 0)
			{
				return _database.UpdateAsync(telefoane);
			}
			else
			{
				return _database.InsertAsync(telefoane);
			}
		}

		public Task<List<ProduseFavorite>> GetShopListsAsync()
		{
			return _database.Table<ProduseFavorite>().ToListAsync();
		}
		public Task<ProduseFavorite> GetShopListAsync(int id)
		{
			return _database.Table<ProduseFavorite>()
			.Where(i => i.ID == id)
		   .FirstOrDefaultAsync();
		}
		public Task<int> SaveShopListAsync(ProduseFavorite slist)
		{
			if (slist.ID != 0)
			{
				return _database.UpdateAsync(slist);
			}
			else
			{
				return _database.InsertAsync(slist);
			}
		}
		public Task<int> DeleteProductAsync(Telefoane telefoane)
		{
			return _database.DeleteAsync(telefoane);
		}
		public Task<List<Telefoane>> GetProductsAsync()
		{
			return _database.Table<Telefoane>().ToListAsync();
		}

		public Task<int> DeleteShopListAsync(ProduseFavorite slist)
		{
			return _database.DeleteAsync(slist);
		}
		public Task<int> SaveListProductAsync(MarcaProdus listp)
		{
			if (listp.ID!= 0)
			{
				return _database.UpdateAsync(listp);
			}
			else
			{
				return _database.InsertAsync(listp);
			}
		}
		public Task<List<Telefoane>> GetListProductsAsync(int shoplistid)
		{
			return _database.QueryAsync<Telefoane>(
			"select P.ID, P.Description from Product P"
			+ " inner join ListProduct LP"
			+ " on P.ID = LP.ProductID where LP.ShopListID = ?",
			shoplistid);
		}
	}
}