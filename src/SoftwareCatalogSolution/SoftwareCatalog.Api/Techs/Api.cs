using Microsoft.AspNetCore.Mvc;

namespace SoftwareCatalog.Api.Techs;

public class Api : ControllerBase
{

    [HttpPost("/techs")]
    public async Task<ActionResult> AddATechAsync(
        [FromBody] CreateTechRequest request,
        CancellationToken token)
    {
        // Judge the heck out of us.
        // Is the person making the request allowed to make this request (Authn/Authz) Later.
        // did they send us the right data?
        //   if not, send them an error.
        // If they did, do we want this person as a tech?
        // - Business rules, etc....
        // If so,create a new subordinate resource.
        return Ok(request);
    }
}


public record CreateTechRequest
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
}

/*
 *  Operation: Create a Tech

 * Operands:
    - We need their name (first, last),
    - we need their email address
    - We need their phone number
    - we need their "identifier" (sub claim) (more on this later)*/