using GalaxyApp.Core;
using GalaxyApp.Core.Dtos;
using GalaxyApp.Core.Models;
using GalaxyApp.Ef;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GalaxyApp.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SuppliersController : ControllerBase
	{
		private readonly IUnitOfWork _unitofWork;

		public SuppliersController(IUnitOfWork unitofWork)
		{
			_unitofWork = unitofWork;
		}

		[HttpPost]
		public async Task<IActionResult> Add([FromForm] SupplierDto dto)
		{
			using var NIdstream = new MemoryStream();
			await dto.National_ID.CopyToAsync(NIdstream);
			using var photostream = new MemoryStream();
			await dto.National_ID.CopyToAsync(photostream);

			Supplier supplier = new Supplier();
			supplier.Name = dto.Name;
			supplier.National_ID = NIdstream.ToArray();
			supplier.Photo=photostream.ToArray();
			_unitofWork.suppliers.AddAsync(supplier);
			_unitofWork.save();
			return Ok(supplier);
		}


	}
}
