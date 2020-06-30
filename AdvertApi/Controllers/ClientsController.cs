using System;
using AdvertApi.DTOs.Requests;
using AdvertApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace AdvertApi.Controllers
{    
    [ApiController]
    [Route("api/clients")]
    public class ClientsController : ControllerBase
    {

        private readonly IDataBaseService _service;

        public ClientsController(IDataBaseService service)
        {
            _service = service;
        }
        
        [HttpPost]
        public IActionResult RegisterUser(ClientRegistrationRequest request)
        {
            try
            {
                var registeredUserResponse = _service.RegisterClient(request);
                return Ok(registeredUserResponse);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        public IActionResult GetRefreshAndAccessToken(string refreshToken)
        {
            try
            {
                var tokenResult = _service.GetRefreshAndAccessToken(refreshToken);
                return Ok(tokenResult);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        public IActionResult GetUserAuthorization(AuthorizationRequest authRequest)
        {
            try
            {
                var authResult = _service.GetUserAuthorization(authRequest);
                return Ok(authResult);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}