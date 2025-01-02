using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Game.Views;

namespace Game;

public partial class MainMenuView : UserControl
{
    private readonly MainWindow _mainWindow;

    public MainMenuView()
    {
        InitializeComponent();
    }

    public MainMenuView(MainWindow mainWindow)
    {
        InitializeComponent();
        _mainWindow = mainWindow;
    }

    private void OnStartGameClick(object sender, RoutedEventArgs e)
    {
        _mainWindow.NavigateToGame();
    }
}