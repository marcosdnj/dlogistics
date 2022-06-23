using delfimLogAPI.Data;
using delfimLogAPI.Models;
using delfimLogAPI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace delfimLogAPI.Controller
{
    [ApiController]
    public class RastreioController : ControllerBase
    {

        [HttpGet]
        [Route("getall")]
        public async Task<IActionResult> Get(
            [FromServices] AppDbContext context)
        {
            var rastreioAll = await context
                .Rastreios
                .AsNoTracking()
                .ToListAsync();

            return Ok(rastreioAll);
        }
        //////////////////////////////


        [HttpGet]
        [Route("get/{id}")]
        public async Task<IActionResult> GetByIdAsync(
            [FromServices] AppDbContext context,
            [FromRoute] int id)
        {
            var rastreiosId = await context
                .Rastreios
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            return rastreiosId == null ? NotFound("Nada encontrado com este Id") : Ok(rastreiosId);

        }

        [HttpPost("post")]
        public async Task<IActionResult> PostAsync(
            [FromServices]AppDbContext context,
            [FromBody] CreateRastreioViewModel rastreio)
        {
            if (!ModelState.IsValid)
                return BadRequest("ERROR");

            var newrastreio = new Rastreio
            {
                Codigo = Guid.NewGuid().ToString().ToUpper(),
                Nome = rastreio.Nome,
                Origem = rastreio.Origem,
                Preco = rastreio.Preco,
                Destino = rastreio.Destino,
                Remetente = rastreio.Remetente,
                Destinatario = rastreio.Destinatario,
                Data = DateTime.Now
            };

            try
            {
                await context.Rastreios.AddAsync(newrastreio);
                await context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest("Erro ao salvar");
            }
        }

        








    }
}
