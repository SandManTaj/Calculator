using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;

namespace Calculator.ViewModel
{
    public class ViewModel : ViewModelBase
    {
        public ICommand MySum { get; set; }
        public ICommand MyDifference { get; set; }
        public ICommand MyProduct { get; set; }

        public ICommand MyQuotient { get; set; }

        private string _number1;
        public string Number1
        {
            get { return _number1; }
            set { _number1 = value; }
        }

        private string _number2;
        public string Number2
        {
            get { return _number2; }
            set { _number2 = value; }
        }

        private string _result;
        public string Result
        {
            get { return _result; }
            set { _result = value; }
        }

        public ViewModel()
        {
            MySum = new RelayCommand(sum, canexecute);
            MyDifference = new RelayCommand(difference, canexecute);
            MyProduct = new RelayCommand(product, canexecute);
            MyQuotient = new RelayCommand(quotient, canexecute);
        }

        private bool canexecute()
        {
            if (!string.IsNullOrEmpty(Number1) && !string.IsNullOrEmpty(Number2))
            {
                return true;
            }
            return false;

        }
        private void sum()
        {
            Result = (Convert.ToDouble(Number1) + Convert.ToDouble(Number2)).ToString();
            RaisePropertyChanged("Result");
        }
        private void difference()
        {
            Result = (Convert.ToDouble(Number1) - Convert.ToDouble(Number2)).ToString();
            RaisePropertyChanged("Result");
        }
        private void product()
        {
            Result = (Convert.ToDouble(Number1) * Convert.ToDouble(Number2)).ToString();
            RaisePropertyChanged("Result");
        }
        private void quotient()
        {
            Result = (Convert.ToDouble(Number1) / Convert.ToDouble(Number2)).ToString();
            RaisePropertyChanged("Result");
        }

    }
}

