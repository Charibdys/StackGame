namespace StackGame.ViewModels;

using CommunityToolkit.Mvvm.ComponentModel;

public partial class MainViewModel : ObservableObject
{

    [ObservableProperty]
    private string _greeting = "Hello!";


    public MainViewModel()
    {
        
    }
}