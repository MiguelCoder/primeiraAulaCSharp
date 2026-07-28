Console.WriteLine("Variáveis:");

string nome = "Miguel";
string profissao = "técnico em informática";
int idade = 31;
double altura = 1.57;
char letra = 'A';
bool estudando = true;
Console.WriteLine("Aqui estão os dados das variáveis:");
Console.WriteLine("String: " +nome);
Console.WriteLine("Int: "+ idade);
Console.WriteLine("Double: "+altura);
Console.WriteLine("Bool: "+ estudando);

//Interpolação:
Console.WriteLine($"{nome} tem {idade} anos");

//Desafio:
Console.WriteLine($" Meu nome é {nome}, eu tenho {idade}, tenho {altura} de altura e atuo como {profissao}. ");