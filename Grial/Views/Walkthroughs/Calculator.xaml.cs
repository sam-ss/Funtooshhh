﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace UXDivers.Artina.Grial
{ 
    public partial class Calculator : CarouselPage
    {
        public Calculator()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
        }

        public void GoToStep()
        {
            var index = Children.IndexOf(CurrentPage);
            var moveToIndex = 0;
            if (index < Children.Count - 1)
            {
                moveToIndex = index + 1;

                SelectedItem = Children[moveToIndex];
            }
            else
            {
                Close();
            }
        }

        public async void Close()
        {
            await Navigation.PopModalAsync();
        }

        protected async override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();
            var currentStep = (WalkthroughStepItemTemplate)CurrentPage;

            await currentStep.AnimateIn();
        }
    }
}
