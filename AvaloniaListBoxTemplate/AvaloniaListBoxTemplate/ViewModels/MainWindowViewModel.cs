using DynamicData;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvaloniaListBoxTemplate.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting => "Welcome to Avalonia!";

        public List<string> SimpleTexts => new List<string>() {
            "# one\nsimple text **one**",
            "# two\nsimple text **two**",
        };

        public List<Item> Items => new List<Item>() {
            new Item("# one\nitem **one**"),
            new Item("# two\nitem **two**"),
        };
    }

    public class Item
    {

        public Item(string text)
        {
            Text = text;
        }

        public string Text { get; }
    }
}
