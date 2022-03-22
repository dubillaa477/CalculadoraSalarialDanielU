using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace CalculadoraSalarialDanielU.Model
{
    internal class CalculadoraModel : INotifyPropertyChanged
    {
        private double salarioBruto;

        public double SalarioBruto
        {
            get { return salarioBruto; }
            set {
                salarioBruto = value;
                OnPropertyChanged();
            }
        }

        private double ingresosExtra;

        public double IngresosExtra
        {
            get { return ingresosExtra; }
            set { 
                ingresosExtra = value;
                OnPropertyChanged();
            }
        }

        private double reembolso;

        public double Reembolso
        {
            get { return reembolso; }
            set { reembolso = value;
                OnPropertyChanged();
            }
        }
        private double totalIngresos;

        public double TotalIngresos
        {
            get { return totalIngresos; }
            set { 
                totalIngresos = value;
                OnPropertyChanged();
            }
        }


        private double enfermedadMaternidad;

        public double EnfermedadMaternidad
        {
            get { return enfermedadMaternidad; }
            set { enfermedadMaternidad = value; 
                OnPropertyChanged ();
            }
        }

        private double ivm;

        public double Ivm
        {
            get { return ivm; }
            set { ivm = value;
                OnPropertyChanged();
            }
        }

        private double aporte;

        public double Aporte
        {
            get { return aporte; }
            set { aporte = value;
                OnPropertyChanged();
            }
        }


        private double asociacion;

        public double Asociacion
        {
            get { return asociacion; }
            set { asociacion = value;
                OnPropertyChanged();
                }
        }

        private double asociaRed;

        public double AsociaRed
        {
            get { return asociaRed; }
            set { asociaRed = value;
                OnPropertyChanged();
            }
        }


        private double pensiones;

        public double Pensiones
        {
            get { return pensiones; }
            set { 
                pensiones = value;
                OnPropertyChanged();
            }
        }

        private double salarioGravable;

        public double SalarioGravable
        {
            get { return salarioGravable; }
            set { salarioGravable = value;
                OnPropertyChanged();
            }
        }


        private double impRenta;

        public double ImpRenta
        {
            get { return impRenta; }
            set { impRenta = value;
                OnPropertyChanged();
            }
        }


        private double totalDeducciones;

        public double TotalDeducciones
        {
            get { return totalDeducciones; }
            set { totalDeducciones = value;
                OnPropertyChanged();
            }
        }

        private double ingresoNeto;

        public double IngresoNeto
        {
            get { return ingresoNeto; }
            set { ingresoNeto = value;
                OnPropertyChanged();
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) { 
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
