// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Metagrain : ModuleRules
{
	public Metagrain(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

        // UE 5.6+ MetaSound node registration requires module-level registration lists.
        // Without these definitions the METASOUND_REGISTER_NODE actions land in the
        // deprecated global fallback list that nothing executes, so the plugin's node
        // classes never register with the frontend registry.
        PrivateDefinitions.AddRange(
            new string[]
            {
                "METASOUND_PLUGIN=Metagrain",
                "METASOUND_MODULE=Metagrain"
            }
        );

        PublicDependencyModuleNames.AddRange(
            new string[]
            {
                "Core",
                "CoreUObject",
                "MetasoundEngine",
                "MetasoundGraphCore",
                "MetasoundGenerator",
                "MetasoundStandardNodes",
                "MetasoundFrontend",
                "WaveTable",
                "AudioExtensions",
                "SignalProcessing"
            }
        );

        // Editor-only Metasound modules (UncookedOnly: MetasoundEditor, MetasoundEngineTest)
        // transitively reference engine editor modules (AudioEditor -> ClassViewer ->
        // EditorSubsystem -> UnrealEd), which are illegal for Game targets. The plugin's
        // runtime sources include no headers from these modules, so they are only
        // referenced for editor targets.
        if (Target.bBuildEditor)
        {
            PublicDependencyModuleNames.AddRange(
                new string[]
                {
                    "MetasoundEditor",
                    "MetasoundEngineTest"
                }
            );
        }

        PrivateDependencyModuleNames.AddRange(
            new string[]
            {
                "Engine",
                "AudioExtensions",
                "MetasoundEngine",
                "MetasoundFrontend",
                "MetasoundGenerator",
                "MetasoundGraphCore",
                "MetasoundStandardNodes",
                "WaveTable",
                "SignalProcessing"
            }
        );
    }
}
