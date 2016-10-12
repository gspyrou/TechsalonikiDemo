using System;
using Xamarin.Forms;

namespace TechSalonikiDemo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		async void Search_Clicked(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(this.SearchParameter.Text ))
			    await DisplayAlert("Error", "Please enter a least one character!", "OK");
			else
				await Navigation.PushAsync(new Results(this.SearchParameter.Text ));
		}


	}
}
