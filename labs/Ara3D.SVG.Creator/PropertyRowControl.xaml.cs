﻿using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Ara3D.Mathematics;
using Ara3D.Utils.Wpf;

namespace Ara3D.SVG.Creator
{
    public partial class PropertyRowControl : INotifyPropertyChanged
    {
        public PropertyRowControl()
        {
            InitializeComponent();
            Button.MouseRightButtonDown += (sender, args) => StartMouseTracking();
            Button.MouseRightButtonUp += (sender, args) => EndMouseTracking();
            Button.MouseMove += (sender, args) => UpdateMouseTracking();
        }

        public NumericControl AddProperty(string name, Color backColor, 
            float changeAmount, float defaultValue,  float currentValue, Action<float> onChanged)
        {
            var control = new NumericControl
            {
                Value = currentValue,
                ChangeSize = changeAmount,
                Label = name,
                Brush = new SolidColorBrush(backColor)
            };
            control.PropertyChanged += (sender, _args) =>
            {
                onChanged(control.Value);
                OnPropertyChanged(name);
            };
            Controls.Add(control);
            Grid.Children.Add(control);
            Grid.SetColumn(control, Controls.Count);
            return control;
        }
        
        public string Name
        {
            get => Button.Content as string;
            set => Button.Content = value;
        }

        public Vector2 Value
        {
            get => (Value1, Value2);
            set => (Value1, Value2) = (value.X, value.Y);
        }

        public float Value1
        {
            get => Controls[0].Value;
            set => Controls[0].Value = value;
        }

        public float Value2
        {
            get => Controls.Count > 1 ? Controls[1].Value : 0;
            set
            {
                if (Controls.Count > 1)
                    Controls[1].Value = value;
            }
        }

        public List<NumericControl> Controls { get; } = new();
        
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public bool TrackMouse = false;
        private Vector2 _startMouse;
        private Vector2 _startValue;

        public void StartMouseTracking()
        {
            if (!Button.CaptureMouse())
                return;
            TrackMouse = true;
            _startMouse = Button.GetMouseVector();
            _startValue = Value;
        }

        public void EndMouseTracking()
        {
            TrackMouse = false;
            Button.ReleaseMouseCapture();
        }

        public void UpdateMouseTracking()
        {
            if (Mouse.RightButton == MouseButtonState.Pressed)
            {
                if (!Button.IsMouseCaptured || !TrackMouse)
                {
                    StartMouseTracking();
                }
            }

            if (!Button.IsMouseCaptured || !TrackMouse || Mouse.RightButton == MouseButtonState.Released)
            {
                EndMouseTracking();
                return;
            }

            var pt = Button.GetMouseVector();
            var offset = pt - _startMouse;
            Value = _startValue + (offset * Controls[0].PixelToAmount);
        }
    }
}
