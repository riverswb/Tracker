using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Tracker.Models;
using Tracker.Data;

namespace Tracker.Views
{
    class QuantityListPageCS : ContentPage
    {
        ListView listView;

        public QuantityListPageCS()
        {
            Title = "Tables";

            listView = new ListView
            {
                Margin = new Thickness(20),
                ItemTemplate = new DataTemplate(() =>
                {
                    var label = new Label
                    {
                        VerticalTextAlignment = TextAlignment.Center,
                        HorizontalOptions = LayoutOptions.StartAndExpand
                    };
                    label.SetBinding(Label.TextProperty, "name");

                    var stacklayout = new StackLayout
                    {
                        Margin = new Thickness(20, 0, 0, 0),
                        Orientation = StackOrientation.Horizontal,
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        Children = { label }
                    };

                    return new ViewCell { View = stacklayout };
                })
            };
        }
    }
}
