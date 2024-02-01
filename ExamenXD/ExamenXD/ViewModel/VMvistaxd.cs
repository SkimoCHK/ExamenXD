using CriticografoMVVM_MALH.VistaModelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
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
        private double _FCN;
        private bool _CalcularIMC;
        private bool _CalcularFCN;
        private bool _Imagen1;
        private bool _Imagen2;
        private string _ResultadoIMC;
        private string _ResultadoFCN;
        #endregion

        #region CONSTRUCTOR
       public VMvistaxd(INavigation navigation) 
        {
            Navigation = navigation;
        }
        #endregion

        #region OBJETOS
        public double FCN
        {
           get { return _FCN; }
           set { SetValue(ref _FCN, value); }
        }
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
        public bool Imagen1
        {
            get { return _Imagen1; }
            set { SetValue(ref _Imagen1, value);}
        }

        public bool Imagen2
        {
            get { return _Imagen2; }
            set { SetValue(ref _Imagen2, value); }
        }
        public string ResultadoIMC
        {
            get { return _ResultadoIMC; }
            set { SetValue(ref _ResultadoIMC, value); }
        }
        public string ResultadoFCN
        {
            get { return _ResultadoFCN; }
            set { SetValue(ref _ResultadoFCN, value); }
        }

        #endregion
        #region PROCESOS
        public void CalcuIMC()
        {
            IMC = Peso / (Altura * Altura);
            
        }
        public void CalcuFCN()
        {
            FCN = Corazon * 4;
        }
        public async void Calcular()
        {
            if (CalcularIMC)
            {
                CalcuIMC();
                if (IMC < 18.5)
                {
                    await DisplayAlert("AVISO", "Andas bien desnutrido compa", "Salir");
                    ResultadoIMC = $"Su IMC es de {IMC}";
                    Imagen2 = true;
                }
                else
                {
                    if(IMC >= 18.5 && IMC <= 25.9)
                    {
                        await DisplayAlert("AVISO", "Andas al fregaso compa", "Salir");
                        ResultadoIMC = $"Su IMC es de {IMC}";
                        Imagen1 = true;
                    }
                    else
                    {
                        if (IMC>= 25.0 && IMC<29.9)
                        {
                            await DisplayAlert("AVISO", "Andas bien obeso carnal", "Salir");
                            ResultadoIMC = $"Su IMC es de {IMC}";
                            Imagen2 = true;
                        }
                        else
                        {
                            await DisplayAlert("AVISO", "Vete a operar compa", "Salir");
                            ResultadoIMC = $"Su IMC es de {IMC}";
                            Imagen2 = true;
                        }
                    }
                }

            }
            else if (CalcularFCN)
            {
                CalcuFCN();
                if (FCN < 60)
                {
                    await DisplayAlert("ATENCIÓN", "Frecuencia cardiaca baja", "Salir");
                    ResultadoFCN = $"Su frecuencia cardiaca es de {FCN}";
                    Imagen2= true;
                    Imagen1 = false;
                }
                else
                {
                    if(FCN >= 60 && FCN <= 100)
                    {
                        await DisplayAlert("ATENCIÓN", "Frecuencia cardiaca normal", "Salir");
                        ResultadoFCN = $"Su frecuencia cardiaca es de {FCN}";
                        Imagen1 = true;
                        Imagen2 = false;
                    }
                    else
                    {
                        await DisplayAlert("ATENCIÓN", "Frecuencia cardiaca alta", "Salir");
                        ResultadoFCN = $"Su frecuencia cardiaca es de {FCN}";
                        Imagen2 = true;
                        Imagen1 = false;
                    }
                }
                FCN = 0;
                CalcularFCN = false;

            }
            else
            {
                await DisplayAlert("AVISO", "Seleccione una opcion", "Salir");
            }

        }
        #endregion

        #region COMANDOS
        public ICommand CalcularCommand => new Command(Calcular);
        #endregion
    }
}
