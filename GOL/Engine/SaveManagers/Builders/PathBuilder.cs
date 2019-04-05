using GOL.Engine.Config;
using System.IO;

namespace GOL.Engine.SaveManagers.Builders
{
    public class PathBuilder
    {
        public string Build(string filename)
        {
            var path = filename + ".save";
            path = Path.Combine(ConfigSettings.Path, filename);
            return path;
        }
    }
}
