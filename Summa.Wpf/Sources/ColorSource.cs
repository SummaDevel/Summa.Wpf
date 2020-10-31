using System.Reflection;
using System.Windows.Media;

namespace Summa.Wpf
{

    /// <summary>
    /// Defines a <see cref="Color"/> source.
    /// </summary>
    public class ColorSource : ItemsSource
    {

        #region Ctors

        /// <summary>
        /// Instantiates a new <see cref="ColorSource"/>.
        /// </summary>
        public ColorSource()
        {

            foreach (var property in typeof(Colors).GetProperties(BindingFlags.Static | BindingFlags.Public))
            {
                Add(property.Name, property.GetValue(null));
            }

        }

        #endregion

    }

}
