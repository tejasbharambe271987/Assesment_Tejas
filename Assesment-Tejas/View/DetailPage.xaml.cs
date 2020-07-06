using System;
using System.Collections.Generic;
using AssesmentTejas.Model;
using AssesmentTejas.ViewModel;
using Xamarin.Forms;

namespace AssesmentTejas.View
{
    public partial class DetailPage : ContentPage
    {
        private Person _person;
        private DetailPageViewModel _detailPageViewModel;

        public DetailPage(Person person)
        {
            _person = person;
            _detailPageViewModel = new DetailPageViewModel();
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            BindingContext = _person;
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            _person.id_citizem = TextField_UserID.Text;
            DisplayAlert("", _detailPageViewModel.Validate_SA_ID(_person.id_citizem) ? "Valid user" : "Invalid user", "Ok");
        }
    }
}
