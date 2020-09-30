using System;

namespace PracticaC_
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World!");
            int[] array = new int[5] {4,7,2,8,3};
            for(int i = 0; i<array.Length; i++){
                if(array[i] >= 5)
                    array[i] += 2;
                else{
                    array[i] -= 1;
                }
                Console.WriteLine("{0}: {1}",(i+1), array[i]);
                               //((i+1) + ": " +array[i] )
            } */

            /* Persona tian = new Persona();
            string s = tian.info();
            Console.WriteLine(s);
            Console.WriteLine("No de personas: "+Persona.noPersonas);

            Persona ash = new Persona("Ashlon", "US", 130);
            Persona kate = new Persona("Kather..", null, 230);
            Console.WriteLine("No de personas nuevo: "+Persona.noPersonas); */
            
            Random rnd = new Random();
            string[] marcas = new string[5]{"Casio", "HP", "Patito", "Darlington", "Robin.inc"};
            Calculadora cal1 = new Calculadora(marcas[rnd.Next(0,5)]);

            //Console.WriteLine(rnd.Next(0,4));
        }


    }

    public class Calculadora{
        private string marca;
        public static int noCal;

        public Calculadora(string marca){
            this.marca = marca; 
            noCal++;
            Console.WriteLine("\nCaluladora "+this.marca);

            otravez:
            Console.WriteLine("\nOperaciones:\n1.Suma\n2.Resta\n3.Multiplicacion\n4.Division\n5.exit");
            string op = Console.ReadLine();
            switch(op){
                case "1":
                    suma();
                    break;
                case "2":
                    resta();
                    break;
                case "3":
                    multi();
                    break;
                case "4":
                    division();
                    break;
                case "5":
                    Environment.Exit(0);
                    break;    
                default:
                    goto otravez;
                    break;     
            }
            goto otravez;
        }
        

        public void suma(){
            int a, b, sum;
            Console.WriteLine("Numero 1:" );
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Numero 2: ");
            b = int.Parse(Console.ReadLine());
            sum = a + b;
            Console.WriteLine("la suma es: "+sum);
        }

        public void resta(){
            int a, b, res;
            Console.WriteLine("Numero 1:" );
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Numero 2: ");
            b = int.Parse(Console.ReadLine());
            res = a - b;
            Console.WriteLine("la resta es: "+res);
        }

        public void multi(){
            int a, b, mul;
            Console.WriteLine("Numero 1:" );
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Numero 2: ");
            b = int.Parse(Console.ReadLine());
            mul = a * b;
            Console.WriteLine("la multiplicacion es: "+mul);
        }

        public void division(){
            int a, b;
            float div, mod;
            Console.WriteLine("Numero 1:" );
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Numero 2: ");
            b = int.Parse(Console.ReadLine());
            div = a/b;
            mod = a%b;
            Console.WriteLine("la division es: "+div+"\nel modulo es: "+mod);
        }
    
    }



    public class Persona{
        private string nom, nac;
        private int alt;
        public static int noPersonas;

        public Persona(string nom, string nac, int alt){
            this.nom = nom;
            this.nac = nac;
            this.alt = alt;
            noPersonas++;
        }
        public Persona(){
            Console.WriteLine("digame su nombre: ");
            this.nom = Console.ReadLine();
            this.nac = Console.ReadLine(); 
        error:
            try{
                Console.WriteLine("Inserta altura:");
                this.alt = int.Parse(Console.ReadLine());
            }catch(Exception ex){
                Console.WriteLine("pinche inutil "+ ex.Message);
                goto error;
            }
            noPersonas++;
        }

        public string info(){
            
            return "nombre: "+nom+", nacionalidad: "+nac+", altura: "+alt+".\n";
        }
    }
}
