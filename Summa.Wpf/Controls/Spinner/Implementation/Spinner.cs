using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace Summa.Wpf
{

    /// <summary>
    /// Defines a spinner.
    /// </summary>
    [TemplatePart(Name = "PART_UpRepeatButton")]
    [TemplatePart(Name = "PART_DownRepeatButton")]
    public class Spinner : Control
    {

        #region Routed events

        /// <summary>
        /// Defines the <see cref="Spin"/> routed event.
        /// </summary>
        public static readonly RoutedEvent SpinEvent =
            EventManager.RegisterRoutedEvent(nameof(Spin), RoutingStrategy.Bubble, typeof(SpinEventHandler), typeof(Spinner));

        #endregion

        #region Events

        /// <summary>
        /// Fired each time the spinner spins.
        /// </summary>
        public event SpinEventHandler Spin
        {
            add
            {
                AddHandler(SpinEvent, value);
            }
            remove
            {
                RemoveHandler(SpinEvent, value);
            }
        }

        #endregion

        #region Dependency properties

        /// <summary>
        /// Defines the <see cref="UpRepeatButtonStyle"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty UpRepeatButtonStyleProperty =
            DependencyProperty.Register(nameof(UpRepeatButtonStyle), typeof(Style), typeof(Spinner), new PropertyMetadata(null, OnUpButtonStyleChanged));

        /// <summary>
        /// Defines the <see cref="DownRepeatButtonStyle"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty DownRepeatButtonStyleProperty =
            DependencyProperty.Register(nameof(DownRepeatButtonStyle), typeof(Style), typeof(Spinner), new PropertyMetadata(null, OnDownButtonStyleChanged));

        #endregion

        #region Properties

        /// <summary>
        /// Gets/ sets the up button style.
        /// </summary>
        public Style UpRepeatButtonStyle
        {
            get { return (Style)GetValue(UpRepeatButtonStyleProperty); }
            set { SetValue(UpRepeatButtonStyleProperty, value); }
        }

        /// <summary>
        /// Gets/ sets the down button style.
        /// </summary>
        public Style DownRepeatButtonStyle
        {
            get { return (Style)GetValue(DownRepeatButtonStyleProperty); }
            set { SetValue(DownRepeatButtonStyleProperty, value); }
        }

        /// <summary>
        /// Gets the up button.
        /// </summary>
        protected RepeatButton UpButton { get; private set; }

        /// <summary>
        /// Gets the down button.
        /// </summary>
        protected RepeatButton DownButton { get; private set; }

        #endregion

        #region Ctors

        /// <summary>
        /// Instantiates a new <see cref="Spinner"/>.
        /// </summary>
        public Spinner()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Spinner), new FrameworkPropertyMetadata(typeof(Spinner)));
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Called when the content template has to be applied.
        /// </summary>
        public override void OnApplyTemplate()
        {

            base.OnApplyTemplate();

            UpButton = (RepeatButton)GetTemplateChild("PART_UpRepeatButton");
            DownButton = (RepeatButton)GetTemplateChild("PART_DownRepeatButton");

            UpRepeatButtonStyle = UpRepeatButtonStyle;
            DownRepeatButtonStyle = DownRepeatButtonStyle;

            UpButton.Click += (s, e) => RaiseSpin(SpinDirection.Up);

            DownButton.Click += (s, e) => RaiseSpin(SpinDirection.Down);

        }

        /// <summary>
        /// Handles the <see cref="UpRepeatButtonStyle"/> changed event.
        /// </summary>
        /// <param name="sender"> Event sender. </param>
        /// <param name="e"> Event info. </param>
        public static void OnUpButtonStyleChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {

            Spinner spinner = sender as Spinner;

            if (sender == null ||
                e.NewValue == null)
            {
                return;
            }

            spinner.UpButton.Style = (Style)e.NewValue;

        }

        /// <summary>
        /// Handles the <see cref="DownRepeatButtonStyle"/> changed event.
        /// </summary>
        /// <param name="sender"> Event sender. </param>
        /// <param name="e"> Event info. </param>
        public static void OnDownButtonStyleChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {

            Spinner spinner = sender as Spinner;

            if (sender == null ||
                e.NewValue == null)
            {
                return;
            }

            spinner.DownButton.Style = (Style)e.NewValue;

        }

        #endregion

        #region Private methods

        private void RaiseSpin(SpinDirection direction)
        {
            RaiseEvent(new SpinEventArgs(SpinEvent, direction));
        }

        #endregion

    }

    /// <summary>
    /// Defines the <see cref="Spinner.Spin"/> event handler.
    /// </summary>
    /// <param name="sender"> Event sender. </param>
    /// <param name="e"> Event info. </param>
    public delegate void SpinEventHandler(object sender, SpinEventArgs e);

    /// <summary>
    /// Defines the <see cref="Spinner.Spin"/> event info.
    /// </summary>
    public class SpinEventArgs : RoutedEventArgs
    {

        #region Properties

        public SpinDirection Direction { get; set; }

        #endregion

        #region Ctors

        public SpinEventArgs(SpinDirection direction)
        {
            Direction = direction;
        }

        public SpinEventArgs(RoutedEvent routedEvent, SpinDirection direction) : base(routedEvent)
        {
            Direction = direction;
        }

        #endregion

    }

    /// <summary>
    /// Defines the <see cref="Spinner"/> spin direction.
    /// </summary>
    public enum SpinDirection
    {
        /// <summary>
        /// Up.
        /// </summary>
        Up,
        /// <summary>
        /// Down.
        /// </summary>
        Down
    }
}
