using System;

namespace console_crud
{
    public class Util
    {
        Product product = new Product();
        public void showMainMenu(ref int option)
        {
            Console.WriteLine("Bem-vindo ao sistema de gerenciamento de produtos, escolha uma opção(1 a 5): ");
            Console.WriteLine("1 - Cadastrar");
            Console.WriteLine("2 - Visualizar produtos cadastrados");
            Console.WriteLine("3 - Atualizar produtos");
            Console.WriteLine("4 - Deletar produto");
            Console.WriteLine("5 - Sair");
            option = Convert.ToInt16(Console.ReadLine());
        }

        public void showRegistrerMenu(Product product)
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

        public void showUpdateMenu(Product product)
        {
            Console.WriteLine("Informe o novo nome do produto: ");
            product.name = Console.ReadLine();
            Console.WriteLine("Informe a nova quantidade do produto: ");
            product.quantity = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Informa a nova descrição do produto: ");
            product.description = Console.ReadLine();
            Console.WriteLine("Informe o novo preço do produto: ");
            product.price = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Informe o id do produto a ser alterado: ");
            product.id = Convert.ToInt16(Console.ReadLine());
        }

        public void showDeleteMenu(Product product)
        {
            Console.WriteLine("Informe o ID do produto que deseja excluir: ");
            product.id = Convert.ToInt16(Console.ReadLine());
        }
    }
}
