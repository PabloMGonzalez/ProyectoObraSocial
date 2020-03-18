using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObraSocial
{
    public class Plan
    {
        #region atributos

        private string _nombrePlan;
        private int _precio, _cobMedicamentos, _cobPracticas, _cobConsulta, _cobCirugia;
        //cob=cobertura

        #endregion

        #region propiedades

        public string NombrePlan
        {
            get { return _nombrePlan; }
            set { _nombrePlan = value; }
        }

        public int Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        public int CobMedicamientos
        {
            get { return _cobMedicamentos; }
            set { _cobMedicamentos = value; }
        }

        public int CobPracticas
        {
            get { return _cobPracticas; }
            set { _cobPracticas = value; }
        }

        public int CobConsulta
        {
            get { return _cobConsulta; }
            set { _cobConsulta = value; }
        }

        public int CobCirugia
        {
            get { return _cobCirugia; }
            set { _cobCirugia = value; }
        }
        #endregion

        #region constructor 

        public Plan(string NombrePlan, int Precio, int CobMedicamentos, int CobPracticas, int CobConsulta, int CobCirugia)
        {
            this.NombrePlan = NombrePlan;
            this.Precio = Precio;
            this.CobMedicamientos = CobMedicamentos;
            this.CobPracticas = CobPracticas;
            this.CobConsulta = CobConsulta;
            this.CobCirugia = CobCirugia;
        }

        public Plan()
        {
            this.NombrePlan = "";
            this.Precio = Precio;
            this.CobMedicamientos = CobMedicamientos;
            this.CobPracticas = CobPracticas;
            this.CobConsulta = CobConsulta;
            this.CobCirugia = CobCirugia;
        }
        #endregion

        #region metodos

        public override string ToString()
        {
            return this.NombrePlan + " " + this.Precio + " " + this.CobConsulta + " " + this.CobPracticas + " " + this.CobMedicamientos + " " + this.CobCirugia;
        }

        public override bool Equals(object Plan)
        {
            if (Plan == null)
                return this == null;
            else if (this.GetType() != Plan.GetType())
                return false;
            else
            {
                Plan plan = (Plan)(Plan);
                return (this.NombrePlan == plan.NombrePlan);
            }
        }

        #endregion  
    }
}
