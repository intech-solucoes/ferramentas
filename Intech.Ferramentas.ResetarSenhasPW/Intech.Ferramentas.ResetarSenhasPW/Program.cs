#region Usings
using Dapper;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
#endregion

namespace Intech.Ferramentas.ResetarSenhasPW
{
    class Program
    {
        static string header = @"

  _____           _                   _     
 |_   _|         | |                 | |    
   | |    _ __   | |_    ___    ___  | |__  
   | |   | '_ \  | __|  / _ \  / __| | '_ \ 
  _| |_  | | | | | |_  |  __/ | (__  | | | |
 |_____| |_| |_|  \__|  \___|  \___| |_| |_|
                                            
                                            
";

        static string header2 = @"

 _____                                    _   _____                _       _ _             
|  __ \                                  | | |  __ \              | |     (_) |            
| |__) |_ _ ___ _____      _____  _ __ __| | | |__) |___  ___  ___| |_ ___ _| |_ ___  _ __ 
|  ___/ _` / __/ __\ \ /\ / / _ \| '__/ _` | |  _  // _ \/ __|/ _ \ __/ _ \ | __/ _ \| '__|
| |  | (_| \__ \__ \\ V  V / (_) | | | (_| | | | \ \  __/\__ \  __/ ||  __/ | || (_) | |   
|_|   \__,_|___/___/ \_/\_/ \___/|_|  \__,_| |_|  \_\___||___/\___|\__\___|_|\__\___/|_|   
                                                                                           
                                              ";

        static string header3 = @"by Rony Moura <ronymmoura@gmail.com>";

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(header);
                Console.Write(header2);
                Console.WriteLine(header3);
                Console.WriteLine();
                Console.WriteLine();

                Console.Write("Informe o servidor: ");
                var servidor = Console.ReadLine();

                Console.Write("Informe o usuário: ");
                var usuario = Console.ReadLine();

                Console.Write("Informe a senha: ");
                var senha = Console.ReadLine();

                Console.Write("Informe o nome do banco: ");
                var banco = Console.ReadLine();

                var connectionString = $"Data Source={servidor};Initial Catalog={banco};User ID={usuario};Password={senha};Persist Security Info=True";

                var conexao = new SqlConnection(connectionString);

                var result = conexao.Query("SELECT * FROM FR_USUARIO").ToList();
                foreach (var user in result)
                {
                    var senhaCriptografada = GerarHashMd5(user.USR_CODIGO.ToString() + (123).ToString());
                    conexao.ExecuteScalar("UPDATE FR_USUARIO SET USR_SENHA = @SENHA WHERE USR_CODIGO = @USR_CODIGO", new { SENHA = senhaCriptografada, user.USR_CODIGO });
                }

                Console.WriteLine("Senhas resetadas com sucesso! Pressione uma tecla para fechar...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static string GerarHashMd5(string input)
        {
            var md5Hash = MD5.Create();
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            var sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }
    }
}