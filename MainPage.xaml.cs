using Microsoft.Maui.Controls;

namespace BCS23020012;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        var works = new List<Artwork>
        {
            new Artwork { Title = "Peach Tree in Blossom", Price = "$950,000", Image = "drawfive.png" },
            new Artwork { Title = "Cafe Terrace at Night", Price = "$1,920,000", Image = "drawfour.png" },
            new Artwork { Title = "The Yellow House", Price = "$830,0000", Image = "drawseven.png" },
            new Artwork { Title = "Sunflowers", Price = "$850,000", Image = "drawsix.png" },
            new Artwork { Title = "Wheat Field with Cypresses", Price = "$930,000", Image = "drawthree.png" },
            new Artwork { Title = "The Starry Night", Price = "$880,000", Image = "drawtwo.png" },
        };

        collectionView.ItemsSource = works;
    }
}

public class Artwork
{
    public string Title { get; set; } = "";
    public string Price { get; set; } = "";
    public string Image { get; set; } = "";
}
