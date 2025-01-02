using Avalonia.Controls;

namespace Game.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        MainContent.Content = new MainMenuView(this);
    }

    public void NavigateToGame()
    {
        MainContent.Content = new GameView();
    }

    public void NavigateToMenu()
    {
        MainContent.Content = new MainMenuView(this);
    }
}
