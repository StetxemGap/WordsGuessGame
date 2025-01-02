using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Game.Views;

namespace Game;

public partial class GameView : UserControl
{
    private readonly MainWindow _mainWindow;

    public GameView()
    {
        InitializeComponent();
    }

    private void OnBackToMenuClick(object sender, RoutedEventArgs e)
    {
        var _mainWindow = (MainWindow)TopLevel.GetTopLevel(this);
        _mainWindow.NavigateToMenu();
    }
}