using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace Shared.UnoLibraryIssue.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new Shared.UnoLibraryIssue.App(), args);
            host.Run();
        }
    }
}
