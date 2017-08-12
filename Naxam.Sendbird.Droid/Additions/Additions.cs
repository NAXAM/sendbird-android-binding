using System;
using System.Linq;
using Android.Runtime;

namespace Com.Sendbird.Android.Shadow.Okio
{
    partial class Options
    {
        public override Java.Lang.Object Get(int index)
        {
            return GetString(index);
        }
    }

    partial class ByteString
    {
        public int CompareTo(Java.Lang.Object obj)
        {
            return CompareTo((ByteString)obj);
        }
    }
}

namespace Com.Sendbird.Android.Shadow.Com.Google.Gson.Internal.Bind
{
    partial class DateTypeAdapter
    {
        public override void Write(global::Com.Sendbird.Android.Shadow.Com.Google.Gson.Stream.JsonWriter @out, Java.Lang.Object value)
        {
            WriteDate(@out, (Java.Util.Date)value);
        }

        public override Java.Lang.Object Read(global::Com.Sendbird.Android.Shadow.Com.Google.Gson.Stream.JsonReader @in)
        {
            return ReadDate(@in);
        }
    }

    partial class SqlDateTypeAdapter
    {

        public override void Write(global::Com.Sendbird.Android.Shadow.Com.Google.Gson.Stream.JsonWriter @out, Java.Lang.Object value)
        {
            WriteDate(@out, (Java.Sql.Date)value);
        }

        public override Java.Lang.Object Read(global::Com.Sendbird.Android.Shadow.Com.Google.Gson.Stream.JsonReader @in)
        {
            return ReadDate(@in);
        }
    }

    partial class TimeTypeAdapter
    {

        public override void Write(global::Com.Sendbird.Android.Shadow.Com.Google.Gson.Stream.JsonWriter @out, Java.Lang.Object value)
        {
            WriteTime(@out, (Java.Sql.Time)value);
        }

        public override Java.Lang.Object Read(global::Com.Sendbird.Android.Shadow.Com.Google.Gson.Stream.JsonReader @in)
        {
            return ReadTime(@in);
        }
    }
}

namespace Com.Sendbird.Android.Shadow.Com.Google.Gson.Internal
{
    partial class LinkedTreeMap
    {
		static IntPtr id_entrySet;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.sendbird.android.shadow.com.google.gson.internal']/class[@name='LinkedTreeMap']/method[@name='entrySet' and count(parameter)=0]"
		[Register("entrySet", "()Ljava/util/Set;", "")]
		public override unsafe global::System.Collections.ICollection EntrySet()
		{
			if (id_entrySet == IntPtr.Zero)
				id_entrySet = JNIEnv.GetMethodID(class_ref, "entrySet", "()Ljava/util/Set;");
			try
			{
				var result = global::Android.Runtime.JavaSet<global::Java.Util.IMapEntry>.FromJniHandle(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_entrySet), JniHandleOwnership.TransferLocalRef)
                                            .ToList();

                var non = new System.Collections.ArrayList(result.Count);

                for (int i = 0; i < result.Count; i++)
                {
                    non.Add(result[i]);
                }

                return non;
            }
			finally
			{
			}
		}
    }
    partial class LinkedHashTreeMap
    {
		static IntPtr id_entrySet;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.sendbird.android.shadow.com.google.gson.internal']/class[@name='LinkedHashTreeMap']/method[@name='entrySet' and count(parameter)=0]"
		[Register("entrySet", "()Ljava/util/Set;", "")]
		public override unsafe global::System.Collections.ICollection EntrySet()
		{
			if (id_entrySet == IntPtr.Zero)
				id_entrySet = JNIEnv.GetMethodID(class_ref, "entrySet", "()Ljava/util/Set;");
			try
			{
				var result = global::Android.Runtime.JavaSet<global::Java.Util.IMapEntry>.FromJniHandle(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_entrySet), JniHandleOwnership.TransferLocalRef)
                                            .ToList();

				var non = new System.Collections.ArrayList(result.Count);

				for (int i = 0; i < result.Count; i++)
				{
					non.Add(result[i]);
				}

				return non;
			}
			finally
			{
			}
		}
    }
}