namespace ProiectFinal_Cucu_Cosmin;
using ProiectFinal_Cucu_Cosmin.Models;

public partial class MarcaProdus : ContentPage
{
	public int ID { get; internal set; }

	async void OnSaveButtonClicked(object sender, EventArgs e)
	{
		var slist = (ProduseFavorite)BindingContext;
		slist.Date = DateTime.UtcNow;
		await App.Database.SaveShopListAsync(slist);
		await Navigation.PopAsync();
	}
	async void OnDeleteButtonClicked(object sender, EventArgs e)
	{
		var slist = (ProduseFavorite)BindingContext;
		await App.Database.DeleteShopListAsync(slist);
		await Navigation.PopAsync();


	}
	protected override async void OnAppearing()
	{
		base.OnAppearing();
		var shopl = (ProduseFavorite)BindingContext;
	}

	async void OnChooseButtonClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new ProductPage((ProduseFavorite)
			this.BindingContext)
		{
			BindingContext = new Telefoane()
		});
	}
}