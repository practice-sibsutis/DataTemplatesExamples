using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using DataTemplatesCodeExample.Models;
using System.Linq.Expressions;

namespace DataTemplatesCodeExample.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var template = new FuncDataTemplate<Student>((value, namescope) =>
                new TextBlock
                {
                    [!TextBlock.TextProperty] = new Binding("FirstName"),
                });

            DataTemplates.Add(template);
        }
    }
}
