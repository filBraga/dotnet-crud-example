using Microsoft.AspNetCore.Mvc;

namespace crud_dotnet.Controllers;

[ApiController]
[Route("[controller]")]
public class AlunoController : ControllerBase
{
    private readonly ILogger<AlunoController> _logger;

    public AlunoController(ILogger<AlunoController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetAluno")]
    public IEnumerable<Aluno> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Aluno
        {
            Nome = "Aluno " + index,
            Email = "aluno" + index + "@example.com",
            DataNascimento = DateTime.Now.AddDays(index),
            Ativo = true

        })
        .ToArray();
    }
}
