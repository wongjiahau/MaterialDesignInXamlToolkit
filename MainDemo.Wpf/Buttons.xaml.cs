﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MaterialDesignColors.WpfExample.Domain;
using MaterialDesignDemo.XamlDisplayerClass;

namespace MaterialDesignColors.WpfExample {
    /// <summary>
    /// Interaction logic for Buttons.xaml
    /// </summary>
    public partial class Buttons : UserControl {
        public Buttons() {
            InitializeComponent();
            XamlDisplayer.DisplayXamlCode(this);
            FloatingActionDemoCommand = new AnotherCommandImplementation(Execute);
        }

        public ICommand FloatingActionDemoCommand { get; }

        private void Execute(object o) {
            Console.WriteLine("Floating action button command. - " + (o ?? "NULL").ToString());
        }

        private void ButtonBase_OnClick(object sender , RoutedEventArgs e) {
            Console.WriteLine("Just checking we haven't suppressed the button.");
        }
    }
}
