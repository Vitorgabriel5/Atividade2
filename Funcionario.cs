﻿
using System.Globalization;
using System.Runtime.InteropServices;

namespace Atividade2 {
    internal class Funcionario {

        public string Nome;
        public double Salario;
        public double Imposto;

        public double SalarioLiquido() {
            return Salario - Imposto ;
        }
        public void AumentoSalario(double porcentagem) {
            Salario = Salario+ (Salario * porcentagem / 100);
        }
        public override string ToString() {
            return Nome
                +" "
                +"$"
                + SalarioLiquido().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
