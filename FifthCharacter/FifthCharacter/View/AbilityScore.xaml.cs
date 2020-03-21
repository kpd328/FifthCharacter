﻿using FifthCharacter.Viewmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FifthCharacter.View {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AbilityScore : ContentView {
        public AbilityScore(IAbilityVM ability) {
            InitializeComponent();
            ability.Bind(this);
        }
    }
}