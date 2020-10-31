using System.Collections.ObjectModel;

namespace Summa.Wpf
{

    /// <summary>
    /// Defines an <see cref="Item"/> collection.
    /// </summary>
    public class ItemCollection : ObservableCollection<Item>
    {

        #region Ctors

        /// <summary>
        /// Instantiates a new <see cref="ItemCollection"/>.
        /// </summary>
        public ItemCollection()
        { }

        #endregion

        #region Public methods

        /// <summary>
        /// Adds the given value to the instance, using its string representation as display name.
        /// </summary>
        /// <param name="value"> The value to add. </param>
        public void Add(object value)
        {
            Add(value.ToString(), value);
        }

        /// <summary>
        /// Adds a new <see cref="Item"/> to the collection using the given values.
        /// </summary>
        /// <param name="displayName"> Item display name. </param>
        /// <param name="value"> Item value. </param>
        public void Add(string displayName, object value)
        {
            base.Add(new Item(displayName, value));
        }

        #endregion

    }

}
