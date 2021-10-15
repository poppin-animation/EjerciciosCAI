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
            Lata buscada = _latas.Find(x => x.Codigo == lata.Codigo);

            ///Flujo alternativo 1: El código ya existe
            if(buscada != null)
            {
                //Trow CodigoInvalidoException(int codigo)
                throw new Cuatri2021.Expendedora.Biblioteca.Exceptions.CodigoInvalidoException(lata.Codigo);
            }
            else
            {
                ///Flujo alternativo 2: La máquina está llena(capacidad insuficiente)
                //SI LA CAPACIDAD ESTA COMPLETA (CAPACIDAD - CANTIDAD DE LATAS)=0   ||OR|| CAPACIDAD - NUEVO INGRESO DE LATAS < 0
                if(GetCapacidadRestante() == 0 || (GetCapacidadRestante()-lata.Cantidad ) < 0)
                {
                    //Trow CodigoInvalidoException(int codigo)
                    throw new Cuatri2021.Expendedora.Biblioteca.Exceptions.CapacidadInsuficienteException(lata.Cantidad);
                }
                else 
                {
                    Latas.Add(lata);
                }
            }
        }


        public Lata ExtraerLata(string codigo, double dinero)
        {
            Lata buscada = _latas.Find(x => x.Codigo == codigo);
           
            // Flujo alternativo 1: El código es inválido
            if (buscada == null)
            {
                //Trow CodigoInvalidoException(int codigo)
                throw new Cuatri2021.Expendedora.Biblioteca.Exceptions.CodigoInvalidoException(codigo);

            }
            else
            {
                //Flujo alternativo 2: El dinero no es suficiente
                if (dinero < buscada.Precio)
                {
                    // THROWSDineroInsuficienteException()
                    throw new Cuatri2021.Expendedora.Biblioteca.Exceptions.DineroInsuficienteException();
                }
                else
                {
                    //	Flujo alternativo 3: No hay stock de esa lata
                    if (buscada.Cantidad < 1)
                    {
                        // THROWSinStockException(int codigo)
                        throw new Cuatri2021.Expendedora.Biblioteca.Exceptions.SinStockException(codigo);
                    }
                    else
                    {
                        //// INGRESAR DINERO A LA EXPENDEDORA
                        this._dinero = this._dinero + buscada.Precio;
                        //// BAJAR STOCK DE LA LATA EN LA LISTA (1 UNIDAD MENOS)
                        _latas.Find(l => l.Codigo == codigo).Cantidad = _latas.Find(l => l.Codigo == codigo).Cantidad - 1;
                        //// devolver la lata a extraer !
                        return buscada;
                    }
                }
               
            }

            
            
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
            int cantidadLatas = 0;
            foreach (Lata l in this._latas)
            {
                cantidadLatas = cantidadLatas + l.Cantidad;
            }
            return "Dinero en máquina: " + this._dinero + "\nStock de latas: " + cantidadLatas;
        }



        public int GetCapacidadRestante()
        {
            int cantidadLatas = 0;
            foreach(Lata l in this._latas)
            {
                cantidadLatas = cantidadLatas + l.Cantidad;
            }

            return this._capacidad - cantidadLatas;
        }









    }
}
