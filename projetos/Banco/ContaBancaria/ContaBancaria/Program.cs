namespace ContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao banco ETEC MCM");

            //Instanciar a classe conta e criar um objeto dela
            Conta conta = new Conta();
            Console.WriteLine("CONSULTANDO O SALDO");
            conta.consulta_saldo();
            Console.WriteLine("DEPÓSITO DE R$1000.35");
            conta.depositar(1000.35);
            conta.consulta_saldo();

            Console.WriteLine("SAQUE DE 500");
            conta.sacar(500);
            conta.consulta_saldo();

            Console.WriteLine("SAQUE DE 1000");
            conta.sacar(1000);
           

        }
    }
}