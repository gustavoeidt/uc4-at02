/****
Classes estáticas não precisam ser instanciadas.
No ASP.NET Core MVC, classes estáticas vivem do início 
ao fim da execução do programa.
Por isso, Dados deve ser usado para manipular as informações
dos pedidos.
Exemplos de uso:
Dados.PedidoAtual.PropriedadeDePedido = "Algum Valor";
Dados.PedidoAtual.MetodoDePedido();
*****/

using System.Collections.Generic;

namespace at02.Models
{
    public static class Dados{

        public static Usuario usuario {get; set;}
        public static bool logado {get; set;}
        public static bool admin {get; set;}
        static Dados()
        { 
            usuario = new Usuario();
            logado = false;
            admin = false;
        }
        
        public static Usuario retornarUsuario()
        {
            return usuario;
        }

        public static void Login()
        {
            logado = true;
        }

        public static void Logoff()
        {
            logado = false;
        }
    }
}