using NuGet.DependencyResolver;

namespace JoinTwoTable.Models
{
    public class ViewModel
    {
        public IEnumerable<City> _City { get; set; }
        public IEnumerable<State> _States { get; set; }
    }
}
