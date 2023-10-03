using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal.Class;

namespace Terminal.Interface
{
    public interface IOperaciones
    {
        public double Extraer(double Saldo);
        public double Depositar();
        public double Pagar(double Saldo, double Gas, double Luz, double Agua);
        public void Resumen(double Saldo);
    }
}
