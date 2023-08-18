# MauiTestApp
This .NET MAUI project shows an issue with VerticalStackLayout inside a ScrollView on iOS:

The VerticalStackLayout is populated with 15 items in code behind
On Windows and Android the user can scroll in the list -> correct 
On iOS the lower part of the list is empty, not shown -> incorrect 

Alternative:
When the VerticalStackLayout is replaced by a CollectionView, the items are shown correct
In order to sea the example with CollectionView, change the ContentTemplate to 'UseCollectionView' in AppShell.xaml

