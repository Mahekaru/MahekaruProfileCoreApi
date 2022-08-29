﻿using Newtonsoft.Json;

namespace MahekaruProfileCoreAPI.Models
{
    public class SkillsModel
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal SkillPoints { get; set; } = 0;

        [JsonIgnore]
        public string ExperianceLevel { 
            get {
                string experianceLevel = "Learning...";

                if (SkillPoints > 2)
                {
                    experianceLevel = "Novice";
                }

                if (SkillPoints > 5)
                {
                    experianceLevel = "Intermediate";
                }

                if (SkillPoints > 9)
                {
                    experianceLevel = "Expert";
                }

                if (SkillPoints > 10)
                {
                    experianceLevel = "Expert ++";
                }

                return experianceLevel;
            } 
        }
    }
}
