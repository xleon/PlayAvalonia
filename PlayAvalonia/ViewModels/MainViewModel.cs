using System.Collections.Generic;
using ReactiveUI.Fody.Helpers;

namespace PlayAvalonia.ViewModels;

public class MainViewModel : BaseViewModel
{
    [Reactive] public List<string> Categories { get; private set; }
    
    public MainViewModel()
    {
        Categories = new List<string> { "Personal", "Business" };
    }
}
