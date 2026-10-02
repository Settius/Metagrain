// Copyright Epic Games, Inc. All Rights Reserved.

#include "Metagrain.h"

#include "MetasoundFrontendModuleRegistrationMacros.h"

#define LOCTEXT_NAMESPACE "FMetagrainModule"

void FMetagrainModule::StartupModule()
{
	// UE 5.6+ MetaSound node registration: execute the module's registration actions
	// (the METASOUND_REGISTER_NODE entries linked at static initialization). Without
	// this the Granular Synth / Granular Wave Player Smooth classes never register.
	METASOUND_REGISTER_ITEMS_IN_MODULE

	UE_LOG(LogTemp, Warning, TEXT("Metagrain module has started."));
}

void FMetagrainModule::ShutdownModule()
{
	METASOUND_UNREGISTER_ITEMS_IN_MODULE

	UE_LOG(LogTemp, Warning, TEXT("Metagrain module has shut down."));
}

#undef LOCTEXT_NAMESPACE

METASOUND_IMPLEMENT_MODULE_REGISTRATION_LIST
IMPLEMENT_MODULE(FMetagrainModule, Metagrain)
