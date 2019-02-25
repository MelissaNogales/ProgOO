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
```csharp
namespace Programa
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
            p.Imprime(3);
        }
    }
}
```
### 2.4 Métodos: declaración, mensajes, paso de parámetros, retorno de valores.
#### Parámetros de métodos.
#### _Los parámetros declarados para un método sin in, ref o out se pasan al método llamado por valor. Ese       valor se puede modificar en el método, pero el cambio se perderá cuando se devuelva el control al          procedimiento que ha hecho la llamada._

#### params
#### _Mediante el uso de la palabra clave params, se puede especificar un parámetro de método que toma un        número variable de argumentos._
#### _Puede enviar una lista separada por comas de argumentos del tipo especificado en la declaración de         parámetro o una matriz de argumentos del tipo especificado. También puede no enviar ningún                 argumento. Si no envía ningún argumento, la longitud de la lista params es cero._
#### _No se permiten parámetros adicionales después de la palabra clave params en una declaración de             método, y solo se permite una palabra clave params en una declaración de método._
#### _El tipo declarado del parámetro params debe ser una matriz unidimensional._

#### out
#### _Puede usar la palabra clave out en dos contextos:_
#### _1. Como un modificador de parámetro, que le permite pasar un argumento a un método mediante una               referencia en lugar de mediante un valor._
#### _2. En declaraciones de parámetro de tipo genérico para interfaces y delegados, que especifica que un          parámetro de tipo es covariante._

#### ref
#### _La palabra clave ref indica un valor que se ha pasado mediante referencia. Se usa en cuatro                contextos distintos:_
#### _1. En una firma del método y en una llamada al método, para pasar un argumento a un método mediante           referencia._
#### _2. En una firma del método, para devolver un valor al autor de la llamada mediante referencia._
#### _3. En un cuerpo de miembro, para indicar que un valor devuelto de referencia se almacena localmente           como una referencia que el autor de la llamada pretende modificar o, en general, que una variable          local accede a otro valor por referencia._ 
#### _4. En una declaración struct para declarar ref struct o ref readonly struct._

### 2.5 Constructores y destructores: declaración, uso y aplicaciones.
#### Utilizar constructores.
#### _Los constructores son métodos de clase que se ejecutan cuando se crea un objeto de un tipo                 determinado. Los constructores tienen el mismo nombre que la clase y, normalmente, inicializan los         miembros de datos del nuevo objeto._
#### _Un constructor que no toma ningún parámetro se denomina constructor pre-determinado. Los                   constructores pre-determinados se llaman cada vez que se crea una instancia de un objeto mediante el       operador new y no se proporciona ningún argumento a el operador new._  
#### _Si la clase es estática, a las clases sin constructores se les asigna un constructor público               predeterminado a través del compilador de C# con el fin de habilitar la creación de instancias de          clases._
#### _Se puede evitar que se creen instancias de una clase mediante la conversión del constructor a              privado._
#### _Los constructores para los tipos struct son parecidos a los constructores de clases, pero los tipos        structs no pueden contener un constructor pre-determinado explícito porque el compilador proporciona       uno automáticamente. Este constructor inicializa cada campo del tipo struct con los valores                predeterminados. Pero, este constructor pre-determinado sólo se invoca si se crean instancias del          tipo struct con el operador new._
#### _Se pueden inicializar objetos basados en structs o asignarse._
#### _Como consecuencia no se necesita llamar al constructor predeterminado para un tipo de valor._

#### _Las clases y las structs pueden definir constructores que acepten parámetros. Se debe llamar a             constructores que toman parámetros a través de una instrucción usando el operador new o base. Las          clases y las structs también pueden definir varios constructores y no se necesita ninguno para             definir un constructor predeterminado._
#### _Cualquier constructor puede usar la palabra clave base para llamar al constructor de una clase             base._  
#### _La palabra clave base se puede usar con o sin parámetros. Cualquier parámetro del constructor se           puede usar como parámetro de base o como parte de una expresión._
#### _En una clase derivada, si no se llama explícitamente al constructor de la clase base mediante la           palabra clave base, se llamará implícitamente al constructor pre-determinado, si existe alguno. Esto       significa que las siguientes declaraciones del constructor son efectivamente las mismas._ 
#### _Si una clase base no proporciona un constructor pre-determinado, la clase derivada debe realizar una       llamada explícita a un constructor base mediante base._

#### _Un constructor puede invocar a otro constructor en el mismo objeto mediante la palabra clave this._
#### _Los constructores se pueden marcar como public, private, protected, internal o protectedinternal.          Estos modificadores de acceso definen cómo los usuarios de la clase pueden construir la clase._ 
#### _Un constructor se puede declarar como estático mediante la palabra clave static. Se llama                  automáticamente a los constructores estáticos de forma inmediata antes de que se tenga acceso a            cualquier campo estático, y, generalmente, se utilizan para inicializar los miembros de clase              estáticos._

###  2.6 Sobrecarga de métodos.

### 2.7 Sobrecarga de operadores: Concepto y utilidad, operadores unarios y binarios.
### 