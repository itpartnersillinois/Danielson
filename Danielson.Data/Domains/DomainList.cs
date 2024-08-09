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
                        AnswerText = [
                            "The teacher lacks sufficient knowledge of content and pedagogy to support student learning of the content.",
                            "The teachers’ understanding of content and pedagogy partially supports student learning of the content.",
                            "The teachers’ understanding of content and pedagogy supports student learning of the content.",
                         ]
                    },
                    new() {
                        DomainEnum = DomainEnum.One,
                        ComponentOrder = 2,
                        Title = "Component 1b: Knowing and Valuing Students",
                        Code = "1b",
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: The teacher’s knowledge of students is extensive and fosters student learning and development to support academic and personal success.",
                        AnswerText = [ "The teacher lacks sufficient knowledge of students to support student learning or development.  ",
"The teacher’s knowledge of students’ identities, as well as their strengths and needs partially supports learning and development.  ",
"The teacher’s knowledge of students supports learning and development, and enables the teacher to build upon student assets.   "
]
                    },
                    new() {
                        DomainEnum = DomainEnum.One,
                        ComponentOrder = 3,
                        Title = "Component 1c: Setting Instructional Outcomes",
                        Code = "1c",
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: Instructional outcomes represent high-level learning of important content and support student autonomy, curiosity, and intellectual risk-taking.",
                        AnswerText = [
"Instructional outcomes are not identified, are not rigorous, or are inappropriate.   ",
"Instructional outcomes are moderately rigorous and are appropriate for most students in the class.   ",
"Instructional outcomes are rigorous and appropriate for students. "
]
                    },
                    new() {
                        DomainEnum = DomainEnum.One,
                        ComponentOrder = 4,
                        Title = "Component 1d: Using Resources Effectively",
                        Code = "1d",
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: The teacher makes deliberate decisions in the use of instructional materials and other resources to meet individual student needs and support student autonomy and intellectual engagement.",
                        AnswerText = [
"The teacher is not aware of, or does not appropriately or effectively use instructional materials and other resources to support student learning and development.   ",
"The teacher understands and uses instructional materials and other resources to support student learning and development, but these resources represent only a narrow band of what is available.    ",
"The teacher’s knowledge of instructional materials and other resources leads to discerning choices to support learning and development.  "
]
                    },
                    new() {
                        DomainEnum = DomainEnum.One,
                        ComponentOrder = 5,
                        Title = "Component 1e: Planning Coherent Instruction",
                        Code = "1e",
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: Learning experiences prioritize the needs of individual students, ensure all students can meet the intended outcomes, and support student assumption of responsibility for learning.  ",
                        AnswerText = [
"The design of learning experiences does not support student engagement with important content. ",
"Learning experiences are somewhat coherent in structure, within and across lessons, partially supporting students to meet the intended outcomes. ",
"Learning experiences are challenging and engaging; they are designed to meet the needs of students in the class.  "
]
                    },
                    new() {
                        DomainEnum = DomainEnum.One,
                        ComponentOrder = 6,
                        Title = "Component 1f: Designing and Analyzing Assessments",
                        Code = "1f",
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: Students will have the opportunity to demonstrate mastery of content and analyze their own progress through multiple, flexible assessments.",
                        AnswerText = [
"There is no plan for assessment or the assessments will not provide evidence that students have learned the intended outcomes. ",
"Assessments will partially help the teacher know that students have learned or are learning the intended outcomes. ",
"Assessments are planned throughout the instructional process and provide timely and valuable information to teachers and students.  "
]
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
                        AnswerText = [
"Students do not feel safe and valued; learning environments are characterized by negativity, disrespect, inappropriateness, insensitivity, and/or unresolved conflict. ",
"Learning environments are partially characterized by caring and respectful interactions. ",
"Learning environments are characterized by positive developmental relationships that are intentionally nurtured and celebrated.  "
]
                    },
                    new() {
                        DomainEnum = DomainEnum.Two,
                        ComponentOrder = 2,
                        Title = "Component 2b: Fostering a Culture for Learning",
                        Code = "2b",
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: Students play an active role in establishing a culture that consistently fosters dialogue, reflection, and growth, allowing all students to experience success.",
AnswerText = [
"The culture of the class is not conducive to learning and does not support development. ",
"The culture of the class is partially conducive to learning and development. ",
"The culture of the class is characterized by high expectations and supports students’ learning and development.  "
]
                    },
                    new() {
                        DomainEnum = DomainEnum.Two,
                        ComponentOrder = 3,
                        Title = "Component 2c: Maintaining Purposeful Environments",
                        Code = "2c",
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: Students have a voice and play an active role in designing and adjusting routines and procedures that actively create a respectful learning environment and support the growth of each community member.",
AnswerText = [
"Student learning and development are hindered by a lack of routines or inefficient classroom procedures.  ",
    "Classroom routines and procedures, established or managed primarily by the teacher and taught explicitly to students.",
"Shared routines and efficient procedures are largely student-directed and maximize opportunities for student learning and development.  "
]
                    },
                    new() {
                        DomainEnum = DomainEnum.Two,
                        ComponentOrder = 4,
                        Title = "Component 2d: Supporting Positive Student Behavior",
                        Code = "2d",
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: Students consistently and independently display positive behaviors and seek opportunities to build a better classroom community.",
 AnswerText = [
"There is little evidence of explicit modeling, instruction, or guidance related to positive student behavior. ",
"Positive behaviors are modeled by the teacher and occasionally taught explicitly. ",
"Students display positive behaviors, which are modeled by the teachers and reinforced to promote reflection and recalibration rather than compliance.  "
]
                   },
                    new() {
                        DomainEnum = DomainEnum.Two,
                        ComponentOrder = 5,
                        Title = "Component 2e: Organizing Spaces for Learning",
                        Code = "2e",
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: Learning spaces are thoughtfully co-designed and modified as needed by members of the learning community to address the needs of individuals and create collaborative, joyful spaces for all to learn and grow.",
AnswerText = [
"Learning spaces are unsafe, inaccessible, and/or not conducive to learning and development. ",
"Learning spaces are safe and accessible; the arrangement and use of resources partially support student learning and development. ",
"Learning spaces are thoughtfully designed to address the needs of individual learners within the context of shared experiences.  "
]
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
AnswerText = [
"Communication about purpose and content is unclear or confusing and hinders student learning.  ",
"Communication about purpose and content is mostly clear and accurate; it partially supports learning. ",
"Communication about purpose and content is accurate and clear to students; it supports their active engagement in learning experiences and models effective use of language.  "
]
                    },
                    new() {
                        DomainEnum = DomainEnum.Three,
                        ComponentOrder = 2,
                        Title = "Component 3b: Using Questioning and Discussion Techniques",
                        Code = "3b",
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: Students intentionally use questioning and discussion to develop their own and others’ thinking, reasoning skills, and habits of reflection.",
AnswerText = [
"Questioning and discussion are absent, low-level, or do not support learning and development. ",
"Questioning and discussion, primarily framed and led by the teacher, are used to support student learning and development. ",
"Questioning and discussion, framed or led by the teacher and students, effectively support critical thinking, reasoning, and reflection.  "
]
                    },
                    new() {
                        DomainEnum = DomainEnum.Three,
                        ComponentOrder = 3,
                        Title = "Component 3c: Engaging Students in Learning",
                        Code = "3c",
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: Students take initiative to increase the challenge or complexity of learning experiences; they think critically about a variety of issues and offere solutions; and they make suggestions for modifications that increase meaning and relevance.",
AnswerText = [
"Learning experiences do not require active intellectual engagement by students. ",
"Learning experiences partially engage students intellectually; the activities require students to do some thinking. ",
"Learning experiences support curiosity and exploration and encourage higher-order thinking; students engage in multiple ways and represent their ideas and responses through multiple means.  "
]
                    },
                    new() {
                        DomainEnum = DomainEnum.Three,
                        ComponentOrder = 4,
                        Title = "Component 3d: Using Assessment for Learning",
                        Code = "3d",
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: Students take initiative to analyze their own progress against a clear standard in order to achieve the outcome and identify new opportunities and challenges.",
AnswerText = [
"Formative assessment is not used during instruction or is not aligned to the instructional purpose of the lesson. ",
"Formative assessment partially supports student learning and development. ",
"The teacher and students use formative assessments to elicit evidence of understanding, analyze progress, and provide constructive feedback.  "
]
                    },
                    new() {
                        DomainEnum = DomainEnum.Three,
                        ComponentOrder = 5,
                        Title = "Component 3e: Responding Flexibly to Student Needs",
                        Code = "3e",
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: Based on self-monitoring and reflection, students voice their needs, ask questions, and make suggestions that lead to adjustments and modifications or spark new learning opportunities.",
AnswerText = [
"The teacher makes no adjustments to learning experiences, even when warranted, and is not responsive to student needs.  ",
"The teacher makes some adjustments to learning experiences and is responsive to student needs with partial success.  ",
"The teacher’s adjustments and responsiveness lead to deeper understanding for students and/or new learning experiences.  "
]
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
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: The teacher consistently engages in reflective practice based on multiple sources of evidence that results in the exploration of new ideas and approaches focused on supporting students who need it most.",
AnswerText = [
"The teacher does not appear to engage in reflective practice or misjudges the success of instruction.  ",
"The teacher’s reflective practice leads to some accurate assessment of student success of instruction but does not follow through with analysis and changes to practice.  ",
"The teacher’s reflective practice, based on consideration of evidence of student learning and development, leads to an accurate assessment of the success of instruction and results in specific changes and adjustments.  "
]
                    },
                    new() {
                        DomainEnum = DomainEnum.Four,
                        ComponentOrder = 2,
                        Title = "Component 4b: Documenting Student Progress",
                        Code = "4b",
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: Students monitor progress toward mastery and their own attainment of learning and development goals; they regularly analyze and discuss their progress with the teacher and their families.",
AnswerText = [
"There is no system for documenting student progress or the system is ineffective at communicating progress to students and families. ",
"The teacher documents some aspects of student progress in a manner that is accessible to students and families. ",
"The teacher documents student progress toward mastery, focusing on the attainment of learning and developmental goals; students have access to and engage in reflection on their progress.  "
]
                    },
                    new() {
                        DomainEnum = DomainEnum.Four,
                        ComponentOrder = 3,
                        Title = "Component 4c: Engaging Families and Communities",
                        Code = "4c",
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: The teacher’s frequent and ongoing engagement of families and communities demonstrates a clear value for the role they play in student learning and is focused on forging partnerships that further the academic and personal success of each and every student.",
AnswerText = [
"There is no system for documenting student progress, the system is ineffective and inefficient, or it does not provide relevant information to students and those who support them. ",
"The teacher documents some aspects of student progress in a manner that is accessible to students and those who support them. ",
"The teacher engages students’ families and communities in a respectful and culturally responsive manner, making information readily available and inviting participation in the intellectual life of the classroom."
]
                    },
                    new() {
                        DomainEnum = DomainEnum.Four,
                        ComponentOrder = 4,
                        Title = "Component 4d: Contributing to School Community and Culture",
                        Code = "4d",
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: The teacher takes a leadership role in defining, modeling, and holding self and peers accountable to the values and intellectual life of the school, leading with an emphasis on meeting the needs of students and families.",
AnswerText = [
"The teacher is not an active member of the school community or contributes negatively to the culture of learning and values of the school. ",
"The teacher makes some contributions to the school culture, supporting professional learning and upholding the values of the school. ",
"The teacher takes initiative in contributing to and leading events, programs, or activities that further the culture of learning in the school and bring the values of the school to life through modeling and positive action.  "
]
                    },
                    new() {
                        DomainEnum = DomainEnum.Four,
                        ComponentOrder = 5,
                        Title = "Component 4e: Growing and Developing Professionally",
                        Code = "4e",
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: The teacher appropriately exercises autonomy to direct professional learning for themselves and their peers, taking a leadership role in the school, setting direction, and supporting colleagues to engage in inquiry and innovation.",
AnswerText = [
"The teacher does not engage in professional inquiry or learning focused on developing knowledge, skills, and mindsets, or does so reluctantly. ",
"The teacher engages in professional inquiry and learning focused on developing knowledge, skills, and mindsets individually and with colleagues that is typically arranged or directed by others. ",
"The teacher directs their own professional inquiry and learning in collaboration with colleagues and demonstrates curiosity and energy for professional conversations and growth focused on developing knowledge, skills, and mindsets.  "
]
                    },
                    new() {
                        DomainEnum = DomainEnum.Four,
                        ComponentOrder = 6,
                        Title = "Component 4f: Acting in Service of Students",
                        Code = "4f",
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: The teacher is a leader in the school in defining and upholding high standards of ethical practice and modeling wise decision-making that honors the inherent worth and dignity of each and every student and prioritizes their needs.",
AnswerText = [
"The teacher acts unethically and does not understand the needs of students or make decisions in their best interest. ",
"The teacher acts ethically and attempts to make deliberate decisions in the best interest of students, families, and colleagues.  ",
"The teacher models high standards of ethical practice and wise decision making on behalf of students, families, and colleagues.  "
]
                    }
                ]
            }
        ];
    }
}