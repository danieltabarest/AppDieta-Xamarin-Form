using AppDieta.Helpers;
using AppDieta.Models;
using AppDieta.Services;

using Xamarin.Forms;

namespace AppDieta.ViewModels
{
    public class BaseViewModel : ObservableObject
    {
        /// <summary>
        /// Get the azure service instance
        /// </summary>

        public IDataStore<Alimento> DataStoreAlimento => DependencyService.Get<IDataStore<Alimento>>();

        public IDataStore<Item> DataStore => DependencyService.Get<IDataStore<Item>>();

        public IDataStore<Consejo> DataStoreConsejo => DependencyService.Get<IDataStore<Consejo>>();
        public IDataStore<Cuidados> DataStoreCuidados => DependencyService.Get<IDataStore<Cuidados>>();
        public IDataStore<Medicamento> DataStoreMedicamento => DependencyService.Get<IDataStore<Medicamento>>();
        public IDataStore<Pregunta> DataStorePregunta => DependencyService.Get<IDataStore<Pregunta>>();
        public IDataStore<Receta> DataStoreReceta => DependencyService.Get<IDataStore<Receta>>();

        public IDataStore<RecetaDetails> DataStoreRecetaDetalle => DependencyService.Get<IDataStore<RecetaDetails>>();
        public IDataStore<ConsejoDetalle> DataStoreConsejoDetalle => DependencyService.Get<IDataStore<ConsejoDetalle>>();

        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }
        /// <summary>
        /// Private backing field to hold the title
        /// </summary>
        string title = string.Empty;
        /// <summary>
        /// Public property to set and get the title of the item
        /// </summary>
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }
    }
}

