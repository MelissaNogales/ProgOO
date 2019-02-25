# Tarea 2
## Unidad 2. Clases y Objetos
### 2.1 Declaración de clases: atributos, métodos, encapsulamiento.
####     Clases y estructuras
####     _Las clases (class) y estructuras (struct) son dos de las construcciones básicas. Cada una de               las anteriores es simplemente una estructura de datos que encapsulanun conjunto de datos y                 comportamientos que forman un conjunto como una unidad lógica. Los datos y comportamientos son             los miembros de la clase o estructura, e incluyen sus métodos, propiedades y eventos, entre                otros elementos._
####     _Si define una clase o estructura llamada Persona, Persona es el nombre del tipo. Si declara e              inicializa una variable p de tipo Persona, se dice que p es un objeto o instancia de Persona. Se           pueden crear varias instancias del mismo tipo Persona, y cada instancia tiene diferentes valores           en sus propiedades y campos._

####     Campos
####     _Un campo es una variable de cualquier tipo que se declara directamente en una clase o struct. Los       campos son miembros de su tipo contenedor._

####     Métodos 
####     _Un método es un bloque de código que tiene un instrucción o varias instrucciones. s. Un programa           hace que se ejecuten las instrucciones al llamar al método y especificando los argumentos de               método necesarios._

####     Encapsulación
####     _Una clase o una estructura pueden especificar hasta qué punto se puede acceder a sus miembros              para codificar fuera de la clase o la estructura. No se prevé el uso de los métodos y las                  variables fuera de la clase, o el ensamblado puede ocultarse para limitar el potencial de los              errores de codificación o de los ataques malintencionados._

### 2.2 Instanciación de una clase.
####     _El operador new._
####     _Permite crear un objeto de cualquier tipo, incluyendo tipos definidos por el usuario, y devuelve           un puntero (del tipo adecuado) al objeto creado._
####     _En clase usabamos el operador new para crear objetos con sus respectivos atributos, crear nuevos           programas de consola._

### 2.3 Referencia al objeto actual.  
####    _La palabra clave this hace referencia a la instancia actual de la clase._ 
'''namespace Programa
{
    class Paciente
    {
        private string nombre;
        private int edad;
        private int consulta=60;
        public string Nombre
        {
            get 
                {
                    return nombre;
                }
            set 
                {
                    nombre=value;
                }
        }
        public Paciente(string nombre, int e)
        {
            this.nombre=nombre;
            edad=e;
        }
        public void Imprime()
            {
                Console.WriteLine(nombre);
                Console.WriteLine("Total consulta: {0:C}", Pago.TotalConsulta(this));
            }

            public void Imprime(int veces)
            {
                for (int i=0; i<=veces; i++)
                Imprime();
            }
            public int Consulta
            {
                get
                {
                    return consulta;
                }
            }
    }
    class Pago
    {
        public static int TotalConsulta(Paciente P)
        {
            return 10+P.Consulta;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Paciente p =new Paciente("Patricia", 41);
            List<Paciente> pacientes =new List<Paciente>();
            pacientes.Add(p);
            pacientes.Add(new Paciente("Yovanny", 22));
            p.Imprime(3);
        }
    }
}
'''

