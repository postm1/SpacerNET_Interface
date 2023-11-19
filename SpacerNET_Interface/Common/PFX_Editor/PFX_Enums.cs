using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SpacerUnion.Common.PFX_Editor
{
    class DirConverter : EnumConverter
    {
        private Type type;

        public DirConverter(Type type)
            : base(type)
        {
            this.type = type;
        }

        public override object ConvertTo(ITypeDescriptorContext context,
            CultureInfo culture, object value, Type destType)
        {
            FieldInfo fi = type.GetField(Enum.GetName(type, value));
            DescriptionAttribute descAttr =
              (DescriptionAttribute)Attribute.GetCustomAttribute(
                fi, typeof(DescriptionAttribute));

            if (descAttr != null)
                return descAttr.Description;
            else
                return value.ToString();
        }

        public override object ConvertFrom(ITypeDescriptorContext context,
            CultureInfo culture, object value)
        {
            foreach (FieldInfo fi in type.GetFields())
            {
                DescriptionAttribute descAttr =
                  (DescriptionAttribute)Attribute.GetCustomAttribute(
                    fi, typeof(DescriptionAttribute));

                if ((descAttr != null) && ((string)value == descAttr.Description))
                    return Enum.Parse(type, fi.Name);
            }
            return Enum.Parse(type, (string)value);
        }
    }

    public enum SHPTYPE_S
    {
        [Description("POINT")]
        POINT,
        [Description("LINE")]
        LINE,
        [Description("BOX")]
        BOX,
        [Description("CIRCLE")]
        CIRCLE,
        [Description("SPHERE")]
        SPHERE,
        [Description("MESH")]
        MESH
    }

    public enum SHPFOR_S
    {
        [Description("WORLD")]
        WORLD,
        [Description("OBJECT")]
        OBJECT
    }

    public enum SHPDISTRIBTYPE_S
    {
        [Description("RAND")]
        RAND,
        [Description("UNI")]
        UNI,
        [Description("WALK")]
        WALK
    }

    public enum DIRFOR_S
    {
        [Description("OBJECT")]
        OBJECT,
        [Description("WORLD")]
        WORLD,
        [Description("FRAME")]
        FRAME   
    }

    public enum DIRMODETARGETFOR_S
    {
        [Description("OBJECT")]
        OBJECT,
        [Description("WORLD")]
        WORLD
    }

    public enum VISTEXANIISLOOPING
    {
        [Description("FALSE")]
        FALSE,
        [Description("TRUE")]
        TRUE,
        [Description("SPECIAL")]
        SPECIAL
    }

    public enum FLYCOLLDET_B
    {
        [Description("NONE")]
        NONE,
        [Description("SLOWER_REFLECT")]
        SLOWER_REFLECT,
        [Description("FASTER_REFLECT")]
        FASTER_REFLECT,
        [Description("FREEZE")]
        FREEZE,
        [Description("REMOVE")]
        REMOVE
    }
    

    public static class ExtClass
    {
        public static T ToEnum<T>(this string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }

    }
}
