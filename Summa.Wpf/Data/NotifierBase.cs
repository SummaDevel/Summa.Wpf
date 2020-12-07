using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Summa.Wpf
{

    /// <summary>
    /// Defines the base class for property notification classes.
    /// </summary>
    [Serializable]
    public class NotifierBase : INotifyPropertyChanged
    {

        #region Events

        /// <summary>
        /// Fired when one of the instance property value changed.
        /// </summary>
        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Protected methods

        /// <summary>
        /// Fires a new <see cref="PropertyChanged"/> event for the default indexer property.
        /// </summary>
        protected virtual void RaiseIndexer()
        {
            RaiseChanged("Item[]");
        }

        /// <summary>
        /// Fires a new <see cref="PropertyChanged"/> event for the given property name.
        /// </summary>
        /// <param name="propertyName"> Changed property name. </param>
        protected virtual void RaiseChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Fires a new <see cref="PropertyChanged"/> event for the given property name if the given values are not equal, returing whether the new value has been assigned.
        /// </summary>
        /// <param name="propertyValue"> Property value. </param>
        /// <param name="value"> New value. </param>
        /// <param name="propertyName"> Changed property name. </param>
        /// <returns> <see langword="true"/> if the value has been assigned, otherwise <see langword="false"/>. </returns>
        protected virtual bool RaiseChangedIfNotEqual<T>(ref T propertyValue, T value, [CallerMemberName] string propertyName = null)
        {

            if (propertyValue == null)
            {
                if (value == null)
                {
                    return false;
                }

            }
            else
            {

                if (value != null)
                {

                    if (propertyValue.Equals(value))
                    {
                        return false;
                    }

                }

            }

            propertyValue = value;

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

            return true;

        }

        #endregion

    }

}
