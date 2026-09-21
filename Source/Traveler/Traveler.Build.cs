// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Traveler : ModuleRules
{
	public Traveler(ReadOnlyTargetRules Target) : base(Target)
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
			"Traveler",
			"Traveler/Variant_Platforming",
			"Traveler/Variant_Platforming/Animation",
			"Traveler/Variant_Combat",
			"Traveler/Variant_Combat/AI",
			"Traveler/Variant_Combat/Animation",
			"Traveler/Variant_Combat/Gameplay",
			"Traveler/Variant_Combat/Interfaces",
			"Traveler/Variant_Combat/UI",
			"Traveler/Variant_SideScrolling",
			"Traveler/Variant_SideScrolling/AI",
			"Traveler/Variant_SideScrolling/Gameplay",
			"Traveler/Variant_SideScrolling/Interfaces",
			"Traveler/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
