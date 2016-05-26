using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DAL
{
    public class DadosDaConexao
    {
        public static String servidor = @"DESKTOP-2GBEGHL\SQLEXPRESS";
        public static String banco = "nupac";
        public static String usuario = "root";
        public static String senha = "salmo91";
        public static String StringDeConexao
        {
            get 
            {
                return @"Data Source="+servidor+";Initial Catalog="+banco+";User ID="+usuario+";Password="+senha;
            }
        }
    }
}
