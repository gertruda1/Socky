using Socky_Models;
using SockyWeb_Client.ViewModels;

namespace SockyWeb_Client.Serivce.IService
{
    public interface IPaymentService
    {
        public Task<SuccessModelDTO> Checkout(StripePaymentDTO model);

    }
}