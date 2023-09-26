int n = 1; 
do{

Console.WriteLine("Bem vindo ao Seu Gerador de relatório de IMC"); 
Console.WriteLine("Insira seu nome para iniciarmos o relatório:");
string? nome = Console.ReadLine ();

Console.WriteLine("Insira Os dados questionados pelo programa!");
Console.WriteLine("Insira sua idade:");
///////////////////////////////////////////////////////
int idade = Convert.ToInt32 (Console.ReadLine());
   
////////////////////////////////////////////////////
Console.WriteLine("Insira sua altura:");
double altura = Convert.ToDouble (Console.ReadLine());

Console.WriteLine("Insira seu peso:");
double peso = Convert.ToDouble (Console.ReadLine());

/////////////////////////////////////////////////////
double imc = peso /(altura * altura);
  
//////////////////////////////////////////////////////
    
Console.WriteLine ("Seu Relatório está sendo processado !");
Console.WriteLine ($"Nome de Usuário:{nome}");
Console.WriteLine ($"Idade de Usuário:{idade}");
 if (idade < 14){
      Console.WriteLine("O usuário atualmente esta na fase de Criança");
    }
    else if (idade < 18){
     Console.WriteLine("O usuário atualmente esta na fase de Adolescente");
    }
    else if (idade < 60 ){
       Console.WriteLine("O usuário atualmente esta na fase de Adulto");
    }
    else {
       Console.WriteLine("O usuário atualmente esta na fase de Idoso");
    }
Console.WriteLine ($"Peso de Usuário:{peso}");
Console.WriteLine ($"altura de Usuário:{altura}");
Console.WriteLine ($"Usuário possui seu IMC calculado em: {imc} !");


      if (imc < 16.9 ){
       Console.WriteLine( "Está classificado em Muito abaixo do Peso!");
    }
    else if (imc < 18.4 ){
   Console.WriteLine("Está classificado em Abaixo do peso!");
    }
    else if (imc < 24.9 ){
      Console.WriteLine("Está classificado em Peso Normal!");
    }
    else if (imc < 29.9 ){
       Console.WriteLine("Está classificado em Acima do peso!!");
    }
    else if (imc < 34.9 ){
      Console.WriteLine("Está classificado em Obesidade grau 1!");
    }
    else if (imc < 40 ){
       Console.WriteLine("Está classificado em Obesidade grau 2!!");
    }
    else if (imc > 40 ){
        Console.WriteLine("Está classificado em Obesidade grau 3!!!");
    }
Console.WriteLine("Você deseja gerar outro relatório ?");
Console.WriteLine("caso deseje gerar outro relatório insira o numero '1' ");
Console.WriteLine("Caso deseje finalizar insira o numero '2' ");
n = Convert.ToInt32 (Console.ReadLine());
} while (n == 1);