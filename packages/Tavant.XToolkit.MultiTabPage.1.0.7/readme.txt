
Multi Tabbed Page
==================

By Tavant Technologies Pvt Ltd.

The MultiTabPage is a Bottom navigation page similar to the Tab controller on iOS. The MultiTabPage is used
in XAML to work the same on Android and iOS. Each item is associated with a page. The transitions between 
pages are animated, though you can disable it through the property AnimatePageTransitions. On Android it
implements a dialect of the bottom navigation design paradigm as per material design.

The items can be added through the AddPage method. It supports Icon + Text and Icon only options.

Each Tab item also has a badge view that shows up if the badge value is > 0.

NOTE:
======

You must call InitMultiTabPage.Init() from AppDelegate and MainActivity.

USAGE:
=======

In your App.xaml.cs

MultiTabPage.MultiTabPage mtb = new MultiTabPage.MultiTabPage();
mtb.SelectedColor = Color.FromHex("#3366cc");
mtb.DefaultColor = Color.Silver;

mtb.AddPage(1, "Main", "ic_account_balance.png", new MainPage());
mtb.AddPage(2, "Second", "ic_stars", new SecondPage());
mtb.AddPage(3, "Third", "ic_account_balance.png", new MainPage());
mtb.AddPage(4, "Fourth", "ic_stars", new SecondPage());

MainPage = mtb;