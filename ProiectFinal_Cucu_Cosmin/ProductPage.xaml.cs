using ProiectFinal_Cucu_Cosmin.Models;

namespace ProiectFinal_Cucu_Cosmin;

public partial class ProductPage : ContentPage
{
	ProduseFavorite sl;
	public ProductPage(ProduseFavorite slist)
	{
		InitializeComponent();
		sl = slist;
	}
	async void OnSaveButtonClicked(object sender, EventArgs e)
	{
		var telefoane= (Telefoane)BindingContext;
		await App.Database.SaveProductAsync(telefoane);
		listView.ItemsSource = await App.Database.GetProductsAsync();
	}
	async void OnDeleteButtonClicked(object sender, EventArgs e)
	{
		var telefoane= (Telefoane)BindingContext;
		await App.Database.DeleteProductAsync(telefoane);
		listView.ItemsSource = await App.Database.GetProductsAsync();
	}
	protected override async void OnAppearing()
	{
		base.OnAppearing();
		listView.ItemsSource = await App.Database.GetProductsAsync();
	}
	async void OnAddButtonClicked(object sender, EventArgs e)
	{
		Telefoane p;
		if (listView.SelectedItem != null)
		{
			p = listView.SelectedItem as Telefoane;
			var lp = new MarcaProdus();
			await App.Database.SaveListProductAsync(lp);
			p.MarcaProdus = new List<MarcaProdus> { lp };
			await Navigation.PopAsync();
		}
	}
}

