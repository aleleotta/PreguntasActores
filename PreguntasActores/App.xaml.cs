﻿
namespace PreguntasActores
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            Window window = base.CreateWindow(activationState);
            window.MinimumHeight = 700;
            window.MinimumWidth = 1000;
            return window;
        }

    }
}
