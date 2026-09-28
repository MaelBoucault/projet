// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class PojectProject : ModuleRules
{
	public PojectProject(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"PojectProject",
			"PojectProject/Variant_Platforming",
			"PojectProject/Variant_Platforming/Animation",
			"PojectProject/Variant_Combat",
			"PojectProject/Variant_Combat/AI",
			"PojectProject/Variant_Combat/Animation",
			"PojectProject/Variant_Combat/Gameplay",
			"PojectProject/Variant_Combat/Interfaces",
			"PojectProject/Variant_Combat/UI",
			"PojectProject/Variant_SideScrolling",
			"PojectProject/Variant_SideScrolling/AI",
			"PojectProject/Variant_SideScrolling/Gameplay",
			"PojectProject/Variant_SideScrolling/Interfaces",
			"PojectProject/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
