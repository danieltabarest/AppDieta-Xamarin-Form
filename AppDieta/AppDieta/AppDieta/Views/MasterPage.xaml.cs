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
                IconSource = "ic_keyboard_capslock_black_24dp.png",
                TargetType = typeof(Started)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Acerca de la app",
                IconSource = "ic_smartphone_black_24dp.png",
                TargetType = typeof(Acerca)
            });

            masterPageItems.Add(new MasterPageItem
            {
                Title = "Quienes somos",
                IconSource = "ic_description_black_24dp.png",
                TargetType = typeof(QuienesSomos)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Twitter",
                IconSource = "ic_account_box_black_24dp.png",
                TargetType = typeof(TwitterPage)
            });

            masterPageItems.Add(new MasterPageItem
            {
                Title = "Facebook",
                IconSource = "ic_stars_black_18dp.png",
                TargetType = typeof(FacebookPage)
            });

            listView.ItemsSource = masterPageItems;
		}
	}
}
