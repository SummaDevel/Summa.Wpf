using System.Windows;

namespace Summa.Wpf
{

    /// <summary>
    /// Defines a proxy context, which contains wpf shareable data.
    /// </summary>
    public class ProxyContext : Freezable
    {

        #region Dependency properties

        /// <summary>
        /// Defines the <see cref="Data"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty DataProperty =
            DependencyProperty.Register(nameof(Data), typeof(object), typeof(ProxyContext), new PropertyMetadata(null));

        #endregion

        #region Properties

        /// <summary>
        /// Defines the proxy data.
        /// </summary>
        public object Data
        {
            get { return (object)GetValue(DataProperty); }
            set { SetValue(DataProperty, value); }
        }

        #endregion

        #region Ctors

        /// <summary>
        /// Instantiates a new <see cref="ProxyContext"/>.
        /// </summary>
        public ProxyContext()
        { }

        #endregion

        #region Protected methods

        /// <inheritdoc/>
        protected override Freezable CreateInstanceCore()
        {
            return new ProxyContext();
        }

        #endregion

    }

}
