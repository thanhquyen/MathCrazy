using UnityEngine;
using System.Collections;

public class MNP {
	
	public static void ShowPreloader(string title, string message) {

		#if UNITY_ANDROID
		MNAndroidNative.ShowPreloader(title, message);
		#endif

		#if UNITY_IPHONE 
		MNIOSNative.ShowPreloader();
		#endif

		#if UNITY_WP8 || UNITY_METRO
		WP8PopUps.PopUp.ShowPreLoader(100);
		#endif


	}
	
	public static void HidePreloader() {

		#if UNITY_ANDROID
		MNAndroidNative.HidePreloader();
		#endif


		#if UNITY_IPHONE 
		MNIOSNative.HidePreloader();
		#endif


		#if UNITY_WP8 || UNITY_METRO
		WP8PopUps.PopUp.HidePreLoader();
		#endif
	}
}

