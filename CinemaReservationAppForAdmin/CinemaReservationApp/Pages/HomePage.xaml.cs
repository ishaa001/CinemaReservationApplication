using CinemaReservationApp.Models;
using CinemaReservationApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CinemaReservationApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public ObservableCollection<Movie> MoviesCollection;
        private int pageNumber = 0;
        public HomePage()
        {
            InitializeComponent();            
        }
        private void BtnMovies_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MoviesListPage());
        }

        private void BtnReservations_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ReservationListPage());
        }
    }
}