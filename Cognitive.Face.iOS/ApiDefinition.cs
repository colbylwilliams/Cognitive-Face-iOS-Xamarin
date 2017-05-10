using System;
using Foundation;
using ObjCRuntime;

namespace Xamarin.Cognitive.Face.iOS
{

	// @interface MPOAddPersistedFaceResult : NSObject
	[BaseType (typeof (NSObject))]
	interface MPOAddPersistedFaceResult
	{
		// @property NSString * persistedFaceId;
		[Export ("persistedFaceId")]
		string PersistedFaceId { get; set; }

		// -(instancetype)initWithDictionary:(NSDictionary *)dict;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary dict);
	}

	// @interface MPOCandidate : NSObject
	[BaseType (typeof (NSObject))]
	interface MPOCandidate
	{
		// @property NSString * personId;
		[Export ("personId")]
		string PersonId { get; set; }

		// @property NSNumber * confidence;
		[Export ("confidence", ArgumentSemantic.Assign)]
		NSNumber Confidence { get; set; }

		// -(instancetype)initWithDictionary:(NSDictionary *)dict;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary dict);
	}

	// @interface MPOCreatePersonResult : NSObject
	[BaseType (typeof (NSObject))]
	interface MPOCreatePersonResult
	{
		// @property NSString * personId;
		[Export ("personId")]
		string PersonId { get; set; }

		// -(instancetype)initWithDictionary:(NSDictionary *)dict;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary dict);
	}

	// @interface MPOFaceFeatureCoordinate : NSObject 
	[BaseType (typeof (NSObject))]
	interface MPOFaceFeatureCoordinate
	{
		// @property NSNumber * x;
		[Export ("x", ArgumentSemantic.Assign)]
		NSNumber X { get; set; }

		// @property NSNumber * y;
		[Export ("y", ArgumentSemantic.Assign)]
		NSNumber Y { get; set; }

		// -(instancetype)initWithDictionary:(NSDictionary *)dict;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary dict);
	}

	// @interface MPOFaceLandmarks : NSObject
	[BaseType (typeof (NSObject))]
	interface MPOFaceLandmarks
	{
		// @property MPOFaceFeatureCoordinate * pupilLeft;
		[Export ("pupilLeft", ArgumentSemantic.Assign)]
		MPOFaceFeatureCoordinate PupilLeft { get; set; }

		// @property MPOFaceFeatureCoordinate * pupilRight;
		[Export ("pupilRight", ArgumentSemantic.Assign)]
		MPOFaceFeatureCoordinate PupilRight { get; set; }

		// @property MPOFaceFeatureCoordinate * noseTip;
		[Export ("noseTip", ArgumentSemantic.Assign)]
		MPOFaceFeatureCoordinate NoseTip { get; set; }

		// @property MPOFaceFeatureCoordinate * mouthLeft;
		[Export ("mouthLeft", ArgumentSemantic.Assign)]
		MPOFaceFeatureCoordinate MouthLeft { get; set; }

		// @property MPOFaceFeatureCoordinate * mouthRight;
		[Export ("mouthRight", ArgumentSemantic.Assign)]
		MPOFaceFeatureCoordinate MouthRight { get; set; }

		// @property MPOFaceFeatureCoordinate * eyebrowLeftOuter;
		[Export ("eyebrowLeftOuter", ArgumentSemantic.Assign)]
		MPOFaceFeatureCoordinate EyebrowLeftOuter { get; set; }

		// @property MPOFaceFeatureCoordinate * eyebrowLeftInner;
		[Export ("eyebrowLeftInner", ArgumentSemantic.Assign)]
		MPOFaceFeatureCoordinate EyebrowLeftInner { get; set; }

		// @property MPOFaceFeatureCoordinate * eyeLeftOuter;
		[Export ("eyeLeftOuter", ArgumentSemantic.Assign)]
		MPOFaceFeatureCoordinate EyeLeftOuter { get; set; }

		// @property MPOFaceFeatureCoordinate * eyeLeftTop;
		[Export ("eyeLeftTop", ArgumentSemantic.Assign)]
		MPOFaceFeatureCoordinate EyeLeftTop { get; set; }

		// @property MPOFaceFeatureCoordinate * eyeLeftBottom;
		[Export ("eyeLeftBottom", ArgumentSemantic.Assign)]
		MPOFaceFeatureCoordinate EyeLeftBottom { get; set; }

		// @property MPOFaceFeatureCoordinate * eyeLeftInner;
		[Export ("eyeLeftInner", ArgumentSemantic.Assign)]
		MPOFaceFeatureCoordinate EyeLeftInner { get; set; }

		// @property MPOFaceFeatureCoordinate * eyebrowRightInner;
		[Export ("eyebrowRightInner", ArgumentSemantic.Assign)]
		MPOFaceFeatureCoordinate EyebrowRightInner { get; set; }

		// @property MPOFaceFeatureCoordinate * eyeRightInner;
		[Export ("eyeRightInner", ArgumentSemantic.Assign)]
		MPOFaceFeatureCoordinate EyeRightInner { get; set; }

		// @property MPOFaceFeatureCoordinate * eyeRightTop;
		[Export ("eyeRightTop", ArgumentSemantic.Assign)]
		MPOFaceFeatureCoordinate EyeRightTop { get; set; }

		// @property MPOFaceFeatureCoordinate * eyeRightBottom;
		[Export ("eyeRightBottom", ArgumentSemantic.Assign)]
		MPOFaceFeatureCoordinate EyeRightBottom { get; set; }

		// @property MPOFaceFeatureCoordinate * eyeRightOuter;
		[Export ("eyeRightOuter", ArgumentSemantic.Assign)]
		MPOFaceFeatureCoordinate EyeRightOuter { get; set; }

		// @property MPOFaceFeatureCoordinate * noseRootLeft;
		[Export ("noseRootLeft", ArgumentSemantic.Assign)]
		MPOFaceFeatureCoordinate NoseRootLeft { get; set; }

		// @property MPOFaceFeatureCoordinate * noseRootRight;
		[Export ("noseRootRight", ArgumentSemantic.Assign)]
		MPOFaceFeatureCoordinate NoseRootRight { get; set; }

		// @property MPOFaceFeatureCoordinate * noseLeftAlarTop;
		[Export ("noseLeftAlarTop", ArgumentSemantic.Assign)]
		MPOFaceFeatureCoordinate NoseLeftAlarTop { get; set; }

		// @property MPOFaceFeatureCoordinate * noseLeftAlarOutTip;
		[Export ("noseLeftAlarOutTip", ArgumentSemantic.Assign)]
		MPOFaceFeatureCoordinate NoseLeftAlarOutTip { get; set; }

		// @property MPOFaceFeatureCoordinate * noseRightAlarOutTip;
		[Export ("noseRightAlarOutTip", ArgumentSemantic.Assign)]
		MPOFaceFeatureCoordinate NoseRightAlarOutTip { get; set; }

		// @property MPOFaceFeatureCoordinate * upperLipTop;
		[Export ("upperLipTop", ArgumentSemantic.Assign)]
		MPOFaceFeatureCoordinate UpperLipTop { get; set; }

		// @property MPOFaceFeatureCoordinate * upperLipBottom;
		[Export ("upperLipBottom", ArgumentSemantic.Assign)]
		MPOFaceFeatureCoordinate UpperLipBottom { get; set; }

		// @property MPOFaceFeatureCoordinate * underLipTop;
		[Export ("underLipTop", ArgumentSemantic.Assign)]
		MPOFaceFeatureCoordinate UnderLipTop { get; set; }

		// @property MPOFaceFeatureCoordinate * underLipBottom;
		[Export ("underLipBottom", ArgumentSemantic.Assign)]
		MPOFaceFeatureCoordinate UnderLipBottom { get; set; }

		// -(instancetype)initWithDictionary:(NSDictionary *)dict;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary dict);
	}

	// @interface MPOFaceHeadPose : NSObject
	[BaseType (typeof (NSObject))]
	interface MPOFaceHeadPose
	{
		// @property NSNumber * roll;
		[Export ("roll", ArgumentSemantic.Assign)]
		NSNumber Roll { get; set; }

		// @property NSNumber * yaw;
		[Export ("yaw", ArgumentSemantic.Assign)]
		NSNumber Yaw { get; set; }

		// @property NSNumber * pitch;
		[Export ("pitch", ArgumentSemantic.Assign)]
		NSNumber Pitch { get; set; }

		// -(instancetype)initWithDictionary:(NSDictionary *)dict;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary dict);
	}

	// @interface MPOFacialHair : NSObject
	[BaseType (typeof (NSObject))]
	interface MPOFacialHair
	{
		// @property NSNumber * mustache;
		[Export ("mustache", ArgumentSemantic.Assign)]
		NSNumber Mustache { get; set; }

		// @property NSNumber * beard;
		[Export ("beard", ArgumentSemantic.Assign)]
		NSNumber Beard { get; set; }

		// @property NSNumber * sideburns;
		[Export ("sideburns", ArgumentSemantic.Assign)]
		NSNumber Sideburns { get; set; }

		// -(instancetype)initWithDictionary:(NSDictionary *)dict;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary dict);
	}

	// @interface MPOFaceAttributes : NSObject
	[BaseType (typeof (NSObject))]
	interface MPOFaceAttributes
	{
		// @property NSNumber * age;
		[Export ("age", ArgumentSemantic.Assign)]
		NSNumber Age { get; set; }

		// @property NSNumber * smile;
		[Export ("smile", ArgumentSemantic.Assign)]
		NSNumber Smile { get; set; }

		// @property NSString * gender;
		[Export ("gender")]
		string Gender { get; set; }

		// @property MPOFaceHeadPose * headPose;
		[Export ("headPose", ArgumentSemantic.Assign)]
		MPOFaceHeadPose HeadPose { get; set; }

		// @property MPOFacialHair * facialHair;
		[Export ("facialHair", ArgumentSemantic.Assign)]
		MPOFacialHair FacialHair { get; set; }

		// -(instancetype)initWithDictionary:(NSDictionary *)dict;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary dict);
	}

	// @interface MPOFaceRectangle : NSObject
	[BaseType (typeof (NSObject))]
	interface MPOFaceRectangle
	{
		// @property NSNumber * width;
		[Export ("width", ArgumentSemantic.Assign)]
		NSNumber Width { get; set; }

		// @property NSNumber * height;
		[Export ("height", ArgumentSemantic.Assign)]
		NSNumber Height { get; set; }

		// @property NSNumber * left;
		[Export ("left", ArgumentSemantic.Assign)]
		NSNumber Left { get; set; }

		// @property NSNumber * top;
		[Export ("top", ArgumentSemantic.Assign)]
		NSNumber Top { get; set; }

		// -(instancetype)initWithDictionary:(NSDictionary *)dict;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary dict);
	}

	// @interface MPOFace : NSObject
	[BaseType (typeof (NSObject))]
	interface MPOFace
	{
		// @property NSString * faceId;
		[Export ("faceId")]
		string FaceId { get; set; }

		// @property MPOFaceRectangle * faceRectangle;
		[Export ("faceRectangle", ArgumentSemantic.Assign)]
		MPOFaceRectangle FaceRectangle { get; set; }

		// @property MPOFaceLandmarks * faceLandmarks;
		[Export ("faceLandmarks", ArgumentSemantic.Assign)]
		MPOFaceLandmarks FaceLandmarks { get; set; }

		// @property MPOFaceAttributes * attributes;
		[Export ("attributes", ArgumentSemantic.Assign)]
		MPOFaceAttributes Attributes { get; set; }

		// -(id)initWithDictionary:(NSDictionary *)dict;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary dict);
	}

	// @interface MPOFaceMetadata : NSObject
	[BaseType (typeof (NSObject))]
	interface MPOFaceMetadata
	{
		// @property NSString * persistedFaceId;
		[Export ("persistedFaceId")]
		string PersistedFaceId { get; set; }

		// @property NSString * userData;
		[Export ("userData"), NullAllowed]
		NSObject NSUserData { get; set; }

		// -(instancetype)initWithDictionary:(NSDictionary *)dict;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary dict);
	}

	// @interface MPOFaceList : NSObject
	[BaseType (typeof (NSObject))]
	interface MPOFaceList
	{
		// @property NSString * faceListId;
		[Export ("faceListId")]
		string FaceListId { get; set; }

		// @property NSString * name;
		[Export ("name")]
		string Name { get; set; }

		// @property NSString * userData;
		[Export ("userData"), NullAllowed]
		NSObject NSUserData { get; set; }

		// @property NSArray * persistedFaces;
		[Export ("persistedFaces", ArgumentSemantic.Assign)]
		//[Verify (StronglyTypedNSArray)]
		MPOFaceMetadata [] PersistedFaces { get; set; }

		// -(instancetype)initWithDictionary:(NSDictionary *)dict;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary dict);
	}

	// @interface MPOFaceListMetadata : NSObject
	[BaseType (typeof (NSObject))]
	interface MPOFaceListMetadata
	{
		// @property NSString * faceListId;
		[Export ("faceListId")]
		string FaceListId { get; set; }

		// @property NSString * name;
		[Export ("name")]
		string Name { get; set; }

		// @property NSString * userData;
		[Export ("userData"), NullAllowed]
		NSObject NSUserData { get; set; }

		// -(instancetype)initWithDictionary:(NSDictionary *)dict;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary dict);
	}

	// @interface MPOGroupResult : NSObject
	[BaseType (typeof (NSObject))]
	interface MPOGroupResult
	{
		// @property NSArray * groups;
		[Export ("groups", ArgumentSemantic.Assign)]
		//[Verify (StronglyTypedNSArray)]
		NSObject [] Groups { get; set; }

		// @property NSArray * messeyGroup;
		[Export ("messeyGroup", ArgumentSemantic.Assign)]
		//[Verify (StronglyTypedNSArray)]
		NSObject [] MesseyGroup { get; set; }

		// -(instancetype)initWithDictionary:(NSDictionary *)dict;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary dict);
	}

	// @interface MPOSimilarFace : NSObject
	[BaseType (typeof (NSObject))]
	interface MPOSimilarFace
	{
		// @property (retain, nonatomic) NSString * faceId;
		[Export ("faceId", ArgumentSemantic.Retain)]
		string FaceId { get; set; }

		// @property (retain, nonatomic) NSNumber * confidence;
		[Export ("confidence", ArgumentSemantic.Retain)]
		NSNumber Confidence { get; set; }
	}

	// @interface MPOIdentifyResult : NSObject
	[BaseType (typeof (NSObject))]
	interface MPOIdentifyResult
	{
		// @property NSString * faceId;
		[Export ("faceId")]
		string FaceId { get; set; }

		// @property NSArray * candidates;
		[Export ("candidates", ArgumentSemantic.Assign)]
		//[Verify (StronglyTypedNSArray)]
		MPOCandidate [] Candidates { get; set; }

		// -(instancetype)initWithDictionary:(NSDictionary *)dict;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary dict);
	}

	// @interface MPOVerifyResult : NSObject
	[BaseType (typeof (NSObject))]
	interface MPOVerifyResult
	{
		// @property BOOL isIdentical;
		[Export ("isIdentical")]
		bool IsIdentical { get; set; }

		// @property NSNumber * confidence;
		[Export ("confidence", ArgumentSemantic.Assign)]
		NSNumber Confidence { get; set; }

		// -(instancetype)initWithDictionary:(NSDictionary *)dict;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary dict);
	}

	// @interface MPOPersonGroup : NSObject
	[BaseType (typeof (NSObject))]
	interface MPOPersonGroup
	{
		// @property NSString * personGroupId;
		[Export ("personGroupId")]
		string PersonGroupId { get; set; }

		// @property NSString * name;
		[Export ("name")]
		string Name { get; set; }

		// @property NSString * userData;
		[Export ("userData"), NullAllowed]
		NSObject NSUserData { get; set; }

		// -(instancetype)initWithDictionary:(NSDictionary *)dict;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary dict);
	}

	// @interface MPOTrainingStatus : NSObject
	[BaseType (typeof (NSObject))]
	interface MPOTrainingStatus
	{
		// @property NSString * personGroupId;
		[Export ("personGroupId")]
		string PersonGroupId { get; set; }

		// @property NSString * status;
		[Export ("status")]
		string Status { get; set; }

		// @property NSString * startTime;
		[Export ("startTime")]
		string StartTime { get; set; }

		// @property NSString * endTime;
		[Export ("endTime")]
		string EndTime { get; set; }

		// -(instancetype)initWithDictionary:(NSDictionary *)dict;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary dict);
	}

	// @interface MPOPerson : NSObject
	[BaseType (typeof (NSObject))]
	interface MPOPerson
	{
		// @property NSString * personId;
		[Export ("personId")]
		string PersonId { get; set; }

		// @property NSArray * persistedFaceIds;
		[Export ("persistedFaceIds", ArgumentSemantic.Assign)]
		//[Verify (StronglyTypedNSArray)]
		string [] PersistedFaceIds { get; set; }

		// @property NSString * name;
		[Export ("name")]
		string Name { get; set; }

		// @property NSString * userData;
		[Export ("userData"), NullAllowed]
		NSObject NSUserData { get; set; }

		// -(instancetype)initWithDictionary:(NSDictionary *)dict;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary dict);
	}

	// @interface MPOPersonFace : NSObject
	[BaseType (typeof (NSObject))]
	interface MPOPersonFace
	{
		// @property NSString * persistedFaceId;
		[Export ("persistedFaceId")]
		string PersistedFaceId { get; set; }

		// @property NSString * userData;
		[Export ("userData"), NullAllowed]
		NSObject NSUserData { get; set; }

		// -(instancetype)initWithDictionary:(NSDictionary *)dict;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary dict);
	}

	// typedef void (^MPOCompletionBlock)(NSError *);
	delegate void MPOCompletionBlock (NSError error);

	//delegate void CompletionBlock (NSObject obj, NSError error);

	// typedef void (^MPOFaceArrayCompletionBlock)(NSArray<MPOFace *> *, NSError *);
	delegate void MPOFaceArrayCompletionBlock (MPOFace [] faces, NSError error);

	// typedef void (^MPOSimilarFaceArrayCompletionBlock)(NSArray<MPOSimilarFace *> *, NSError *);
	delegate void MPOSimilarFaceArrayCompletionBlock (MPOSimilarFace [] similarFaces, NSError error);

	// typedef void (^MPOIdentifyResultArrayCompletionBlock)(NSArray<MPOIdentifyResult *> *, NSError *);
	delegate void MPOIdentifyResultArrayCompletionBlock (MPOIdentifyResult [] identifyResults, NSError error);

	// typedef void (^MPOPersonGroupArrayCompletionBlock)(NSArray<MPOPersonGroup *> *, NSError *);
	delegate void MPOPersonGroupArrayCompletionBlock (MPOPersonGroup [] personGroup, NSError error);

	// typedef void (^MPOPersonArrayCompletionBlock)(NSArray<MPOPerson *> *, NSError *);
	delegate void MPOPersonArrayCompletionBlock (MPOPerson [] people, NSError error);

	// typedef void (^MPOFaceListMetadataArrayCompletionBlock)(NSArray<MPOFaceListMetadata *> *, NSError *);
	delegate void MPOFaceListMetadataArrayCompletionBlock (MPOFaceListMetadata [] metaData, NSError error);

	// typedef void(^PORequestCompletionBlock)(NSURLResponse *response, id responseObject, NSError *error);
	delegate void PORequestCompletionBlock (NSUrlResponse response, NSObject responseObject, NSError error);

	// @interface MPOFaceServiceClient : NSObject
	[BaseType (typeof (NSObject))]
	interface MPOFaceServiceClient
	{
		// -(id)initWithSubscriptionKey:(NSString *)key;
		[Export ("initWithSubscriptionKey:")]
		IntPtr Constructor (string key);

		// -(NSURLSessionDataTask *)detectWithUrl:(NSString *)url returnFaceId:(BOOL)returnFaceId returnFaceLandmarks:(BOOL)returnFaceLandmarks returnFaceAttributes:(NSArray *)returnFaceAttributes completionBlock:(MPOFaceArrayCompletionBlock)completion;
		[Export ("detectWithUrl:returnFaceId:returnFaceLandmarks:returnFaceAttributes:completionBlock:")]
		//[Verify (StronglyTypedNSArray)]
		NSUrlSessionDataTask DetectWithUrl (string url, bool returnFaceId, bool returnFaceLandmarks, NSObject [] returnFaceAttributes, MPOFaceArrayCompletionBlock completion);

		// -(NSURLSessionDataTask *)detectWithData:(NSData *)data returnFaceId:(BOOL)returnFaceId returnFaceLandmarks:(BOOL)returnFaceLandmarks returnFaceAttributes:(NSArray *)returnFaceAttributes completionBlock:(MPOFaceArrayCompletionBlock)completion;
		[Export ("detectWithData:returnFaceId:returnFaceLandmarks:returnFaceAttributes:completionBlock:")]
		//[Verify (StronglyTypedNSArray)]
		NSUrlSessionDataTask DetectWithData (NSData data, bool returnFaceId, bool returnFaceLandmarks, NSObject [] returnFaceAttributes, MPOFaceArrayCompletionBlock completion);

		// -(NSURLSessionDataTask *)verifyWithFirstFaceId:(NSString *)faceId1 faceId2:(NSString *)faceId2 completionBlock:(void (^)(MPOVerifyResult *, NSError *))completion;
		[Export ("verifyWithFirstFaceId:faceId2:completionBlock:")]
		NSUrlSessionDataTask VerifyWithFirstFaceId (string faceId1, string faceId2, Action<MPOVerifyResult, NSError> completion);

		// -(NSURLSessionDataTask *)verifyWithFaceId:(NSString *)faceId personId:(NSString *)personId personGroupId:(NSString *)personGroupId completionBlock:(void (^)(MPOVerifyResult *, NSError *))completion;
		[Export ("verifyWithFaceId:personId:personGroupId:completionBlock:")]
		NSUrlSessionDataTask VerifyWithFaceId (string faceId, string personId, string personGroupId, Action<MPOVerifyResult, NSError> completion);

		// -(NSURLSessionDataTask *)findSimilarWithFaceId:(NSString *)faceId faceIds:(NSArray *)faceIds completionBlock:(MPOSimilarFaceArrayCompletionBlock)completion;
		[Export ("findSimilarWithFaceId:faceIds:completionBlock:")]
		//[Verify (StronglyTypedNSArray)]
		NSUrlSessionDataTask FindSimilarWithFaceId (string faceId, NSString [] faceIds, MPOSimilarFaceArrayCompletionBlock completion);

		// -(NSURLSessionDataTask *)findSimilarWithFaceId:(NSString *)faceId faceListId:(NSString *)faceListId completionBlock:(MPOSimilarFaceArrayCompletionBlock)completion;
		[Export ("findSimilarWithFaceId:faceListId:completionBlock:")]
		NSUrlSessionDataTask FindSimilarWithFaceId (string faceId, string faceListId, MPOSimilarFaceArrayCompletionBlock completion);

		// -(NSURLSessionDataTask *)findSimilarWithFaceId:(NSString *)faceId faceIds:(NSArray *)faceIds maxNumOfCandidatesReturned:(NSInteger)maxNumOfCandidatesReturned mode:(MPOSimilarFaceSearchingMode)mode completionBlock:(MPOSimilarFaceArrayCompletionBlock)completion;
		[Export ("findSimilarWithFaceId:faceIds:maxNumOfCandidatesReturned:mode:completionBlock:")]
		//[Verify (StronglyTypedNSArray)]
		NSUrlSessionDataTask FindSimilarWithFaceId (string faceId, NSString [] faceIds, nint maxNumOfCandidatesReturned, MPOSimilarFaceSearchingMode mode, MPOSimilarFaceArrayCompletionBlock completion);

		// -(NSURLSessionDataTask *)findSimilarWithFaceId:(NSString *)faceId faceListId:(NSString *)faceListId maxNumOfCandidatesReturned:(NSInteger)maxNumOfCandidatesReturned mode:(MPOSimilarFaceSearchingMode)mode completionBlock:(MPOSimilarFaceArrayCompletionBlock)completion;
		[Export ("findSimilarWithFaceId:faceListId:maxNumOfCandidatesReturned:mode:completionBlock:")]
		NSUrlSessionDataTask FindSimilarWithFaceId (string faceId, string faceListId, nint maxNumOfCandidatesReturned, MPOSimilarFaceSearchingMode mode, MPOSimilarFaceArrayCompletionBlock completion);

		// -(NSURLSessionDataTask *)groupWithFaceIds:(NSArray *)faceIds completionBlock:(void (^)(MPOGroupResult *, NSError *))completion;
		[Export ("groupWithFaceIds:completionBlock:")]
		//[Verify (StronglyTypedNSArray)]
		NSUrlSessionDataTask GroupWithFaceIds (NSString [] faceIds, Action<MPOGroupResult, NSError> completion);

		// -(NSURLSessionDataTask *)identifyWithPersonGroupId:(NSString *)personGroupId faceIds:(NSArray *)faceIds maxNumberOfCandidates:(NSInteger)maxNumberOfCandidates completionBlock:(MPOIdentifyResultArrayCompletionBlock)completion;
		[Export ("identifyWithPersonGroupId:faceIds:maxNumberOfCandidates:completionBlock:")]
		//[Verify (StronglyTypedNSArray)]
		NSUrlSessionDataTask IdentifyWithPersonGroupId (string personGroupId, NSString [] faceIds, nint maxNumberOfCandidates, MPOIdentifyResultArrayCompletionBlock completion);

		// -(NSURLSessionDataTask *)identifyWithPersonGroupId:(NSString *)personGroupId faceIds:(NSArray *)faceIds maxNumberOfCandidates:(NSInteger)maxNumberOfCandidates confidenceThreshold:(CGFloat)confidenceThreshold completionBlock:(MPOIdentifyResultArrayCompletionBlock)completion;
		[Export ("identifyWithPersonGroupId:faceIds:maxNumberOfCandidates:confidenceThreshold:completionBlock:")]
		//[Verify (StronglyTypedNSArray)]
		NSUrlSessionDataTask IdentifyWithPersonGroupId (string personGroupId, NSString [] faceIds, nint maxNumberOfCandidates, nfloat confidenceThreshold, MPOIdentifyResultArrayCompletionBlock completion);

		// -(NSURLSessionDataTask *)createPersonGroupWithId:(NSString *)personGroupId name:(NSString *)name userData:(NSString *)userData completionBlock:(MPOCompletionBlock)completion;
		[Export ("createPersonGroupWithId:name:userData:completionBlock:")]
		NSUrlSessionDataTask CreatePersonGroupWithId (string personGroupId, string name, [NullAllowed] string userData, MPOCompletionBlock completion);

		// -(NSURLSessionDataTask *)getPersonGroupWithPersonGroupId:(NSString *)personGroupId completionBlock:(void (^)(MPOPersonGroup *, NSError *))completion;
		[Export ("getPersonGroupWithPersonGroupId:completionBlock:")]
		NSUrlSessionDataTask GetPersonGroupWithPersonGroupId (string personGroupId, Action<MPOPersonGroup, NSError> completion);

		// -(NSURLSessionDataTask *)updatePersonGroupWithPersonGroupId:(NSString *)personGroupId name:(NSString *)name userData:(NSString *)userData completionBlock:(MPOCompletionBlock)completion;
		[Export ("updatePersonGroupWithPersonGroupId:name:userData:completionBlock:")]
		NSUrlSessionDataTask UpdatePersonGroupWithPersonGroupId (string personGroupId, string name, [NullAllowed] string userData, MPOCompletionBlock completion);

		// -(NSURLSessionDataTask *)deletePersonGroupWithPersonGroupId:(NSString *)personGroupId completionBlock:(MPOCompletionBlock)completion;
		[Export ("deletePersonGroupWithPersonGroupId:completionBlock:")]
		NSUrlSessionDataTask DeletePersonGroupWithPersonGroupId (string personGroupId, MPOCompletionBlock completion);

		// -(NSURLSessionDataTask *)getPersonGroupsWithCompletion:(MPOPersonGroupArrayCompletionBlock)completion __attribute__((availability(ios, introduced=7.0, deprecated=7.0)));
		[Introduced (PlatformName.iOS, 7, 0)]
		[Deprecated (PlatformName.iOS, 7, 0)]
		[Export ("getPersonGroupsWithCompletion:")]
		NSUrlSessionDataTask GetPersonGroupsWithCompletion (MPOPersonGroupArrayCompletionBlock completion);

		// -(NSURLSessionDataTask *)listPersonGroupsWithCompletion:(MPOPersonGroupArrayCompletionBlock)completion;
		[Export ("listPersonGroupsWithCompletion:")]
		NSUrlSessionDataTask ListPersonGroupsWithCompletion (MPOPersonGroupArrayCompletionBlock completion);

		// -(NSURLSessionDataTask *)listPersonGroupsWithStart:(NSString *)start top:(NSInteger)top completionBlock:(MPOPersonGroupArrayCompletionBlock)completion;
		[Export ("listPersonGroupsWithStart:top:completionBlock:")]
		NSUrlSessionDataTask ListPersonGroupsWithStart (string start, nint top, MPOPersonGroupArrayCompletionBlock completion);

		// -(NSURLSessionDataTask *)trainPersonGroupWithPersonGroupId:(NSString *)personGroupId completionBlock:(MPOCompletionBlock)completion;
		[Export ("trainPersonGroupWithPersonGroupId:completionBlock:")]
		NSUrlSessionDataTask TrainPersonGroupWithPersonGroupId (string personGroupId, MPOCompletionBlock completion);

		// -(NSURLSessionDataTask *)getPersonGroupTrainingStatusWithPersonGroupId:(NSString *)personGroupId completionBlock:(void (^)(MPOTrainingStatus *, NSError *))completion;
		[Export ("getPersonGroupTrainingStatusWithPersonGroupId:completionBlock:")]
		NSUrlSessionDataTask GetPersonGroupTrainingStatusWithPersonGroupId (string personGroupId, Action<MPOTrainingStatus, NSError> completion);

		// -(NSURLSessionDataTask *)createPersonWithPersonGroupId:(NSString *)personGroupId name:(NSString *)name userData:(NSString *)userData completionBlock:(void (^)(MPOCreatePersonResult *, NSError *))completion;
		[Export ("createPersonWithPersonGroupId:name:userData:completionBlock:")]
		NSUrlSessionDataTask CreatePersonWithPersonGroupId (string personGroupId, string name, [NullAllowed] string userData, Action<MPOCreatePersonResult, NSError> completion);

		// -(NSURLSessionDataTask *)getPersonWithPersonGroupId:(NSString *)personGroupId personId:(NSString *)personId completionBlock:(void (^)(MPOPerson *, NSError *))completion;
		[Export ("getPersonWithPersonGroupId:personId:completionBlock:")]
		NSUrlSessionDataTask GetPersonWithPersonGroupId (string personGroupId, string personId, Action<MPOPerson, NSError> completion);

		// -(NSURLSessionDataTask *)updatePersonWithPersonGroupId:(NSString *)personGroupId personId:(NSString *)personId name:(NSString *)name userData:(NSString *)userData completionBlock:(MPOCompletionBlock)completion;
		[Export ("updatePersonWithPersonGroupId:personId:name:userData:completionBlock:")]
		NSUrlSessionDataTask UpdatePersonWithPersonGroupId (string personGroupId, string personId, string name, [NullAllowed] string userData, MPOCompletionBlock completion);

		// -(NSURLSessionDataTask *)deletePersonWithPersonGroupId:(NSString *)personGroupId personId:(NSString *)personId completionBlock:(MPOCompletionBlock)completion;
		[Export ("deletePersonWithPersonGroupId:personId:completionBlock:")]
		NSUrlSessionDataTask DeletePersonWithPersonGroupId (string personGroupId, string personId, MPOCompletionBlock completion);

		// -(NSURLSessionDataTask *)getPersonsWithPersonGroupId:(NSString *)personGroupId completionBlock:(MPOPersonArrayCompletionBlock)completion __attribute__((availability(ios, introduced=7.0, deprecated=7.0)));
		[Introduced (PlatformName.iOS, 7, 0)]
		[Deprecated (PlatformName.iOS, 7, 0)]
		[Export ("getPersonsWithPersonGroupId:completionBlock:")]
		NSUrlSessionDataTask GetPersonsWithPersonGroupId (string personGroupId, MPOPersonArrayCompletionBlock completion);

		// -(NSURLSessionDataTask *)listPersonsWithPersonGroupId:(NSString *)personGroupId completionBlock:(MPOPersonArrayCompletionBlock)completion;
		[Export ("listPersonsWithPersonGroupId:completionBlock:")]
		NSUrlSessionDataTask ListPersonsWithPersonGroupId (string personGroupId, MPOPersonArrayCompletionBlock completion);

		// -(NSURLSessionDataTask *)getPersonFaceWithPersonGroupId:(NSString *)personGroupId personId:(NSString *)personId persistedFaceId:(NSString *)persistedFaceId completionBlock:(void (^)(MPOPersonFace *, NSError *))completion;
		[Export ("getPersonFaceWithPersonGroupId:personId:persistedFaceId:completionBlock:")]
		NSUrlSessionDataTask GetPersonFaceWithPersonGroupId (string personGroupId, string personId, string persistedFaceId, Action<MPOPersonFace, NSError> completion);

		// -(NSURLSessionDataTask *)updatePersonFaceWithPersonGroupId:(NSString *)personGroupId personId:(NSString *)personId persistedFaceId:(NSString *)persistedFaceId userData:(NSString *)userData completionBlock:(MPOCompletionBlock)completion;
		[Export ("updatePersonFaceWithPersonGroupId:personId:persistedFaceId:userData:completionBlock:")]
		NSUrlSessionDataTask UpdatePersonFaceWithPersonGroupId (string personGroupId, string personId, string persistedFaceId, [NullAllowed] string userData, MPOCompletionBlock completion);

		// -(NSURLSessionDataTask *)deletePersonFaceWithPersonGroupId:(NSString *)personGroupId personId:(NSString *)personId persistedFaceId:(NSString *)persistedFaceId completionBlock:(MPOCompletionBlock)completion;
		[Export ("deletePersonFaceWithPersonGroupId:personId:persistedFaceId:completionBlock:")]
		NSUrlSessionDataTask DeletePersonFaceWithPersonGroupId (string personGroupId, string personId, string persistedFaceId, MPOCompletionBlock completion);

		// -(NSURLSessionDataTask *)addPersonFaceWithPersonGroupId:(NSString *)personGroupId personId:(NSString *)personId url:(NSString *)url userData:(NSString *)userData faceRectangle:(MPOFaceRectangle *)faceRectangle completionBlock:(void (^)(MPOAddPersistedFaceResult *, NSError *))completion;
		[Export ("addPersonFaceWithPersonGroupId:personId:url:userData:faceRectangle:completionBlock:")]
		NSUrlSessionDataTask AddPersonFaceWithPersonGroupId (string personGroupId, string personId, string url, [NullAllowed] string userData, MPOFaceRectangle faceRectangle, Action<MPOAddPersistedFaceResult, NSError> completion);

		// -(NSURLSessionDataTask *)addPersonFaceWithPersonGroupId:(NSString *)personGroupId personId:(NSString *)personId data:(NSData *)data userData:(NSString *)userData faceRectangle:(MPOFaceRectangle *)faceRectangle completionBlock:(void (^)(MPOAddPersistedFaceResult *, NSError *))completion;
		[Export ("addPersonFaceWithPersonGroupId:personId:data:userData:faceRectangle:completionBlock:")]
		NSUrlSessionDataTask AddPersonFaceWithPersonGroupId (string personGroupId, string personId, NSData data, [NullAllowed] string userData, MPOFaceRectangle faceRectangle, Action<MPOAddPersistedFaceResult, NSError> completion);

		// -(NSURLSessionDataTask *)createFaceListWithFaceListId:(NSString *)faceListId name:(NSString *)name userData:(NSString *)userData completionBlock:(MPOCompletionBlock)completion;
		[Export ("createFaceListWithFaceListId:name:userData:completionBlock:")]
		NSUrlSessionDataTask CreateFaceListWithFaceListId (string faceListId, string name, [NullAllowed] string userData, MPOCompletionBlock completion);

		// -(NSURLSessionDataTask *)getFaceListWithFaceListId:(NSString *)faceListId completionBlock:(void (^)(MPOFaceList *, NSError *))completion;
		[Export ("getFaceListWithFaceListId:completionBlock:")]
		NSUrlSessionDataTask GetFaceListWithFaceListId (string faceListId, Action<MPOFaceList, NSError> completion);

		// -(NSURLSessionDataTask *)listFaceListsWithCompletion:(MPOFaceListMetadataArrayCompletionBlock)completion;
		[Export ("listFaceListsWithCompletion:")]
		NSUrlSessionDataTask ListFaceListsWithCompletion (MPOFaceListMetadataArrayCompletionBlock completion);

		// -(NSURLSessionDataTask *)updateFaceListWithFaceListId:(NSString *)faceListId name:(NSString *)name userData:(NSString *)userData completionBlock:(MPOCompletionBlock)completion;
		[Export ("updateFaceListWithFaceListId:name:userData:completionBlock:")]
		NSUrlSessionDataTask UpdateFaceListWithFaceListId (string faceListId, string name, [NullAllowed] string userData, MPOCompletionBlock completion);

		// -(NSURLSessionDataTask *)deleteFaceListWithFaceListId:(NSString *)faceListId name:(NSString *)name userData:(NSString *)userData completionBlock:(MPOCompletionBlock)completion;
		[Export ("deleteFaceListWithFaceListId:name:userData:completionBlock:")]
		NSUrlSessionDataTask DeleteFaceListWithFaceListId (string faceListId, string name, [NullAllowed] string userData, MPOCompletionBlock completion);

		// -(NSURLSessionDataTask *)deleteFacesFromFaceListWithFaceListId:(NSString *)faceListId name:(NSString *)name persistedFaceId:(NSString *)persistedFaceId completionBlock:(MPOCompletionBlock)completion;
		[Export ("deleteFacesFromFaceListWithFaceListId:name:persistedFaceId:completionBlock:")]
		NSUrlSessionDataTask DeleteFacesFromFaceListWithFaceListId (string faceListId, string name, string persistedFaceId, MPOCompletionBlock completion);

		// -(NSURLSessionDataTask *)addFacesToFaceListWithFaceListId:(NSString *)faceListId url:(NSString *)url userData:(NSString *)userData faceRectangle:(MPOFaceRectangle *)faceRectangle completionBlock:(void (^)(MPOAddPersistedFaceResult *, NSError *))completion;
		[Export ("addFacesToFaceListWithFaceListId:url:userData:faceRectangle:completionBlock:")]
		NSUrlSessionDataTask AddFacesToFaceListWithFaceListId (string faceListId, string url, [NullAllowed] string userData, MPOFaceRectangle faceRectangle, Action<MPOAddPersistedFaceResult, NSError> completion);

		// -(NSURLSessionDataTask *)addFacesToFaceListWithFaceListId:(NSString *)faceListId data:(NSData *)data userData:(NSString *)userData faceRectangle:(MPOFaceRectangle *)faceRectangle completionBlock:(void (^)(MPOAddPersistedFaceResult *, NSError *))completion;
		[Export ("addFacesToFaceListWithFaceListId:data:userData:faceRectangle:completionBlock:")]
		NSUrlSessionDataTask AddFacesToFaceListWithFaceListId (string faceListId, NSData data, [NullAllowed] string userData, MPOFaceRectangle faceRectangle, Action<MPOAddPersistedFaceResult, NSError> completion);

		// -(NSURLSessionDataTask *)startTaskWithHttpMethod:(NSString *)httpMethod path:(NSString *)path parameters:(NSDictionary *)params urlParams:(NSDictionary *)urlParams bodyData:(NSData *)bodyData completion:(PORequestCompletionBlock)completion;
		//[Export ("startTaskWithHttpMethod:path:parameters:urlParams:bodyData:completion:")]
		//NSUrlSessionDataTask StartTaskWithHttpMethod (string httpMethod, string path, [NullAllowed] NSDictionary parameters, [NullAllowed] NSDictionary urlParams, [NullAllowed] NSData bodyData, PORequestCompletionBlock completion);

		// - (void)runCompletionOnMainQueueWithBlock:(void (^) (id obj, NSError *error))completionBlock object:(id )object error:(NSError *)error 
		//[Export ("runCompletionOnMainQueueWithBlock:object:error:")]
		//void RunCompletionOnMainQueueWithBlock (MPOPersonArrayCompletionBlock completionBlock, [NullAllowed] NSObject obj, [NullAllowed] NSError error);
	}


	[Static]
	//[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double ProjectOxfordFaceVersionNumber;
		[Field ("ProjectOxfordFaceVersionNumber", "__Internal")]
		double ProjectOxfordFaceVersionNumber { get; }

		// extern const unsigned char [] ProjectOxfordFaceVersionString;
		[Field ("ProjectOxfordFaceVersionString", "__Internal")]
		NSString ProjectOxfordFaceVersionString { get; }
	}
}
