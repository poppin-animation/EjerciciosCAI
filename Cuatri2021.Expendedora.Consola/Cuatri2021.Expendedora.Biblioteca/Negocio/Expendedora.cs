using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cuatri2021.Expendedora.Biblioteca.Negocio;

namespace Cuatri2021.Expendedora.Biblioteca
{
    public class Eexpendedora
    {
        private List<Lata> _latas;
        private string _proveedor;
        private bool _encendida;
        private double _dinero;
        private int _capacidad;

        public string Proveedor
        {
            get { return this._proveedor; }
        }

        public List<Lata> Latas
        {
            get { return this._latas; }
        }

        public bool Encendida
        {
            get { return this._encendida; }
        }

        public int Capacidad
        {
            get { return this._capacidad; }
        }

        public double Dinero 
        {
            get { return this._dinero; }
        }

        //////////////////CONSTRUCTOR
        ///
        public Eexpendedora()
        {
            this._encendida = false;
            this._latas = new List<Lata>();
        }




        ////////////METODOS
        public void AgregarLata(Lata lata)
        {

        }


        public Lata ExtraerLata(string codigo, double cantidad)
        {
            Lata lata1 = new Lata();

            return lata1;
        }


        public string GetBalance()
        {
            string balance = "";
            return balance;
        }



        public int GetCapacidadRestante()
        {
            int capacidadRestante = 0;
            return capacidadRestante;
        }

        public void EncenderMaquina()
        {
            this._encendida = true;

        }
        public bool EstaVacia()
        {

            if(Latas.Any() == true)
            {
                return false;
            }
            else
            {
                return false;
            }


        }













    }
    }
