using System.Reflection;
using System.Windows.Media;

namespace Summa.Wpf
{
    /// <summary>
    /// Defines a <see cref="SolidColorBrush"/> source.
    /// </summary>
    public class SolidColorBrushSource : ItemsSource
    {

        #region Ctors

        /// <summary>
        /// Instantiates a new <see cref="SolidColorBrushSource"/>.
        /// </summary>
        public SolidColorBrushSource()
        {

            foreach (var property in typeof(Colors).GetProperties(BindingFlags.Static | BindingFlags.Public))
            {
                Add(property.Name, new SolidColorBrush((Color)property.GetValue(null)));
            }

        }

        #endregion

    }

}
