using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DiagnosticCenterBillManagementSystemWebApp.Gateway;
using DiagnosticCenterBillManagementSystemWebApp.Model;

namespace DiagnosticCenterBillManagementSystemWebApp.BLL
{
    public class TestSetupManager
    {
        TestSetupGateway gateway = new TestSetupGateway();
        public string SaveTest(TestSetup testSetup)
        {
            if (testSetup.TestName!=String.Empty)
            {
                if (gateway.ShowSearchedTests(testSetup.TestName)>0)
                {
                    return "Test Name already exists.";
                }
                else
                {
                    if (gateway.SaveTest(testSetup)>0)
                    {
                        return "Test Saved Successfully";
                    }
                    return "Test Saving Failed";
                }
            }
            return "Please Enter a Test name.";
        }

        public List<TestAndType> ShowAllTestsAndTypes()
        {
            return gateway.ShowAllTestsAndTypes();
        }
        public List<TestSetup> ShowAllTests()
        {
            return gateway.ShowAllTests();
        }
    }
}