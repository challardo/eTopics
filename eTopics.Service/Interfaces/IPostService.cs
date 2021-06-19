using eTopics.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTopics.Service.Interfaces {
    public interface IPostService {
        Post GetPost(int postId);
        IEnumerable<Post> GetPosts(string searchString);
        IEnumerable<Post> GetPosts(ApplicationUsers applicationUser);
        Comment GetComment(int commentId);
        Task<Post> Add(Post post);
        Task<Comment> Add(Comment comment);
        Task<Post> Update(Post post);
        Task<Post> Delete(Post post, int postId);
    }
}