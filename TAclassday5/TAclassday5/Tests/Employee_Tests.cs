using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAclassday5.Pages;
using TAclassday5.Utilities;

namespace TAclassday5.Tests
{

    [TestFixture]
    [Parallelizable]
    public class Employees_Tests : CommonDriver
    {
        HomePage homePageObj = new HomePage();
        EmployeesPage employeePageObj = new EmployeesPage();

        [Test]
        public void CreateEmployee_Test()
        {
            homePageObj.GoToEmployeesPage(driver);
            employeePageObj.CreateEmployee(driver);
        }

        [Test]
        public void EditEmployee_Test()
        {
            homePageObj.GoToEmployeesPage(driver);
            employeePageObj.EditEmployee(driver);
        }

        [Test]
        public void DeleteEmployee_Test()
        {
            homePageObj.GoToEmployeesPage(driver);
            employeePageObj.DeleteEmployee(driver);
        }
    }
}