using DutyModels;

namespace DutyBusinessLayer.ViewModels
{
    public class TeamViewModel : IViewModel
    {
        public Team Team { get; set; } = new Team();
        public string Action { get; set; } = "Create";
        public bool ReadOnly { get; set; } = false;
        public string Theme { get; set; } = "primary";
        public bool ShowAction { get; set; } = true;
        public IEnumerable<Employee> Employees { get; set; } = Enumerable.Empty<Employee>();
        public IEnumerable<Project> Projects { get; set; } = Enumerable.Empty<Project>();
    }
}
