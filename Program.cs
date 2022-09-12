using ProjetoCalculadora.Models;

//intanciando a classe calculadora em um novo objeto calc
Calculadora calc = new Calculadora();

bool repetir = true;

do {
    calc.Menu();
    Console.WriteLine("Para realizar o procedimento novamente pressione enter");
    Console.WriteLine("digite n para sair");
    string sair = Console.ReadLine();
    if(sair == "n" || sair == "N"){
        repetir = false;
    }
}
while(repetir == true);