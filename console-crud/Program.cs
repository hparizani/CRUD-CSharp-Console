using System;
using System.Collections.Generic;

namespace console_crud
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            Util util = new Util();
            int option = 0;

            do
            {
                util.showMainMenu(ref option);

                if (option < 1 || option > 5)
                {
                    Console.WriteLine("Opção inválida, digite um valor númerico (1 a 5).");
                    Console.WriteLine("Pressione 'Enter' para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                Console.Clear();

                switch (option)
                {
                    case 1: // Register Product
                        try
                        {
                            util.showRegistrerMenu(product);
                            bool returnRegisterProduct = product.registrerProduct(product);

                            if (returnRegisterProduct)
                            {
                                Console.WriteLine(String.Format("Cadastro do produto {0} realizado com sucesso.", product.name));
                            }
                            else
                            {
                                Console.WriteLine("Falha ao cadastrar produto");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(String.Format("Erro ao executar cadastro do produto {0}. Erro: {1}", product.name, ex.Message));
                        }
                        break;

                    case 2: // Select Products
                        try
                        {
                            List<Product> products = product.GetProducts(); // Recarrega a lista de produtos
                            foreach (Product selectedProduct in products)
                            {
                                Console.WriteLine($"ID: {selectedProduct.id} Nome: {selectedProduct.name} Quantidade: {selectedProduct.quantity} Descrição: {selectedProduct.description} Preço: {selectedProduct.price}");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(String.Format("Erro ao selecionar produtos. Erro: {0}", ex.Message));
                        }
                        break;

                    case 3: // Update Product
                        try
                        {
                            List<Product> products = product.GetProducts(); // Recarrega a lista de produtos
                            foreach (Product updateProduct in products)
                            {
                                Console.WriteLine($"ID: {updateProduct.id} Nome: {updateProduct.name} Quantidade: {updateProduct.quantity} Descrição: {updateProduct.description} Preço: {updateProduct.price}");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(String.Format("Erro ao selecionar produtos. Erro: {0}", ex.Message));
                        }

                        try
                        {
                            util.showUpdateMenu(product);
                            bool returnUpdateProduct = product.updateProduct(product);

                            if (returnUpdateProduct)
                            {
                                Console.WriteLine(String.Format("Alteração do produto {0} realizada com sucesso.", product.name));
                            }
                            else
                            {
                                Console.WriteLine("Falha ao alterar produto");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(String.Format("Erro ao alterar produto. Erro: {0}", ex.Message));
                        }
                        break;

                    case 4: // Delete Product
                        Console.WriteLine("Produtos cadastrados: ");
                        try
                        {
                            List<Product> products = product.GetProducts(); // Recarrega a lista de produtos
                            foreach (Product selectedProduct in products)
                            {
                                Console.WriteLine($"ID: {selectedProduct.id} Nome: {selectedProduct.name}  Quantidade:  {selectedProduct.quantity} Descrição: {selectedProduct.description} Preço: {selectedProduct.price}");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(String.Format("Erro ao selecionar produtos. Erro: {0}", ex.Message));
                        }

                        try
                        {
                            util.showDeleteMenu(product);
                            bool returnDeleteProduct = product.deleteProduct(product);

                            if (returnDeleteProduct)
                            {
                                Console.WriteLine(String.Format("Produto {0} deletado com sucesso.", product.id));
                            }
                            else
                            {
                                Console.WriteLine("Falha ao deletar o produto");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(String.Format("Erro ao deletar produto. Erro {0}", ex.Message));
                        }
                        break;

                    case 5: // Exit
                        Console.WriteLine("Saindo do programa...");
                        return;
                }

                Console.WriteLine("Pressione 'Enter' para continuar...");
                Console.ReadKey();
                Console.Clear();

            } while (option != 5);
        }
    }
}


