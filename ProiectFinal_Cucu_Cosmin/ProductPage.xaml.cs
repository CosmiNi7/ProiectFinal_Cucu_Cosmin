using ProiectFinal_Cucu_Cosmin.Models;

namespace ProiectFinal_Cucu_Cosmin;

public partial class ProductPage : ContentPage
{
	public ProductPage()
	{
		InitializeComponent();
	}
	async void OnSaveButtonClicked(object sender, EventArgs e)
	{
		var product = (Telefoane)BindingContext;
		await App.Database.SaveProductAsync(product);
		listView.ItemsSource = await App.Database.GetProductsAsync();
	}
	async void OnDeleteButtonClicked(object sender, EventArgs e)
	{
		var product = (Telefoane)BindingContext;
		await App.Database.DeleteProductAsync(product);
		listView.ItemsSource = await App.Database.GetProductsAsync();
	}
	protected override async void OnAppearing()
	{
		base.OnAppearing();
		listView.ItemsSource = await App.Database.GetProductsAsync();
	}

}