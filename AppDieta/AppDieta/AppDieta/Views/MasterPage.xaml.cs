using AppDieta.Views;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AppDieta
{
	public partial class MasterPage : ContentPage
	{
		public ListView ListView { get { return listView; } }
        public System.Windows.Input.ICommand SettingsCommand { get; }
        public MasterPage ()
		{
			InitializeComponent ();

            //SettingsCommand = new Command(() => { ));
            var masterPageItems = new List<MasterPageItem> ();


            masterPageItems.Add(new MasterPageItem
            {
                Title = "Inicio",
                //IconSource = "contacts.png",
                TargetType = typeof(Started)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Acerca",
                //IconSource = "contacts.png",
                TargetType = typeof(Acerca)
            });

            listView.ItemsSource = masterPageItems;
		}
	}
}
