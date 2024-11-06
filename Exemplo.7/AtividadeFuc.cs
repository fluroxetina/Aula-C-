namespace Exemplo7
{
    class AtividadeFuc
    {
        public delegate double Operacao(int[] a);

        static double MediaArray(int[] a)
        {
            double soma = 0;
            for (int i = 0; i < a.Length ; i++)
            {
                soma += a[i];
            }

            return soma / a.Length;
        }

        static void Media()
        {
            Operacao op = MediaArray;
            int[] array = {1,2,3,4,5,6,7,8};

            System.Console.WriteLine(op(array));

        }
    }
}