using DutyModels;

namespace DutyBusinessLayer.ViewModels
{
    public class ProjectViewModel : IViewModel
    {
        public Project Project { get; set; } = new Project();
        public string Action { get; set; } = "Create";
        public bool ReadOnly { get; set; } = false;
        public string Theme { get; set; } = "primary";
        public bool ShowAction { get; set; } = true;
        public IEnumerable<Team> Teams { get; set; } = Enumerable.Empty<Team>();
        public IEnumerable<Duty> Duties { get; set; } = Enumerable.Empty<Duty>();
    }
}
