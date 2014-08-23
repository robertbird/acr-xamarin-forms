﻿using System;
using Xamarin.Forms;


namespace Acr.XamForms.Controls {
    
    public class ExtendedEntryCell : EntryCell {
        public static readonly BindableProperty IsPasswordProperty = BindableProperty.Create<ExtendedEntryCell, bool>(x => x.IsPassword, false);
        public static readonly BindableProperty IsVisibleProperty = BindableProperty.Create<ExtendedEntryCell, bool>(x => x.IsVisible, false);
        public static readonly BindableProperty IsSeparatorVisibleProperty = BindableProperty.Create<ExtendedEntryCell, bool>(x => x.IsSeparatorVisible, false);
        public static readonly BindableProperty SeparatorColorProperty = BindableProperty.Create<ExtendedEntryCell, Color>(x => x.SeperatorColor, Color.Default);


        public bool IsPassword {
            get { return (bool)this.GetValue(IsPasswordProperty); }
            set { this.SetValue(IsPasswordProperty, value); }
        }


        public bool IsVisible {
            get { return (bool)this.GetValue(IsVisibleProperty); }
            set { this.SetValue(IsVisibleProperty, value); }
        }


        public bool IsSeparatorVisible {
            get { return (bool)this.GetValue(IsSeparatorVisibleProperty); }
            set { this.SetValue(IsSeparatorVisibleProperty, value); }
        }


        public Color SeperatorColor {
            get { return (Color)this.GetValue(SeparatorColorProperty); }
            set { this.SetValue(SeparatorColorProperty, value); }
        }
    }
}