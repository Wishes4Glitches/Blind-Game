using UnrealBuildTool;

public class BlindGameTarget : TargetRules
{
	public BlindGameTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("BlindGame");
	}
}
