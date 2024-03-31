using GalaxyApp.Core;
using GalaxyApp.Core.Dtos;
using GalaxyApp.Core.Models;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace GalaxyApp.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductsController : ControllerBase
	{
		private readonly IUnitOfWork _unitofwork;

		public ProductsController(IUnitOfWork unitofwork)
		{
			_unitofwork = unitofwork;
		}
		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			var allproduct = await _unitofwork.Products.GetAll();
			var prodcutsdtos = allproduct.Adapt<IEnumerable<ProdctIDdto>>();
			return Ok(prodcutsdtos);
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> GetById(int id)
		{
			Product prodct = await _unitofwork.Products.GetByIdAsync(id);
			if (prodct == null)
				return BadRequest($"No Prodcut was found with ID {id}");
			return Ok(prodct);
		}
		[HttpPost]

		public async Task<IActionResult> CodeProduct([FromForm] CreateProductdto dto)
		{
			var prdct = await _unitofwork.Products.FindAsync(d => d.Name == dto.Name);
			if (prdct != null)
				return BadRequest("The product name already exists");
			using var photostream = new MemoryStream();
			await dto.Photo.CopyToAsync(photostream);
			//Product product = dto.Adapt<Product>();
			var product = new Product
			{
				Name = dto.Name,
				Low_inventory_In = dto.Low_inventory_In,
				Evaluation = dto.Evaluation
			};
			product.Photo = photostream.ToArray();

			_unitofwork.Products.AddAsync(product);
			_unitofwork.save();
			return Ok(product);
		}
		[HttpPut]
		public async Task<IActionResult> Edit( [FromBody] ProdctIDdto dto)
		{
			var product = await _unitofwork.Products.GetByIdAsync(dto.Id);
			if (product == null)
				return NotFound($"NO product was found with ID {dto.Id}");
			if (product.Name != dto.Name)
			{
				var productWhithName = await _unitofwork.Products.FindAsync(p => p.Name == dto.Name);
				if (productWhithName != null && product.Id != productWhithName.Id)
					return BadRequest($"This name: {product.Name} is already used!");
			}
			product = dto.Adapt<Product>();

			await _unitofwork.save();

			return Ok();
		}
		[HttpDelete]
		public async Task<IActionResult> Delete(int id)
		{
			Product product = await _unitofwork.Products.GetByIdAsync(id);
			if (product == null)
				return BadRequest($"No Prodcut was found with ID {id}");
			_unitofwork.Products.Delete(product);
			_unitofwork.save();
			return Ok(product);
		}
	}
}
