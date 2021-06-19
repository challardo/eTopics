using Microsoft.AspNetCore.Http;
using eTopics.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace eTopics.Models.PostViewModels {
    public class CreateViewModel {
        [Required, Display(Name = "Header Image")]
        public IFormFile HeaderImage { get; set; }
        public Post Post { get; set; }
    }
}