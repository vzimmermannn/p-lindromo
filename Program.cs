Console.WriteLine("Qual a Palavra?");
string palavra = Console.ReadLine();
int ultimaPosicao = palavra.Length -1;
int primeiraPosicao = 0;
bool ehPalindromo = true;
while (primeiraPosicao < ultimaPosicao)
{
if (palavra[primeiraPosicao] != palavra[ultimaPosicao])
{
 ehPalindromo =false;
}

primeiraPosicao++;
ultimaPosicao--;
}
if (ehPalindromo)
{
    Console.WriteLine("A palavra é um pálindromo!");
}
else
{
   Console.WriteLine("A palavra não é um pálindromo!"); 
}