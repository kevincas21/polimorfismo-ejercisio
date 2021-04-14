using System;

namespace libro
{

    public class libro : documento  {
        protected string autor;
        protected string titulo;
        protected string ubicacion;
        public string Autor { get{return autor;} set{autor = value;} }
        public string Titulo { get{return titulo;} set{titulo = value;} }

        public string Ubicacion { get{return ubicacion;} set{ubicacion = value;} }

        
        

        public void mostrar (){
            Console.WriteLine("mi libro es: {0}",titulo);
            Console.WriteLine("El autor es: {0}",autor);
            Console.WriteLine("su ubicacion es: {0}",ubicacion);
        }
        public libro(string titulo,string autor,string ubicacion){
            this.titulo = titulo;
            this.autor = autor;
            this.ubicacion = ubicacion;
            Console.WriteLine("creando libro");
        }
        public libro(string titulo,string autor){
            this.titulo = titulo;
            this.autor = autor;
            this.ubicacion = "no detallado";
            Console.WriteLine("creando libro");

        }


        
    }
    public class pruebaDeLibro{
            public pruebaDeLibro(string titulo,string autor){
                libro l = new libro(titulo,autor);
                l.mostrar();
            }
            public pruebaDeLibro(string titulo,string autor,string ubicacion){
                libro l = new libro(titulo,autor,ubicacion);
                l.mostrar();
            }
        }

    public abstract class documento{
        protected int paginas;

        public int Paginas { get{return paginas;} set{paginas = value;} }

        public documento(){
            Console.WriteLine("Creando Documento");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que desea?");
            Console.WriteLine("1)guardar un documento");
            Console.WriteLine("2)guardar un libro");
            string opcion = Console.ReadLine();
            if (Convert.ToInt64(opcion) == 1){
                Console.WriteLine("ingresa el titulo y luego el autor");
                string titulo = Console.ReadLine();
                string Autor = Console.ReadLine();
                pruebaDeLibro p = new pruebaDeLibro(titulo,Autor);
            }
            if (Convert.ToInt64(opcion) == 2){
                Console.WriteLine("ingresa el titulo, luego el autor,luego la ubicacion");
                string titulo = Console.ReadLine();
                string Autor = Console.ReadLine();
                string ubicacion = Console.ReadLine();
                pruebaDeLibro p = new pruebaDeLibro(titulo,Autor,ubicacion);
            }
            if (Convert.ToInt64(opcion) != 2 && Convert.ToInt64(opcion) != 1 ){
                Console.WriteLine("ingreso un valor no valido");
            }
            
        }
    }
}
