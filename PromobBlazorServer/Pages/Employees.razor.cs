using Microsoft.AspNetCore.Components;
using PromobBlazorServer.Components;
using PromobBlazorServer.Data;
using PromobClassLibrary;
using RestSharp;

namespace PromobBlazorServer.Pages
{
    public partial class Employees : ComponentBase
    {
        List<Employee> employees;

        protected string txtSearchEmployee { get; set; }
        long employeeId;
        string firstName;
        string lastName;
        string birthdate;
        string decimalfield;
        bool? happy;

        PageMode PageMode = PageMode.Search;
        Employee employee;

        protected override async Task OnInitializedAsync()
        {
            await load();
        }

        protected async Task load()
        {
            employees = await employeeService.GetEmployeesAsync();
        }

        protected async Task Insert()
        {
            Employee employee = new Employee()
            {
                FirstName = firstName,
                LastName = lastName,
                BirthDate = DateTime.TryParse(birthdate, out DateTime date) ? date : null,
                MyDecimalField = decimal.TryParse(decimalfield, out decimal dField) ? dField : 0,
                AmIHappy = happy
            };

            HttpResponseMessage message = await employeeService.InsertEmployeeAsync(employee);
            ClearFields();
            await load();
            PageMode = PageMode.Search;
        }

        protected void ClearFields()
        {
            employeeId = 0;
            firstName = string.Empty;
            lastName = string.Empty;
            birthdate = string.Empty;
            decimalfield = string.Empty;
            happy = false;
        }

        protected void Add()
        {
            ClearFields();
            PageMode = PageMode.Edit;
        }

        protected async Task Save()
        {
            if (employeeId > 0)
                await Update();
            else
                await Insert();
        }
        protected async Task Update()
        {

            Employee employee = new Employee()
            {
                Id = employeeId,
                FirstName = firstName,
                LastName = lastName,
                BirthDate = DateTime.TryParse(birthdate, out DateTime date) ? date : null,
                MyDecimalField = decimal.TryParse(decimalfield, out decimal dField) ? dField : 0,
                AmIHappy = happy
            };

            HttpResponseMessage message = await employeeService.UpdateEmployeeAsync(employeeId, employee);
            ClearFields();
            await load();
            PageMode = PageMode.Search;
            StateHasChanged();
        }

        protected async Task Delete()
        {
            HttpResponseMessage message = await employeeService.DeleteEmployeeAsync(employeeId);
            ClearFields();
            await load();
            PageMode = PageMode.Search;
        }

        protected async Task Show(long id)
        {
            employee = await employeeService.GetEmployeesByIdAsync(id);
            employeeId = employee.Id;
            firstName = employee.FirstName;
            lastName = employee.LastName;
            birthdate = employee.BirthDate?.ToString("dd/MM/yyyy");
            decimalfield = employee.MyDecimalField.ToString();
            happy = employee.AmIHappy;
            PageMode = PageMode.Edit;
            StateHasChanged();
        }

        protected void ChangePageMode(PageMode pageMode, bool clearFields = true)
        {
            //await AguardeProcessando.MostraAguardeProcessando(true);
            //System.Threading.Thread.Sleep(2000);
            PageMode = pageMode;

            if (clearFields)
                ClearFields();

            //await AguardeProcessando.MostraAguardeProcessando(false);
        }
    }
}
