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
    public sealed partial class PostPage : Page
    {
        private ViewModelSubject _viewModelSubject = null;

        public PostPage()
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
                _viewModelSubject = (ViewModelSubject)e.Parameter;
                await _viewModelSubject.getReponseBySujet();

                DataContext = _viewModelSubject;

                HardwareButtons.BackPressed += HardwareButtons_BackPressed;
            }
            catch (System.Exception)
            {

                throw new System.Exception("Il n'y a pas de post dans ce sujet");
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

        private async void mnuSynchro_Click(object sender, RoutedEventArgs e)
        {
            await _viewModelSubject.getReponseBySujet();
        }

        private void mnuQuitter_Click(object sender, RoutedEventArgs e)
        {
            // Retour à la fenêtre appelante
            if (Frame.CanGoBack)
            {
                Frame.GoBack();
            }
        }

        #endregion Evenements
    }
}
