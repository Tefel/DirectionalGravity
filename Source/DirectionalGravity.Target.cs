// Copyright 2019 Tefel. All Rights Reserved

using UnrealBuildTool;
using System.Collections.Generic;

public class DirectionalGravityTarget : TargetRules
{
	public DirectionalGravityTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "DirectionalGravity" } );
	}
}
