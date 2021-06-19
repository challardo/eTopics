using Microsoft.AspNetCore.Mvc;
using eTopics.Data.Models;
using eTopics.Models.PostViewModels;
using System.Security.Claims;
using System.Threading.Tasks;
using eTopics.Models.HomeViewModel;

namespace eTopics.BusinessManagers.Interfaces {
    public interface IPostBusinessManager {
        IndexViewModel GetIndexViewModel(string searchString, int? page);
        Task<ActionResult<PostViewModel>> GetPostViewModel(int? id, ClaimsPrincipal claimsPrincipal);
        Task<Post> CreatePost(CreateViewModel createViewModel, ClaimsPrincipal claimsPrincipal);
        Task<ActionResult<Comment>> CreateComment(PostViewModel postViewModel, ClaimsPrincipal claimsPrincipal);
        Task<ActionResult<EditViewModel>> UpdatePost(EditViewModel editViewModel, ClaimsPrincipal claimsPrincipal);
        Task<ActionResult<EditViewModel>> GetEditViewModel(int? id, ClaimsPrincipal claimsPrincipal);
        Task<Post> DeletePost(EditViewModel deleteViewModel);
    }
}