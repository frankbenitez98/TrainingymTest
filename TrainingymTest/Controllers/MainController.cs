using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using TrainingymTest.Models;
using TrainingymTest.Repositories;

namespace TrainingymTest.Controllers
{
    [Route("api/main")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly IProductRepository _ProdRepo;
        private readonly IMemberRepository _MemRepo;
        private readonly IOrderRepository _OrdRepo;
        public MainController(IProductRepository ProdRepo, IMemberRepository MemRepo, IOrderRepository OrdRepo)
        {
            _ProdRepo = ProdRepo;
            _MemRepo = MemRepo;
            _OrdRepo = OrdRepo;
        }

        [HttpGet("run-seed")]
        public async Task<IActionResult> RunSeedAsync()
        {
            if (!await _MemRepo.Any() && !await _OrdRepo.Any() && !await _ProdRepo.Any())
            {

                var membersToAdd = new List<Member>
                {
                    new Member { Name = "María" },
                    new Member { Name = "José" },
                    new Member { Name = "Ana" },
                    new Member { Name = "Juan" },
                    new Member { Name = "Luisa" },
                    new Member { Name = "Pedro" },
                    new Member { Name = "Carmen" },
                    new Member { Name = "Carlos" },
                    new Member { Name = "Laura" },
                    new Member { Name = "Roberto" }
                };

                await _MemRepo.Create(membersToAdd);

                var productsToAdd = new List<Product>
                {
                    new Product {Name = "Product A" },
                    new Product {Name = "Product B" },
                    new Product {Name = "Product C" },
                    new Product {Name = "Product D" },
                    new Product {Name = "Product E" },
                    new Product {Name = "Product F" },
                    new Product {Name = "Product G" },
                    new Product {Name = "Product H" },
                    new Product {Name = "Product I" },
                    new Product {Name = "Product J" }
                };

                await _ProdRepo.Create(productsToAdd);

                var ordersToAdd = new List<Order>();

                for (int i = 1; i <= 10; i++)
                {
                    var order = new Order
                    {
                        MemberId = i,
                        ProductId = i,
                        DateOrder = DateTime.Now.AddDays(-i),
                    };

                    ordersToAdd.Add(order);
                }

                await _OrdRepo.Create(ordersToAdd);

                return Ok(new { Message = "Seed executed!" });
            }
            else return BadRequest(new { Message = "DB is not empty" });
        }

        [HttpGet("last-order")]
        public async Task<IActionResult> LastOrder([FromQuery][BindRequired] long MemberId)
        {
            if (ModelState.IsValid)
            {
                var lastOrder = await _OrdRepo.GetLastOrderByMemberId(MemberId);

                return Ok(lastOrder);
            }
            return BadRequest();

        }

    }
}
