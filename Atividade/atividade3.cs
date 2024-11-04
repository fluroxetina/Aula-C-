using System;

namespace Atividade3
{
    class Atividade3
    {
        static void Main(string[] args)
        {   
          
            
            bool control = false;
            
            int[] array = new int [10]{
                1,2,3,4,5,5,4,3,2,1
            };
            
            int[] array2 = new int [10];
            int cont = 0;
            //compararando arrays 
            

            for (int i = 9 ; i >= 0 ; i--){
                
                array2[cont] = array[i];
                Console.WriteLine(array2[cont]);
                cont++;
                
            }
            
            for(int i = 0 ; i < 10 ; i++){
                if(array2[i] == array[i]){
                    
                    control = true;
                }
                else{
                    control = false;
                    break;
                }
            }
            
            if (control){
                Console.WriteLine("dante");
            }
            else{
                 Console.WriteLine("Willdante");
            }
            
        }
            
    }
}

