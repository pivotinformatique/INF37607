using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TDRSolutionFrontEnd.Core.Entities;
using TDRSolutionFrontEnd.Core.Interfaces;
using TDRSolutionFrontEnd.WebAPI.DTOs;

namespace TDRSolutionFrontEnd.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class DeclarationsController : ControllerBase
    {
        private readonly IDeclarationRevenuService _declarationService;
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        public DeclarationsController(IDeclarationRevenuService declarationService, IUserService userService, IMapper mapper)
        {
            _declarationService = declarationService;
            _userService = userService;
            _mapper = mapper;
        }

        /// <summary>
        /// Get the declarations list of a user
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <remarks>Used after the login operation</remarks>
        [ProducesResponseType(typeof(DeclarationsForListDto), 200)]
        [HttpGet("UserDeclarations/{id}")]
        public async Task<IActionResult> GetUserDeclarations(int id)
        {
            var userDeclarations = await _declarationService.GetUserDeclarationRevenus(id);

            var declarationsToReturn = _mapper.Map<IEnumerable<DeclarationsForListDto>>(userDeclarations);

            return Ok(declarationsToReturn);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="declarationForCreateDto"></param>
        /// <returns></returns>
        [HttpPost("NewUserDeclaration/{userId}")]
        public async Task<IActionResult> AddDeclaration(int userId, DeclarationForCreateDto declarationForCreateDto)
        {
            var user = await _userService.GetUserById(userId);
            if (user == null) return BadRequest("User not found");
            var declarationToCreate = _mapper.Map<DeclarationRevenus>(declarationForCreateDto);
            var declarationUpdated = await _declarationService.AddDeclarationRevenu(userId, declarationToCreate);
            var declarationToReturn = _mapper.Map<DeclarationForDetailedDto>(declarationUpdated);
            return Ok(declarationToReturn);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="declarationForUpdateDto"></param>
        /// <returns></returns>
        [HttpPut("UpdateUserDeclaration/{userId}")]
        public async Task<IActionResult> UpdateDeclaration(int userId, DeclarationForUpdateDto declarationForUpdateDto)
        {
            var user = await _userService.GetUserById(userId);
            if (user == null) return BadRequest("User not found");
            var declaration = await _declarationService.GetDeclarationRevenu(Convert.ToInt32(declarationForUpdateDto.Id));
            if (declaration == null) return BadRequest("Declaration not found");
            declaration.Annee = declarationForUpdateDto.Annee;
            declaration.RevenusEmploi = declarationForUpdateDto.RevenusEmploi;
            declaration.RevenusAutre = declarationForUpdateDto.RevenusAutre;
            await _declarationService.UpdateDeclarationRevenus(declaration);
            var declarationToReturn = _mapper.Map<DeclarationForDetailedDto>(declaration);
            return Ok(declarationToReturn);
        }

        /// <summary>
        /// Empêcher la suppresion d'un IdDeclaration si elle n'appartient pas au UserId
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="declarationId"></param>
        /// <returns></returns>
        [HttpDelete("RemovalDeclaration/{declarationId}")]
        public async Task<IActionResult> DeleteDeclaration(int declarationId)
        {
            var declarationToDelete = await _declarationService.GetDeclarationRevenu(declarationId);
            if (declarationToDelete is null) return BadRequest("Declaration not found");
            await _declarationService.DeleteDeclarationRevenus(declarationToDelete);
            return Ok();
        }

        /// <summary>
        /// Empêcher la suppresion d'un IdDeclaration si elle n'appartient pas au UserId
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="declarationId"></param>
        /// <returns></returns>
        [Obsolete("This method is depecated, please use RemovalDeclaration/{declarationId}")]
        [HttpDelete("RemovalDeclaration/{userId}/{declarationId}")]
        public async Task<IActionResult> DeleteDeclaration(int userId, int declarationId)
        {
            var user = await _userService.GetUserById(userId);
            if (user == null) return BadRequest("User not found");
            var userDeclarations = await _declarationService.GetUserDeclarationRevenus(userId);
            var declarationToDelete = userDeclarations.Where(x => x.Id == declarationId).FirstOrDefault();
            if (declarationToDelete is null) return BadRequest("User declaration not found");
            await _declarationService.DeleteDeclarationRevenus(declarationToDelete);
            return Ok();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="declarationId"></param>
        /// <param name="directory"></param>
        /// <returns></returns>
        [HttpPut("SubmissionDeclaration/{declarationId}/{directory}")]
        public async Task<IActionResult> SubmitDeclaration(int declarationId, string directory)
        {
            var declaration = await _declarationService.GetDeclarationRevenu(declarationId);
            if (declaration == null) return BadRequest("Declaration not found");
            var demandeForBackEnd = _mapper.Map<DemandeTraitement>(declaration);
            var declarationUpdated = await _declarationService.SubmitDeclarationRevenus(demandeForBackEnd, directory);
            var declarationToReturn = _mapper.Map<DeclarationForDetailedDto>(declarationUpdated);
            return Ok(declarationToReturn);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="declarationId"></param>
        /// <returns></returns>
        [HttpGet("AvisCotisation/{declarationId}")]
        public async Task<IActionResult> GetAvisCotisation(int declarationId)
        {
            var avisCotisation = await _declarationService.GetDeclarationAvisCotisation(declarationId);
            if (avisCotisation == null) return BadRequest("Cotisation not found");
            return Ok(avisCotisation);
        }


    }
}
