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
}
