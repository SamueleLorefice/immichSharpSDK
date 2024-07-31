# ImmichApi.Model.AssetResponseDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Checksum** | **string** | base64 encoded sha1 hash | 
**DeviceAssetId** | **string** |  | 
**DeviceId** | **string** |  | 
**DuplicateId** | **string** |  | [optional] 
**Duration** | **string** |  | 
**ExifInfo** | [**ExifResponseDto**](ExifResponseDto.md) |  | [optional] 
**FileCreatedAt** | **DateTime** |  | 
**FileModifiedAt** | **DateTime** |  | 
**HasMetadata** | **bool** |  | 
**Id** | **string** |  | 
**IsArchived** | **bool** |  | 
**IsFavorite** | **bool** |  | 
**IsOffline** | **bool** |  | 
**IsTrashed** | **bool** |  | 
**LibraryId** | **string** | This property was deprecated in v1.106.0 | [optional] 
**LivePhotoVideoId** | **string** |  | [optional] 
**LocalDateTime** | **DateTime** |  | 
**OriginalFileName** | **string** |  | 
**OriginalMimeType** | **string** |  | [optional] 
**OriginalPath** | **string** |  | 
**Owner** | [**UserResponseDto**](UserResponseDto.md) |  | [optional] 
**OwnerId** | **string** |  | 
**People** | [**List&lt;PersonWithFacesResponseDto&gt;**](PersonWithFacesResponseDto.md) |  | [optional] 
**Resized** | **bool** |  | 
**SmartInfo** | [**SmartInfoResponseDto**](SmartInfoResponseDto.md) |  | [optional] 
**Stack** | [**List&lt;AssetResponseDto&gt;**](AssetResponseDto.md) |  | [optional] 
**StackCount** | **int?** |  | 
**StackParentId** | **string** |  | [optional] 
**Tags** | [**List&lt;TagResponseDto&gt;**](TagResponseDto.md) |  | [optional] 
**Thumbhash** | **string** |  | 
**Type** | **AssetTypeEnum** |  | 
**UnassignedFaces** | [**List&lt;AssetFaceWithoutPersonResponseDto&gt;**](AssetFaceWithoutPersonResponseDto.md) |  | [optional] 
**UpdatedAt** | **DateTime** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

