namespace Summa.Wpf
{

    /// <summary>
    /// Defines an item.
    /// </summary>
    public class Item
    {

        #region Properties

        /// <summary>
        /// Item display name.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Item value.
        /// </summary>
        public object Value { get; set; }

        #endregion

        #region Ctors

        /// <summary>
        /// Instantiates a new <see cref="Item"/>.
        /// </summary>
        /// <param name="displayName"> Item display name. </param>
        /// <param name="value"> Item value. </param>
        public Item(string displayName, object value)
        {
            DisplayName = displayName;
            Value = value;
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Gets the string representation of this item.
        /// </summary>
        /// <returns> A string representing this item. </returns>
        public override string ToString()
        {
            return DisplayName;
        }

        #endregion

    }

}
