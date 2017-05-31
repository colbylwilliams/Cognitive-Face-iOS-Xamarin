using Foundation;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Xamarin.Cognitive.Face.iOS
{
	#region Wrapper properties to get around annoying NSNull issue


	public partial class MPOPersonGroup : NSObject
	{
		public string UserData
		{
			get
			{
				if (NSNull.Null.Equals (NSUserData))
				{
					return null;
				}

				return NSUserData.ToString ();
			}
			set
			{
				NSUserData = new NSString (value);
			}
		}
	}


	public partial class MPOPerson : NSObject
	{
		public string UserData
		{
			get
			{
				if (NSNull.Null.Equals (NSUserData))
				{
					return null;
				}

				return NSUserData.ToString ();
			}
			set
			{
				NSUserData = new NSString (value);
			}
		}
	}


	public partial class MPOPersonFace : NSObject
	{
		public string UserData
		{
			get
			{
				if (NSNull.Null.Equals (NSUserData))
				{
					return null;
				}

				return NSUserData.ToString ();
			}
			set
			{
				NSUserData = new NSString (value);
			}
		}
	}


	public partial class MPOFaceMetadata : NSObject
	{
		public string UserData
		{
			get
			{
				if (NSNull.Null.Equals (NSUserData))
				{
					return null;
				}

				return NSUserData.ToString ();
			}
			set
			{
				NSUserData = new NSString (value);
			}
		}
	}


	public partial class MPOFaceList : NSObject
	{
		public string UserData
		{
			get
			{
				if (NSNull.Null.Equals (NSUserData))
				{
					return null;
				}

				return NSUserData.ToString ();
			}
			set
			{
				NSUserData = new NSString (value);
			}
		}
	}


	public partial class MPOFaceListMetadata : NSObject
	{
		public string UserData
		{
			get
			{
				if (NSNull.Null.Equals (NSUserData))
				{
					return null;
				}

				return NSUserData.ToString ();
			}
			set
			{
				NSUserData = new NSString (value);
			}
		}
	}


	public partial class MPOTrainingStatus : NSObject
	{
		public string Message
		{
			get
			{
				if (NSNull.Null.Equals (NSMessage))
				{
					return null;
				}

				return NSMessage.ToString ();
			}
			set
			{
				NSMessage = new NSString (value);
			}
		}
	}


	#endregion


	public partial class MPOGroupResult
	{
		public List<string []> Groups
		{
			get
			{
				return new List<string []> (NSGroups.Select (g => NSArray.StringArrayFromHandle (g.Handle)));
			}
		}
	}


	public partial class MPOFaceServiceClient : NSObject
	{
		public NSUrlSessionDataTask DetectWithUrl (string url, bool returnFaceId, bool returnFaceLandmarks, MPOFaceAttributeType [] returnFaceAttributes, MPOFaceArrayCompletionBlock completion)
		{
			var attrs = returnFaceAttributes.Select (a => Foundation.NSNumber.FromInt32 ((int) a)).ToArray ();

			return DetectWithUrl (url, returnFaceId, returnFaceLandmarks, attrs, completion);
		}


		public NSUrlSessionDataTask DetectWithData (NSData data, bool returnFaceId, bool returnFaceLandmarks, MPOFaceAttributeType [] returnFaceAttributes, MPOFaceArrayCompletionBlock completion)
		{
			var attrs = returnFaceAttributes.Select (a => Foundation.NSNumber.FromInt32 ((int) a)).ToArray ();

			return DetectWithData (data, returnFaceId, returnFaceLandmarks, attrs, completion);
		}
	}


	//public partial class MPOPerson : NSObject
	//{
	//workaround for https://github.com/Microsoft/Cognitive-Face-iOS/issues/21
	//[Export("initWithDictionary:")]
	////IntPtr Constructor (NSDictionary dict);
	//public MPOPerson(NSDictionary dict) : base(NSObjectFlag.Empty)
	//{
	//	this.FaceIds = new string [] { "test1" };

	//	this.PersonId = dict[@"personId"].ToString();
	//	this.Name = dict[@"name"].ToString();
	//	this.UserData = dict[@"userData"]?.ToString();

	//	Console.WriteLine ("dict[@\"persistedFaceIds\"] is: {0}", dict [@"persistedFaceIds"]);

	//	if (dict[@"persistedFaceIds"] is NSArray)
	//	{
	//		Console.WriteLine ("Valid NSArray, not trying to turn into string[]");

	//		this.FaceIds = NSArray.StringArrayFromHandle(dict[@"persistedFaceIds"].Handle);
	//	}

	//	this.FaceIds = new string [] { "test2" };
	//}


	//}
}