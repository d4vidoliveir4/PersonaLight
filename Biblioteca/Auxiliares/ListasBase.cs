using Dominio.Enumerados;
using System;
using System.Collections.Generic;

namespace Biblioteca.Auxiliares
{
    public static class ListasBase
    {
        public static List<Item> ObterListaMeses()
        {
            return new List<Item>
                {
                    new Item (1, "Janeiro"),
                    new Item (2, "Fevereiro"),
                    new Item (3, "Março"),
                    new Item (4, "Abril"),
                    new Item (5, "Maio"),
                    new Item (6, "Junho"),
                    new Item (7, "Julho"),
                    new Item (8, "Agosto"),
                    new Item (9, "Setembro"),
                    new Item (10, "Outubro"),
                    new Item (11, "Novembro"),
                    new Item (12, "Dezembro"),
                };
        }

        public static List<Item> ObterUltimos10Anos()
        {
            return new List<Item>
                {
                    new Item (DateTime.Now.Year, DateTime.Now.Year.ToString()),
                    new Item (DateTime.Now.Year-1, (DateTime.Now.Year-1).ToString()),
                    new Item (DateTime.Now.Year-2, (DateTime.Now.Year-2).ToString()),
                    new Item (DateTime.Now.Year-3, (DateTime.Now.Year-3).ToString()),
                    new Item (DateTime.Now.Year-4, (DateTime.Now.Year-4).ToString()),
                    new Item (DateTime.Now.Year-5, (DateTime.Now.Year-5).ToString()),
                    new Item (DateTime.Now.Year-6, (DateTime.Now.Year-6).ToString()),
                    new Item (DateTime.Now.Year-7, (DateTime.Now.Year-7).ToString()),
                    new Item (DateTime.Now.Year-8, (DateTime.Now.Year-8).ToString()),
                    new Item (DateTime.Now.Year-9, (DateTime.Now.Year-9).ToString()),
                };
        }
        
        public static List<Item> ObterTiposFinanceiro()
        {
            return new List<Item> 
                { 
                    new Item ((int)TipoFinanceiro.Entrada, TipoFinanceiro.Entrada.ToString()),
                    new Item ((int)TipoFinanceiro.Saida, TipoFinanceiro.Saida.ToString())
                };
        }
    }
}
