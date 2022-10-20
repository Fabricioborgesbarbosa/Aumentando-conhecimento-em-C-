/* 
   For e foreach array inteiro simples:
*/

int[] arrayInt = new int[3];
arrayInt[0] = 18;
arrayInt[1] = 20;
arrayInt[2] = 22;

//Redimerecionando array, Resize = copia do array.
//Array.Resize(ref arrayInt, arrayInt.Length * 3);

//Copiando um array
//criando um novo array, aumentando suaa capacidade
int[] arrayIntDobrado = new int[arrayInt.Length * 3];
Array.Copy(arrayInt, arrayIntDobrado, arrayInt.Length );


Console.WriteLine("\nfor:");
for (int i = 0; i < arrayInt.Length; i++)
{

    Console.WriteLine($"Posição numero {i} =  {arrayInt[i]}");

}


Console.WriteLine("\nforeach:");
int contador = 0;
foreach (int valor in arrayInt)
{
    Console.WriteLine($"Posição Numero: {contador} = {arrayInt[contador]}");
    contador++;
}