using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace WebMvcSample.Current.Core
{
    public static class Utils
    {
        #region get type
        public static string GetString(Hashtable dATA, string name)
        {
            if (string.IsNullOrEmpty(name)) return "";
            if (dATA[name] == null) return "";
            if (dATA[name] is string[]) return (dATA[name] as string[])[0];
            if (dATA[name] is string) return dATA[name] as string;
            return "";
        }
        public static string[] GetStrings(Hashtable dATA, string name)
        {
            if (string.IsNullOrEmpty(name)) return new string[]{ };
            if (dATA[name] == null) return new string[] { };
            if (dATA[name] is string[]) return (dATA[name] as string[]);
            return new string[] { };
        }

        public static Byte GetByte(Hashtable dATA, string name)
        {
            if (string.IsNullOrEmpty(name)) return 0;
            if (dATA[name] == null) return 0;
            if (dATA[name] is Byte[]) return (dATA[name] as Byte[])[0];
            if (dATA[name] is Byte) return Convert.ToByte(dATA[name]);
            return 0;
        }
        public static Byte[] GetBytes(Hashtable dATA, string name)
        {
            if (string.IsNullOrEmpty(name)) return new Byte[] { };
            if (dATA[name] == null) return new Byte[] { };
            if (dATA[name] is Byte[]) return (dATA[name] as Byte[]);
            return new Byte[] { };
        }

        public static int GetInt(Hashtable dATA, string name)
        {
            if (string.IsNullOrEmpty(name)) return 0;
            if (dATA[name] == null) return 0;
            if (dATA[name] is int[] || dATA[name] is string[]) return (dATA[name] as int[])[0];
            if (dATA[name] is int || dATA[name] is string) return Convert.ToInt32(dATA[name]);
            return 0;
        }
        public static int[] GetInts(Hashtable dATA, string name)
        {
            if (string.IsNullOrEmpty(name)) return new int[] { };
            if (dATA[name] == null) return new int[] { };
            if (dATA[name] is int[]) return (dATA[name] as int[]);
            return new int[] { };
        }

        public static long GetBigInt(Hashtable dATA, string name)
        {
            if (string.IsNullOrEmpty(name)) return 0;
            if (dATA[name] == null) return 0;
            if (dATA[name] is long[]) return (dATA[name] as long[])[0];
            if (dATA[name] is long) return Convert.ToInt64(dATA[name]);
            return 0;
        }
        public static long[] GetBigInts(Hashtable dATA, string name)
        {
            if (string.IsNullOrEmpty(name)) return new long[] { };
            if (dATA[name] == null) return new long[] { };
            if (dATA[name] is long[]) return (dATA[name] as long[]);
            return new long[] { };
        }

        public static float GetSingle(Hashtable dATA, string name)
        {
            if (string.IsNullOrEmpty(name)) return 0;
            if (dATA[name] == null) return 0;
            if (dATA[name] is float[]) return (dATA[name] as float[])[0];
            if (dATA[name] is float) return Convert.ToSingle(dATA[name]);
            return 0;
        }
        public static float[] GetSingles(Hashtable dATA, string name)
        {
            if (string.IsNullOrEmpty(name)) return new float[] { };
            if (dATA[name] == null) return new float[] { };
            if (dATA[name] is float[]) return (dATA[name] as float[]);
            return new float[] { };
        }

        public static double GetDouble(Hashtable dATA, string name)
        {
            if (string.IsNullOrEmpty(name)) return 0;
            if (dATA[name] == null) return 0;
            if (dATA[name] is double[]) return (dATA[name] as double[])[0];
            if (dATA[name] is double) return Convert.ToDouble(dATA[name]);
            return 0;
        }
        public static double[] GetDoubles(Hashtable dATA, string name)
        {
            if (string.IsNullOrEmpty(name)) return new double[] { };
            if (dATA[name] == null) return new double[] { };
            if (dATA[name] is double[]) return (dATA[name] as double[]);
            return new double[] { };
        }

        public static decimal GetDecimal(Hashtable dATA, string name)
        {
            if (string.IsNullOrEmpty(name)) return 0;
            if (dATA[name] == null) return 0;
            if (dATA[name] is decimal[]) return (dATA[name] as decimal[])[0];
            if (dATA[name] is decimal) return Convert.ToDecimal(dATA[name]);
            return 0;
        }
        public static decimal[] GetDecimals(Hashtable dATA, string name)
        {
            if (string.IsNullOrEmpty(name)) return new decimal[] { };
            if (dATA[name] == null) return new decimal[] { };
            if (dATA[name] is decimal[]) return (dATA[name] as decimal[]);
            return new decimal[] { };
        }

        public static DateTime? GetDateTime(Hashtable dATA, string name)
        {
            if (string.IsNullOrEmpty(name)) return null;
            if (dATA[name] == null) return null;
            if (dATA[name] is DateTime[]) return (dATA[name] as DateTime[])[0];
            if (dATA[name] is DateTime) return Convert.ToDateTime(dATA[name]);
            return null;
        }
        public static DateTime[] GetDateTimes(Hashtable dATA, string name)
        {
            if (string.IsNullOrEmpty(name)) return new DateTime[] { };
            if (dATA[name] == null) return new DateTime[] { };
            if (dATA[name] is DateTime[]) return (dATA[name] as DateTime[]);
            return new DateTime[] { };
        }

        public static TimeSpan? GetTimeSpan(Hashtable dATA, string name)
        {
            if (string.IsNullOrEmpty(name)) return null;
            if (dATA[name] == null) return null;
            if (dATA[name] is TimeSpan[]) return (dATA[name] as TimeSpan[])[0];
            if (dATA[name] is TimeSpan) return TimeSpan.Parse(dATA[name].ToString());
            return null;
        }
        public static TimeSpan[] GetTimeSpans(Hashtable dATA, string name)
        {
            if (string.IsNullOrEmpty(name)) return new TimeSpan[] { };
            if (dATA[name] == null) return new TimeSpan[] { };
            if (dATA[name] is TimeSpan[]) return (dATA[name] as TimeSpan[]);
            return new TimeSpan[] { };
        }
        #endregion

        #region get DataPost
        public static Hashtable GetDataPost()
        {
            Hashtable data = new Hashtable();
            foreach (var item in HttpContext.Current.Request.Form.AllKeys)
            {
                var value = HttpContext.Current.Request.Form.GetValues(item);
                if(value.Length == 1)
                    data.Add(item, value[0]);
                else
                    data.Add(item, value);
            }
            return data;
        }
        #endregion

        #region Bind Data
        private static Object ObjectGetValue(Hashtable DATA, string Name, string TypeName)
        {
            if (Equals(DATA[Name], null)) return null;

            if (Equals(TypeName, typeof(string).Name)) return GetString(DATA, Name);
            if (Equals(TypeName, typeof(string[]).Name)) return GetStrings(DATA, Name);

            if (Equals(TypeName, typeof(Byte).Name)) return GetByte(DATA, Name);
            if (Equals(TypeName, typeof(Byte[]).Name)) return GetBytes(DATA, Name);

            if (Equals(TypeName, typeof(int).Name)) return GetInt(DATA, Name);
            if (Equals(TypeName, typeof(int[]).Name)) return GetInts(DATA, Name);

            if (Equals(TypeName, typeof(long).Name)) return GetBigInt(DATA, Name);
            if (Equals(TypeName, typeof(long[]).Name)) return GetBigInts(DATA, Name);

            if (Equals(TypeName, typeof(float).Name)) return GetSingle(DATA, Name);
            if (Equals(TypeName, typeof(float[]).Name)) return GetSingles(DATA, Name);

            if (Equals(TypeName, typeof(double).Name)) return GetDouble(DATA, Name);
            if (Equals(TypeName, typeof(double[]).Name)) return GetDoubles(DATA, Name);

            if (Equals(TypeName, typeof(decimal).Name)) return GetDecimal(DATA, Name);
            if (Equals(TypeName, typeof(decimal[]).Name)) return GetDecimals(DATA, Name);

            if (Equals(TypeName, typeof(DateTime).Name)) return GetDateTime(DATA, Name);
            if (Equals(TypeName, typeof(DateTime[]).Name)) return GetDateTimes(DATA, Name);

            if (Equals(TypeName, typeof(TimeSpan).Name)) return GetTimeSpan(DATA, Name);
            if (Equals(TypeName, typeof(TimeSpan[]).Name)) return GetTimeSpans(DATA, Name);
            return null;
        }
        public static T Bind<T>(this T obj, Hashtable DATA)
        {
            Type type = obj.GetType();
            foreach (PropertyInfo prop in type.GetProperties())
            {
                var value = ObjectGetValue(DATA, prop.Name, prop.PropertyType.Name);
                if (!Equals(value, null)) prop.SetValue(obj, value, null);
            }
            foreach (FieldInfo field in type.GetFields())
            {
                var value = ObjectGetValue(DATA, field.Name, field.FieldType.Name);
                if (!Equals(value, null)) field.SetValue(obj, value);
            }
            return obj;
        }
        #endregion

        public static Hashtable ConvertObjectToHashtable<T>(T obj)
        {
            Hashtable data = new Hashtable();
            if (Equals(obj, null)) return data;
   
            Type type = obj.GetType();
            try
            {
                if (type.Name.IndexOf("Dictionary") >= 0)
                {
                    var dictionary = obj as Dictionary<object, object>;
                    foreach (var item in dictionary)
                    {
                        data.Add(item.Key, item.Value);
                    }
                }
                else
                {
                    Console.WriteLine("{0} -- ", type.Name);
                    Console.WriteLine(" Properties: ");
                    foreach (PropertyInfo prop in type.GetProperties())
                    {
                        Console.WriteLine("\t{0} {1} = {2}", prop.PropertyType.Name,
                            prop.Name, prop.GetValue(obj, null));
                        data.Add(prop.Name, prop.GetValue(obj, null));
                    }
                    Console.WriteLine(" Fields: ");
                    foreach (FieldInfo field in type.GetFields())
                    {
                        Console.WriteLine("\t{0} {1} = {2}", field.FieldType.Name,
                            field.Name, field.GetValue(obj));
                        data.Add(field.Name, field.GetValue(obj));
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("{0} -- ", type.Name);
                Console.WriteLine("{0} -- ", ex.Message);
            }
            return data;
        }

        

        

        
    }
}