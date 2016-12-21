using ConsumeWSR;
using MetiersPortable;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;


namespace WinPhoneFR
{
    /// <summary>
    /// Classe métier de connexion qui intègre le DataBinding
    /// </summary>
    public class MonitorViewModel : ViewModelBase
    {
        private ConsumeWSRest _cdDAL;
        private ObservableCollection<ViewModelRubric> _colViewModelRubric;

        public MonitorViewModel()
        {
            _cdDAL = new ConsumeWSRest();
            _colViewModelRubric = new ObservableCollection<ViewModelRubric>();
        }


        #region Propriétés bindables

        public ReadOnlyObservableCollection<ViewModelRubric> Rubric
        {
            get { return new ReadOnlyObservableCollection<ViewModelRubric>(_colViewModelRubric); }
        }       

        #endregion Propriétés bindables


        #region Méthodes

        public async Task GetRubric()
        {
            List<Rubric> rubrics = await _cdDAL.getRubric();
            MAJ_Rubrics(rubrics);
        }

        private void MAJ_Rubrics(List<Rubric> rubrics)
        {
            _colViewModelRubric.Clear();
            foreach(Rubric rubric in rubrics)
            {
                ViewModelRubric rubricVM = new ViewModelRubric(rubric, _cdDAL);
                
                if(!_colViewModelRubric.Contains(rubricVM))
                {
                    _colViewModelRubric.Add(rubricVM);
                } 
            }
        }
        
        #endregion Méthodes
    }
}
