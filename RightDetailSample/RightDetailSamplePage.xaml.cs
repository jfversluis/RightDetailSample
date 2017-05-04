using System.Collections.Generic;
using Xamarin.Forms;

namespace RightDetailSample
{
    public partial class RightDetailSamplePage : ContentPage
    {
        public List<Foo> Items {
            get;
            set;
        } = new List<Foo> { new Foo {
                FooText = "Hello",
                FooDetail = "English"
            },
        new Foo {
                FooText = "Hallo",
                FooDetail = "Dutch"
            }};

        public RightDetailSamplePage ()
        {
            InitializeComponent ();

            BindingContext = this;
        }
    }
}