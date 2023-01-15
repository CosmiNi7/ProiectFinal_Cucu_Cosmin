using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace ProiectFinal_Cucu_Cosmin.Models
{
	public class ProduseFavorite
	{
		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
		[MaxLength(250), Unique]
		public string Description { get; set; }
		public DateTime Date { get; set; }
	}
}
