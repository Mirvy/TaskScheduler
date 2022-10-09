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
                    : new List<Employee> { d.Assigned }
            };
        }

        public static DutyViewModel DutyCreate(Duty d, IEnumerable<Employee> employees)
        {
            return new DutyViewModel
            {
                Duty = d,
                Action = "Create",
                Theme = "primary",
                Employees = employees
            };
        }

        public static DutyViewModel DutyEdit(Duty d, IEnumerable<Employee> employees)
        {
            return new DutyViewModel
            {
                Duty = d,
                Action = "Edit",
                Theme = "warning",
                Employees = employees
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
    }
}
