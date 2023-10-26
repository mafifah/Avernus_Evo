namespace mbaAvernus
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        public static Window W { get; set; }
        protected override Window CreateWindow(IActivationState activationState)
        {
            W = base.CreateWindow(activationState);
            return W;
        }
    }
}