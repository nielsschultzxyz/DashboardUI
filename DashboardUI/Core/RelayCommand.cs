﻿using System;
using System.Windows.Input;

namespace DashboardUI.Core;

public class RelayCommand : ICommand
{
    private Action<object> _execute;
    private Func<object, bool> _canExecute;

    public bool CanExecute(object? parameter)
    {
        return this._canExecute == null || this.CanExecute(parameter);
    }

    public void Execute(object? parameter)
    {
        this._execute(parameter);
    }

    public event EventHandler? CanExecuteChanged
    {
        add { CommandManager.RequerySuggested += value; }
        remove { CommandManager.RequerySuggested -= value; }
    }

    public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
    {
        _execute = execute;
        _canExecute = canExecute;
    }
}