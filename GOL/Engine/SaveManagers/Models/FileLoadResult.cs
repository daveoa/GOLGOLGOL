using GOL.Engine.GameMechanics;

namespace GOL.Engine.SaveManagers.Models
{
    public class FileLoadResult
    {
        public bool isLoadSuccessful { get; set; }
        public BoardGame gameFromSave { get; set; }
    }
}
