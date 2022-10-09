using DutyModels;

namespace DutyBusinessLayer.ViewModels
{
    public class EmployeeViewModel
    {
        public Employee Employee { get; set; } = new Employee();
        public string Action { get; set; } = "Create";
        public bool ReadOnly { get; set; } = false;
        public string Theme { get; set; } = "primary";
        public bool ShowAction { get; set; } = true;
        public IEnumerable<Duty> Duties { get; set; } = Enumerable.Empty<Duty>();
        public IEnumerable<Team> Teams { get; set; } = Enumerable.Empty<Team>();
    }
}
