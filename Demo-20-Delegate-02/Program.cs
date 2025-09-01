using Demo_20_Delegate_02.Models;

namespace Demo_20_Delegate_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VisualStudioCode vscode = new VisualStudioCode();

            VSCodeExtension ext_prettier = new("Prettier");
            VSCodeExtension ext_linter = new("Linter");
            VSCodeExtension ext_SqlServer = new("Sql Server");
            VSCodeExtension ext_ThunderClient = new("Thunder Client");

            vscode.AjouterExtension(ext_prettier);
            vscode.AjouterExtension(ext_linter);
            vscode.AjouterExtension(ext_SqlServer);
            vscode.AjouterExtension(ext_ThunderClient);

            vscode.DemarrerVSCode();

            vscode.DisableExtension(ext_linter);
            vscode.DisableExtension(ext_prettier);
            vscode.EnableExtension(ext_linter);

        }
    }
}
