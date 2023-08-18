using MauiTestApp.UserControls;
using System.Collections.ObjectModel;

namespace MauiTestApp.Views;

public partial class EditEntryView : ContentPage
{
    public EditEntryView()
    {
        InitializeComponent();
    }

    private void OnLoaded(object sender, EventArgs e)
	{
        Init();
    }

    /// <summary>
    /// populate VerticalStackLayout with items
    /// </summary>
    private void Init()
    {
        var selectors = new ObservableCollection<ListSelector>();
        for (int i = 0; i < 15; i++)
        {
            selectors.Add(new ListSelector($" Selector {i}"));
        }

        foreach (ListSelector selector in selectors)
        {
            mainStack.Children.Add(selector);
        }
    }

}