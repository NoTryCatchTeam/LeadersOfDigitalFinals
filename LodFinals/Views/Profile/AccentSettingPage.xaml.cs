﻿using FFImageLoading.Svg.Forms;
using NoTryCatch.Xamarin.Portable.Extensions;
using NoTryCatch.Xamarin.Portable.ViewControls;

namespace LodFinals.Views.Profile
{
    public partial class AccentSettingPage : BasePage
    {
        public AccentSettingPage()
        {
            InitializeComponent();

            SvgImageSource closeIcon = AppImages.IcClose;
            closeIcon.SetTintColor(AppColors.Navy);

            icClose.Source = closeIcon;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            icClose.SetTintColor(AppColors.Navy);
        }
    }
}
