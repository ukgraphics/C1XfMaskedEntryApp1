using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace C1XfMaskedEntryApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void C1MaskedEntry1_TextChanged(object sender, C1.Xamarin.Forms.Input.TextChangedEventArgs e)
        {
            bool isFinished = C1MaskedEntry1.Value.Length == 12 ? true : false;

            GoToState1(isFinished);
        }

        void GoToState1(bool isFinished)
        {
            string visualState = isFinished ? "Finished" : "InProgress";
            VisualStateManager.GoToState(C1MaskedEntry1, visualState);
        }

        private void C1MaskedEntry2_TextChanged(object sender, C1.Xamarin.Forms.Input.TextChangedEventArgs e)
        {
            bool isFinished = C1MaskedEntry2.Value.Length == 8 ? true : false;

            GoToState2(isFinished);
        }

        void GoToState2(bool isFinished)
        {
            string visualState = isFinished ? "Finished" : "InProgress";
            VisualStateManager.GoToState(C1MaskedEntry2, visualState);
        }

    }
}
