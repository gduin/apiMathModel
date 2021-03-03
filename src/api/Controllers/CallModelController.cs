using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Models;
using service;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CallModelController : ControllerBase
    {
        
        private readonly ILogger<CallModelController> _logger;
        private readonly modelsParams _models;

        public CallModelController(ILogger<CallModelController> logger, IOptions<modelsParams> models)
        {
            _logger = logger;
            _models = models.Value;
        }

        [HttpPost]
        public ActionResult<ResponseModel<ResultModel>> Post(CallModel model)
        {
            var execmodel = new ExecModel {
                Interpreter = _models.models[model.Name].Interpreter,
                ScriptFile  = _models.models[model.Name].ScriptFile,
                Arg0        = model.Arg0,
                Arg1        = model.Arg1,
                Data1       = model.Data1
            };

            var caller =new service.Caller(execmodel);
            return Ok(caller.Output());
        }
    }
}
