using System;
using System.Collections.Generic;
using System.Threading;
using Avalonia.Controls;
using MyEncryptApp.Models;
using MyEncryptApp.ViewModels;

namespace MyEncryptApp.UI;

public partial class MainWindow : Window
{
    private MainWindowViewModel viewModel;
    public MainWindow()
    {
        InitializeComponent();
        viewModel = getViewModel();
        DataContext = viewModel;

        Timer timer = new Timer(new TimerCallback(changeGenders), null, 5000, 5000);
    }

    private void changeGenders(object? state)
    {
        foreach (EmployeeViewModel employee in viewModel.Employees)
        {
            if(employee.Gender == "Мужской")
            {
                employee.Gender = "Женский";
            }
            else
            {
                employee.Gender = "Мужской";
            }
        }
    }

    private MainWindowViewModel getViewModel()
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee() { Name = "Тимофей", Birthdate=DateOnly.Parse("12/12/1999"), Gender="Мужской"},
            new Employee() { Name = "Анна", Birthdate=DateOnly.Parse("12/12/1998"), Gender="Женский"},
            new Employee() { Name = "Пётр", Birthdate=DateOnly.Parse("12/12/1932"), Gender="Мужской"},
            new Employee() { Name = "Максим", Birthdate=DateOnly.Parse("12/12/2001"), Gender="Мужской"},
            new Employee() { Name = "Татьяна", Birthdate=DateOnly.Parse("12/12/1997"), Gender="Женский"},
            new Employee() { Name = "Зинаида", Birthdate=DateOnly.Parse("12/12/1994"), Gender="Женский"},
        };

        List<EmployeeViewModel> employeesViewModel = new List<EmployeeViewModel>();

        foreach (Employee employee in employees)
        {
            employeesViewModel.Add(new EmployeeViewModel(employee));
        }

        return new MainWindowViewModel(employeesViewModel);
    }
}