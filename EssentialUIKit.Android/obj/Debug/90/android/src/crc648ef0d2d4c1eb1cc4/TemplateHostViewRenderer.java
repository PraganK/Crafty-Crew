package crc648ef0d2d4c1eb1cc4;


public class TemplateHostViewRenderer
	extends crc643f46942d9dd1fff9.ViewRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("EssentialUIKit.Droid.Renderers.TemplateHostViewRenderer, EssentialUIKit.Android", TemplateHostViewRenderer.class, __md_methods);
	}


	public TemplateHostViewRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == TemplateHostViewRenderer.class)
			mono.android.TypeManager.Activate ("EssentialUIKit.Droid.Renderers.TemplateHostViewRenderer, EssentialUIKit.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public TemplateHostViewRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == TemplateHostViewRenderer.class)
			mono.android.TypeManager.Activate ("EssentialUIKit.Droid.Renderers.TemplateHostViewRenderer, EssentialUIKit.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public TemplateHostViewRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == TemplateHostViewRenderer.class)
			mono.android.TypeManager.Activate ("EssentialUIKit.Droid.Renderers.TemplateHostViewRenderer, EssentialUIKit.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}

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
