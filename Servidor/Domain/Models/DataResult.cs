namespace Servidor.Domain.Models;

public class DataResult<T> : Result
{
    public T Data { get; set; }
}