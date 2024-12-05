using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ProyectoFinal.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Propiedades adicionales
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Método para generar la identidad del usuario
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // El parámetro authenticationType debe coincidir con el definido en CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Agregar claims personalizados aquí si es necesario
            return userIdentity;
        }
    }
}