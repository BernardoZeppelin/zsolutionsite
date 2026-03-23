using KitchenEquip.Models;
using KitchenEquip.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace KitchenEquip.Controller
{
    public class AboutController : Microsoft.AspNetCore.Mvc.Controller
    {
        public IActionResult Index()
        {
            var viewModel = new AboutViewModel
            {
                Contact = new ContactInfo
                {
                    Email = "contato@kitchenequip.com.br",
                    Phone = "(11) 3456-7890",
                    WhatsApp = "(11) 99876-5432",
                    Address = "Av. Industrial, 1.500 – Galpão 7, Distrito Industrial, São Paulo – SP, CEP 04000-000",
                    BusinessHours = "Segunda a Sexta: 08h às 18h | Sábado: 08h às 12h",
                    LinkedIn = "https://linkedin.com/company/kitchenequip",
                    Instagram = "https://instagram.com/kitchenequip"
                }
            };
            return View(viewModel);
        }
    }
}
