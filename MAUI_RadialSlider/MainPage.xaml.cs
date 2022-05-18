using Syncfusion.Maui.Gauges;

namespace MAUI_RadialSlider;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    private void markerPointer_ValueChanging(object sender, ValueChangingEventArgs e)
    {
        if (Math.Abs(e.NewValue - e.OldValue) > 20)
            e.Cancel = true;
        else
        {
            double value = e.NewValue;
            value = value > 50 ? Math.Ceiling(value) : Math.Floor(value);

            annotationLabel.Text = value.ToString() + "%";
        }
    }
}

