using ConsumeWSR;
using MetiersPortable;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace WinPhoneFR
{
    public class ViewModelRubric : ViewModelBase
    {
        private ConsumeWSRest _cdDAL;
        private int _idCategorie;
        private string _Libelle;
        private string _errorMessage;

        private ObservableCollection<ViewModelSubject> _colViewModelSubjects;

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        internal ViewModelRubric() { }

        /// <summary>
        /// Constructeur avec passage des paramètres Id et Libellé (titre) des rubriques
        /// </summary>
        /// <param name="rubric"></param>
        /// <param name="cdDAL"></param>
        internal ViewModelRubric(Rubric rubric, ConsumeWSRest cdDAL)
        {
            _idCategorie = rubric.Id;
            _Libelle = rubric.Libelle;
            _cdDAL = cdDAL;
            _colViewModelSubjects = new ObservableCollection<ViewModelSubject>();
        }

        #endregion Constructeurs


        #region Propriétés bindables

        public int IdCategorie
        {
            get { return _idCategorie; }
            private set
            {
                if (_idCategorie != value)
                {
                    _idCategorie = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string Libelle
        {
            get { return _Libelle; }
            private set
            {
                if(_Libelle != value)
                {
                    _Libelle = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string ErrorMessage
        {
            get { return _errorMessage; }
            private set
            {
                if (_errorMessage != value)
                {
                    _errorMessage = value;
                    RaisePropertyChanged();
                }
            }
        }

        public ReadOnlyObservableCollection<ViewModelSubject> Subject
        {
            get { return new ReadOnlyObservableCollection<ViewModelSubject>(_colViewModelSubjects); }
        }

        #endregion¨Propriétés bindables


        #region Méthodes

        public override string ToString()
        {
            return Libelle;
        }

        public async Task GetSujetByCategorieID()
        {
            List<Subject> subjects = await _cdDAL.getSujetByCategorieID(IdCategorie);
            MAJ_Subjects(subjects);
        }

        private void MAJ_Subjects(List<Subject> subjects) 
        {
            if (subjects != null)
            {
                _colViewModelSubjects.Clear();

                //Lecture des sujets même des nouveaux
                foreach (Subject subject in subjects)
                {
                    ViewModelSubject subjectVM = new ViewModelSubject(subject, _cdDAL);

                    if (!_colViewModelSubjects.Contains(subjectVM))
                    {
                        // On utilise la méthode d'extention de la classe 'IListExtensions'
                        _colViewModelSubjects.Add(subjectVM);
                    }
                }
            }
            else
            {
                return;
            }
        }

        #endregion Méthodes
    }
}
