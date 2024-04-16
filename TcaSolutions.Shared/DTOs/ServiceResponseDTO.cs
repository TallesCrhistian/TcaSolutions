namespace TcaSolutions.Shared.DTOs
{
    public class ServiceResponseDTO<T>
    {
        public T GenericData { get; set; }

        public bool Success { get; set; }

        public string Message { get; set; }
    }
}
