using Microsoft.AspNetCore.Mvc;
using WebAPI_Prueba.Entidades;

namespace WebAPI_Prueba.Controllers
{
    [ApiController]
    [Route("APIPruebaAsientoPYRAMID")]
    public class APIPruebaAsientoPYRAMID : ControllerBase
    {

        private readonly ILogger<APIPruebaAsientoPYRAMID> _logger;

        public APIPruebaAsientoPYRAMID(ILogger<APIPruebaAsientoPYRAMID> logger)
        {
            _logger = logger;
        }

        [HttpPost("ExagonAuth/api/Authentication/auth")]
        public ERptaAsientosSAP Login()
        {
            
            var respuesta = new ERptaAsientosSAP
            {
                StatusCode = "200",
                StatusDescription = "Correcto - Login - ApiPruebaPYRAMID",
                token = "4"
            };

            return respuesta;
        }

        [HttpPost("ExagonUpload/api/Files/upload")]
        public ERptaAsientosPYRAMID CargarArchivo()
        {
            Thread.Sleep(60000);

            var respuesta = new ERptaAsientosPYRAMID
            {
                cargados = "10"
            };

            return respuesta;
        }
    }
}