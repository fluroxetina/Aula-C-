namespace Exemplo_7
{   
    class AtividadeFuc
    {
        public delegate bool Operacao(int[] a);

        static bool VerificarPalindromo(int[] a)
        {
            bool control = false;

            for (int i = 0 ; i < a.Length / 2 ; i++)
            {
                if (a[i] == a [9 - i])
                {
                    control = true;
                }
                else
                {
                    control = false;
                    break;
                }

                return control;
            }
        }
        static void Teste()
        {
            Operacao op = VerificarPalindromo;
            int[] ara = {1,2,3,4,5,5,4,3,2,1};

            bool a = op(ara);

            if(a){
                System.Console.WriteLine("Palidromo");
            }
            else{
                System.Console.WriteLine("Nao Palidromo");
            }


        }
    }
}

//. Verificar se um Vetor é um Palíndromo (Função Estática)


//  bool control = false;
            
//             int[] array = new int [10]{
//                 1,2,3,4,5,5,4,3,2,1
//             };
            
//             int[] array2 = new int [10];
//             int cont = 0;
//             //compararando arrays 
            

//             for (int i = 9 ; i >= 0 ; i--){
                
//                 array2[cont] = array[i];
//                 Console.WriteLine(array2[cont]);
//                 cont++;
                
//             }
            
//             for(int i = 0 ; i < 10 ; i++){
//                 if(array2[i] == array[i]){
                    
//                     control = true;
//                 }
//                 else{
//                     control = false;
//                     break;
//                 }
//             }
            
//             if (control){
//                 Console.WriteLine("dante");
//             }
//             else{
//                  Console.WriteLine("Willdante");
//             }