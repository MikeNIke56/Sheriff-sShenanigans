using UnrealBuildTool;

public class SherrifsShenanigansServerTarget : TargetRules
{
	public SherrifsShenanigansServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("SherrifsShenanigans");
	}
}
