﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IDS328L.DTO;
using IDS328L.Services;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CORE_Api_Pymes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActividadController : ControllerBase
    {
        private readonly IActividadServices _IServices;

        #region Constructor
        public ActividadController(IActividadServices service)
        {
            _IServices = service;
        }
        #endregion

        #region[HttpGet] search by Nombre, Id, Operacion
        [HttpGet]
        public ActionResult Get(int Operacion = 1, int Id = 0, bool Estado = true)
        {
            var result = _IServices.Get(Operacion, Id,Estado);
            return Ok(result);
        }
        #endregion

        #region[HttpPost] Actividad Requests
        [HttpPost]
        public ActionResult Post(ActividadEntities ActividadEntities)
        {
            if (_IServices != null)
            {
                var result = _IServices.Post(ActividadEntities);

                return Ok(result);
            }
            else
            {
                return Ok();
            }
        }
        #endregion

        #region [HttpPut] Actividad Requests
        [HttpPut]
        public ActionResult Put(ActividadEntities ActividadEntities)
        {
            var Result = _IServices.Put(ActividadEntities);

            return Ok(Result);
        }
        #endregion

        #region Delete by 
        [HttpDelete]
        public ActionResult Delete(int Id)
        {
            var result = _IServices.Delete(Id);

            return Ok(result);
        }
        #endregion
    }
}
