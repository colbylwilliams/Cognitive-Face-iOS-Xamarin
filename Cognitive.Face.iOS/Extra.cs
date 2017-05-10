using Foundation;
using System;

namespace Xamarin.Cognitive.Face.iOS
{
	#region Wrapper properties to get around annoying NSNull issue

	public partial class MPOPersonGroup : NSObject
	{
		public string UserData {
			get {
				if (NSNull.Null.Equals(NSUserData))
				{
					return null;
				}

				return NSUserData.ToString();
			}
			set {
				NSUserData = new NSString(value);
			}
		}
	}


	public partial class MPOPerson : NSObject
	{
		public string UserData {
			get {
				if (NSNull.Null.Equals(NSUserData))
				{
					return null;
				}

				return NSUserData.ToString();
			}
			set {
				NSUserData = new NSString(value);
			}
		}
	}


	public partial class MPOPersonFace : NSObject
	{
		public string UserData {
			get {
				if (NSNull.Null.Equals(NSUserData))
				{
					return null;
				}

				return NSUserData.ToString();
			}
			set {
				NSUserData = new NSString(value);
			}
		}
	}


	public partial class MPOFaceMetadata : NSObject
	{
		public string UserData {
			get {
				if (NSNull.Null.Equals(NSUserData))
				{
					return null;
				}

				return NSUserData.ToString();
			}
			set {
				NSUserData = new NSString(value);
			}
		}
	}


	public partial class MPOFaceList : NSObject
	{
		public string UserData {
			get {
				if (NSNull.Null.Equals(NSUserData))
				{
					return null;
				}

				return NSUserData.ToString();
			}
			set {
				NSUserData = new NSString(value);
			}
		}
	}


	public partial class MPOFaceListMetadata : NSObject
	{
		public string UserData {
			get {
				if (NSNull.Null.Equals(NSUserData))
				{
					return null;
				}

				return NSUserData.ToString();
			}
			set {
				NSUserData = new NSString(value);
			}
		}
	}


	#endregion

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

	//public partial class MPOFaceServiceClient : NSObject
	//{
	//	const string NULL = "<null>";

	//	public NSUrlSessionDataTask ListPersonsForGroup (string personGroupId, MPOPersonArrayCompletionBlock completion)
	//	{
	//		return StartTaskWithHttpMethod ("GET", $"persongroups/{personGroupId}/persons", null, null, null, (response, responseObject, error) =>
	//		{
	//			var array = new NSMutableArray ();

	//			if (error == null)
	//			{
	//				var dictionaries = NSArray.FromArray<NSDictionary> ((NSArray)responseObject);

	//				foreach (var dict in dictionaries)
	//				{
	//					var mpoPerson = new MPOPerson ();
	//					mpoPerson.PersonId = dict [@"personId"].ToString ();
	//					mpoPerson.Name = dict [@"name"].ToString ();

	//					var userData = dict [@"userData"] as NSString;
	//					var userDataString = userData?.ToString ();

	//					if (userDataString != NULL)
	//					{
	//						mpoPerson.UserData = userDataString;
	//					}

	//					if (dict [@"persistedFaceIds"] is NSArray)
	//					{
	//						mpoPerson.FaceIds = NSArray.StringArrayFromHandle (dict [@"persistedFaceIds"].Handle);
	//					}

	//					array.Add (mpoPerson);
	//				}
	//			}

	//			RunCompletionOnMainQueueWithBlock (completion, array, error);
	//		});
	//	}
	//}
}