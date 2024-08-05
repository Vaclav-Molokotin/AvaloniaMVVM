using System;
using System.Collections.Generic;
using ReactiveUI;

namespace MyEncryptApp.ViewModels;

public class MainWindowViewModel : ReactiveObject
{
    private List<EmployeeViewModel> employees;
    public List<EmployeeViewModel> Employees
    {
        get { return employees; }
        set
        {
            employees = value;
            this.RaiseAndSetIfChanged(ref employees, value);
        }
    }

    public MainWindowViewModel(List<EmployeeViewModel> employees)
    {
        this.employees = employees;
    }
}
