using BTD_Mod_Helper.Api.Helpers;
namespace BTD_Mod_Helper.Api.Commands;

internal class ExportGameModelCommand : ModCommand<ExportCommand>
{
    public override string Command => "gamedata";
    public override string Help => "Exports most static game data to the sandbox root folder";

    public override bool Execute(ref string resultText)
    {
        GameModelExporter.ExportAll();

        return true;
    }
}