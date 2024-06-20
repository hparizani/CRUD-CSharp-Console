using System;

namespace console_crud
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            int option = 0;
            do
            {
                option = 0;
                Console.WriteLine("Bem-vindo ao sistema de gerenciamento de produtos, escolha uma opção(1 a 4): ");
                Console.WriteLine("1 - Cadastrar");
                Console.WriteLine("2 - Visualizar produtos cadastrados");
                Console.WriteLine("3 - Atualizar produtos");
                Console.WriteLine("4 - Deletar produto");
                option = Convert.ToInt16(Console.ReadLine());
                if (option < 1|| option > 4)
                {
                    Console.WriteLine("Opção inválida, digite um valor númerico (1 a 4).");
                }
            }while(option < 1 || option > 4);
            
            Console.Clear();

            if (option == 1)
            {
                try
                {
                    registrer(product);
                    bool returnRegirstrerProduct = product.registrerProduct(product);

                    if (returnRegirstrerProduct)
                    {
                        Console.WriteLine(String.Format("Cadastro do produto {0} realizado com sucesso.", product.name));
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Falha ao cadastrar produto");
                        Console.ReadKey();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(String.Format("Erro ao executar cadastro do produto {0}. Erro: {1}", product.name, ex.Message));
                }
            }

        }

        static void registrer(Product product)
        {
            Console.WriteLine("Informe o nome do produto: ");
            product.name = Console.ReadLine();
            Console.WriteLine("Informe a quantidade do produto: ");
            product.quantity = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Informe a descrição do produto: ");
            product.description = Console.ReadLine();
            Console.WriteLine("Informe o preço do produto: ");
            product.price = Convert.ToDecimal(Console.ReadLine());
        }
    }
}
