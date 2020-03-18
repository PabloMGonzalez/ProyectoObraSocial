using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObraSocial
{
    public class Afiliado : Persona

    {
        #region atributos

        private int _nroafiliado;
        private string _observacion;
        private DateTime _fechaAlta;
        private string _plan;
        private string _nombreempresa;
        #endregion

        #region propiedades

        public string Observacion
        {
            get { return _observacion; }
            set { _observacion = value; }
        }

        public int NroAfiliado
        {
            get { return _nroafiliado; }
            set { _nroafiliado = value; }
        }

        public DateTime FechaAlta
        {
            get { return _fechaAlta; }
            set { _fechaAlta = value; }
        }

        public string Plan
        {
            get { return _plan; }
            set { _plan = value; }
        }

        public string NombreEmpresa
        {
            get { return _nombreempresa; }
            set { _nombreempresa = value; }
        }

        #endregion

        #region constructor

        public Afiliado(string Nombre, string Apellido, string Domicilio, string Sexo, string Observacion, int DNI, double Telefono, int NroAfiliado, DateTime FechaAlta, string Plan)

        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Domicilio = Domicilio;
            this.Sexo = Sexo;
            this.Observacion = Observacion;
            this.DNI = DNI;
            this.Telefono = Telefono;
            this.NroAfiliado = NroAfiliado;
            this.FechaAlta = FechaAlta;
            this.Plan = Plan;
        }

        public Afiliado(string Nombre, string Apellido, string Domicilio, string Sexo, string Observacion, int DNI, double Telefono, int NroAfiliado, DateTime FechaAlta, string Plan, string NombreEmpresa)

        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Domicilio = Domicilio;
            this.Sexo = Sexo;
            this.Observacion = Observacion;
            this.DNI = DNI;
            this.Telefono = Telefono;
            this.NroAfiliado = NroAfiliado;
            this.FechaAlta = FechaAlta;
            this.NombreEmpresa = NombreEmpresa;
        }

        public Afiliado()
        {
            this.Nombre = "";
            this.Apellido = "";
            this.Domicilio = "";
            this.Sexo = "";
            this.Observacion = Observacion;
            this.DNI = DNI;
            this.Telefono = Telefono;
            this.NroAfiliado = NroAfiliado;
            this.FechaAlta = FechaAlta;
        }
        #endregion

        #region metodos

        public override string ToString()
        {
            return base.ToString() + this.NroAfiliado + " " + this.Observacion + " " + this.FechaAlta + " ";
        }

        public override bool Equals(object Afiliado)
        {
            if (Afiliado == null)
                return this == null;
            else if (this.GetType() != Afiliado.GetType())
                return false;
            else
            {
                Afiliado afiliado = (Afiliado)(Afiliado);
                return (this.DNI == afiliado.DNI);
            }
        }
        #endregion
    }
}
