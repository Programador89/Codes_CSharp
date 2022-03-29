using System;

namespace ConsultaSalario {
    class Funcionario {

        public string Name;
        public double WageFirst;
        public double WageSecound;


        public double SalaryCalculation() {
            double _wage01 = WageFirst;
            double _wage02 = WageSecound;

            return (_wage01 + _wage02) /2;
        }
        
    }
}