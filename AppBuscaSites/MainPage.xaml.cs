using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace AppBuscaSites
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        List<string> sites = new List<string>
        {
            "https://google.com.br", "https://mercadolivre.com.br", "https://amazon.com", "https://lokando.azurewebsites.net",
            "https://registro.br","https://timtec.com.br", "https://udemy.com","https://cursoemvideo.com.br","https://instagram.com",
            "https://facebook.com","https://youtube.com","https://netflix.com"
        };

        public MainPage()
        {
            InitializeComponent();
            LstVwSites.ItemsSource = sites;
        }

        private void SchSites_TextChanged(object sender, TextChangedEventArgs e)
        {
            string texto = SchSites.Text;
            LstVwSites.ItemsSource = sites.Where(x => x.ToLower().Contains(texto));

            var tapGestureRecognizer = new TapGestureRecognizer();

            tapGestureRecognizer.Tapped +=  (s, lblSites) => {
                // Depreciated - Device.OpenUri( new Uri((Label)s).Text); 
                Launcher.OpenAsync(new Uri(((Label)s).Text));
            };
            
            //label.GestureRecognizers.Add(tapGestureRecognizer);
        }
    }
}
