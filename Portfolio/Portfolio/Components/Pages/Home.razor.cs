using Portfolio.Skills;

namespace Portfolio.Components.Pages
{
    /// <summary>
    /// Main page for the portfolio site. All the content is presented here on this
    /// single page. 
    /// </summary>
    public partial class Home
    {
        /// <summary>
        /// Flag stores whether the image overlay is currently open or not. This value is
        /// bound to a MudOverlay component, so that overlay will react to the value changing. 
        /// </summary>
        private bool _imageOverlayOpen = false;
        
        /// <summary>
        /// Stores the path for an image to display when the image overlay is open. 
        /// </summary>
        private string _overlayImagePath = string.Empty;

        /// <summary>
        /// List of all Skill and SkillSection objects to be displayed. 
        /// </summary>
        private readonly Skills.SkillList _skillList = new();

        // Text to be rendered using MudMarkdown components. These should be stored in a resource
        // or a database in the future. 

        private string _aboutMeText = "Hi, my name is Tom. When I was about 9 years old I played Colin McRae Rally on PlayStation, and it became my dream to make " +
                                  "video games. After high school I went on to study game development, but then I found that I wanted to know more about how " +
                                  "computers work, so I went to study computer science at university. After university in Australia I wanted to try something " +
                                  "different for a little while, so I moved to Canada and got caught up in the bike industry. A little while turned into 7 years, " +
                                  "and then the global pandemic came along and shook everything up.\r\n \r\n Growing tired of working as a mechanic, and feeling " +
                                  "out of touch with the computing industry, I decided to go back to school and pursue a master's degree in computer science. " +
                                  "Here I got a deeper appreciation for how operating systems and hardware work, and I indulged my fascination in the games console " +
                                  "hacking scene by taking cybersecurity and reverse engineering classes.\r\n \r\n So here I am, exactly 10 years after graduating " +
                                  "from my undergraduate degree I am graduating again. I'm still interested in making games, but more than that, I am simply " +
                                  "interested in making (and breaking) just about anything! That's where my interest in software lies, in the sheer joy of creating " +
                                  "things that I, and other people, can use.\r\n \r\n When I'm not working on digital things, I like to be outside, it's hard not " +
                                  "to when you live in a place like British Columbia. I'm involved in the usual things like hiking, biking, and snowboarding. But " +
                                  "that love of rallying from my childhood never died, and in an effort to always learn new and different skills I got my amateur " +
                                  "radio license in 2023 so that I could help volunteer at the western rounds of the Canadian Rally Championship. And hopefully at " +
                                  "some point in the future I'll be able to experience the thrill from inside the car as well.";

        private readonly string _tildeExperienceMarkdown = "###### **Technologies:** Objective-C | iOS | Xcode \r\n" +
                                                  "Tilde was a short term project I worked on during the summer holiday following the end of university in 2013. \r\n\r\nTilde is an iPad application that was commissioned by the founders of Tilde (www.tilde.net.au). The application was used as an interactive gallery during the first Tilde New Music Festival in 2014, where patrons could listen to audio works produced by artists exhibiting at the festival. Patrons could also read more about the artists, their works, and learn more about products the artists had for sale at the festival. \r\n\r\nThe app was on display to the public at the Tilde New Music Mini Festival on January 26th 2014 and based on feedback taken from surveys at the festival the app was considered an overall success. \r\n\r\nThis was the first iOS application I designed and developed and can be considered a prototype featuring a vertical slice of the full functionality desired for future versions of the Tilde app.";

        private readonly string _dlaExperienceMarkdown = "###### **Technologies:** C# | Visual Studio | Monogame | Xamarin.iOS \r\n " +
                                                         "Digital Lab Assistant was my final year project as part of my Computer Science degree at La Trobe University, and I continued work on the project as an intern with Quantum Victoria. \r\n\r\nIn summary Digital Lab Assistant is an iPad application designed to increase learning engagement in secondary school science classes. Students receive instructions for their lab practical classes through the application and input their results back into pre-defined result fields. The results of the lab class are compiled into a digital report for marking purposes. \r\n\r\nKey features of Digital Lab Assistant\r\n* Lab Editor - Allows content creators to produce new labs on the iPad\r\n* Lab Viewer - Allows students to participate in labs\r\n* MyDLA - Provides search capabilities to let creators and participants find existing labs, create new labs, and manage their profile. \r\n* Server Backend - Performs data storage and data management operations\r\n\r\nKey Technical Features\r\n* Written on top of Mono - Allows the application to be compiled for iPad and PC, with plans for an Android implementation after the initial release. \r\n* Implemented using XNA - The use of XNA has meant that the application can be structured more like a game and aids in the development of \"gamification\" features\r\n\r\nMy position on the project primarily involved:\r\n* Application Design - Along with the rest of the team I was involved in designing the overall look of the application\r\n* Domain Modelling - In partnership with another team member I had a large input into the overall design of the software components of the application\r\n* Cross Platform Framework Development - One of my major coding responsibility was writing the framework code that allowed the application to compile and run on both iOS and Windows\r\n* User Interface Development - To further increase the usability of the application I wrote a custom UI system for the Digital Lab Assistant, which allowed the team to forgo the use of the business like iOS user interface system";

        private readonly string _hoeExperienceMarkdown = "###### **Technologies:** C++ | Visual Studio | Windows | Xbox 360 | PlayStation 3 | Perforce | SN Systems ProDG \r\n " + 
                                                         "As part of a four month internship at Transmission Games I worked on the game Heroes Over Europe, released for XBOX 360, PlayStation 3 and PC in 2009.\r\n\r\nDuring the internship I was part of the audio programming team and wrote and debugged C++ code. I worked alongside two other programmers and the project sound designer. I also reported to programming leads and the project producer. My contributions to the project included:\r\n* Implementing boat sound effects\r\n* Adding sound effects to levels using the in house level design tools\r\n* Tweaking sound effect parameters in the project database\r\n* Adding volume ducking to improve in games voice overs\r\n* Debugging various in game sound effects during the project beta phase";

        private readonly string _kleptocratExperienceMarkdown = "###### **Technologies:** C# | Visual Studio | Unity \r\n " +
                                                                "Kleptocrat was developed as part of Georgia Tech's Video Game Design Class. This was a semester long " +
                                                                "project where groups of 5 students were tasked with designing and implementing a 3D game in the Unity game " +
                                                                "engine. Kleptocrat is a stealth game where the player must navigate a level, steal and item, and make it to " +
                                                                "an extraction point. Along the way the player will encounter AI guards that patrol the level who can sense the " +
                                                                "player by sight and sound. If they catch you it's game over and you'll have to try again.\r\n\r\n" +
                                                                "My major contributions to the project were\r\n" +
                                                                "* Event system inspired by Ryan Hipple's [talk at Unite Austin 2017](https://www.youtube.com/watch?v=raQ3iHhE_Kk&ab_channel=Unity) \r\n" +
                                                                "* Audio system featuring 2D and 3D audio effects \r\n" +
                                                                "* Scene controller that managed level loading and unloading \r\n" +
                                                                "* AI civilians \r\n" +
                                                                "* Selection and placement of sound effects \r\n" +
                                                                "* Decoration of levels using the [polyperfect Steampunk Asset Pack](https://assetstore.unity.com/packages/3d/props/poly-steampunk-pack-265079)";

        private readonly string _dlaInternshipMarkdown = "Quantum Victoria, the client for the Digital Lab Assistant project, invited me to join them as an intern to continue work " +
                                                         "on the project part-time for an additional 6 months. During this time I finalised incomplete features, fixed bugs, wrote " +
                                                         "documentation and prepared the application for release on the App Store. You can read more about the Digital Lab " +
                                                         "Assistant project [here](#dla).";

        private readonly string _aieEducationMarkdown = "The Advanced Diploma course offered by the AIE was a 2 year course which taught both software and game development skills. " +
                                                        "During the first year of the course I learned C++ while working on small game projects. I'll forever be grateful that I learned " +
                                                        "programming this way, rather than starting out with a text editor and a terminal like I did in so many later university courses.\r\n\r\n" +
                                                        "In the second year of the course I worked on a year long game project from which the team I was in produced Shadow, a 3rd person puzzle " +
                                                        "game where the player moves through a light and dark version of the same world, where they must remain in the shadows at all times. " +
                                                        "All remnants of this project have been lost, but if I ever manage to find them on an old hard drive somewhere I will add Shadow to the " +
                                                        "projects section.\r\n\r\n " +
                                                        "During the second year of the course I also undertook an internship at a local development studio, Transmission Games, which you can " +
                                                        "find out more about [here](#hoe).";

        private readonly string _ltuEducationMarkdown = "After a single semester at Deakin University in 2009 I chose to instead enrol at La Trobe University starting in 2011. Here I was able to " +
                                                        "undertake some of the classic computer science classes like operating systems, discrete mathematics, linear algebra, and data structures and algorithms. I also " +
                                                        "took more game technologies classes, and learned some new languages like C# and Java.\r\n\r\n" +
                                                        "During the second year of the course I did a study abroad semester at Linnaeus University in Sweden, which was one of the most " +
                                                        "valuable life experiences I have ever had and is still a fond memory. Jag kan talar lite Svenska, men varje år jag glömmer lite mer.\r\n\r\n" +
                                                        "During the final year of the course I completed a year long industry project, the Digital Lab Assistant, which you can learn more about [here](#dla).";

        private readonly string _gtEducationMarkdown = "7 years after graduating from my undergraduate degree I finally found myself wanting to get into the computing industry, but I felt like too much " +
                                                       "time had passed and that I would no longer be a competitive candidate when applying for jobs. This was also during the second year of the pandemic and " +
                                                       "I was fortunate enough to still have a stable job so I was not immediately in need of the career change. I discovered Georgia Tech's online master's program " +
                                                       "and found that it was the perfect fit for me due to the challenges posed by the pandemic and my geographic location.\r\n\r\n" +
                                                       "I chose to take the computing systems specialisation onto which I added a number of cybersecurity focused electives. This allowed me " +
                                                       "to improve my knowledge in:\r\n\r\n" +
                                                       "* How computer hardware works in High Performance Computer Architecture\r\n\r\n" +
                                                       "* The design and implementation of operating systems Graduate Introduction to Operating Systems and Advanced Operating Systems\r\n\r\n" +
                                                       "* Cybersecurity defense strategies in Introduction to Information Security, Network Security, System and Network Defenses\r\n\r\n" +
                                                       "* Cybersecurity attack strategies in Advanced Malware Analysis and Reverse Engineering and Binary Exploitation\r\n\r\n" +
                                                       "Much of what I worked on at Georgia Tech was small individual projects. However, during my final semester I completed a video game project " +
                                                       "in a team of five people which you can learn more about [here](#kleptocrat).\r\n\r\n" +
                                                       "My proudest moment during my master's studies was completing Graduate Algorithms, a class with a reputation for both its high quality and " +
                                                       "high difficulty, the first time around with an A grade despite my noted weaknesses with mathematics.";

        private readonly string _tuningHubExperienceMarkdown = "###### **Technologies:** C# | Visual Studio | Blazor | MudBlazor | IIS | Entity Framework | SQL Server | Plotly | + more \r\n " + 
                                                               "I designed, developed and deployed 'Tuning Hub', a web application that will assist Vorsprung staff, dealers, and customers in tuning the new Telum mountain " +
                                                               "bike shock damper and spring. \r\n\r\nKey technological features: \r\n- Built on Microsoft's Blazor framework with MudBlazor providing consistent and clean " +
                                                               "user interface components\r\n- Uses Microsoft SQL Server for data persistence, and Entity Framework for object-relational mapping\r\n- Deployed on an IIS " +
                                                               "webserver running on Windows Server 2019\r\n- 2D and 3D data visualisations implemented with Plotly.Blazor, a C# wrapper for the Plotly graphing library\r\n\r\n" +
                                                               "This was a solo project where I was responsible for all aspects of design and development. I learned a lot during this project, not just about new technologies " +
                                                               "but also how to move and adapt quickly in the face of changing requirements and schedules.";

        private readonly string _webstoreToolsExperienceMarkdown1 = "###### **Technologies:** C# | Visual Studio | Blazor | MudBlazor \r\n" +
                                                                    "This is a set of 3 tools developed at different times for the Vorsprung Suspension web store. Each fulfils a " +
                                                                    "different role in helping customers with the bicycle suspension upgrade components that Vorsprung sells. The tools " +
                                                                    "are built on the same platform as the [Tuning Hub](#tuninghub).\r\n\r\n" +
                                                                    "**Smashpot Spring Rate Calculator**\r\n" +
                                                                    "The Smashpot is a coil conversion kit for mountain bike suspension forks. The spring rate calculator was " +
                                                                    "developed in response to numerous phone calls every day asking for the spring rate recommendations because " +
                                                                    "the published chart was too difficult to decode. Better yet, the tool is able to collect far more information " +
                                                                    "about a riders preferences to produce better recommendations. For example, two riders of the same weight on " +
                                                                    "the same fork but with vastly different riding styles may require totally different setups which lean towards " +
                                                                    "a stiffer or softer spring rate. Since adding the tool to the [Smashpot product page](https://vorsprungsuspension.com/collections/smashpot-all/products/smashpot-fork-coil-conversion-system-kit-fox) " +
                                                                    "on the web store the number of daily calls and emails regarding spring rates dropped significantly.\r\n\r\n";
                                                                   
        private readonly string _webstoreToolsExperienceMarkdown2 = "**Compatibility Checker**\r\n" + 
                                                                    "Vorsprung makes 3 primary upgrade components that can be installed in suspension forks from 4 up to different " +
                                                                    "manufacturers, with up 13 different fork models per manufacturer, spanning up to 8 model years. Needless to say " +
                                                                    "this can make it difficult for customers to know which upgrades are compatible with their forks. For a long time each " +
                                                                    "upgrade component product page had a chart that listed the compatible fork models, but the charts were often hard to " +
                                                                    "read and were also difficult to maintain.\r\n\r\n" +
                                                                    "The compatibility checker tool takes the 3 basic pieces of information that are needed " +
                                                                    "to determine compatibility and compares them against a master spreadsheet with all the compatibility information encoded into it. " +
                                                                    "This takes much of the guess work out of determining product compatibility and greatly reduced the number of calls an emails " +
                                                                    "received regarding compatibility.\r\n\r\n" +
                                                                    "The compatibility checker tool can be found on the various product pages on the [Vorsprung web store](https://vorsprungsuspension.com/collections/secus-all/products/secus-fork-air-spring-upgrade-kit-fox-rockshox-forks-2021).\r\n\r\n";

        private readonly string _webstoreToolsExperienceMarkdown3 = "**Product Recommender**\r\n" +
                                                                    "The final tool is the Product Recommender. Often a customer won't even know which upgrade component is right for them, let alone if " +
                                                                    "a particular component is compatible with their fork. The Product Recommender asks prospective customers a number of questions " +
                                                                    "about their bike and their riding preferences and then uses this information along with the master compatibility " +
                                                                    "spreadsheet to make product recommendations. Sometimes there may only be one option available to a customer, but often there " +
                                                                    "all 3 fork upgrade components will be compatible, so the tool recommends the products in order based on what it thinks is going " +
                                                                    "to best suit the rider given their answers to the questions asked.\r\n\r\n" +
                                                                    "If a customer still isn't sure what direction to head in they can email Vorsprung directly from the tool. Their query " +
                                                                    "is sent as a regular email, but with tags added to the subject line so that the email can be correctly categorised by Vorsprung's " +
                                                                    "CMS tool.";

        private readonly string _portfolioProjectMarkdown = "###### **Technologies:** C# | Visual Studio | Blazor | MudBlazor | Linux | NGINX\r\n\r\n" +
                                                            "I started this portfolio website around the time I finished my graduate studies as a way to showcase my skills with " +
                                                            "more detail and less noise than nwhat is found on LinkedIn. You can find the repository for it on [GitHub](https://github.com/waffleShirt/portfolio-site). " +
                                                            "The site is built on the latest version of Microsoft's Blazor framework. As I am much better at backend than frontend " +
                                                            "development the site uses the [MudBlazor](https://mudblazor.com/) component library to create a more consistent look " +
                                                            "and feel than I could ever hope to achieve on my own. The site is deployed on a virtual private server running " +
                                                            "Ubuntu 22.04 with the NGINX webserver.";

        protected override void OnInitialized()
        {
            SkillSection programmingLanguages = new()
            {
                SectionTitle = "Programming Languages"
            };

            programmingLanguages.SkillList.Add(new Skills.Skill()
            {
                Name = "C#",
                Icon = "devicon-csharp-plain",
                Proficiency = Skills.Skill.Level.Advanced,
                Description = "This has been my primary language for many years. I used it to develop the Vorsprung Tuning Hub, Kleptocrat, Digital Lab Assistant, and this website!"
            });
            programmingLanguages.SkillList.Add(new Skills.Skill()
            {
                Name = "C++",
                Icon = "devicon-cplusplus-plain",
                Proficiency = Skills.Skill.Level.Intermediate,
                Description = "Still my first love when it comes to programming. I used it regularly when I was more heavily involved in game development. " +
                              "I'm a little rust these days, especially regarding modern standards like C++11 and beyond." 
            });
            programmingLanguages.SkillList.Add(new Skills.Skill()
            {
                Name = "C",
                Icon = "devicon-c-plain",
                Proficiency = Skills.Skill.Level.Intermediate,
                Description = "Operating systems courses during my graduate studies had a heavy emphasis on using C and multithreading."
            });
            programmingLanguages.SkillList.Add(new Skills.Skill()
            {
                Name = "Python",
                Icon = "devicon-python-plain",
                Proficiency = Skills.Skill.Level.Intermediate,
                Description = "A lot of classes during my graduate studies used Python. My favourite use for Python was writing pwntools scripts for a binary exploitation class."
            });
            programmingLanguages.SkillList.Add(new Skills.Skill()
            {
                Name = "x86/x64 Assembly",
                Proficiency = Skills.Skill.Level.Beginner,
                Description = "I read a lot of assembly language during malware analysis and binary exploitation classes at Georgia Tech. I can read it, I can find information " +
                              "in the Intel reference manuals, but I'd be hard pressed to write anything beyond a simple program."
            });

            _skillList.SkillSections.Add(programmingLanguages);

            SkillSection tools = new()
            {
                SectionTitle = "Tools"
            };

            tools.SkillList.Add(new Skills.Skill()
            {
                Name = "Visual Studio",
                Icon = "devicon-visualstudio-plain",
                Proficiency = Skills.Skill.Level.Advanced,
                Description = "I have used Visual Studio for just about every project I have worked on since 2007."
            });
            tools.SkillList.Add(new Skills.Skill()
            {
                Name = "Visual Studio Code",
                Icon = "devicon-vscode-plain",
                Proficiency = Skills.Skill.Level.Intermediate,
                Description = "I still prefer Visual Studio for most projects, but I find that VS Code has more information available when it comes to remote development " +
                              "and debugging for Linux."
            });

            tools.SkillList.Add(new Skills.Skill()
            {
                Name = "Git",
                Icon = "devicon-git-plain",
                Proficiency = Skills.Skill.Level.Intermediate,
                Description = "I remember when SVN was cool, and I was probably a bit late to the Git game. The biggest team project I have done that used Git only " +
                              "had 5 team members, so I haven't gotten deep into the weeds with it yet, but I try to be a good citizen when using it."
            });
            tools.SkillList.Add(new Skills.Skill()
            {
                Name = "Ghidra",
                Proficiency = Skills.Skill.Level.Intermediate,
                Description = "I spent quite a bit of time in Ghidra during malware analysis and binary exploitation classes at Georgia Tech, including using its " +
                              "Java scripting interface, and I hope to use it more in the coming years to improve my reverse engineering skills." 
            });
            tools.SkillList.Add(new Skills.Skill()
            {
                Name = "GDB",
                Proficiency = Skills.Skill.Level.Intermediate,
                Description = "I'll admit it, I was scared of GDB for a long time. But after having my head buried deep in GDB (and more specifically GDB with the pwndbg " +
                              "plugin) for a semester during a binary exploitation class, now I love it. The sheer amount of information that can be gleaned about the state " +
                              "of a process is amazing and using it improved my general debugging skills greatly."
            });
            tools.SkillList.Add(new Skills.Skill()
            {
                Name = "Unity",
                Icon = "devicon-unity-plain",
                Proficiency = Skills.Skill.Level.Beginner,
                Description = "I'd like to say that I am an intermediate level user with Unity, but after a semester developing Kleptocrat in it I feel like I only just " +
                              "scratched the surface of its enormous toolset."
            });

            _skillList.SkillSections.Add(tools);

            SkillSection operatingSystems = new()
            {
                SectionTitle = "Operating Systems"
            };

            operatingSystems.SkillList.Add(new Skills.Skill()
            {
                Name = "Windows",
                Icon = "devicon-windows11-plain",
                Proficiency = Skills.Skill.Level.Advanced,
                Description = "Windows has been my daily driver for as long as I have used a computer. I use it for development and am familiar with the " +
                              "Windows API documentation. I have deployed websites and databases on Sever 2019, which pushed me to improve my Windows system " +
                              "administration skills."
            });
            operatingSystems.SkillList.Add(new Skills.Skill()
            {
                Name = "Linux",
                Icon = "devicon-linux-plain",
                Proficiency = Skills.Skill.Level.Intermediate,
                Description = "I dabbled with Linux as a kid when I would build basic websites on a LAMP stack. But when I got to Georgia Tech my Linux skills really " +
                              "took off as I did systems programming in C, some basic kernel module development, and reverse engineered x86 and x64 applications " +
                              "compiled for Linux."
            });

            _skillList.SkillSections.Add(operatingSystems);

            SkillSection otherSkills = new()
            {
                SectionTitle = "Other Skills"
            };

            otherSkills.SkillList.Add(new Skills.Skill()
            {
                Name = "SolidWorks",
                Proficiency = Skills.Skill.Level.Beginner,
                Description = "I've done a couple of Udemy courses on SolidWorks and made a couple of basic objects that I had 3D printed."
            });

            _skillList.SkillSections.Add(otherSkills);
        }

        /// <summary>
        /// Opens the MudOverlay component that displays images in full screen when they are
        /// clicked on. 
        /// </summary>
        /// <param name="imagePath">Path to the image that should be displayed in its full resolution when the overlay is open.</param>
        private void OpenImageOverlay(string imagePath)
        {
            _imageOverlayOpen = true;
            _overlayImagePath = imagePath;
        }

        /// <summary>
        /// Closes the MudOverlay component that displays full screen images.
        /// </summary>
        private void CloseImageOverlay()
        {
            _imageOverlayOpen = false;
            _overlayImagePath = string.Empty;
        }
    }
}
