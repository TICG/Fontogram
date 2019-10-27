﻿using PergleLabs.UI;
using System;
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

namespace PergleLabs.Fontogrammer
{

    public static class DependencyObjectEx
    {

        public static _T FindAncestor<_T>(this DependencyObject dependencyObject)
            where _T : DependencyObject
        {
            var parent = VisualTreeHelper.GetParent(dependencyObject);

            if (parent == null) return null;

            var typedParent = parent as _T;

            return typedParent ?? FindAncestor<_T>(parent);
        }

    }


    /// <summary>
    /// Interaction logic for LayerBoxFgItem.xaml
    /// </summary>
    public partial class LayerBoxFgItem
        : UserControl
    {

        public static readonly DependencyProperty LayerEditorProperty = DependencyProperty.Register("LayerEditor", typeof(LayerEditor), typeof(LayerBoxFgItem)
            );
        public LayerEditor LayerEditor
        {
            get { return (LayerEditor)GetValue(LayerEditorProperty); }
            set { SetValue(LayerEditorProperty, value); }
        }


        private ListBoxItem _ListBoxItem;


        public LayerBoxFgItem()
        {
            InitializeComponent();
        }

        protected override void OnVisualParentChanged(DependencyObject oldParent)
        {
            base.OnVisualParentChanged(oldParent);

            _ListBoxItem = this.FindAncestor<ListBoxItem>();
        }

        private void UserControl_MouseEnter(object sender, MouseEventArgs e)
        {
            _ListBoxItem.IsSelected = true;
        }
    }

}
