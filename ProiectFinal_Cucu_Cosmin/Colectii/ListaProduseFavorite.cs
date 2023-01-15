using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using ProiectFinal_Cucu_Cosmin.Models;
using SQLite;


namespace ProiectFinal_Cucu_Cosmin.Colectii
{
	public class ListaProduseFavorite
	{
		readonly SQLiteAsyncConnection _database;
		public ListaProduseFavorite(string dbPath)
		{
			_database = new SQLiteAsyncConnection(dbPath);
			_database.CreateTableAsync<ProduseFavorite>().Wait();
		}
		public Task<List<ProduseFavorite>> GetProduseFavoriteAsync()
		{
			return _database.Table<ProduseFavorite>().ToListAsync();
		}
		public Task<ProduseFavorite> GetProduseFavoriteAsync(int id)
		{
			return _database.Table<ProduseFavorite>()
			.Where(i => i.ID == id)
		   .FirstOrDefaultAsync();
		}
		public Task<int> SaveProduseFavoriteAsync(ProduseFavorite slist)
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
		public Task<int> DeleteProduseFavoriteAsync(ProduseFavorite slist)
		{
			return _database.DeleteAsync(slist);
		}
	}
}