using System;

using AppDieta.Models;

using Xamarin.Forms;

namespace AppDieta.Views
{
    public partial class NewPreguntaPage : ContentPage
    {
        public Pregunta Item { get; set; }

        public NewPreguntaPage()
        {
            InitializeComponent();

            Item = new Pregunta
            {
                Text = "Item name",
                Description = "This is a nice description"
            };

            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddItem", Item);
            await Navigation.PopToRootAsync();
        }
    }
}