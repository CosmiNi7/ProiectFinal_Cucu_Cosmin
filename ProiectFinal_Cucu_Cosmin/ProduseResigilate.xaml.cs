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
		await Navigation.PopAsync();
	}
	async void OnDeleteButtonClicked(object sender, EventArgs e)
	{
		var slist = (ProduseFavorite)BindingContext;
		await Navigation.PopAsync();
	}

}