using ItemTemplateEXample.Models;
using Microsoft.CodeAnalysis.Operations;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItemTemplateEXample.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private Student[] students;

        public MainWindowViewModel() {
            Students = new Student[] {
                new Student("Аббасов", "Анар"),
                new Student("Аксенова", "Татьяна"),
                new Student("Баженов", "Эдуард"),
                new Student("Баринов", "Артём"),
                new Student("Глинский", "Вадим")
            };
        }

        public Student[] Students
        {
            get => students;
            set => this.RaiseAndSetIfChanged(ref students, value);
        }
    }
}
