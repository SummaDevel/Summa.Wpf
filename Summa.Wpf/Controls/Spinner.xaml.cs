using System;
using System.Windows.Controls;

namespace Summa.Wpf
{

    /// <summary>
    /// Defines a spinner.
    /// </summary>
    public partial class Spinner : UserControl
    {

        #region Events

        /// <summary>
        /// Fired when the spinner is spinned.
        /// </summary>
        public event EventHandler<SpinEventArgs> Spin;

        #endregion

        #region Properties



        #endregion

        #region Ctors

        /// <summary>
        /// Instantiates a new <see cref="Spinner"/>.
        /// </summary>
        public Spinner()
        {
            InitializeComponent();
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Called when the content template has to be applied.
        /// </summary>
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            UpButton.Click += (s, e) =>
            {
                RaiseSpin(SpinDirection.Up);
            };

            DownButton.Click += (s, e) =>
            {
                RaiseSpin(SpinDirection.Down);
            };

        }

        #endregion

        #region Private methods

        private void RaiseSpin(SpinDirection direction)
        {

            Spin?.Invoke(this, new SpinEventArgs(direction));

        }

        #endregion

    }

    /// <summary>
    /// Defines the <see cref="Spinner"/> spin event args.
    /// </summary>
    public class SpinEventArgs : EventArgs
    {

        #region Properties

        /// <summary>
        /// Event spin direction.
        /// </summary>
        public SpinDirection Direction { get; }

        #endregion

        #region Ctors

        /// <summary>
        /// Instantiates a new <see cref="SpinEventArgs"/> with the given direction.
        /// </summary>
        /// <param name="direction"> Spin direction. </param>
        public SpinEventArgs(SpinDirection direction)
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
