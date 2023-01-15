using ProiectFinal_Cucu_Cosmin.Models;

namespace ProiectFinal_Cucu_Cosmin;

public partial class OfertaZilei : ContentPage
{
	public OfertaZilei()
	{
		InitializeComponent();
	}
	protected override async void OnAppearing()
	{
		base.OnAppearing();
	}
	async void OnShopListAddedClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new ProduseResigilate
		{
			BindingContext = new ProduseFavorite()
		});
	}
	async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
	{
		if (e.SelectedItem != null)
		{
			await Navigation.PushAsync(new ProduseResigilate
			{
				BindingContext = e.SelectedItem as ProduseFavorite
			});
		}
	}
}