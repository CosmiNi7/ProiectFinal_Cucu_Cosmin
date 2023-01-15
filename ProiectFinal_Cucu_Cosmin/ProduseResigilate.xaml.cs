namespace ProiectFinal_Cucu_Cosmin;
using ProiectFinal_Cucu_Cosmin.Models;

public partial class ProduseResigilate : ContentPage
{
	public ProduseResigilate()
	{
		InitializeComponent();
	}
	async void OnSaveButtonClicked(object sender, EventArgs e)
	{
		var slist = (ProduseFavorite)BindingContext;
		slist.Date = DateTime.UtcNow;
		await App.Database.SaveProduseFavoriteAsync(slist);
		await Navigation.PopAsync();
	}
	async void OnDeleteButtonClicked(object sender, EventArgs e)
	{
		var slist = (ProduseFavorite)BindingContext;
		await App.Database.DeleteProduseFavoriteAsync(slist);
		await Navigation.PopAsync();
	}

}