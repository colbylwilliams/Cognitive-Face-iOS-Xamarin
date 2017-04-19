using System;

namespace Xamarin.Cognitive.Face.iOS
{
	public enum MPOFaceAttributeType : uint
	{
		Age = 1,
		Gender,
		FacialHair,
		Smile,
		HeadPose
	}

	public enum MPOSimilarFaceSearchingMode : uint
	{
		Face = 1,
		Person
	}
}
