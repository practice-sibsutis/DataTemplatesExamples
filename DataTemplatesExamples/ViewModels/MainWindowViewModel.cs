using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Text;
using DataTemplatesXAMLExample.Models;

namespace DataTemplatesExamples.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private object content;

        public MainWindowViewModel() {
            Content = new Teacher("Anton", "Mileshko"); //можно поменять на Student, тогда отображаться объект будет иначе
        }

        public object Content
        {
            get => content;
            set
            {
                this.RaiseAndSetIfChanged(ref content, value);
            }
        }
    }
}
