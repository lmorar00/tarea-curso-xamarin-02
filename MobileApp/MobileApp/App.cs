using System;
using Xamarin.Forms;

namespace MobileApp
{
    public partial class App : Application
    {
        public App()
        {
            MainPage = new ContentPage
            {
                Content = BuildCalculator(),
                BackgroundColor = Color.Blue,
            };
        }

        private View BuildCalculator()
        {
            var entryField = new Entry() { Text = "123" };
            entryField.IsReadOnly = true;

            var container = new StackLayout();
            container.Orientation = StackOrientation.Vertical;
            container.BackgroundColor = Color.AntiqueWhite;

            container.Children.Add(
                new StackLayout
                {
                    Orientation = StackOrientation.Horizontal,
                    Children = {
                    new Button { Text = "7", BackgroundColor = Color.Yellow },

                    new Button { Text = "8", BackgroundColor = Color.Yellow },

                    new Button { Text = "8", BackgroundColor = Color.Yellow },

                    new Button { Text = "X", BackgroundColor = Color.Yellow },
                    }
                }
            );

            container.Children.Add(
                new StackLayout
                {
                    Orientation = StackOrientation.Horizontal,
                    Children = {
                    new Button { Text = "4", BackgroundColor = Color.Yellow},

                    new Button { Text = "5", BackgroundColor = Color.Yellow },

                    new Button { Text = "6", BackgroundColor = Color.Yellow},

                    new Button { Text = "+", BackgroundColor = Color.Yellow },

                    }
                }
            );

            container.Children.Add(
                new StackLayout
                {
                    Orientation = StackOrientation.Horizontal,
                    Children = {
                    new Button { Text = "1", BackgroundColor = Color.Yellow},

                    new Button { Text = "2", BackgroundColor = Color.Yellow },

                    new Button { Text = "3", BackgroundColor = Color.Yellow},

                    new Button { Text = "=", BackgroundColor = Color.Yellow },
                    }
                }
            );


            return new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Children = {
                    entryField,
                    container
                }
            };
        }
    }
}