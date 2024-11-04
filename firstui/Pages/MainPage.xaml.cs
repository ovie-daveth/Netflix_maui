using firstui.Services;

namespace firstui.Pages
{
    public partial class MainPage : ContentPage
    {
        private readonly ApiService _apiServic;
        public MainPage(ApiService apiService)
        {
            InitializeComponent();
            _apiServic = apiService;

        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            var trending = await _apiServic.GetTrending();
        }
    }

}
