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

        [HttpPost("consultarNomina")]
        public PAYROLL_ERsptaNomina ConsultarNomina()
        {
            int MyValue;
            Random rnd = new Random();
            MyValue = rnd.Next(1, 20);
            if (MyValue > 10)
            {
                Thread.Sleep(10000);
            }
            else
            {
                Thread.Sleep(30000);
            }

            var respuesta = new PAYROLL_ERsptaNomina();
            respuesta.IT_NOMINA_CAB = new PAYROLL_ERsptaNominaItemCab
            {
                item = new PAYROLL_ERsptaNominaItem
                {
                    ESTADO = "2", // Aprobado
                    IDENT = "" // ID ASIENTO
                }
            };

            return respuesta;

        }
    }
}