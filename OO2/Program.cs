using System;

namespace OO2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Bem vindo ao ArthurBank");

            ContaCorrente conta1 = new ContaCorrente();
            
            System.Console.WriteLine("Digite o nome do titular:");
            conta1.titular = Console.ReadLine();
            System.Console.WriteLine("Digite o número da agência:");
            conta1.agencia = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o número da conta:");
            conta1.numeroConta = int.Parse(Console.ReadLine());
            conta1.Depositar(1000);
            // System.Console.WriteLine("Digite o valor do saque:");
            // double valor = double.Parse(Console.ReadLine());
            // bool resultado = conta1.Sacar(valor);

            ContaCorrente conta2 = new ContaCorrente();
            System.Console.WriteLine("Digite o nome do titular:");
            conta2.titular = Console.ReadLine();
            System.Console.WriteLine("Digite o número da agência:");
            conta2.agencia = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o número da conta:");
            conta2.numeroConta = int.Parse(Console.ReadLine());
            conta2.Depositar(3000);
            // System.Console.WriteLine("Digite o valor do saque:");
            // double valor2 = double.Parse(Console.ReadLine());
            // bool resultado2 = conta1.Sacar(valor2);

            System.Console.WriteLine("------------------------------");
            System.Console.WriteLine($"Titular: {conta1.titular}\nAgência: {conta1.agencia}\nNúmero da Conta: {conta1.numeroConta}\nSaldo: {conta1.saldo}");
            
            System.Console.WriteLine("------------------------------");

            System.Console.WriteLine($"Titular: {conta2.titular}\nAgência: {conta2.agencia}\nNúmero da Conta: {conta2.numeroConta}\nSaldo: {conta2.saldo}");
            System.Console.WriteLine("------------------------------");
            bool resultadoTransferencia = true;
            do{

            System.Console.WriteLine("Quanto deseja transferir da conta1 para a conta2:");
            double ValorTransferencia = double.Parse(Console.ReadLine());
            resultadoTransferencia = conta1.Transferir(ValorTransferencia, conta2);
            }while(resultadoTransferencia != true);

            System.Console.WriteLine("-----Resultado Tranferência-----");
            System.Console.WriteLine($"Saldo conta1 {conta1.saldo}");
            System.Console.WriteLine($"Saldo conta2 {conta2.saldo}");
        }
    }
}
