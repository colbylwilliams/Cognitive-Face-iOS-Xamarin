using System;

namespace Xamarin.Cognitive.Face.iOS
{
	public enum MPOFaceAttributeType : uint
	{
		Age = 1,
		Gender,
		Smile,
		Glasses,
		FacialHair,
		HeadPose,
		Emotion,
		Hair,
		Makeup,
		Occlusion,
		Accessories,
		Blur,
		Exposure,
		Noise
	}


	public enum MPOSimilarFaceSearchingMode : uint
	{
		Face = 1,
		Person
	}
}