using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObraSocial
{
    public class Empresa : Afiliado
    {
        #region atributos

        private string _rubro;

        #endregion

        #region propiedades

        public string Rubro
        {
            get { return _rubro; }
            set { _rubro = value; }
        }
        #endregion

        #region constructor

        public Empresa(int CUIT, int NroAfiliado, double Telefono, string Rubro, string NombreEmpresa, string Plan, DateTime FechaAlta, string Domicilio)
        {
            this.DNI = CUIT;
            this.Rubro = Rubro;
            this.Nombre = NombreEmpresa;
            this.NroAfiliado = NroAfiliado;
            this.Telefono = Telefono;
            this.FechaAlta = FechaAlta;
            this.Plan = Plan;
            this.Domicilio = Domicilio;
        }

        public Empresa()
        {
            this.DNI = DNI;
            this.Rubro = "";
            this.Nombre = "";
            this.NroAfiliado = NroAfiliado;
            this.Telefono = Telefono;
        }
        #endregion

        #region metodos

        public override string ToString()
        {
            return base.ToString() + this.Rubro + " ";
        }

        public override bool Equals(object Afiliado)
        {
            if (Afiliado == null)
                return this == null;
            else if (this.GetType() != Afiliado.GetType())
                return false;
            else
            {
                Empresa empresa = (Empresa)(Afiliado);
                return (this.DNI == empresa.DNI);
            }
        }
        #endregion
    }
}
