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
            get { return this._dinero;  }
            set { this._dinero = value; }
        }

        //////////////////CONSTRUCTOR
        ///
        public Eexpendedora()
        {
            this._encendida = false;
            this._latas = new List<Lata>();
            this._capacidad = 50; //la decido yo la capacidad???
            this._dinero = 0;
    }




        ////////////METODOS
        public void AgregarLata(Lata lata)
        {
            //FALTA VALIDAR QUE EL CODIGO NO ESTE REPETIDO 

            Latas.Add(lata);
            

        }


        public Lata ExtraerLata(string codigo, double dinero)
        {
            Lata buscada = _latas.Find(l => l.Codigo == codigo);
           
            // Flujo alternativo 1: El código es inválido
            if (buscada != null)
            {
                //	Flujo alternativo 3: No hay stock de esa lata
                if (buscada.Cantidad <1)
                {
                    //Flujo alternativo 2: El dinero no es suficiente
                    if (dinero >= buscada.Precio)
                    {
                        this._dinero = this._dinero + buscada.Precio;
                    }
                    else
                    {
                        throw new Cuatri2021.Expendedora.Biblioteca.Exceptions.DineroInsuficienteException();
                    }

                }
                else
                {
                    // THROWSinStockException(int codigo)
                    throw new Cuatri2021.Expendedora.Biblioteca.Exceptions.SinStockException(codigo);
                }
            }
            else
            {
                //Trow CodigoInvalidoException(int codigo)
                throw new Cuatri2021.Expendedora.Biblioteca.Exceptions.CodigoInvalidoException(codigo);
            }

            
            return buscada;
        }



        public void EncenderMaquina()
        {
            this._encendida = true;

        }
        public bool EstaVacia()
        {

            if(Latas.Any() == true)
            {
                //si la maquina expendedora tiene AL MENOS una lata en la lista, NO esta VACIA, entonces retorno FALSO
                return false;
            }
            else
            {
                //si la maquina expendedora NO TIENE NI una lata en la lista, esta VACIA, entonces retorno VERDADERO, ESTA VACIA. 
                return true;
            }


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









    }
}
