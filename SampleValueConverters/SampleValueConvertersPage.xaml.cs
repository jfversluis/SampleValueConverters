using System.Collections.ObjectModel;
using SampleValueConverters.Enums;
using SampleValueConverters.Models;
using Xamarin.Forms;

namespace SampleValueConverters
{
    public partial class SampleValueConvertersPage : ContentPage
    {
        public ObservableCollection<Game> Games { get; set; } = new ObservableCollection<Game>
        {
            new Game
            {
                GamePlatform = Platform.Wii,
                Name = "Itsa-me! Mario!"
            },
			new Game
			{
                GamePlatform = Platform.Playstation,
				Name = "Crash Bandicoot is N Sane!"
			},
			new Game
			{
                GamePlatform = Platform.Xbox,
				Name = "Master Chiefs Swifty Shooter"
			}
        };

        public SampleValueConvertersPage()
        {
            InitializeComponent();

            BindingContext = this;
        }
    }
}