using Windows.Phone.UI.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// Pour en savoir plus sur le modèle d’élément Page vierge, consultez la page http://go.microsoft.com/fwlink/?LinkID=390556

namespace WinPhoneFR
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class SujetPage : Page
    {
        private ViewModelRubric _viewModelRubric = null;

        public SujetPage()
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
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            try
            {
                _viewModelRubric = (ViewModelRubric)e.Parameter;

                await _viewModelRubric.GetSujetByCategorieID();

                // Binding de la source de données (MonitorViewModel) avec le contexte de la page
                DataContext = _viewModelRubric;

                // On s'abonne à l'événement système 'HardwareButtons_BackPressed'  
                HardwareButtons.BackPressed += HardwareButtons_BackPressed;

            }
            catch (System.Exception)
            {
                throw new System.Exception("Il n'y a pas de sujet dans cette rubrique");
            }
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            HardwareButtons.BackPressed -= HardwareButtons_BackPressed;
        }

        #endregion Ouverture / fermeture de la fenêtre


        #region Evenements


        private void HardwareButtons_BackPressed(object sender, BackPressedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                e.Handled = true;
                Frame.GoBack();
            }
        }

        private void mnuQuitter_Click_1(object sender, RoutedEventArgs e)
        {
            // Retour à la fenêtre appelante
            if (Frame.CanGoBack)
            {
                Frame.GoBack();
            }
        }

        private async void mnuSynchro_Click_1(object sender, RoutedEventArgs e)
        {
            await _viewModelRubric.GetSujetByCategorieID();
        }

        private void ListView_Click(object sender, RoutedEventArgs e)
        {
            ViewModelSubject viewModelSubject = (ViewModelSubject)((Button)sender).DataContext;
            Frame.Navigate(typeof(PostPage), viewModelSubject);
        }

        private async void btSubject_Click(object sender, RoutedEventArgs e)
        {
            prbtSubj.IsActive = true;
            prbtSubj.Visibility = Visibility.Visible;

            btSubject.Visibility = Visibility.Collapsed;
            await _viewModelRubric.GetSujetByCategorieID();
            btSubject.Visibility = Visibility.Visible;

            prbtSubj.IsActive = false;
            prbtSubj.Visibility = Visibility.Collapsed;
        }

        #endregion Evenements        
    }
}
