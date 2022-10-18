﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto_1_HPA_4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VerListado : ContentPage
    {
        public VerListado()
        {
            InitializeComponent();
            var listView = new ListView();
            listView.ItemsSource = new string[]
            {
                  "mono",
                  "monodroid",
                  "monotouch",
                  "monorail",
                  "monodevelop",
                  "monotone",
                  "monopoly",
                  "monomodal",
                  "mononucleosis"
            };
        }
    }
}