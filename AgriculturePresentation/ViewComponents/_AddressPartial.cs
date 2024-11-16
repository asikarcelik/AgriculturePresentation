using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AgriculturePresentation.ViewComponents
{
    public class _AddressPartial:ViewComponent
    {
        private readonly IAddressService _addressService;

        public _AddressPartial(IAddressService addressService)
        {
            _addressService = addressService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _addressService.GetListAll();
            return View(value);
        }
    }
}
