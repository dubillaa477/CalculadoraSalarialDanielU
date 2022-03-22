using System;
using System.Collections.Generic;
using System.Text;
using CalculadoraSalarialDanielU.Model;
using Xamarin.Forms;

namespace CalculadoraSalarialDanielU.ModelView
{
    internal class MainViewVM
    {
        public CalculadoraModel calculadora { get; set; }
        public Command OperationCommand { get; set; }

        public MainViewVM(){
            calculadora = new CalculadoraModel() {
                SalarioBruto = 0,
                IngresosExtra = 0,
                Reembolso = 0,
                Asociacion = 5
            };
            OperationCommand = new Command(CalcularSalario);
        }

        public void CalcularSalario() { 
            calculadora.TotalIngresos = calculadora.SalarioBruto + calculadora.IngresosExtra + calculadora.Reembolso;
            calculadora.EnfermedadMaternidad = calculadora.TotalIngresos * 5.5 / 100;
            calculadora.Ivm = calculadora.TotalIngresos * 3.84/100;
            calculadora.Aporte = calculadora.TotalIngresos * 1 / 100;
            calculadora.AsociaRed = calculadora.Asociacion / 100 * calculadora.TotalIngresos;
            calculadora.TotalDeducciones = calculadora.EnfermedadMaternidad + calculadora.Aporte + calculadora.Ivm + calculadora.AsociaRed + calculadora.Pensiones;
            calculadora.SalarioGravable = calculadora.TotalIngresos;
            calculadora.ImpRenta = CalcularRenta(calculadora.SalarioGravable);
            calculadora.IngresoNeto = calculadora.SalarioGravable - calculadora.TotalDeducciones;
        }

        public double CalcularRenta(double salario)
        {
            double impRenta = 0;
            if (salario > 840000 && salario <= 1233000)
            {
                impRenta = salario * 0.1;
            }
            else if (salario > 1233000 && salario <= 2163000)
            {
                impRenta = salario * 0.15;
            }
            else if (salario > 2163000 && salario <= 4325000)
            {
                impRenta = salario * 0.2;
            }
            else if (salario > 4325000) {
                impRenta = salario * 0.25;
            }

            return impRenta;
        }
    }
}
