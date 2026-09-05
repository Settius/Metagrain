// Copyright Epic Games, Inc. All Rights Reserved.

#include "Metagrain.h"
#include "MetasoundFrontendModuleRegistrationMacros.h"

#define LOCTEXT_NAMESPACE "FMetagrainModule"

METASOUND_IMPLEMENT_MODULE_REGISTRATION_LIST

void FMetagrainModule::StartupModule()
{
	METASOUND_REGISTER_ITEMS_IN_MODULE
	UE_LOG(LogTemp, Warning, TEXT("Metagrain module has started and registered MetaSound nodes."));
}

void FMetagrainModule::ShutdownModule()
{
	METASOUND_UNREGISTER_ITEMS_IN_MODULE
	UE_LOG(LogTemp, Warning, TEXT("Metagrain module has shut down."));
}

#undef LOCTEXT_NAMESPACE

IMPLEMENT_MODULE(FMetagrainModule, Metagrain)
