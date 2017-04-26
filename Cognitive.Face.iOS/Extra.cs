using Foundation;

namespace Xamarin.Cognitive.Face.iOS
{
    public partial class MPOPerson : NSObject
    {
		//workaround for https://github.com/Microsoft/Cognitive-Face-iOS/issues/21
		[Export("initWithDictionary:")]
		//IntPtr Constructor (NSDictionary dict);
		public MPOPerson(NSDictionary dict)
		{
			//var person = new MPOPerson();

			this.PersonId = dict[@"personId"].ToString();
			this.Name = dict[@"name"].ToString();
			this.UserData = dict[@"userData"]?.ToString();

			if (dict[@"persistedFaceIds"] is NSArray)
			{
				this.FaceIds = NSArray.StringArrayFromHandle(dict[@"persistedFaceIds"].Handle);
			}
		}
	}
}