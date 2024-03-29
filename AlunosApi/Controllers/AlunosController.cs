﻿using AlunosApi.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlunosApi.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class AlunosController : ControllerBase {
        private IAlunoService _alunoService;

        public AlunosController(IAlunoService alunoService) {
            _alunoService = alunoService;
        }
    }
}
