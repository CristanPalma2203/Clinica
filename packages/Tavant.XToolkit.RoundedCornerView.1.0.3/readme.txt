
Rounded Corner View
=====================

By Tavant Technologies Pvt Ltd.

This view provides the control to convert any view to a circular shape. 
You can specify the corner radius to confine the curvature just to the 
corner or increase till it becomes a circle.

The library works for both Android and iOS when you use it in XAML.

If you specify a width and height, use the MakeCircle property to convert 
the container to a circle.

BorderWidth and BorderColor can also be specified to provide a border to the 
content view.

To control the corner radius, specify a value for the RoundedCornerRadius property.

NOTE:
=====

You must call InitRoundedCornerView.Init() in your AppDelegate and MainActivity. 

USAGE:
=======

xmlns:tkt=clr-namespace:Tavant.XToolkit

<StackLayout HeightRequest="64" WidthRequest="64">
	<tkt:RoundedCornerView BorderWidth="2" BorderColor="Black" MakeCircle="true">
		<Image Source="profile.png" />
	</tkt:RoundedCornerView>
</StackLayout>