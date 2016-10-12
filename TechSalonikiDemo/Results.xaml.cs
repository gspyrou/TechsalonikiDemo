using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using Newtonsoft.Json;
using Xamarin.Forms;
using System.Linq;
namespace TechSalonikiDemo
{
	public partial class Results : ContentPage
	{
		public string Param
		{
			get;
			set;
		}
		public Results(string q)
		{
			InitializeComponent();
			this.Param = q;
			this.Title = String.Format("'{0}'", q);
			}
		protected override async void OnAppearing()
		{
			base.OnAppearing();

			try
			{
				this.IsBusy = true;
				var client = new HttpClient();
				var response = await client.GetStringAsync(String.Format(@"http://universities.hipolabs.com/search?name={0}", this.Param));
				var data = JsonConvert.DeserializeObject<List<University>>(response);
				var results = new ObservableCollection<University>();
				foreach (var item in data)
				{
					results.Add(item);
				}

				this.ResultsList.ItemsSource = from c in data orderby c.name select c;
				this.IsBusy = false;
				return;

			}
			catch (Exception exception)
			{
				await this.DisplayAlert("Error", exception.Message, "OK");
			}
		}

	}
}
