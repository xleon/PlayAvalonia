using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace PlayAvalonia.Controls
{
    public partial class AvatarProgress : UserControl
    {
        public AvatarProgress()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}