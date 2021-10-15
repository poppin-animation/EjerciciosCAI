using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cuatri2021.Presentismo.Biblioteca.Utilidades;
using Cuatri2021.Indumentaria.Biblioteca.Excepciones;

namespace Cuatri2021.Indumentaria.Biblioteca.Entidades
{
    public class TiendaRopa
    {
        //Atributos privados
        private List<Indumentariaa> _inventario;
        private List<Venta> _ventas;
        private static int _ultimoCodigo;

        //propiedades publicas


        //constructor
        public TiendaRopa()
        {
            this._inventario = new List<Indumentariaa>();
            this._ventas = new List<Venta>();
            
        }


        //metodos
        public int GetProximoCodigo()
        {
            _ultimoCodigo++;
            return _ultimoCodigo;
        }
        public void Agregar(Indumentariaa indu)
        {
            if(indu == null)
            {
                throw new Exception("No se ha podido agregar la prenda");
            }
            else if (this.Equals(_inventario.Find(x => x.Codigo == indu.Codigo)))
            {
                throw new Exception("Ya se encuentra listada la prenda solicitada. Si necesita realizar actualizaciones sobre ella, elija la opcion de Modificar");
            }
            else
            {
                if(indu.Stock <3)
                {
                    throw new Exception("El stock mínimo para ingresar una prenda es de 3 unidades. Reintente. ");

                }
                else
                {
                    indu.Codigo = GetProximoCodigo();
                    _inventario.Add(indu);
                }

            }
            
        }

        public void Modificar(Indumentariaa indu)
        {
            if (indu == null)
            {
                throw new Exception("No se ha podido seleccionar la prenda");
            }
            else if (indu.Equals(_inventario.Find(x => x.Codigo == indu.Codigo)))
            {
                _inventario.Find(x => x.Codigo == indu.Codigo).Stock = indu.Stock;
                _inventario.Find(x => x.Codigo == indu.Codigo).Talle = indu.Talle;
                _inventario.Find(x => x.Codigo == indu.Codigo).Precio = indu.Precio;
            }
            else
            {
                throw new Exception("El código de prenda seleccionado es inválido");

            }
        }
        public Indumentariaa Seleccionar(int codigo)
        {

            Indumentariaa indu;
            indu = this.Listar().Find(x => x.Codigo == codigo);
            if (indu == null)
            {
                throw new Exception("No existe el codigo seleccionado");
            }
            else
            {
                return indu;
            }




        }
        public void Quitar(Indumentariaa indu)
        {

            if(indu == null)
            {
                throw new SinStockException();

            }
            //else if()//////////AGREGAR VALIDACION CON EQUALS 
            //{
               

            //}
            else
            {
                this._inventario.Remove(indu);
            }

        }


        public void IngresarOrden(Venta venta)
        {
            if (venta == null)
            {
                throw new Exception("No se ha podido ingresar la venta");
            }
            else if (Equals(_ventas.Find(x => x.Codigo == venta.Codigo)))
            {
                throw new Exception("Ya se encuentra listada la prenda solicitada. Si necesita realizar actualizaciones sobre ella, elija la opcion de Modificar");
            }
            else
            {
                venta.Codigo = GetProximoCodigo();
                _ventas.Add(venta);
                //RESTAR STOCK DE LAS PRENDAS INGRESADAS !!! 
            }
        }
        public List<Indumentariaa> Listar()
        {
            if(_inventario.Any() == true )
            {
                return _inventario;
            }
            else
            {
                throw new Exception("No existen prendas en la Lista");
            }
                                
        }
        public List<Venta> ListarOrden()
        {
            if (_ventas.Any() == true)
            {
                return _ventas;
            }
            else
            {
                throw new Exception("No existen Ordenes en la Lista");
            }
        }






        public void DevolverOrden(Venta venta)
        {

        }












    }
}
