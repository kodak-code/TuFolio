namespace TuFolioAPI.Utilidad
{
    public class Response<T>
    {
        public bool Estado { get; set; }

        public T Valor { get; set; }

        public string Mensaje { get; set; }
    }
}
