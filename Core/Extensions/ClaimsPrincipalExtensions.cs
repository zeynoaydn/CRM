using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace Core.Extensions
{
    ///burası çokta önemli değil,istersen sonra silebilirsin ama önemli gibi 
    /*
     Bu kod, ClaimsPrincipal sınıfına iki adet extension metodu eklemektedir. 
    Bu extension metodlar, ClaimsPrincipal nesnesine belirli işlemler yapmak için kullanılabilir hale getirir:
    Claims Metodu: Bu metot, belirli bir claimType için kullanıcının tüm claim değerlerini liste olarak döndürür.
    ClaimRoles Metodu: Bu metot, kullanıcının rollerini liste olarak döndürür.
    Örneğin, kullanıcının adı, e-posta gibi claim'leri varsa, bu extension metodları kullanarak bu 
    claim değerlerine erişmek mümkündür. Ayrıca, kullanıcının rollerine erişmek için de ClaimRoles metodunu kullanabilirsiniz.
    Kısaca, bu extension metodlar, ClaimsPrincipal sınıfına yeni ve kullanışlı özellikler ekleyerek, 
    kullanıcı kimlik doğrulama bilgilerini elde etmeyi kolaylaştırır.
    */
    public static class ClaimsPrincipalExtensions
    {
        public static List<string> Claims(this ClaimsPrincipal claimsPrincipal, string claimType)
        {
            var result = claimsPrincipal?.FindAll(claimType)?.Select(x => x.Value).ToList();
            return result;
        }

        public static List<string> ClaimRoles(this ClaimsPrincipal claimsPrincipal)
        {
            return claimsPrincipal?.Claims(ClaimTypes.Role);
        }
    }
}
