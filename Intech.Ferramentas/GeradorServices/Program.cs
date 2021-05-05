using System;

namespace GeradorServices
{
    class Program
    {
        static void Main(string[] args)
        {
            var oidProjeto = int.Parse(args[0]);
            var diretorioGit = args[1];
            var apiUrl = args[2];

            new Gerador(oidProjeto, diretorioGit, apiUrl).Gerar();
        }
    }
}
