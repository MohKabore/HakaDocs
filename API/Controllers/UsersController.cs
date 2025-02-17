
using API.Helpers;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;

namespace API.Controllers
{
     [Authorize]
    [ServiceFilter(typeof(LogUserActivity))]
    public class UsersController : BaseApiController
    {
        private readonly IMapper _mapper;
        //private readonly IPhotoService _photoService;
        private readonly IUnitOfWork _unitOfWork;
        // public UsersController(IUnitOfWork unitOfWork, IMapper mapper, IPhotoService photoService)
        public UsersController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            //  _photoService = photoService;
            _mapper = mapper;
        }

        // [Authorize]
        // [HttpGet("GetUsers")]
        // public async Task<ActionResult<IEnumerable<MemberDto>>> GetUsers([FromQuery] UserParams userParams)
        // {
        //     var gender = await _unitOfWork.UserRepository.GetUserGender(User.GetUsername());
        //     userParams.CurrentUsername = User.GetUsername();
        //     if (string.IsNullOrEmpty(userParams.Gender))
        //         userParams.Gender = userParams.Gender == "male" ? "female" : "male";
        //     var users = await _unitOfWork.UserRepository.GetMembersAsync(userParams);
        //     Response.AddPaginationHeader(users.CurrentPage, users.PageSize, users.TotalCount, users.TotalPages);
        //     return Ok(users);
        // }



        // [HttpGet("{id}")]
        // public async Task<ActionResult<MemberDto>> GetUser(int id)
        // {
        //     var user = await _unitOfWork.UserRepository.GetUserByIdAsync(id);
        //     var userToReturn = _mapper.Map<MemberDto>(user);
        //     return Ok(userToReturn);
        // }
        // [HttpGet("getUser/{username}", Name = "GetUser")]
        // public async Task<ActionResult<MemberDto>> GetUser(string username)
        // {
        //     return await _unitOfWork.UserRepository.GetMemberAsync(username);
        // }



        // [HttpPut]
        // public async Task<ActionResult> UpdateUser(MemberUpdateDto memberUpdateDto)
        // {
        //     var username = User.GetUsername();
        //     var user = await _unitOfWork.UserRepository.GetUserByUsernameAsync(username);
        //     _mapper.Map(memberUpdateDto, user);
        //     _unitOfWork.UserRepository.Update(user);
        //     if (await _unitOfWork.Complete()) return NoContent();
        //     return BadRequest("failed to update user");
        // }

        // [HttpPost("add-photo")]
        // public async Task<ActionResult<PhotoDto>> AddPhoto(IFormFile file)
        // {
        //     var user = await _unitOfWork.UserRepository.GetUserByUsernameAsync(User.GetUsername());
        //     var result = await _photoService.AddPhotoAsync(file);
        //     if (result.Error != null) return BadRequest(result.Error.Message);
        //     var photo = new Photo
        //     {
        //         Url = result.SecureUrl.AbsoluteUri,
        //         PublicId = result.PublicId
        //     };
        //     if (user.Photos.Count == 0)
        //         photo.IsMain = true;

        //     user.Photos.Add(photo);

        //     if (await _unitOfWork.Complete())
        //         return CreatedAtRoute("GetUser", new { username = user.UserName }, _mapper.Map<PhotoDto>(photo));

        //     return BadRequest("problem adding photo");
        // }

        // [HttpPut("set-main-photo/{photoId}")]
        // public async Task<ActionResult> SetManiPhoto(int photoId)
        // {
        //     var user = await _unitOfWork.UserRepository.GetUserByUsernameAsync(User.GetUsername());
        //     var photo = user.Photos.FirstOrDefault(photo => photo.Id == photoId);
        //     if (photo.IsMain) return BadRequest("this is already your main photo");
        //     var currentMain = user.Photos.FirstOrDefault(photo => photo.IsMain);
        //     if (currentMain != null) currentMain.IsMain = false;
        //     photo.IsMain = true;
        //     if (await _unitOfWork.Complete())
        //         return NoContent();

        //     return BadRequest("failed to save main photo");
        // }

        // [HttpDelete("delete-photo/{photoId}")]
        // public async Task<ActionResult> DeletePhoto(int photoId)
        // {
        //     var user = await _unitOfWork.UserRepository.GetUserByUsernameAsync(User.GetUsername());
        //     var photo = user.Photos.FirstOrDefault(photo => photo.Id == photoId);
        //     if (photo == null) return NotFound();
        //     if (photo.IsMain) return BadRequest("you cannot delete main photo");
        //     if (photo.PublicId != null)
        //     {
        //         var result = await _photoService.DeletePhotoAsync(photo.PublicId);
        //         if (result.Error != null) return BadRequest(result.Error.Message);
        //     }
        //     user.Photos.Remove(photo);
        //     if (await _unitOfWork.Complete()) return Ok();
        //     return BadRequest("Failed to delete photo");


        // }

        // [AllowAnonymous]
        // [HttpGet("test-getusers")]
        // public async Task<ActionResult> getAllUsers()
        // {
        //     var client = new HttpClient();
        //     string url = "https://localhost:5003/api/users/getusers";

        //     client.DefaultRequestHeaders.Accept.Clear();
        //     client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //     var response = await client.GetFromJsonAsync<List<MemberDto>>(url);
        //  //   var responseString = await response.Content.ReadAsStringAsync();
        //   //  var users = JsonSerializer.Deserialize<List<MemberDto>>(responseString);
             

        //     return Ok(response);
        // }
    }
}