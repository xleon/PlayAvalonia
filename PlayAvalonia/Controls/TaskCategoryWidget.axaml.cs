using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace PlayAvalonia.Controls
{
    public partial class TaskCategoryWidget : UserControl
    {
        public TaskCategoryWidget()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}