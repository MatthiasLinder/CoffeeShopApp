package md51dc7567a6dade523f4190a82baeb756f;


public class Products_List_Activity
	extends android.app.ListActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("CoffeeShopApp.Products_List_Activity, CoffeeShopApp", Products_List_Activity.class, __md_methods);
	}


	public Products_List_Activity ()
	{
		super ();
		if (getClass () == Products_List_Activity.class)
			mono.android.TypeManager.Activate ("CoffeeShopApp.Products_List_Activity, CoffeeShopApp", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
