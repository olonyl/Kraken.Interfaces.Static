using Kraken.Interfaces.Dynamic.Library.Interfaces;
using Kraken.Interfaces.Dynamic.Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using static Kraken.WPF.Consumer.RepositoryFactory;

namespace Kraken.WPF.Consumer
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private IPersonRepository _repository;

        private IEnumerable<PersonModel> people;
        public IEnumerable<PersonModel> People
        {
            get => people; private set
            {
                people = value;
                OnPropertyChanged();
            }
        }

        public string RepositoryType
        {
            get { return _repository.RepositoryType(); }
        }

        public void FetchData(RepositoryType respositoryType)
        {
            _repository = RepositoryFactory.GetRepository(respositoryType);
            People = _repository.GetPeople();
        }

        public void ClearData()
        {
            People = new List<PersonModel>();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        // Create the OnPropertyChanged method to raise the event
        // The calling member's name will be used as the parameter.
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
