/*
// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;

public class Voxel : ModuleRules
{
	public Voxel(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });
		
		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}

// Fill out your copyright notice in the Description page of Project Settings.
*/
using System.IO;
using UnrealBuildTool;
public class Voxel : ModuleRules
{
    // The path to our game module; e.g. ProjectFolder/Source/ModuleName/
    private string ModulePath
    {
        get { return ModuleDirectory; }
    }

    // The path to our Third Party code assets; e.g. ProjectFolder/ThirdParty/
    private string ThirdPartyPath
    {
        get { return Path.Combine(ModulePath, "../../ThirdParty/"); }
    }

    public Voxel(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
        PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "ProceduralMeshComponent" });
        PrivateDependencyModuleNames.AddRange(new string[] { });



        //PublicIncludePaths.Add(Path.Combine(ThirdPartyPath, "polyvox/library/PolyVoxCore/include/PolyVoxCore"));
        PublicIncludePaths.Add(Path.Combine(ThirdPartyPath, "polyvox", "include"));

    }
}
