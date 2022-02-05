using DataStore.CSV;
using Kraken.Interfaces.Dynamic.Library.Interfaces;
using People.DataStore.Service.Library;
using People.DataStore.SQL;
using System;

namespace Kraken.WPF.Consumer
{
    public static class RepositoryFactory
    {
        public static IPersonRepository GetRepository(RepositoryType respositoryType)
        {
            IPersonRepository repo = null;
            switch (respositoryType)
            {
                case RepositoryType.Service:
                    repo = new ServiceRepository();
                    break;
                case RepositoryType.CSV:
                    repo = new CSVRepository();
                    break;
                case RepositoryType.SQL:
                    repo = new SQLRepository();
                    break;
                default:
                    throw new ArgumentException("Invalid Reposiroty Type");
                    break;
            }
            return repo;

        }
        public enum RepositoryType
        {
            SQL,
            CSV,
            Service
        }
    }
}
