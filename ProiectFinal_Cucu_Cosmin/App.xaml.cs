namespace ProiectFinal_Cucu_Cosmin;
using System;
using ProiectFinal_Cucu_Cosmin.Colectii;
using System.IO;

public partial class App : Application
{
	static ListaProduseFavorite database;
	public static ListaProduseFavorite Database
	{
		get
		{
			if (database == null)
			{
				database = new
			  ListaProduseFavorite(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
			   LocalApplicationData), "ShoppingList.db3"));
			}
			return database;
		}
	}
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
