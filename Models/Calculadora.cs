using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCalculadora.Models
{   
    //Trabalhando com operadores aritiméticos usando C#
    public class Calculadora
    {

        public void Somar(){
            
            //entrada de dados
            Console.WriteLine($"Digite o primeiro termo:");
            string input1 = Console.ReadLine();
            Console.WriteLine($"Digite o segundo termo:");
            string input2 = Console.ReadLine();

            //conversao
            double.TryParse(input1, out double valor1);
            double.TryParse(input2, out double valor2);
            
            //saida
            Console.WriteLine($"{valor1} + {valor2} = {valor1 + valor2}");
            
        }

        public void Subtrair(){

            Console.WriteLine($"Digite o primeiro termo:");
            string input1 = Console.ReadLine();
            Console.WriteLine($"Digite o segundo termo:");
            string input2 = Console.ReadLine();

            double.TryParse(input1, out double valor1);
            double.TryParse(input2, out double valor2);
            
            Console.WriteLine($"{valor1} - {valor2} = {valor1 - valor2}");
        }   

        public void Dividir(){

            Console.WriteLine($"Digite o primeiro termo:");
            string input1 = Console.ReadLine();
            Console.WriteLine($"Digite o segundo termo:");
            string input2 = Console.ReadLine();

            double.TryParse(input1, out double valor1);
            double.TryParse(input2, out double valor2);
            
            Console.WriteLine($"{valor1} / {valor2} = {valor1 / valor2}");
        }

        public void Multiplicar(){

            Console.WriteLine($"Digite o primeiro termo:");
            string input1 = Console.ReadLine();
            Console.WriteLine($"Digite o segundo termo:");
            string input2 = Console.ReadLine();

            double.TryParse(input1, out double valor1);
            double.TryParse(input2, out double valor2);
            
            Console.WriteLine($"{valor1} * {valor2} = {valor1 * valor2}");
        }

        public void Potencia(){

            Console.WriteLine($"Digite a base:");
            string input1 = Console.ReadLine();
            Console.WriteLine($"Digite o expoente:");
            string input2 = Console.ReadLine();

            int.TryParse(input1, out int valor1);
            int.TryParse(input2, out int valor2);

            double resultado = Math.Pow(valor1,valor2);
            Console.WriteLine($"{valor1} elevado a {valor2} = {resultado}");
        }

        public void Seno(){
            
            Console.WriteLine($"Digite o angulo:");
            string input1 = Console.ReadLine();

            double.TryParse(input1, out double valor1);
            
            double radiano = valor1 * Math.PI / 180;
            double seno = Math.Sin(radiano);

            Console.WriteLine($"Seno de {input1}° = {Math.Round(seno,4)}");
        }
        public void Coseno(){

            Console.WriteLine($"Digite o angulo:");
            string input1 = Console.ReadLine();
            
            double.TryParse(input1, out double valor1);

            double radiano = valor1 * Math.PI / 180;
            double coseno = Math.Cos(radiano);

            Console.WriteLine($"Seno de {input1}° = {Math.Round(coseno,4)}");
        }

        public void Tangente(){
            
            Console.WriteLine($"Digite o angulo:");
            string input1 = Console.ReadLine();
            
            double.TryParse(input1, out double valor1);

            double radiano = valor1 * Math.PI / 180;
            double tangente = Math.Tan(radiano);

            Console.WriteLine($"Seno de {input1}° = {Math.Round(tangente, 4)}");
        }
        
        public void RaizQuadrada(){
            
            Console.WriteLine($"Digite o radicando: ");
            string input1 = Console.ReadLine();
            
            double.TryParse(input1, out double valor1);
            
            double raiz = Math.Sqrt(valor1);
            Console.WriteLine($"raiz quadrada de {input1} = {raiz}");
        }

        public void Menu(){

            string[] menuItens = {
                "1 - SOMA", 
                "2 - SUBTRACAO",
                "3 - DIVISAO", 
                "4 - MULTIPLICAR",
                "5 - POTENCIA",
                "6 - SENO",
                "7 - CONSENO",
                "8 - TANGENTE",
                "9 - RAIZ QUADRADA"
            };
            
            Console.WriteLine("Bem vindo a calculadora !");
            
            for(int i = 0; i < menuItens.Length; i++){
                Console.WriteLine(menuItens[i]);
            }

            Console.WriteLine("Digte a opção desejada:");
            string opcao = Console.ReadLine();
            int.TryParse(opcao, out int escolha);

           switch(escolha){
            
            case 1:
                Console.Clear();
                Console.WriteLine($"Você escolheu {menuItens[escolha-1]}! ");
                Somar();
            break;

            case 2:
                Console.Clear();
                Console.WriteLine($"Você escolheu {menuItens[escolha-1]}! ");
                Subtrair();
            break;

            case 3:
                Console.Clear();
                Console.WriteLine($"Você escolheu {menuItens[escolha-1]}! ");
                Dividir();
            break;

            case 4:
                Console.Clear();
                Console.WriteLine($"Você escolheu {menuItens[escolha-1]}! ");
                Multiplicar();
            break;
            
            case 5:
                Console.Clear();
                Console.WriteLine($"Você escolheu {menuItens[escolha-1]}! ");
                Potencia();
            break;

            case 6:
                Console.Clear();
                Console.WriteLine($"Você escolheu {menuItens[escolha-1]}! ");
                Seno();
            break;

            case 7:
                Console.Clear();
                Console.WriteLine($"Você escolheu {menuItens[escolha-1]}! ");
                Coseno();
            break;

            case 8:
                Console.Clear();
                Console.WriteLine($"Você escolheu {menuItens[escolha-1]}! ");
                Tangente();
            break;

            case 9:
                Console.Clear();
                Console.WriteLine($"Você escolheu {menuItens[escolha-1]}! ");
                RaizQuadrada();
            break;
            
            default:
                Console.WriteLine("Opção inválida");
            break;
           }
           
        }
    }
}