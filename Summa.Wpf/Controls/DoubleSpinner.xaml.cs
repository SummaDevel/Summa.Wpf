using System;
using System.Windows;
using System.Windows.Controls;

namespace Summa.Wpf
{

    /// <summary>
    /// Defines a <see cref="double"/> spinner.
    /// </summary>
    public partial class DoubleSpinner : UserControl
    {

        #region Dependency properties

        /// <summary>
        /// Defines the <see cref="Value"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register(nameof(Value), typeof(double), typeof(DoubleSpinner), new PropertyMetadata(0d));

        /// <summary>
        /// Defines the <see cref="Increment"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty IncrementProperty =
            DependencyProperty.Register(nameof(Increment), typeof(double), typeof(DoubleSpinner), new PropertyMetadata(1d));

        /// <summary>
        /// Defines the <see cref="Decrement"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty DecrementProperty =
            DependencyProperty.Register(nameof(Decrement), typeof(double), typeof(DoubleSpinner), new PropertyMetadata(1d));

        #endregion

        #region Properties

        /// <summary>
        /// Gets/ sets the spinner value.
        /// </summary>
        public double Value
        {
            get { return (double)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        public double Increment
        {
            get { return (double)GetValue(IncrementProperty); }
            set { SetValue(IncrementProperty, value); }
        }

        public double Decrement
        {
            get { return (double)GetValue(DecrementProperty); }
            set { SetValue(DecrementProperty, value); }
        }

        #endregion

        #region Events

        /// <summary>
        /// Fired when the spinner is spinned.
        /// </summary>
        public event EventHandler<SpinEventArgs> Spin;

        #endregion

        #region Ctors

        /// <summary>
        /// Instantiates a new <see cref="DoubleSpinner"/>
        /// </summary>
        public DoubleSpinner()
        {
            InitializeComponent();

            LayoutRoot.DataContext = this;

        }

        #endregion

        #region Public methods

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            Spinner.Spin += (s, e) =>
            {
                RaiseSpin(e.Direction);
            };

        }

        #endregion

        #region Private methods

        private void OnKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {

            if (e.Key == System.Windows.Input.Key.Up)
            {
                RaiseSpin(SpinDirection.Up);
            }

            if (e.Key == System.Windows.Input.Key.Down)
            {
                RaiseSpin(SpinDirection.Down);
            }

        }

        private void RaiseSpin(SpinDirection direction)
        {

            switch (direction)
            {
                case SpinDirection.Up:
                    Value += Increment;
                    break;
                case SpinDirection.Down:
                    Value -= Decrement;
                    break;
                default:
                    break;
            }

            Spin?.Invoke(this, new SpinEventArgs(direction));

        }

        #endregion

    }
}
