using System.Reflection.Emit;
using ConsoleGUI;
using ConsoleGUI.Controls;

class Program
{
    static void Main( string[] args )
    {
        // Initialize Console.GUI
        ConsoleGUIManager.Initialize();

        // Create a console window
        var window = new Window( 50, 20 );
        window.Title = "My Console App";

        // Add controls to the window
        var label = new Label( 2, 2, "Hello, Console.GUI!" );
        var button = new Button( 10, 5, "Click Me!" );
        button.Click += ( sender, e ) =>
        {
            label.Text = "Button clicked!";
        };
        window.AddControl( label );
        window.AddControl( button );

        // Run the Console.GUI manager
        ConsoleGUIManager.Run( window );
    }
}

