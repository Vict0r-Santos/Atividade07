using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        double valor;
        string option;
        
        Console.WriteLine ("Bem-vindo a Maquina de Cafe do Submundo");
        Console.WriteLine ("Essas são as opcoes:");
        Console.WriteLine ("1 - Café Expresso - 3,00");
        Console.WriteLine ("2 - Capuccino - 4,50");
        Console.WriteLine ("3 - Mocaccino - 6,00");
        Console.WriteLine ("4 - Agua Quente - 1,00");
        Console.WriteLine ("Informe o  Valor que deseja inserir na Maquina:");
        valor = double.Parse(Console.ReadLine());
        
        if (valor < 1.00) {
            Console.WriteLine ("Valor insuficente...");
            Console.ReadLine();
            Console.Clear();
            Main(null);
            
            return;
        }
        Console.WriteLine("informe a opção desejada:");
        option = Console.ReadLine();
        
        if (option == "1") {
            Console.WriteLine("Voce selecionou Café expresso - 3,00");
            if (valor < 3.00) {
            Console.WriteLine ("Valor insuficente...");
            Console.ReadLine();
            Console.Clear();
            Main(null);
            
            return;
            }else{
            Console.WriteLine("Pagamento feito com sucesso"); 
            Console.WriteLine($"Troco = {valor - 3.00} reais");
            Console.ReadLine();
            Console.Clear();
            Main(null);
            
            return;
            }
            
            
        }
        
        if (option == "2") {
            Console.WriteLine("Voce selecionou Capuccino - 4,50");
            if (valor < 4.50) {
            Console.WriteLine ("Valor insuficente...");
            Console.ReadLine();
            Console.Clear();
            Main(null);
            
            return;
            }else{
            Console.WriteLine("Pagamento feito com sucesso"); 
            Console.WriteLine($"Troco = {valor - 4.50} reais");
            Console.ReadLine();
            Console.Clear();
            Main(null);
            
            return;
            }
            
        }
            
            if (option == "3") {
            Console.WriteLine("Voce selecionou Mocaccino - 6,00");
            if (valor < 6.00) {
            Console.WriteLine ("Valor insuficente...");
            Console.ReadLine();
            Console.Clear();
            Main(null);
            
            return;
            }else{
            Console.WriteLine("Pagamento feito com sucesso"); 
            Console.WriteLine($"Troco = {valor - 6.00} reais");
            Console.ReadLine();
            Console.Clear();
            Main(null);
            
            return;
            }
            
            }
            
            if (option == "4") {
            Console.WriteLine("Voce selecionou Agua Quente - 1,00");
            if (valor < 1.00) {
            Console.WriteLine ("Valor insuficente...");
            Console.ReadLine();
            Console.Clear();
            Main(null);
            
            return;
            }else{
            Console.WriteLine("Pagamento feito com sucesso"); 
            Console.WriteLine($"Troco = {valor - 1.00} reais");
            Console.ReadLine();
            Console.Clear();
            Main(null);
            
            return;
            }
            
            }
            
          Console.ReadLine();
    }
}
