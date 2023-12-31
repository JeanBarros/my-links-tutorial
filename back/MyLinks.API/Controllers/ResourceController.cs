using Microsoft.AspNetCore.Mvc;
using MyLinks.Domain.Repository;

namespace MyLinks.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ResourceController : ControllerBase
{
    private ILinkResourceRepository _repository;

    public ResourceController(ILinkResourceRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public ActionResult Get()
    {
        return Ok(_repository.GetAll());
    }

    [HttpGet("{id}")]
    public ActionResult Get(Guid? id)
    {
        return Ok(_repository.GetById(id.Value));
    }
}
