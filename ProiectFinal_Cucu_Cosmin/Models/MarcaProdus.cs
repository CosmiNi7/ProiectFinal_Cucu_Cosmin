using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLiteNetExtensions.Attributes;

namespace ProiectFinal_Cucu_Cosmin.Models
{
	public class MarcaProdus
	{
		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
		[ ForeignKey (typeof(ProduseFavorite)) ]
		public int ProduseFavoriteID { get; set; }
		public int ProductID { get; set; }
	}
}
