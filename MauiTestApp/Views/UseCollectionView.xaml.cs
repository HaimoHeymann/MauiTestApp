using MauiTestApp.UserControls;
using System.Collections.ObjectModel;

namespace MauiTestApp.Views;

public partial class UseCollectionView : ContentPage
{
	public UseCollectionView()
	{
		InitializeComponent();
        Init();
	}

    /// <summary>
    /// populate CollectionView with items
    /// </summary>
    private void Init()
    {
        var selectors = new ObservableCollection<ListSelector>();
        for (int i = 0; i < 15; i++)
        {
            selectors.Add(new ListSelector($" Selector {i}"));
        }

        collection.ItemsSource = selectors;
    }
}