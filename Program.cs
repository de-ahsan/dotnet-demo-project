using DMS_BLL;
using DMS_View;
using System;
using System.Threading.Tasks;

namespace dotnet_demo_project
{
    class Program
    {
        static void Main()
        {
            ApiHelper.InitializeClient();
            PeopleView.DisplayOptions();
        }

    }
}
