using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using ConvertEverything.Units;
using ConvertEverything.Values;

namespace ConvertEverything.Converters
{
    internal static class Converter
    {
        public static bool CanConvert(this MutableValue source, IUnit unit)
        {
            var conversions = source.GetConversions();
            return conversions.Contains(unit.GetType());
        }

        public static bool Convert(this MutableValue source, IUnit unit)
        {
            var methodInfo = source.GetConversionMethod(unit);

            if (methodInfo == null)
                return false;

            try
            {
                if (!(methodInfo.Invoke(source.Unit, new object[] {unit}) is Action<MutableValue> converter))
                    return false;

                converter(source);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private static IEnumerable<Type> GetConversions(this IValue source)
        {
            var methods = source.GetConversionMethods();
            return methods.Select(mi => mi.GetParameters().First().ParameterType);
        }

        private static MethodInfo GetConversionMethod(this IValue source, IUnit unit)
        {
            var methods = source.GetConversionMethods();
            return methods.SingleOrDefault(mi => mi.GetParameters().First().ParameterType == unit.GetType());
        }

        private static IEnumerable<MethodInfo> GetConversionMethods(this IValue source)
        {
            var methods = source.Unit.GetType().GetMethods();
            return methods.Where(mi =>
                mi.Name == "Converter" &&
                mi.ReturnType == typeof(Action<MutableValue>) &&
                mi.FirstParameterIsIUnit());
        }

        private static bool FirstParameterIsIUnit(this MethodInfo methodInfo)
        {
            var parameters = methodInfo.GetParameters();
            return parameters.Length > 0 && 
                   parameters.First().ParameterType.GetInterfaces().Contains(typeof(IUnit));
        }
    }
}