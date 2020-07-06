using System;
using System.Collections.Generic;
using System.Net.Http;
using AssesmentTejas.Model;
using AssesmentTejas.ViewModel;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace AssesmentTejas.View
{
    public partial class PeopleList : ContentPage
    {
        PeopleListViewModel _httpCommunication = new PeopleListViewModel();
        List<Person> _users = new List<Person>();
        public PeopleList()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            _users = await _httpCommunication.GetResponseFromServer();
            ListView.ItemsSource = _users;
        }


        void ListView_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            ListView.SelectedItem = null;
        }

        async void ListView_ItemTapped(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            var person = e.Item as Person;
            await Navigation.PushAsync(new DetailPage(person));
        }
    }
}
