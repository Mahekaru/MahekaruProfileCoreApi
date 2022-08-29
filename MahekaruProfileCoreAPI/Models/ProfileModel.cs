using Newtonsoft.Json;

namespace MahekaruProfileCoreAPI.Models
{
    public class ProfileModel
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Exp { get; set; } = 0;
        public int ExpTotal { get; set; } = 0;
        public int HP { get; set; }
        public int MP { get; set; }
        public string LinkedIn { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string GitHub { get; set; }
        public string ProfileImage { get; set; }

    }
}
