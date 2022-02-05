using Kraken.Interfaces.Dynamic.Library.Interfaces;

namespace System
{
    public static class Extensions
    {
        public static string RepositoryType(this IPersonRepository repository)
        {
            return repository.GetType().ToString();
        }
    }
}
