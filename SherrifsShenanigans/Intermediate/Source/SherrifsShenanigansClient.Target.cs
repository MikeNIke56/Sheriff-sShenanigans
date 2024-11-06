using UnrealBuildTool;

public class SherrifsShenanigansClientTarget : TargetRules
{
	public SherrifsShenanigansClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("SherrifsShenanigans");
	}
}
