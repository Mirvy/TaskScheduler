using DutyModels;

namespace DutyBusinessLayer.ViewModels
{
    public class DutyViewModel : IViewModel
    {
        public Duty Duty { get; set; } = new Duty();
        public string Action { get; set; } = "Create";
        public bool ReadOnly { get; set; } = false;
        public string Theme { get; set; } = "primary";
        public bool ShowAction { get; set; } = true;
        public IEnumerable<Employee> Employees { get; set; } = Enumerable.Empty<Employee>();
        public IEnumerable<Project> Projects { get; set; } = Enumerable.Empty<Project>();
    }
}
