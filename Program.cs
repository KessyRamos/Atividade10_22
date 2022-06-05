//Modificação 1
int idadeMin;
int idadeMax;
int mediaIdade;

Console.WriteLine("");
Console.WriteLine("Exercício 1");
Console.WriteLine("          Calcular média de idade dos alunos!!!          ");

Console.Write("Digite a Idade Mínima: ");
idadeMin = Convert.ToInt16(Console.ReadLine());

Console.Write("Digite a Idade Maxima: ");
idadeMax = Convert.ToInt16(Console.ReadLine());

mediaIdade = (idadeMin + idadeMax)/2;

Console.Write($"A idade média dos alunos é de: {mediaIdade}");

Console.WriteLine("");
Console.WriteLine("");

//Modificação 2
double euro = 5.13;
double qtd;
double real;

Console.WriteLine("Exercício 2");
Console.WriteLine("          Calcular a converção do euro!!!          ");

Console.Write("Digite a quantidade de euro que deseja comprar: ");
qtd = Convert.ToDouble(Console.ReadLine());

real = (qtd * euro);

Console.Write($"A converção do euro para o real é de: {real}");

Console.WriteLine("");
Console.WriteLine("");

//Modificação 3
double valorVendido;
double comissao;
double resultado;

Console.WriteLine("Exercício 3");
Console.WriteLine("          Calcular a comissão do vendedor!!!          ");

Console.WriteLine("");
Console.Write("Digite o valor que o vendedor vendeu no mês: ");
valorVendido = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a comissão do vendedor: ");
comissao = Convert.ToDouble(Console.ReadLine());

resultado = (valorVendido * comissao) / 100;

Console.Write($"A comissão que o vendedor irá receber vai ser de: {resultado}");

Console.WriteLine("");
Console.WriteLine("");

//Modificação 4
double gc;
double gf;

Console.WriteLine("Exercício 4");
Console.WriteLine("          Calcular a conversão da temperatura em Fahrenheit!!!          ");

Console.Write("Digite uma temperatura em graus Celsius: ");
gc = Convert.ToDouble(Console.ReadLine());

gf = (9 * gc + 160) / 5;

Console.Write($"A conversão para Fahrenheit é: {gf} °F");

Console.WriteLine("");
Console.WriteLine("");

//Modificação 5
double f;
double c;

Console.WriteLine("Exercício 5");
Console.WriteLine("          Calcular a conversão da temperatura em graus Celsius!!!          ");

Console.Write($"Digite uma temperatura em Fahrenheit: ");
f = Convert.ToDouble(Console.ReadLine());

c = (f - 32) * 5 / 9;

Console.Write($"A conversão de Fahrenheit para Celsius é: {c} °C");

Console.WriteLine("");
Console.WriteLine("");

//Modificação 6
double h;
double pesoIdeal;

Console.WriteLine("Exercício 6");
Console.WriteLine("          Calcular o peso ideal de um homem!!!          ");

Console.Write("Digite uma altura de um homem: ");
h = Convert.ToDouble(Console.ReadLine());

pesoIdeal = (72.7 * h) -58;

Console.Write($"O peso ideal do homem de acordo com a altura é: {pesoIdeal} Kg");

Console.WriteLine("");
Console.WriteLine("");

//Modificação 7
double nota1;
double nota2;
double nota3;
double nota4;
double media;

Console.WriteLine("Exercício 7");
Console.WriteLine("          Calcular media da nota do aluno!!!          ");

Console.Write("Informe a primeira nota: ");
nota1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe a segunda nota: ");
nota2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe a terceira nota: ");
nota3 = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe a quarta nota: ");
nota4 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("");

media = (nota1 + nota2 + nota3 + nota4) / 4;

Console.WriteLine($"A média do aluno é {media}");

Console.WriteLine("");

if (media > 7 ){
    Console.WriteLine("O aluno foi APROVADO!!");
} else{
    Console.WriteLine("O aluno foi REPROVADO!");
}

Console.WriteLine("");

//Modificação 8
double valor1;
double valor2;
double v;

Console.WriteLine("Exercício 8");
Console.WriteLine("          Calcular a subtração de dois valores!!!          ");

Console.Write("Digite o primeiro número: ");
valor1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o segundo número: ");
valor2 = Convert.ToDouble(Console.ReadLine());

v = valor1 - valor2;

if( v < 0){
    Console.WriteLine($"Valor negativo! O valor é: {v}");
}else if(v > 0){
    Console.WriteLine($"Valor positivo! O valor é: {v}");
}else {
    Console.WriteLine("Valor Zero!");
}

Console.WriteLine("");

//Modificação 9
double n1;
double n2;
double resto;

Console.WriteLine("Exercício 9");
Console.WriteLine("          Calcular o resto da divisão!!!          ");

Console.Write("Digite o primeiro numero: ");
n1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o segundo numero: ");
n2 = Convert.ToDouble(Console.ReadLine());

resto = n1 % n2;

if (n2 == 0){
    Console.WriteLine("Não é possivel realizar divisão por 0!");
}else{
    Console.Write($"O resto da divisão entre {n1} e {n2} é {resto}");
}
Console.WriteLine("");

Console.WriteLine("          Fim dos exercícios!!!          ");
