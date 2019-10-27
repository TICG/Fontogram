﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

    public interface LayerObjectCreator
    {
        LayerBoxItem CreateLayer(int position);
    }


    public interface LayerEditor
    {
        int SelectedLayerIndex { get; set; }

        ObservableCollection<LayerBoxItem> LiveTopToBottomLayers { get; }

        void SetLayerCreator(LayerObjectCreator creator);

        event Action LayersChanged;


        void AddLayer();

        void RemoveCurrentLayer();

        void MoveUpSelectedLayer();

        void MoveDownSelectedLayer();
    }


    public abstract class LayerCommand
        : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public virtual bool CanExecute(object parameter)
        {
            return true;
        }

        public abstract void Execute(object parameter);


        internal LayerCommand(LayerEditor layerEditor)
        {
            _LayerEditor = layerEditor;
        }

        private protected readonly LayerEditor _LayerEditor;
    }

    public abstract class SelectedLayerCommand
        : LayerCommand
    {
        private protected SelectedLayerCommand(LayerEditor layerEditor)
            : base(layerEditor)
        {
        }
    }

    public class RemoveLayerCommand
        : SelectedLayerCommand
    {

        internal RemoveLayerCommand(LayerEditor layerEditor)
            : base(layerEditor)
        {
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            _LayerEditor.RemoveCurrentLayer();
        }
    }

    public class AddLayerCommand
        : LayerCommand
    {

        internal AddLayerCommand(LayerEditor layerEditor)
            : base(layerEditor)
        {
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            _LayerEditor.AddLayer();
        }
    }


    /// <summary>
    /// Interaction logic for LayerBoxControl.xaml
    /// </summary>
    public partial class LayerBox
        : ListBox
        , LayerEditor
    {

        public ObservableCollection<LayerBoxItem> LiveTopToBottomLayers { get; } = new ObservableCollection<LayerBoxItem>();


        public RemoveLayerCommand _RemoveCommand { get; }

        public AddLayerCommand _AddCommand { get; }


        public LayerBox()
        {
            InitializeComponent();

            this.ItemsSource = LiveTopToBottomLayers;

            _RemoveCommand = new RemoveLayerCommand(this);
            _AddCommand = new AddLayerCommand(this);
        }


        private int _selectedLayerIndex;
        public int SelectedLayerIndex
        {
            get { return this.LiveTopToBottomLayers.Count - this.SelectedIndex - 1; }
            set { this.SelectedIndex = this.LiveTopToBottomLayers.Count - value - 1; }
        }

        public void AddLayer()
        {
            int newIndex = SelectedIndex;
            if (newIndex < 0)
                newIndex = 0;
            RepositionLayer(-1, newIndex);
        }

        public void RemoveCurrentLayer()
        {
            RepositionLayer(SelectedIndex, -1);
        }


        public void MoveUpSelectedLayer()
        {
            // since layers are shown reversed, we need to decrease the index

            RepositionLayer(SelectedIndex, SelectedIndex - 1);
        }

        public void MoveDownSelectedLayer()
        {
            // since layers are shown reversed, we need to increase the index

            RepositionLayer(SelectedIndex, SelectedIndex + 1);
        }

        private void RepositionLayer(int originalLayerIndex, int newLayerIndex)
        {
            int layerCount = LiveTopToBottomLayers.Count;
            LayerBoxItem layerItem = null;

            bool changeEffected = false;

            // 1. Remove from old position.

            if (originalLayerIndex >= 0 && originalLayerIndex < layerCount)
            {
                layerItem = LiveTopToBottomLayers[originalLayerIndex];
                LiveTopToBottomLayers.RemoveAt(originalLayerIndex);

                // Layers above (meaning: at lower indexes in the ListBox) will have their position in the Fontogram decremented.
                for (int i = 0; i < originalLayerIndex; i++)
                    LiveTopToBottomLayers[i].Position--;

                changeEffected = true;
            }


            // 2. Add into new position.

            layerCount = LiveTopToBottomLayers.Count;
            if (newLayerIndex >= 0 && newLayerIndex <= layerCount)
            {
                if (layerItem == null)
                {
                    if (_LayerObjectCreator != null)
                        layerItem = _LayerObjectCreator.CreateLayer(layerCount);
                }

                if (layerItem != null)
                {
                    LiveTopToBottomLayers.Insert(newLayerIndex, layerItem);

                    // Layers starting from the new position and up (lower indexes in the ListBox) must have their position in the Fontogram updated.
                    for (int i = 0; i <= newLayerIndex; i++)
                        LiveTopToBottomLayers[i].Position = layerCount - i;

                    SelectedIndex = newLayerIndex;

                    changeEffected = true;
                }
            }


            if (changeEffected)
                LayersChanged?.Invoke();
        }

        public void SetLayerCreator(LayerObjectCreator creator)
        {
            _LayerObjectCreator = creator;
        }

        LayerObjectCreator _LayerObjectCreator = null;

        public event Action LayersChanged;
    }

}
