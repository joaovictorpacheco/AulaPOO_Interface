using System;
using System.Collections.Generic;

namespace POOInterfaces.classes
{
    public class Carrinho : ICarrinho
    {

        List<Produto> carrinho = new List<Produto>();

        
        public void Alterar(int cod, Produto produto)
        {
            //Lambda
            // Produto
            // Cod 123
            // PlayStation 5
            //R$ 10.000
            // Alterar(123, Xbox Serie X)
            carrinho.Find(x => x.Codigo == cod).Nome = produto.Nome;
            carrinho.Find(x => x.Codigo == cod).Preco = produto.Preco;
        }

        public void Cadastrar(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void Deletar(Produto produto)
        {
            carrinho.Remove(produto);
        }

        public void Listar()
        {
            foreach(Produto itemCarrinho in carrinho){
                Console.WriteLine($"Produto : {itemCarrinho.Nome} \n Preco: R$ {itemCarrinho.Preco} \n Código: {itemCarrinho.Codigo}");

            }
        }
    }
}