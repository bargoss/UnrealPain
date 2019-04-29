// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Actor.h"
#include "Test.generated.h"

UCLASS()
class VOXEL_API ATest : public AActor
{
	GENERATED_BODY()
	
public:	
	// Sets default values for this actor's properties
	ATest();
	class UProceduralMeshComponent* CustomMesh;
	
	/* The vertices of the mesh */
	TArray<FVector> Vertices;

	/* The triangles of the mesh */
	TArray<int32> Triangles;

protected:
	// Called when the game starts or when spawned
	virtual void BeginPlay() override;

	void MarchingTest();

	void AddTriangle(int32 V1, int32 V2, int32 V3);

	void GenerateCubeMesh();

public:	
	// Called every frame
	virtual void Tick(float DeltaTime) override;

};
