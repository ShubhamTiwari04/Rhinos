using System;
using System.Windows;
using Rhino;
using Rhino.Commands;

namespace YourPluginNamespace
{
    public class YourPluginClass : Command
    {
        public YourPluginClass()
        {
            // Constructor
        }

        public override string EnglishName => "GenerateRectangularSurface";

        protected override Result RunCommand(RhinoDoc doc, RunMode mode)
        {
            // Show your WPF panel/window
            YourWpfWindow wpfWindow = new YourWpfWindow();
            var result = wpfWindow.ShowDialog();

            // Process user input and generate the surface
            if (result.HasValue && result.Value)
            {
                // Retrieve values from the WPF controls
                double length = wpfWindow.Length;
                double width = wpfWindow.Width;
                double centerX = wpfWindow.CenterX;
                double centerY = wpfWindow.CenterY;
                double centerZ = wpfWindow.CenterZ;

            }
        using System;
        using System.Windows;
        using System.Windows.Input;

        namespace YourPluginNamespace
    {
        public partial class YourWpfWindow : Window
        {
            public YourWpfWindow()
            {
                InitializeComponent();
                DataContext = this; // Set the DataContext to itself for data binding
            }

            public double Length { get; set; }
            public double Width { get; set; }
            public double CenterX { get; set; }
            public double CenterY { get; set; }
            public double CenterZ { get; set; }

            public ICommand GenerateSurfaceCommand => new RelayCommand(GenerateSurface);

            private void GenerateSurface()
            {
                // Handle surface generation logic here
            }
        }

        public class RelayCommand : ICommand
        {
            private readonly Action _action;

            public RelayCommand(Action action)
            {
                _action = action;
            }

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public void Execute(object parameter)
            {
                _action();
            }

            public event EventHandler CanExecuteChanged;
        }
    }


                return Result.Success;
            }
        }
}
