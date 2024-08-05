using System;
using MyEncryptApp.Models;
using ReactiveUI;

namespace MyEncryptApp.ViewModels;

public class EmployeeViewModel : ReactiveObject
{
    private Employee employee;

    public EmployeeViewModel(Employee employee)
    {
        this.employee = employee;
    }
    public string Name
    {
        get { return employee.Name; }
        set
        {
            employee.Name = value;
            
            this.RaisePropertyChanged("Name");
        }
    }
    public DateOnly Birthdate
    {
        get { return employee.Birthdate; }
        set
        {
            employee.Birthdate = value;
            this.RaisePropertyChanged("Birthdate");
        }
    }
    public string Gender
    {
        get { return employee.Gender; }
        set
        {
            employee.Gender = value;
            this.RaisePropertyChanged("Gender");
        }
    }

    public void Hello()
    {
        
    }
}
