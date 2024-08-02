using Danielson.Data.DataModels;
using Microsoft.AspNetCore.Components;

namespace Danielson.Data.Domains {

    public static class DomainList {

        public static List<DomainObject> Domains { get; set; } = [
            new() {
                DomainEnum = DomainEnum.One,
                Title = "Domain 1: Planning and Preparation",
                DescriptionHtml = (MarkupString)"The components in <strong>Domain 1: Planning & Preparation</strong> describe how teachers organize instruction for student learning. It is difficult to overstate the importance of planning and preparation. One could argue that a teacher’s role is not so much to teach as it is to arrange for learning. That is, a teacher’s essential responsibility is to prepare for learning activities such that students learn important content and develop skills, mindsets, and habits to be successful in school and beyond.",
                Components = [
                    new() {
                        DomainEnum = DomainEnum.One,
                        ComponentOrder = 1,
                        Title = "Component 1a: Applying Knowledge of Content and Pedagogy",
                        Code = "1a",
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: The teachers’ understanding of content and pedagogy fosters deeper learning, student agency, and intellectual dispositions such as curiosity, reasoning, and reflection.",
                    },
                    new() {
                        DomainEnum = DomainEnum.One,
                        ComponentOrder = 2,
                        Title = "Component 1b: Knowing and Valuing Students",
                        Code = "1b",
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: The teacher’s knowledge of students is extensive and fosters student learning and development to support academic and personal success.",
                    },
                    new() {
                        DomainEnum = DomainEnum.One,
                        ComponentOrder = 3,
                        Title = "Component 1c: Setting Instructional Outcomes",
                        Code = "1c",
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: Instructional outcomes represent high-level learning of important content and support student autonomy, curiosity, and intellectual risk-taking.",
                    },
                    new() {
                        DomainEnum = DomainEnum.One,
                        ComponentOrder = 4,
                        Title = "Component 1d: Using Resources to Support Students",
                        Code = "1d",
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: The teacher makes deliberate decisions in the use of instructional materials and other resources to meet individual student needs and support student autonomy and intellectual engagement.",
                    },
                    new() {
                        DomainEnum = DomainEnum.One,
                        ComponentOrder = 5,
                        Title = "Component 1e: Planning Coherent Instruction",
                        Code = "1e",
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: Learning experiences prioritize the needs of individual students, ensure all students can meet the intended outcomes, and support student assumption of responsibility for learning.  ",
                    },
                    new() {
                        DomainEnum = DomainEnum.One,
                        ComponentOrder = 6,
                        Title = "Component 1f: Assessing Student Progress",
                        Code = "1f",
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: Students will have the opportunity to demonstrate mastery of content and analyze their own progress through multiple, flexible assessments.",
                    },
                ],
            },
            new() {
                DomainEnum = DomainEnum.Two,
                Title = "Domain 2: Learning Environments",
                DescriptionHtml = (MarkupString)"The components of <strong>Domain 2: Learning Environments</strong> describe conditions and qualities of environments that are conducive to learning and support student success. These aspects of teaching are not associated with the learning of any particular content but rather support the understanding of all content and attend to the social-emotional needs of students. The components of Domain 2 center on establishing a safe and respectful classroom environment and require explicit attention and responsiveness to the individual identities of students, including race and culture, and the values of the broader community the school serves. Cultivating an inviting culture for learning focused on student wellbeing and creating a safe place for academic risk taking and the development of habits and mindsets that support student success are the ultimate goal of these components of practice.",
                Components = [
                    new() {
                        DomainEnum = DomainEnum.Two,
                        ComponentOrder = 1,
                        Title = "Component 2a: Cultivating Respectful and Affirming Environments",
                        Code = "2a",
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: Students play an active role in creating learning environments characterized by a sense of community, where each member feels safe, valued, and connected.",
                    },
                    new() {
                        DomainEnum = DomainEnum.Two,
                        ComponentOrder = 2,
                        Title = "Component 2b: Fostering a Culture for Learning",
                        Code = "2b",
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: Students play an active role in establishing a culture that consistently fosters dialogue, joyful inquiry, reflection, and growth, allowing all students to flourish.",
                    },
                    new() {
                        DomainEnum = DomainEnum.Two,
                        ComponentOrder = 3,
                        Title = "Component 2c: Maintaining Purposeful Environments",
                        Code = "2c",
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: Students have a voice and play an active role in designing and adjusting routines and procedures that actively create a respectful learning environment and support the growth of each community member.",
                    },
                    new() {
                        DomainEnum = DomainEnum.Two,
                        ComponentOrder = 4,
                        Title = "Component 2d: Supporting Positive Student Behavior",
                        Code = "2d",
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: Members of the classroom community consistently and independently display positive behavior and seek opportunities to build a better classroom and school community.",
                    },
                    new() {
                        DomainEnum = DomainEnum.Two,
                        ComponentOrder = 5,
                        Title = "Component 2e: Organizing Spaces for Learning",
                        Code = "2e",
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: Learning spaces are thoughtfully co-designed and modified as needed by members of the learning community to address the needs of individuals and create collaborative, joyful spaces for all to learn and grow.",
                    },
                ],
            },
            new() {
                DomainEnum = DomainEnum.Three,
                Title = "Domain 3: Learning Experiences",
                DescriptionHtml = (MarkupString)"The components of <strong>Domain 3: Learning Experiences</strong> describe the engagement of students in learning experiences and reflect the primary mission of schools: enhancing student learning and growth. These components are unified through a vision of students developing complex understanding, achieving goals, cultivating purpose, and participating in a community of learners. The components of the other domains provide a foundation for purposeful, engaging, and successful learning experiences. In many ways, success in Domain 3 is the direct result of success in Domains 1 and 2 in particular. Teachers prepare experiences that are grounded in deep understanding of the content, aligned with appropriate standards, designed to engage students in important work, and planned or adapted with the goals, strengths, needs, and lives of each student in mind. Learning experiences can only be consistently successful for each student when the environment, nurtured by the teacher in collaboration with students, is a space where students are affirmed and challenged. ",
                Components = [
                    new() {
                        DomainEnum = DomainEnum.Three,
                        ComponentOrder = 1,
                        Title = "Component 3a: Communicating About Purpose and Content",
                        Code = "3a",
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: Communication about purpose and content is rich, nuanced, and relevant to students inviting them to think critically and contribute intellectually; it encourages curiosity and supports student autonomy.",
                    },
                    new() {
                        DomainEnum = DomainEnum.Three,
                        ComponentOrder = 2,
                        Title = "Component 3b: Using Questioning and Discussion Techniques",
                        Code = "3b",
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: Students intentionally use questioning and discussion to develop their own and others’ thinking, reasoning skills, and habits of reflection.",
                    },
                    new() {
                        DomainEnum = DomainEnum.Three,
                        ComponentOrder = 3,
                        Title = "Component 3c: Engaging Students in Learning",
                        Code = "3c",
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: Students take initiative to increase the challenge or complexity of learning experiences and make suggestions for modifications that increase meaning and relevance.",
                    },
                    new() {
                        DomainEnum = DomainEnum.Three,
                        ComponentOrder = 4,
                        Title = "Component 3d: Using Assessment for Learning",
                        Code = "3d",
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: Students take initiative to analyze their own progress against a clear standard in order to achieve the outcome and identify new opportunities and challenges.",
                    },
                    new() {
                        DomainEnum = DomainEnum.Three,
                        ComponentOrder = 5,
                        Title = "Component 3e: Responding Flexibly to Student Needs",
                        Code = "3e",
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: Based on self-monitoring and reflection, students voice their needs, ask questions, and make suggestions that lead to adjustments and modifications or spark new learning opportunities.",
                    }
                ]
            },
            new() {
                DomainEnum = DomainEnum.Four,
                Title = "Domain 4: Principled Teaching",
                DescriptionHtml = (MarkupString)"The components of <strong>Domain 4: Principled Teaching</strong> capture and reflect the practices of educators that extend beyond their classrooms or any single learning experience. These activities are critical to preserving and enhancing the profession and to the success of students. Teaching is a purposedriven profession. It is a calling. Those who take up the work have a lasting and profound impact on the lives of students. Their purpose, and the purpose of education more broadly, is not solely to impart academic knowledge; it is the intellectual and moral development of human beings who will themselves flourish and help create a just and flourishing society.",
                Components = [
                    new() {
                        DomainEnum = DomainEnum.Four,
                        ComponentOrder = 1,
                        Title = "Component 4a: Engaging in Reflective Practice",
                        Code = "4a",
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: The teacher consistently engages in reflective practice that leads to a thorough and accurate assessment of the success of instruction, exploration of new ideas and approaches, and ongoing changes to practices and mindsets focused on supporting students who need it most.",
                    },
                    new() {
                        DomainEnum = DomainEnum.Four,
                        ComponentOrder = 2,
                        Title = "Component 4b: Documenting Student Progress",
                        Code = "4b",
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: Students monitor progress toward mastery and their own attainment of learning and development goals; they analyze and discuss their progress with the teacher and those who support them.",
                    },
                    new() {
                        DomainEnum = DomainEnum.Four,
                        ComponentOrder = 3,
                        Title = "Component 4c: Engaging Families and Communities",
                        Code = "4c",
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: The teacher’s engagement of students, families, and communities focuses on supporting the academic and personal success of each student, especially students who have been marginalized.",
                    },
                    new() {
                        DomainEnum = DomainEnum.Four,
                        ComponentOrder = 4,
                        Title = "Component 4d: Contributing to School Community and Culture",
                        Code = "4d",
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: The teacher takes a leadership role in defining, modeling, and holding self and peers accountable to the values and intellectual life of the school, leading with an emphasis on meeting the needs of students and families who have been marginalized.",
                    },
                    new() {
                        DomainEnum = DomainEnum.Four,
                        ComponentOrder = 5,
                        Title = "Component 4e: Growing and Developing Professionally",
                        Code = "4e",
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: The teacher appropriately exercises autonomy to direct professional learning for themselves and their peers, taking a leadership role in the school, setting direction, and supporting colleagues to engage in inquiry and innovation.",
                    },
                    new() {
                        DomainEnum = DomainEnum.Four,
                        ComponentOrder = 6,
                        Title = "Component 4f: Acting Ethically on Behalf of Students",
                        Code = "4f",
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: The teacher is a leader in the school in defining, modeling, and upholding high standards of ethical practice and wise decision making that prioritize the needs of all students, especially those who have been marginalized or undeserved.",
                    }
                ]
            }
        ];
    }
}