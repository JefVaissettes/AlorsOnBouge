using Windows.Phone.UI.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// Pour en savoir plus sur le modèle d'élément Page vierge, consultez la page http://go.microsoft.com/fwlink/?LinkId=391641

namespace WinPhoneFR
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private MonitorViewModel _monitorViewModel = new MonitorViewModel();

        public MainPage()
        {
            InitializeComponent();
            NavigationCacheMode = NavigationCacheMode.Required;
        }

        #region Ouverture / fermeture de la fenêtre

        /// <summary>
        /// Invoqué lorsque cette page est sur le point d'être affichée dans un frame.
        /// </summary>
        /// <param name="e">Données d'événement décrivant la manière dont l'utilisateur a accédé à cette page.
        /// Ce paramètre est généralement utilisé pour configurer la page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // Binding de la source de données (MonitorViewModel) avec le contexte de la page
            DataContext = _monitorViewModel;

            // On s'abonne à l'événement système 'HardwareButtons_BackPressed'  
            HardwareButtons.BackPressed += HardwareButtons_BackPressed;
            //await _monitorViewModel.GetRubric();
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            HardwareButtons.BackPressed -= HardwareButtons_BackPressed;
        }

        #endregion Ouverture / fermeture de la fenêtre


        #region Evenements

        private async void btCategorie_Click(object sender, RoutedEventArgs e)
        {
            prbtCat.IsActive = true;
            prbtCat.Visibility = Visibility.Visible;

            btCategorie.Visibility = Visibility.Collapsed;
            await _monitorViewModel.GetRubric();
            btCategorie.Visibility = Visibility.Visible;

            prbtCat.IsActive = false;
            prbtCat.Visibility = Visibility.Collapsed;        

        }

        /// <summary>
        /// Evenement pour accès à la SujetPage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListView_Click(object sender, RoutedEventArgs e)
        {
            ViewModelRubric viewModelRubric = (ViewModelRubric)((Button)sender).DataContext;
            Frame.Navigate(typeof(SujetPage), viewModelRubric);
        }

        private void HardwareButtons_BackPressed(object sender, BackPressedEventArgs e)
        {
            e.Handled = true;
        }

        #endregion Evenements

        private void mnuQuitter_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Exit();
        }

        private async void mnuSynchro_Click(object sender, RoutedEventArgs e)
        {
            await _monitorViewModel.GetRubric();
        }
    }
}