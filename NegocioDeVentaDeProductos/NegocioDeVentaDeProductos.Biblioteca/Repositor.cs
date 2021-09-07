using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioDeVentaDeProductos.Biblioteca
{
    public class Repositor : Dueño
    {

        //VARIABLES SIEMPRE PRIVADAS
        private int _legajo;


        /// ATRIBUTOS PUBLICOS
        public int Legajo
        {
            get { return this._legajo; }
            private set { this._legajo = value; } // --> hacer un set privado 
        }


        public override string Tipo
        {
            get { return this._tipo = "Repositor"; }

        }


        //CONSTRUCTOR

        public Repositor()
            : base()
        {
            //hcer los NEW LIST o arrays aca para guardar espacios de memoria??? 
            this._tipo = Tipo;


        }
        public Repositor(int LegajoEntrada, string NombreEntrada, string ApellidoEntrada)
            : base(NombreEntrada, ApellidoEntrada)
        {
            //hcer los NEW LIST o arrays aca para guardar espacios de memoria??? 

            this._legajo = LegajoEntrada;
        }


        /// METODOS 
        public bool Saludar()
        {
            Console.WriteLine("Hola, soy el " + typeof(Repositor).Name + " N°" + this._legajo + ", y mi Nombre es " + Apellido + ", " + Nombre + " ¿Como puedo ayudarle?");
            return true;
        }

        public override sealed string ToString() /////// accesible y modificada para todas las clases derivadas de este. esta SELLADA asique las clases derivadas no lo pueden modificar. 
        {
            //estamos definiendo un metodo que ya esta definido en el arbol para la clase objeto. 
            return string.Format("Está usando el sistema como " + this._tipo + " N°" + this._legajo + ", Nombre: " + Apellido + ", " + Nombre);

        }

        public int SeleccionarProducto()
        {
            Console.WriteLine("Ingrese el ID de producto que desea Modificar. \n" +
                          $"Debe ingresar un número del 1 al 37.");
            int idproducto = Validador.ValidarOpcion(37);
            Console.WriteLine($"Usted a seleccionado el Producto n° {idproducto}");
            int posicionProducto = idproducto - 1; //le resto uno porque en la lista se arranca con el i=0, entonces el producto id = 1 se encuentra en la posicion 0 de la lista. 
            return posicionProducto;
        }


        public new int ModificarStock(int stockactual, int idProducto) //con el new definimos polimorfismo en tiempo de compilacion.             
        {
            int id = idProducto + 1;
            int variacionstock;
            bool valido = false;
            int calculo = 0; /// REVISAR SI ESTO DA ERROR CUANDOHAGO PRUEBAS: no me deja avanzar si no le asigno algun valor primero. 
            do
            {
                Console.Clear();
                Console.WriteLine($"Actualmente hay " + stockactual + " del producto " + id + ". Ingrese la cantidad que desea Modificar. \n" +
                $"Tenga en cuenta que para DISMINUIR Stock debe ingresar un numero negativo  \n" +
                $"y para AGREGAR Stock el numero debe ser positivo.");
                if (!int.TryParse(Console.ReadLine(), out variacionstock)) // que no permita ingresar letras y simbolos, solo numeros. 
                {
                    Console.WriteLine("La Cantidad a modificar debe ser un número.");
                }
                else
                {
                    calculo = stockactual + variacionstock;
                    if (calculo < 0) /// no puede restar mas stock del que existe.
                    {
                        Console.WriteLine("No puede Realizar la operación. El stock no puede ser menor a Cero.");
                        Console.ReadKey();
                    }
                    else
                    {
                        valido = true;
                    }
                }
                // Console.ReadKey();
            } while (!valido);
            return calculo; //retorno el nuevo stock. 
        }
    }
}
