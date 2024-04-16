using TcaSolutions.Shared.DTOs;

namespace TcaSolutions.Shared.Exceptions
{
    public static class CatchCustom
    {
        public static ServiceResponseDTO<TEntity> ServiceResponse<TException, TEntity>(TException ex) where TException : Exception
        {
            ServiceResponseDTO<TEntity> serviceResponseDTO = new ServiceResponseDTO<TEntity>();

            serviceResponseDTO.Success = false;
            serviceResponseDTO.Message = ex.Message;


            return serviceResponseDTO;
        }
    }
}
