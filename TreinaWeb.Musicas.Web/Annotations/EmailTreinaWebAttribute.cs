using System.ComponentModel.DataAnnotations;

namespace TreinaWeb.Musicas.Web.Annotations
{
    public class EmailTreinaWebAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return value.ToString().EndsWith("@treinaweb.com.br");
        }
    }
}