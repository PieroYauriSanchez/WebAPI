using Microsoft.AspNetCore.Mvc;
using WebAPI_Prueba.Entidades;

namespace WebAPI_Prueba.Controllers
{
    [ApiController]
    [Route("APIPruebaAsientoSAP")]
    public class APIPruebaAsientoSAP : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<APIPruebaAsientoSAP> _logger;

        public APIPruebaAsientoSAP(ILogger<APIPruebaAsientoSAP> logger)
        {
            _logger = logger;
        }

        //[HttpGet(Name = "GetWeatherForecast")]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    Thread.Sleep(30000);
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}

        [HttpPost("login")]
        public ERptaAsientosSAP Login()
        {
            
            var respuesta = new ERptaAsientosSAP
            {
                StatusCode = "200",
                StatusDescription = "Correcto - Login - ApiPruebaSAP",
                token = "4"
            };

            return respuesta;
        }

        [HttpPost("guardarNomina")]
        public ERptaAsientosSAP GuardarNomina()
        {
            int MyValue;
            Random rnd = new Random();
            MyValue = rnd.Next(1, 20);
            if (MyValue > 10) {
                Thread.Sleep(10000);
            } else { 
                Thread.Sleep(30000); 
            }
            
            var respuesta = new ERptaAsientosSAP
            {
                StatusCode = "200",
                StatusDescription = "Correcto - Guardar Nomina - ApiPruebaSAP",
                O_SUBRC = "0"
            };
            
            return respuesta;
            
            
        }
    }
}