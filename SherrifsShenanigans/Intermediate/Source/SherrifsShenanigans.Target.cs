using UnrealBuildTool;

public class SherrifsShenanigansTarget : TargetRules
{
	public SherrifsShenanigansTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("SherrifsShenanigans");
	}
}
