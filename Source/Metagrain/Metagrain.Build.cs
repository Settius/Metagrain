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
                "MetasoundEngineTest",
                "MetasoundEditor",
                "MetasoundStandardNodes",
                "MetasoundFrontend",
                "MetasoundGenerator",
                "MetasoundEngineTest",
                "MetasoundEditor",
                "WaveTable",
                "AudioExtensions",
                "SignalProcessing",
                "MetasoundGraphCore"
            }
        );

        PrivateDependencyModuleNames.AddRange(
            new string[]
            {
                "CoreUObject",
                "Engine",
                "AudioExtensions",
                "MetasoundEditor",
                "MetasoundEngineTest",
                "MetasoundEngine",
                "MetasoundFrontend",
                "MetasoundGenerator",
                "MetasoundGraphCore",
                "MetasoundStandardNodes",
                "WaveTable",
                "SignalProcessing",
                "AudioExtensions"
            }
        );
    }
}
