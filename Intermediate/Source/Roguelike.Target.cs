using UnrealBuildTool;

public class RoguelikeTarget : TargetRules
{
	public RoguelikeTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Roguelike");
	}
}
