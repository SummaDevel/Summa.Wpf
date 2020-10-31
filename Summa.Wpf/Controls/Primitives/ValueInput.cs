using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Summa.Wpf
{

    /// <summary>
    /// Defines the base class for a value input control.
    /// </summary>
    public abstract class ValueInput : Control
    {

        #region Dependency property

        /// <summary>
        /// Defines the <see cref="Text"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register(nameof(Text), typeof(string), typeof(ValueInput), new FrameworkPropertyMetadata(default(String), FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, OnTextChanged, null, false, UpdateSourceTrigger.LostFocus));

        /// <summary>
        /// Defines the <see cref="TextAlignment"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty TextAlignmentProperty =
            DependencyProperty.Register(nameof(TextAlignment), typeof(TextAlignment), typeof(ValueInput), new PropertyMetadata(TextAlignment.Left));

        #endregion

        #region Properties

        /// <summary>
        /// Gets/ sets the text.
        /// </summary>
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        /// <summary>
        /// Gets/ sets the text alignment.
        /// </summary>
        public TextAlignment TextAlignment
        {
            get { return (TextAlignment)GetValue(TextAlignmentProperty); }
            set { SetValue(TextAlignmentProperty, value); }
        }

        #endregion

        #region Ctors

        /// <summary>
        /// Instantiates a new <see cref="ValueInput"/>.
        /// </summary>
        public ValueInput()
        {

        }

        #endregion

        #region Protected methods

        /// <summary>
        /// Called when the <see cref="Text"/> property changes.
        /// </summary>
        /// <param name="oldValue"> Old value. </param>
        /// <param name="newValue"> New value. </param>
        protected void OnTextChanged(string oldValue, string newValue)
        { }

        #endregion

        #region Private methods

        private static void OnTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

            ValueInput input = d as ValueInput;

            if (input == null)
            {
                return;
            }

            input.OnTextChanged((string)e.OldValue, (string)e.NewValue);

        }

        #endregion

    }

}
