using UnrealBuildTool;

public class SherrifsShenanigansEditorTarget : TargetRules
{
	public SherrifsShenanigansEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("SherrifsShenanigans");
	}
}
