//formas de declarar o vetor 

int[] vetor1 = new int[5];

//sem estabelecer tamanho

int[] vetor2 = new int[] {1,2,3,4,5};
int[] vetor3 = {1,2,3,4,5};

//vetor vazio

int[] vetor4 = {}


//percorrer o vetor

for (int i = 0; i < vetor2.Length; i++)
{
    Console.WriteLine(vetor2[i]);
}

//percorrer o vetor com foreach

foreach (int item in vetor2){

    Console.WriteLine(item);

}

//percorrer com o while

int i = 0;
while (i < vetor2.Length)
{
    Console.WriteLine(vetor2[i]);
    i++;
}