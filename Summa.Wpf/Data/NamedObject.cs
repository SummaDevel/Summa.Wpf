namespace Summa.Wpf.Data
{

    /// <summary>
    /// Defines a named object.
    /// </summary>
    public class NamedObject : NotifierBase
    {

        #region Fields

        private string _displayName;

        #endregion

        #region Properties

        /// <summary>
        /// Gets/ sets the display name.
        /// </summary>
        public string DisplayName
        {
            get => _displayName;
            set => RaiseChangedIfNotEqual(ref _displayName, value);
        }

        #endregion

        #region Ctors

        /// <summary>
        /// Instantiates a new <see cref="NamedObject"/> with the given name.
        /// </summary>
        /// <param name="displayName"> Display name. </param>
        public NamedObject(string displayName)
        {
            DisplayName = displayName;
        }

        #endregion

        #region Public methods

        /// <inheritdoc/>
        public override string ToString() => DisplayName;

        #endregion

    }

}
