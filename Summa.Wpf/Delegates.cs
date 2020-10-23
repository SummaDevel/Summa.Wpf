using System.Windows;

/// <summary>
/// Defines a typed routed event args.
/// </summary>
/// <typeparam name="T"> Args type. </typeparam>
/// <param name="sender"> Event sender. </param>
/// <param name="e"> Event info. </param>
public delegate void RoutedEventHandler<T>(object sender, T e) where T : RoutedEventArgs;