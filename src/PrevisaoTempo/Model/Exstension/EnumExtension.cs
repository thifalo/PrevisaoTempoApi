namespace PrevisaoTempo.Model.Exstension
{
	using System.ComponentModel;
	using System.ComponentModel.DataAnnotations;
	using System.Reflection;

	public static class EnumExtension
    {
		// Método para obter descrição de Enumeradores
	    public static string ObterDescricao<T>(this T value)
	    {
		    var enumType = typeof(T);

		    foreach (FieldInfo field in enumType.GetFields(BindingFlags.Public | BindingFlags.Static))
		    {
			    if (!field.Name.Equals(value.ToString()))
			    {
				    continue;
			    }

			    var data = field.GetCustomAttributes(typeof(DescriptionAttribute), false);

			    if (data.Length == 1)
			    {
				    return ((DescriptionAttribute)data[0]).Description;
			    }

			    data = field.GetCustomAttributes(typeof(DisplayAttribute), false);

			    if (data.Length == 1)
			    {
				    var description = ((DisplayAttribute)data[0]).Description;

				    return !string.IsNullOrEmpty(description) ? description : field.Name;
			    }

			    return field.Name;
		    }

		    return value.ToString();
	    }
	}
}
