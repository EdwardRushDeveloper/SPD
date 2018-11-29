using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace SPD.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://winthrop.qualtrics.com/jfe/form/SV_ef9vMBXbDsnMQEB?Q_JFE=qdg")));
        }

        public ICommand OpenWebCommand { get; }
    }
}