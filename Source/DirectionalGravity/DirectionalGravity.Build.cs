// Copyright 2019 Tefel. All Rights Reserved

using UnrealBuildTool;

public class DirectionalGravity : ModuleRules
{
	public DirectionalGravity(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "AIModule" });

        PrivateDependencyModuleNames.AddRange(new string[] { "ProceduralMeshComponent" });

    }
}
