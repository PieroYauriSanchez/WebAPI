namespace WebAPI_Prueba.Entidades
{
    public class ERptaAsientosSAP
    {
        public string? StatusCode { get; set; }
        public string? StatusDescription { get; set; }
        public string? token { get; set; }
        public string? exp { get; set; }
        public string? O_SUBRC { get; set; }
        public TokenError? _Error { get; set; }
        public string? jwt { get; set; }
        public string? ErrMsjMPG { get; set; }
    }

    public class TokenError
    {
        public string? message { get; set; }
        public string? code { get; set; }
        public string? time { get; set; }
        public string? requestId { get; set; }
        public string? statusCode { get; set; }
        public string? retryable { get; set; }
        public string? retryDelay { get; set; }
    }

    public class PAYROLL_ERsptaNomina
    {
        public string? IP_RESPUESTA { get; set; }
        public PAYROLL_ERsptaNominaItemCab? IT_NOMINA_CAB { get; set; }
    }

    public class PAYROLL_ERsptaNominaItemCab
    {
        public PAYROLL_ERsptaNominaItem? item { get; set; }
    }

    public class PAYROLL_ERsptaNominaItem
    {
        public string? MANDT { get; set; }
        public string? IDENT { get; set; }
        public string? BLART { get; set; }
        public string? BLDAT { get; set; }
        public string? BUKRS { get; set; }
        public string? BUDAT { get; set; }
        public string? MONAT { get; set; }
        public string? WAERS { get; set; }
        public string? WRBTR { get; set; }
        public string? KURSF { get; set; }
        public string? BELNR { get; set; }
        public string? WWERT { get; set; }
        public string? XBLNR { get; set; }
        public string? BKTXT { get; set; }
        public string? AUGLV { get; set; }
        public string? VBUND { get; set; }
        public string? XMWST { get; set; }
        public string? ESTADO { get; set; }
        public string? DSCMJE { get; set; }
        public string? USRCREA { get; set; }
        public string? FCREA { get; set; }
        public string? HCREA { get; set; }
        public string? USRMOD { get; set; }
        public string? FMOD { get; set; }
        public string? HMOD { get; set; }
        public string? D_BELNR { get; set; }
        public string? D_BUKRS { get; set; }
        public string? D_GJAHR { get; set; }
    }

}
