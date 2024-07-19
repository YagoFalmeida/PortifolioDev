using System.ComponentModel;

namespace ApiPrincipal.Dominio
{
    public class ClasseBase
    {
        public static string ObterDescricaoEnum<T>(string enumValue)
        {
            var descricaoAtributo = typeof(T)
                                    .GetField(enumValue)
                                    .GetCustomAttributes(typeof(DescriptionAttribute), false)
                                    .FirstOrDefault() as DescriptionAttribute;

            return descricaoAtributo != null ? descricaoAtributo.Description : enumValue;
        }
    }
}
