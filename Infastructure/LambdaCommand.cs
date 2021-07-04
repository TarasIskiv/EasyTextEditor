﻿using EasyTextEditor.Infastructure.BaseCommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyTextEditor.Infastructure
{
    internal class LambdaCommand : Command
    {

        private readonly Action<Object> _Execute;
        private readonly Func<Object, bool> _CanExecute;
        LambdaCommand(Action<Object> Execute, Func<Object, bool> CanExecute)
        {
            _Execute = Execute ?? throw new ArgumentNullException(nameof(Execute));
            _CanExecute = CanExecute;
        }

        public override bool CanExecute(object parameter) => _CanExecute?.Invoke(parameter) ?? true;
        public override void Execute(object parameter) => _Execute(parameter);
    }
}
