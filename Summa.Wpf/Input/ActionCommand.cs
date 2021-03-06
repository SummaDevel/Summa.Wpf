using Summa.Data;
using System;
using System.Windows.Input;

namespace Summa.Wpf.Input
{

    /// <summary>
    /// Defines a parameterless command.
    /// </summary>
    public sealed class ActionCommand : ICommand
    {

        #region Fields

        private readonly Action _execute;
        private readonly Condition _canExecute;

        #endregion

        #region Events

        /// <inheritdoc/>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Instantiate a new <see cref="ActionCommand"/> with the given <paramref name="execute"/>.
        /// </summary>
        /// <param name="execute"> Action to execute. </param>
        /// <exception cref="ArgumentNullException"> Given <paramref name="execute"/> is <c>Null</c>. </exception>
        public ActionCommand(Action execute) : this(execute, null) { }

        /// <summary>
        /// Instantiate a new <see cref="ActionCommand"/> with the given <paramref name="execute"/> and <paramref name="canExecute"/>.
        /// </summary>
        /// <param name="execute"> Action to execute. </param>
        /// <param name="canExecute"> Defines the method that determines whether the command can be executed in the current state. </param>
        /// <exception cref="ArgumentNullException"> Given <paramref name="execute"/> is <c>Null</c>. </exception>
        public ActionCommand(Action execute, Condition canExecute)
        {

            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;

        }

        #endregion

        #region Public methods

        /// <summary>
        /// Gets whether the command can be executed or not.
        /// </summary>
        /// <param name="parameter"> Command parameters. </param>
        /// <returns> <c>True</c> if the command can be executed, otherwise <c>False</c>. </returns>
        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute();
        }

        /// <summary>
        /// Execute the command with the given parameters.
        /// </summary>
        /// <param name="parameter"> Command parameters. </param>
        public void Execute(object parameter)
        {
            _execute();
        }

        #endregion

    }

}