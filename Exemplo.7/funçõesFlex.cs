namespace Exemplo_7
{
    public class FunçõesFlex
    {
        //declarando delegate

        public delegate int Operacao(int a, int b );
        
        //Expressão lambda
        static int Soma(int a , int b ) => a + b;  // isso é igual a static int Soma(int a , int b ) { return a + b; }

        //Juntar 2 funções

        public delegate void Notificar();

        public static void EnviarEmail() => System.Console.WriteLine("Email enviado");
        public static void EnviarSMS() => System.Console.WriteLine("SMS enviado");

        static void Del()
        {
            Operacao op = Soma;
            System.Console.WriteLine(op(2,3));

            //Atribuuindo diretamente a expressão lambda
            Operacao op2 = (int a ,int b) => a * b;
            System.Console.WriteLine(op2(2,3)); 
            
            //Metodo anonimo 
            Func<int, int, int > op3 = delegate(int a , int b ){
                return a - b;
            };

            System.Console.WriteLine(op3(2,3));

            //Delegate multicast

            Notificar n1 = EnviarEmail; 
            n1 += EnviarSMS;
            n1();
        }

    }
}




