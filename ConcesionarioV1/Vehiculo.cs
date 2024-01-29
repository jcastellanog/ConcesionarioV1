using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcesionarioV1
{
    public class Vehiculo
    {
        // CONSTANTES

        // MIEMBROS PRIVADOS
        private string _marca;
        private string _modelo;

        // CONSTRUCTORES
        public Vehiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        // PROPIEDADES
        public string Marca
        {
            get { return _marca; }
            set { 
                // TODO: Proporcionar seguridad y protección al miembro - _marca
                _marca = value; }
        }

        public string Modelo
        {
            get { return _modelo; }
            set {
                // TODO: Proporcionar seguridad y protección al miembro - _modelo
                _modelo = value; }
        }

        // MÉTODOS PÚBLICOS

        // MÉTODOS PRIVADOS

    }
}
