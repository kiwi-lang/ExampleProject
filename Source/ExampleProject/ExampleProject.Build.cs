// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ExampleProject : ModuleRules
{
	public ExampleProject(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(new string[] { 
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"HeadMountedDisplay",
			"NavigationSystem",
			"AIModule",
			"Niagara"
		});

		        // Version Info
        // ------------
        // Automatically set by the CI
        string EXAMPLEPROJECT_TAG = "v1.2.3";
        string EXAMPLEPROJECT_HASH = "54b907fdc";
        string EXAMPLEPROJECT_DATE = "2024-02-16 11:28:06 -0500";

        PublicDefinitions.Add("EXAMPLEPROJECT_TAG=" + EXAMPLEPROJECT_TAG);
        PublicDefinitions.Add("EXAMPLEPROJECT_COMMIT=" + EXAMPLEPROJECT_HASH);
        PublicDefinitions.Add("EXAMPLEPROJECT_DATE=" + EXAMPLEPROJECT_DATE);
    }
}
