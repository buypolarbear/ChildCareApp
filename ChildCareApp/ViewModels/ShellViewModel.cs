using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ChildCareApp.ViewModels
{
    class ShellViewModel : Conductor<object>
    {
        public void QuitApplication()
        {
            Application.Current.Shutdown();
        }

        public void ShowFacilityData()
        {
            ActivateItem(new FacilityDataViewModel());
        }

        public void ShowFacilityMenu()
        {
            ActivateItem(new FacilityMenuViewModel());
        }

        public ShellViewModel()
        {
            //using (var context = new CCADBContext())
            //{

            //}
        }
    }
}
