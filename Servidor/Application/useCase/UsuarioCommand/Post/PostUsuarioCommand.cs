using MediatR;
using Microsoft.Extensions.Logging;
using Servidor.Domain.Dtos;
using Servidor.Domain.Entities;
using Servidor.Domain.Models;
using System.Runtime.CompilerServices;

namespace Servidor.Application.useCase.UsuarioCommand.Post
{
    public class PostUsuarioCommand : IRequest<DataResult<string>>
    {
        public UsuarioDto Data { get; set; }
    }

    public class PostUsuarioCommandHandler : IRequestHandler<PostUsuarioCommand, DataResult<string>> 
    {
        private readonly ILogger<PostUsuarioCommandHandler> _logger;
        //private readonly 
        public PostUsuarioCommandHandler(ILogger<PostUsuarioCommandHandler> logger)
        {
            _logger = logger;
        }

        public async Task<DataResult<string>> Handle(PostUsuarioCommand request, CancellationToken cancellationToken)
        {
            var data = request.Data;
            try
            {

                Usuario entidad = new()
                {
                    Nombre = data.Nombre,
                    Apellido = data.Apellido,
                    Deshabilitado = data.Deshabilitado,
                    NombreDeUsuario = data.NombreDeUsuario,
                    Password = data.Password,

                };

                return new DataResult<string> { Success = true, Message = "El usuario fue insertado con exito" };
            }
            catch (Exception ex)
            {
                return new DataResult<string> { Success = false, Message = ex.ToString() };
            }
        }
    }
}
