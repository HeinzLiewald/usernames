using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.AspNetCore.Mvc;

using Models.Usernames;

namespace UserNames.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class UsernamesController : ControllerBase {
        private static readonly string[] Adjective = new[]
        {
            "Freezing",
            "Bracing",
            "Chilly",
            "Cool",
            "Mild",
            "Warm",
            "Balmy",
            "Hot",
            "Sweltering",
            "Scorching",
        };

        private static readonly string[] Name = new[]
        {
            "Lula",
            "Amarah",
            "Emilis",
            "Komal",
            "Kayla",
            "Jaxx",
            "Giorgia",
            "Annabella",
            "Ami",
            "John",
        };

        [HttpGet]
        public IEnumerable<Username> Get() {
            var rng = new Random();
            const int ELEMENTS = 10;

            return Enumerable.Range(1, ELEMENTS)
                        .Select(index => new Username {
                            Date = DateTime.Now.AddDays(index),
                            Value = Adjective[rng.Next(Adjective.Length)] + Name[rng.Next(Name.Length)] + rng.Next(ELEMENTS)
                        }).ToArray();
        }
    }
}
