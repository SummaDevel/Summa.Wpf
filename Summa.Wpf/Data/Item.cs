namespace Summa.Wpf.Data
{

    /// <summary>
    /// Defines an item which holds a value.
    /// </summary>
    public class Item : NamedObject
    {

        #region Fields

        private object _value;

        #endregion

        #region Properties

        /// <summary>
        /// Item value.
        /// </summary>
        public object Value
        {
            get => _value;
            set => RaiseChangedIfNotEqual(ref _value, value);
        }

        #endregion

        #region Ctors

        /// <summary>
        /// Instantiates a new <see cref="Item"/>.
        /// </summary>
        /// <param name="displayName"> Item display name. </param>
        /// <param name="value"> Item value. </param>
        public Item(string displayName, object value) : base(displayName)
        {
            Value = value;
        }

        #endregion

    }

}
