using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Reactive.Linq;
using Akavache;

namespace AkavacheDEmo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Akavache.Registrations.Start("AkavacheDEmo");
            
            
        }
        async void SetData(System.Object sender, System.EventArgs e)
        {
            var persondata = new Person { Name = "RD", Age = 10 };
            var data = await BlobCache.UserAccount.InsertObject("person", persondata);
        }

        async void GetData(System.Object sender, System.EventArgs e)
        {
            var data = await BlobCache.UserAccount.GetObject<Person>("person");
          
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
