using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLiteNetExtensions.Attributes;


namespace ProiectFinal_Cucu_Cosmin.Models
{
	public class Telefoane
	{ 
 [PrimaryKey, AutoIncrement]
		public int ID { get; set; }
		public string Description { get; set; }
		[OneToMany]
		public List<MarcaProdus> MarcaProdus { get; set; }
	}
}