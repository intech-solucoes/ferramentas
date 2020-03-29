using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Intech.Ferramentas
{
    static class Program
    {
        private static string SourceProjectDir =
            @"C:\git\intech\ferramentas\Intech.Ferramentas\Intech.Ferramentas.Design";
        private static string TargetProjectDir =
            @"C:\git\intech\ferramentas\Intech.Ferramentas\Intech.Ferramentas";

        [STAThread]
        static void Main()
        {
            var directory = new DirectoryInfo(SourceProjectDir);

            var blockedFiles = new List<string>
            {
                "AssemblyInfo.cs",
                "Resources.Designer.cs",
                "Settings.Designer.cs",
                "Program.cs"
            };

            var srcFiles = directory
                .GetFiles("*.cs", SearchOption.AllDirectories)
                .Where(x => !blockedFiles.Contains(x.Name))
                .ToList();

            foreach (var srcFile in srcFiles)
            {
                // Get the relative directory
                var relativeDirectory = $"{srcFile.DirectoryName.Substring(SourceProjectDir.Length, srcFile.DirectoryName.Length - SourceProjectDir.Length)}";

                // Append the determined relative directory to the corresponding designer 
                // & C# source files related to the form.
                var designerFileName = $@"{relativeDirectory}\{srcFile.Name}";
                var noDesignerFileName =
                  $@"{relativeDirectory}\{srcFile.Name.Replace(".Designer", "")}";

                var srcDesignerFile = $"{SourceProjectDir}{designerFileName}";
                var srcNoDesignerFile = $"{SourceProjectDir}{noDesignerFileName}";

                var dstDesignerFile = $"{TargetProjectDir}{designerFileName}";
                var dstNoDesignerFile = $"{TargetProjectDir}{noDesignerFileName}";

                // Create an array based on the relative location.
                var dirs = relativeDirectory.Split('\\').ToList();

                // Keep track of where were we when we created a directory.
                var currentDir = TargetProjectDir;

                // Start creating the missing directories in our target project.
                foreach (var dir in dirs)
                {
                    currentDir = Path.Combine(currentDir, dir);
                    Directory.CreateDirectory(currentDir);
                }

                // Overwrite the file to the targeted project.
                File.Copy(srcDesignerFile, dstDesignerFile, true);

                // If our UI logic is unavailable, that means we've created 
                // a new form from the source project.
                // so we copy the form's UI logic code to the target project.
                if (!File.Exists(dstNoDesignerFile) && File.Exists(srcNoDesignerFile))
                {
                    File.Copy(srcNoDesignerFile, dstNoDesignerFile, false);
                }
            }
        }
    }
}