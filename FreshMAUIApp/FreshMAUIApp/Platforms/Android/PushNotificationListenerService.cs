using System;
using System.Diagnostics.CodeAnalysis;
using Android.App;
using Firebase.Messaging;


[assembly: UsesPermission("com.google.android.c2dm.permission.RECEIVE")]
namespace FreshMAUIApp.Platforms.Android
{
    [ExcludeFromCodeCoverage]
    [Service(Exported = false)]
    [IntentFilter(new[] { "com.google.firebase.MESSAGING_EVENT" }, Categories = new[] { "com.medtronic.mycarelinkheart.debug" })]
    public class PushNotificationListenerService : FirebaseMessagingService
    {
		public PushNotificationListenerService()
		{
		}
	}
}

