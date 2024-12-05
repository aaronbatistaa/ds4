using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Microsoft.AspNet.Identity.EntityFramework;

namespace ProyectoFinal.Models
{
    public class ApplicationRole : IdentityRole
    {
        // Propiedades adicionales para el rol
        public ApplicationRole() : base() { }

        public ApplicationRole(string roleName) : base(roleName) { }

        // Puedes agregar propiedades adicionales aquí
    }
}