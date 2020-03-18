using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObraSocial
{
    public abstract class Persona
    {
        #region atributos

        private string _nombre, _apellido, _domicilio, _sexo;
        private int _dni;
        private double _telefono;
        #endregion

        #region propiedades

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public string Domicilio
        {
            get { return _domicilio; }
            set { _domicilio = value; }
        }

        public string Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }

        public int DNI
        {
            get { return _dni; }
            set { _dni = value; }
        }

        public double Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        #endregion

        #region metodos

        public override string ToString()
        {
            return this.Nombre + " " + this.Apellido + " " + this.Domicilio + " " + this.Sexo + " " + this.DNI + " " + this.Telefono + " ";
        }

        public override bool Equals(object Afiliado)
        {
            if (Afiliado == null)
                return this == null;
            else if (this.GetType() != Afiliado.GetType())
                return false;
            else
            {
                Persona persona = (Persona)(Afiliado);
                return (this.DNI == persona.DNI);
            }
        }
        #endregion
    }
}

