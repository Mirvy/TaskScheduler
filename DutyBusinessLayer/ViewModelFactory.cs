using DutyBusinessLayer.ViewModels;
using DutyModels;

namespace DutyBusinessLayer
{
    public class ViewModelFactory
    {
        public static DutyViewModel DutyDetails(Duty d)
        {
            return new DutyViewModel
            {
                Duty = d,
                Action = "Details",
                ReadOnly = true,
                Theme = "info",
                ShowAction = false,
                Employees = d == null || d.Assigned == null
                    ? Enumerable.Empty<Employee>()
                    : new List<Employee> { d.Assigned },
                Projects = d == null || d.Project == null
                    ? Enumerable.Empty<Project>()
                    : new List<Project> { d.Project }
            };
        }

        public static DutyViewModel DutyCreate(Duty d, IEnumerable<Employee> employees, IEnumerable<Project> projects)
        {
            return new DutyViewModel
            {
                Duty = d,
                Action = "Create",
                Theme = "primary",
                Employees = employees,
                Projects = projects
            };
        }

        public static DutyViewModel DutyEdit(Duty d, IEnumerable<Employee> employees, IEnumerable<Project> projects)
        {
            return new DutyViewModel
            {
                Duty = d,
                Action = "Edit",
                Theme = "warning",
                Employees = employees,
                Projects = projects
            };
        }

        public static DutyViewModel DutyDelete(Duty d)
        {
            return new DutyViewModel
            {
                Duty = d,
                Action = "Delete",
                Theme = "danger",
                ReadOnly = true,
                Employees = d == null || d.Assigned == null
                    ? Enumerable.Empty<Employee>()
                    : new List<Employee> { d.Assigned }
            };
        }

        public static EmployeeViewModel EmployeeDetails(Employee e, IEnumerable<Duty> duties, IEnumerable<Team> teams)
        {
            return new EmployeeViewModel
            {
                Employee = e,
                Action = "Details",
                ReadOnly = true,
                Theme = "info",
                ShowAction = false,
                Teams = teams,
                Duties = duties
            };
        }

        public static EmployeeViewModel EmployeeCreate(Employee e, IEnumerable<Duty> duties, IEnumerable<Team> teams)
        {
            return new EmployeeViewModel
            {
                Employee = e,
                Action = "Create",
                Theme = "primary",
                Teams = teams,
                Duties = duties
            };
        }

        public static EmployeeViewModel EmployeeEdit(Employee e, IEnumerable<Duty> duties, IEnumerable<Team> teams)
        {
            return new EmployeeViewModel
            {
                Employee = e,
                Action = "Edit",
                Theme = "warning",
                ShowAction = true,
                Teams = teams,
                Duties = duties
            };
        }

        public static EmployeeViewModel EmployeeDelete(Employee e, IEnumerable<Duty> duties, IEnumerable<Team> teams)
        {
            return new EmployeeViewModel
            {
                Employee = e,
                Action = "Delete",
                ReadOnly = true,
                Theme = "danger",
                ShowAction = true,
                Teams = teams,
                Duties = duties
            };
        }

        public static ProjectViewModel ProjectDetails(Project p, IEnumerable<Team> teams, IEnumerable<Duty> duties)
        {
            return new ProjectViewModel
            {
                Project = p,
                Action = "Details",
                ReadOnly = true,
                Theme = "info",
                ShowAction = false,
                Duties = duties,
                Teams = teams
            };
        }

        public static ProjectViewModel ProjectCreate(Project p, IEnumerable<Team> teams, IEnumerable<Duty> duties)
        {
            return new ProjectViewModel
            {
                Project = p,
                Action = "Create",
                ReadOnly = false,
                Theme = "primary",
                ShowAction = true,
                Duties = duties,
                Teams = teams
            };
        }

        public static ProjectViewModel ProjectEdit(Project p, IEnumerable<Team> teams, IEnumerable<Duty> duties)
        {
            return new ProjectViewModel
            {
                Project = p,
                Action = "Edit",
                Theme = "warning",
                ShowAction = true,
                Duties = duties,
                Teams = teams
            };
        }

        public static ProjectViewModel ProjectDelete(Project p, IEnumerable<Team> teams, IEnumerable<Duty> duties)
        {
            return new ProjectViewModel
            {
                Project = p,
                Action = "Delete",
                Theme = "danger",
                ShowAction = true,
                ReadOnly = true,
                Teams = teams,
                Duties = duties
            };
        }

        public static TeamViewModel TeamDetails(Team t, IEnumerable<Employee> employees, IEnumerable<Project> projects)
        {
            return new TeamViewModel
            {
                Team = t,
                ShowAction = false,
                ReadOnly = true,
                Theme = "info",
                Employees = employees,
                Projects = projects
            };
        }

        public static TeamViewModel TeamCreate(Team t, IEnumerable<Employee> employees, IEnumerable<Project> projects)
        {
            return new TeamViewModel
            {
                Team = t,
                ShowAction = true,
                ReadOnly = false,
                Theme = "primary",
                Action = "Create",
                Employees = employees,
                Projects = projects
            };
        }

        public static TeamViewModel TeamEdit(Team t, IEnumerable<Employee> employees, IEnumerable<Project> projects)
        {
            return new TeamViewModel
            {
                Team = t,
                ShowAction = true,
                ReadOnly = false,
                Theme = "warning",
                Action = "Edit",
                Employees = employees,
                Projects = projects
            };
        }

        public static TeamViewModel TeamDelete(Team t, IEnumerable<Employee> employees, IEnumerable<Project> projects)
        {
            return new TeamViewModel
            {
                Team = t,
                ShowAction = true,
                ReadOnly = true,
                Theme = "danger",
                Action = "Delete",
                Employees = employees,
                Projects = projects
            };
        }
    }
}
