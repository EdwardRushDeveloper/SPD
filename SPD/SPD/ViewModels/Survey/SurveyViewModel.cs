using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace SPD.ViewModels
{
    public class SurveyViewModel : BaseViewModel
    {
        public SurveyViewModel()
        {
            Title = "Survey Question";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("")));
        }

        public ICommand OpenWebCommand { get; }
    }
}