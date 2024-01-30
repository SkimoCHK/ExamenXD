using CriticografoMVVM_MALH.VistaModelo;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ExamenXD.ViewModel
{
    public class VMvistaxd : BaseViewModel
    {
        #region VARIABLES
        private double _Peso;
        private double _Altura;
        private double _IMC;
        private double _Corazon;
        private bool _CalcularIMC;
        private bool _CalcularFCN;
        #endregion

        #region CONSTRUCTOR
       public VMvistaxd(INavigation navigation) 
        {
            Navigation = navigation;
        }
        #endregion

        #region OBJETOS
        public double Peso
        {
            get { return _Peso; }
            set { SetValue(ref _Peso, value); }
        }
        public double Altura
        {
            get { return _Altura; }
            set { SetValue(ref _Altura, value); }
        }
        public double IMC
        {
            get { return _IMC; }
            set { SetValue(ref _IMC, value); }
        }
        public double Corazon
        {
            get { return _Corazon; }
            set { SetValue(ref _Corazon, value); }
        }
        public bool CalcularIMC
        {
            get { return _CalcularIMC; }
            set { SetValue(ref _CalcularIMC, value); }
        }
        public bool CalcularFCN
        {
            get { return _CalcularFCN; }
            set { SetValue(ref _CalcularFCN, value); }
        }
        #endregion
        #region PROCESOS

        #endregion

        #region COMANDOS

        #endregion
    }
}
