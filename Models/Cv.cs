namespace CVWebApp.Models
{
    public class Cv
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Statement {  get; set; }
        public List<string> Skills { get; set; }
        public List<string> Interests { get; set; }
        public List<Experience> WorkExperience { get; set; }
        public List<Project> Projects { get; set; }
        public List<Education> Education { get; set; }
        public List<Certificate> Certificates { get; set;}
    }
}
