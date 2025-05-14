using System.Diagnostics;
using CVWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CVWebApp.Controllers
{
    public class CVController : Controller
    {
        public IActionResult Index()
        {
            var cv = new Cv
            {
                Name = "Zenas Agada",
                Email = "agadazenas@gmail.com",
                Phone = "07478765084",

                Statement = "I am a hardworking, dedicated, and inquisitive" +
                " Computer Science student at the University of Nottingham," +
                " passionate about building real-world software solutions." +
                " I have a strong foundation in programming, problem-solving," +
                " and collaborative development, with a deep interest in" +
                " software engineering, game development, and digital innovation." +
                " My professional experiences—ranging from teaching assistance in" +
                " primary education to retail pharmacy support—have shaped my ability" +
                " to work well with both people and systems. I thrive in dynamic" +
                " environments and am always eager to learn and grow both" +
                " technically and personally.",

                Skills = new List<string> {
                "- Programming Languages: Java, C, Haskell, Python, HTML, SQL",
                "- Software Development: Agile methodology, pair programming, version control (Git), unit testing (JUnit)",
                "- Tools & Platforms: IntelliJ IDEA, VSCode, GitHub, MySQL, Eclipse","" +
                "- Concepts: Object-oriented programming, functional programming, databases, software engineering principles",
                "- Soft Skills: Communication, problem-solving, adaptability, teamwork, responsibility, and rapid learning" },

                Interests = new List<string> {
                "- Football – Enjoy both playing and watching, and have a keen interest in analytics and sports technology",
                "- Gaming & Game Development – Fascinated by the logic, mechanics, and storytelling behind interactive digital experiences",
                "- Technology and Business – Interested in how emerging technologies intersect with entrepreneurship and innovation",
                "- Volunteering – Keen on giving back to the community, particularly in education or youth-focused initiatives" },

                WorkExperience = new List<Experience>
            {
                new Experience
                {
                    JobTitle = "Trainee C# Developer",
                    Company = "Bincom Global",
                    Duration = "April 2025 - Present",
                    Description = "• Developed websites using C# and uploaded them to Microsoft Azure \r\n" +
                    "• Work using MVC architecture which has led to manageable code which is easy to read  "
                },

                new Experience
                {
                    JobTitle = "Sales Assistant",
                    Company = "Nuchem Pharmacy",
                    Duration = "Febuary 2018",
                    Description = "• Supported front-of-house operations in a busy local pharmacy\r\n" +
                    "• Maintained well-organized, clearly labeled, and fully stocked shelves in" +
                    " accordance with pharmacy regulations and hygiene standards\r\n" +
                    "• Handled prescriptions with accuracy and attention to detail, ensuring patient" +
                    " safety and confidentiality\r\n" +
                    "• Operated the till during peak hours, managed queues efficiently, and provided" +
                    " a positive customer service experience\r\n" +
                    "• Communicated regularly with pharmacists, customers, and team members to ensure" +
                    " smooth day-to-day operations\r\n" +
                    "• Learned the importance of precision, empathy and integrity—qualities that I now" +
                    " bring to all aspects of my work"

                },

                new Experience
                {
                    JobTitle = "Teaching Assistant",
                    Company = "Eastbury Primary School",
                    Duration = "Febuary 2018",
                    Description = "• Assisted Year 1 classroom teacher in planning and delivering lessons\r\n" +
                    "• Supported pupils during class activities, encouraging their academic and social development\r\n" +
                    "• Helped maintain classroom order and ensured student safety during transitions" +
                    " (e.g., assemblies, break times)\r\n" +
                    "• Learned how to tailor communication styles to young learners, improving my emotional intelligence" +
                    " and teamwork\r\n" +
                    "• Played a role in fostering a nurturing and inclusive learning environment by working closely with" +
                    " teaching staff and students"
                }
            },

                Projects = new List<Project>
            {
                new Project
                {
                    ProjectTitle = "2D PLATFORMER IN UNITY USING C#",
                    Duration = "January 2024 - May 2024",
                    Description = "• Used Unity's systems to improve on the game I made in 2023 \r\n" +
                    "• Used A*'s AI Pathfinder to control the AI enemies and make them approach and" +
                    " attack the player \r\n" +
                    "• Implemented hitboxes and hurtboxes for the enemies and the players \r\n" +
                    "• Implemented unity's physics systems to simulate collision and movement \r\n" +
                    "• Designed the three elements of fire, water, and wind which all interacted with" +
                    " each other to create different effects when used on enemies \r\n" +
                    "• Used tile maps to design detailed and varied levels \r\n" +
                    "• Debugged many issues like animations appearing at incorrect moments or" +
                    " incorrect physics behaviour \r\n" +
                    "• Performed user testing and feedback to improve flaws in the game like reducing" +
                    " the difficulty at the start of the game or improving how the main character felt "
                },

                new Project
                {
                    ProjectTitle = "PERIOD TRACKING APP PROJECT",
                    Duration = "September 2023 - December 2023",
                    Description = "• Led a group of 6 to develop a Period Tracking App on Android Studio" +
                    " with Java which earned a First grade \r\n" +
                    "• Held weekly meetings to monitor and assign tasks which led to steady progress over" +
                    " 12 weeks \r\n" +
                    "• Used Trello to visualise tasks and progress which provided a platform for clear" +
                    " communication on where the project was \r\n" +
                    "• Created prototypes for each activity in Figma, providing the team with a clear" +
                    " vision to follow and a thorough understanding of the vision \r\n" +
                    "• Studied and followed the ISO 9001 standard which kept the project quality high \r\n" +
                    "• Developed the home page in Android Studio which led to all the other activities" +
                    " and was the basis on which the other team members built the other activities \r\n" +
                    "• Led the design of a presentation which focused on software quality practices used" +
                    " such as an agile coding style along with unit and integration testing showing" +
                    " our commitment to creating a quality product "

                },

                new Project
                {
                    ProjectTitle = "MUSIC PLAYER IN ANDROID STUDIO USING JAVA",
                    Duration = "September 2023 - December 2023",
                    Description = "• Made use of activities and a live service to play the music stored" +
                    " in the music file of a phone \r\n" +
                    "• Developed song select screen using list view, the player using buttons, settings" +
                    " page which changed background colour and playback speed, and a live service which" +
                    " played the song "

                },

                new Project
                {
                    ProjectTitle = "IMAGE SEGMENTATION",
                    Duration = "September 2022 - May 2023",
                    Description = "• Worked with a group to develop image segmentation software which" +
                    " parsed and displayed medical images  \r\n" +
                    "• Collaborated to create different parts of the app and met weekly to monitor progress" +
                    " and assign tasks  \r\n" +
                    "• Used Jira to organise, view, and complete the tasks we assigned at each meeting  \r\n" +
                    "• Implemented file readers for NIFTI and DICOM files  \r\n" +
                    "• Developed features such as DICOM and NIFTI file readers, 2D and 3D file readers," +
                    " data-to-image conversion functions, 3D image slider which helped earn a First grade" +
                    " for the project"
                }
            },

                Education = new List<Education>
            {
                new Education
                {
                    SchoolName = "University of Nottingham",
                    Subject = new List<string> {"Computer Science"},
                    Grade = new List<string> {"2:2"},
                    Duration = "September 2021 - July 2024"
                },

                new Education
                {
                    SchoolName = "Brampton Manor Academy",
                    Subject = new List<string> {"Physics", "Mathematics", "Further Mathematics"},
                    Grade = new List<string> {"A*","A*","A"},
                    Duration = "September 20119 - August 2021"
                },

                new Education
                {
                    SchoolName = "All Saints Catholic School & Technology College",
                    Subject = new List<string> {"Physics",
                        "Biology",
                        "Chemistry",
                        "Mathematics",
                        "Computer Science",
                        "English Literature",
                        "English Language"},
                    Grade = new List<string> {"9", "9", "8", "8", "7", "6", "6"},
                    Duration = "September 2014 - August 2019"
                }
            },

                Certificates = new List<Certificate>
            {
                new Certificate
                {
                    Title = "Certified in Cybersecurity",
                    IssuingOrg = "ISC2",
                    IssueDate = "January 2025"
                }
            }
            };

            return View(cv);
        }
    }
}

