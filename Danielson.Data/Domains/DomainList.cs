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
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: The teacher’s understanding of content and pedagogy fosters deeper learning, student agency, and intellectual dispositions such as curiosity, reasoning, and reflection.",
                        ElementsOfSuccessHtml = (MarkupString)"<p><strong>Disciplinary Expertise</strong></p> <p>Teachers have deep knowledge of the disciplines they teach, including structures, central concepts and skills, prerequisite relationships, and methods of inquiry.</p> <p><strong>Pedagogical Content Knowledge</strong></p> <p>Teachers make content accessible to students by understanding and addressing preconceptions, presenting ideas in comprehensible and powerful ways, and thoughtfully implementing the most effective pedagogical approaches.</p> <p><strong>Knowledge of Interdisciplinary Relationships and Skills</strong></p> <p>Teachers make interdisciplinary connections to scaffold learning, support engagement, and build essential knowledge and skills that cross disciplines and support student learning in multiple contexts.</p>",
                        AnswerText = [
                            "The teacher lacks sufficient knowledge of content and pedagogy to support student learning of the content.",
                            "The teacher’s understanding of content and pedagogy partially supports student learning of the content.",
                            "The teacher’s understanding of content and pedagogy supports student learning of the content.",
                         ]
                    },
                    new() {
                        DomainEnum = DomainEnum.One,
                        ComponentOrder = 2,
                        Title = "Component 1b: Knowing and Valuing Students",
                        Code = "1b",
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: The teacher's knowledge of students is extensive and fosters student learning and development to support academic and personal success.",
                        ElementsOfSuccessHtml = (MarkupString)"<p><strong>Respect for Students’ Identities</strong></p><p>Students’ lived experiences and funds of knowledge are the foundation for the development of identity, purpose, intellect, and character.</p> <p><strong>Understanding of Students’ Current Knowledge and Skills</strong></p> <p>Learning experiences reflect what students bring and are designed with their current knowledge and skills in mind.</p> <p><strong>Knowledge of Whole Child Development</strong></p> <p>Students' cognitive, physical, social, and emotional development are all addressed in the design of learning environments and experiences to promote student success and autonomy. </p> <p><strong>Knowledge of the Learning Process</strong></p> <p>and Learning Differences Learning requires active intellectual engagement and appropriate support aligned to students' individual differences and needs.</p>",
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
                        ElementsOfSuccessHtml = (MarkupString)"<p><strong>Value and Relevance</strong></p> <p> Instructional outcomes represent ambitious learning of important content and meaningful opportunities to support student learning and development.</p> <p><strong>Alignment to Grade-Level Standards</strong></p> <p>Instructional outcomes reflect appropriate grade-level standards and communicate high expectations for each student.</p> <p><strong>Clarity of Purpose</strong></p> <p> Instructional outcomes clearly define what will be learned, why it is important, and how students will develop and demonstrate mastery of content and skills.</p> <p><strong>Integration of Multiple Aspects of Student Development</strong></p> <p> Instructional outcomes integrate academic and social-emotional development to complement and build on one another.</p>",
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
                        ElementsOfSuccessHtml = (MarkupString)"<p><strong>Instructional Materials</strong></p><p> Teachers utilize high-quality instructional materials to ensure access to rigorous content and support specific student needs, furthering engagement and mastery.</p> <p><strong> Technology and Digital Resources</strong></p><p> Technological and digital resources support personalized instruction, equitable learning, engagement, exploration, connection, and student development.</p> <p><strong> Supports for Students</strong></p><p> Teachers seek and provide additional aligned resources and supports that make content and curriculum materials accessible to students and address their individual needs.</p>",
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
                        ElementsOfSuccessHtml = (MarkupString)"<p><strong>Tasks and Activities</strong></p><p> Tasks and activities are specifically matched to learning outcomes, encourage higher-level thinking and student agency, and create authentic opportunities to engage with meaningful content. </p> <p><strong>Flexible Learning</strong></p><p> Multiple strategies and approaches are tailored to individual student needs to create the appropriate level of challenge and support for each student. </p> <p><strong>Student Collaboration</strong></p><p> Student groups are an essential component of learning and development, and are organized thoughtfully to maximize opportunities and build on students’ strengths.</p> <p><strong>Structure and Flow</strong></p><p> Lesson and unit plans are well structured and flow from one to the next to support student learning and development.</p>",
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
                        ElementsOfSuccessHtml = (MarkupString)"<p><strong> Congruence with Instructional Outcomes</strong></p><p> Aligned assessments provide accurate, clear evidence and allow for the analysis of student understanding and mastery of instructional outcomes. </p> <p><strong>Criteria and Standards</strong></p><p> Criteria and standards for assessment are appropriate and aligned, clearly communicated, and whenever possible have been developed with student input. </p> <p><strong>Planning Formative Assessments</strong></p><p> Teachers plan formative assessments to monitor student progress toward instructional outcomes, make needed adjustments, and support students to monitor their own learning. </p> <p><strong>Analysis and Application</strong></p><p> Teachers consistently use assessment data to direct planning and preparation and to support individualized student instruction.</p>",
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
                        ElementsOfSuccessHtml = (MarkupString)"<p><strong>Positive Relationships</strong></p><p> Teacher-student and studentstudent interactions demonstrate caring and respect and honor the dignity of each member of the community.</p> <p><strong>Sense of Belonging</strong></p><p> Teachers and students co-create a community that reflects their unique collective identity and interests as a class while honoring individual identities.</p> <p><strong>Cultural Responsiveness</strong></p><p> Ways of interacting in the classroom are culturally responsive, and they are supported by teachers’ own cultural competence and understanding of societal dynamics and their impact on learning environments.</p> <p><strong>Positive Conflict Resolution</strong></p><p> A clear and culturally competent approach to conflict resolution has been established and is used effectively to resolve conflict and restore trust.</p>",
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
ElementsOfSuccessHtml = (MarkupString)"<p><strong>Purpose and Motivation</strong></p><p> Teachers and students share an overarching dedication to both content mastery and personal growth.</p> <p><strong>Dispositions for Learning</strong></p><p> Teachers model, encourage, explicitly teach, and reinforce curiosity, critical thinking, reasoning, and reflection to support student success and their social, emotional, and academic growth.</p> <p><strong>Student Agency and Pride in Work</strong></p><p> Students make informed choices, devote energy to learning, take pride in their accomplishments, and actively suggest ways to make the classroom more joyful, rigorous, and purposeful.</p> <p><strong>Support and Perseverance</strong></p><p> Teachers and students encourage one another to persevere and use strategies to support each other through challenging work.</p>",
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
                        ElementsOfSuccessHtml = (MarkupString)"<p><strong>Productive Collaboration</strong></p><p> Collaboration is modeled, taught, and reinforced so that students work purposefully and cooperatively in groups, to support one another’s success.</p> <p><strong>Student Autonomy and Responsibility</strong></p><p> Routines support student assumption of responsibility and the development of skills, habits, and mindsets that promote student autonomy.</p> <p><strong>Equitable Access to Resources and Supports</strong></p><p> Resources and supports are deployed efficiently, effectively, and equitably for the benefit of all students.</p> <p><strong>Non-Instructional Tasks</strong></p><p> Teachers complete non-instructional tasks with little to no loss of instructional time or disruption to lesson delivery.</p>",
                        AnswerText = [
"Student learning and development are hindered by a lack of routines or inefficient classroom procedures.  ",
    "Classroom routines and procedures, established or managed primarily by the teacher and taught explicitly to students, support opportunities for student learning and development.",
"Shared routines and efficient procedures are largely student-directed and maximize opportunities for student learning and development.  "
]
                    },
                    new() {
                        DomainEnum = DomainEnum.Two,
                        ComponentOrder = 4,
                        Title = "Component 2d: Supporting Positive Student Behavior",
                        Code = "2d",
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: Students consistently and independently display positive behaviors and seek opportunities to build a better classroom community.",
 ElementsOfSuccessHtml = (MarkupString)"<p><strong>Expectations for the Learning Community</strong></p><p> Students play an active role in establishing and maintaining expectations for the learning community with regular opportunities for critical reflection both individually and as a group.</p> <p><strong>Modeling and Teaching Habits of Character</strong></p><p> Teachers model, explicitly teach, and reinforce habits that promote learning, ethical behavior, and citizenship.</p> <p><strong>Self-Monitoring and Collective Responsibility</strong></p><p> Students successfully monitor their own behavior, attend to their impact on other students, and appropriately support one another.</p>",
                        AnswerText = [
"There is little evidence of explicit modeling, instruction, or guidance related to positive student behaviors. ",
"Positive behaviors are modeled by the teacher and occasionally taught explicitly. ",
"Students display positive behaviors, which are modeled by teachers and reinforced to promote reflection and recalibration rather than compliance.  "
]
                   },
                    new() {
                        DomainEnum = DomainEnum.Two,
                        ComponentOrder = 5,
                        Title = "Component 2e: Organizing Spaces for Learning",
                        Code = "2e",
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: Learning spaces are thoughtfully co-designed and modified as needed by members of the learning community to address the needs of individuals and create collaborative, joyful spaces for all to learn and grow.",
ElementsOfSuccessHtml = (MarkupString)"<p><strong>Safety and Accessibility</strong></p><p> The learning space is safe and accessible to all students and is modified if necessary by students or teachers to accommodate individual student needs.</p> <p><strong>Design for Learning and Development</strong></p><p> The learning space is thoughtfully designed and adjusted as necessary to support and facilitate learning activities.</p> <p><strong>Co-Creation and Shared Ownership</strong></p><p> Students play a role in the design and adjustment of the learning space and demonstrate a sense of ownership through appropriate participation and interaction.</p>",
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
                        ElementsOfSuccessHtml = (MarkupString)"<p><strong>Purpose for Learning and Criteria for Success</strong></p><p> Teachers communicate the goals and objectives of learning activities and outline an instructional pathway for students to meet the established criteria for success. </p> <p><strong>Specific Expectations</strong></p><p> Student actions during each step of learning activities are clearly and effectively communicated with specific expectations articulated and reinforced throughout. </p> <p><strong>Explanations of Content</strong></p><p> Content knowledge is scaffolded and presented in multiple, engaging ways with frequent, integrated checks for student understanding. </p> <p><strong>Use of Academic Language</strong></p><p> Verbal and written content-related language used by teachers and students is academically rigorous, accurate, and subject and grade appropriate.</p>",
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
                        ElementsOfSuccessHtml = (MarkupString)"<p><strong>Critical Thinking and Deeper Learning</strong></p><p> Questions and discussions require critical thinking, have multiple answers, and are used to deepen student understanding of content, themselves, and the larger world. </p> <p><strong>Reasoning and Reflection</strong></p><p> Questions and discussions challenge students to reason, reflect on learning, justify their thinking, and generate ideas for future inquiry. </p> <p><strong>Student Participation</strong></p><p> Students demonstrate curiosity and engage one another through questions and dialogue, challenging each other’s thinking with respect and humility.</p>",
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
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: Students take initiative to increase the challenge or complexity of learning experiences; they think critically about a variety of issues and offer solutions; and they make suggestions for modifications that increase meaning and relevance.",
                        ElementsOfSuccessHtml = (MarkupString)"<p><strong>Rich Learning Experiences</strong></p><p> Students demonstrate agency and critical thinking in completion of tasks and activities that require high levels of intellectual engagement. </p> <p><strong>Collaboration and Teamwork</strong></p><p> Student collaboration is a key component of learning and engagement, and students take initiative to collaborate in new or unplanned ways that further their learning and make it more engaging and meaningful. </p> <p><strong>Use of Instructional Materials and Resources</strong></p><p> Instructional materials and resources are used effectively to support intellectual engagement and deep learning of the content. </p> <p><strong>Opportunities for Thinking and Reflection</strong></p><p> Individual lessons, activities, and tasks, as well as instructional pathways, have multiple and effective opportunities to think, reflect, and consolidate understanding.</p>",
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
ElementsOfSuccessHtml = (MarkupString)"<p><strong>Clear Standards for Success</strong></p><p> Collaborative goals, the characteristics of high-quality work, and the criteria established as evidence of success are clear to students and those supporting them. </p> <p><strong>Monitoring Student Understanding</strong></p><p> Teachers and students are constantly monitoring learning and making use of specific strategies to elicit evidence of understanding. </p> <p><strong>Timely, Constructive Feedback</strong></p><p> High-quality feedback comes from many sources, including students; it is specific and focused on improvement.</p>",
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
ElementsOfSuccessHtml = (MarkupString)"<p><strong>Evidence-Based Adjustments</strong></p><p> When appropriate, teachers use their expertise to alter or replace pre-planned activities based on students’ understanding, questions, and interests. </p> <p><strong>Receptiveness and Responsiveness</strong></p><p> Teachers are open to and capitalize upon unexpected student actions, questions, and internal and external events; they encourage and support students to pursue new learning and opportunities on their own. </p> <p><strong>Determination and Persistence</strong></p><p> Teachers are committed to efficacy, even when students encounter difficulty in learning, and pursue alternative approaches when necessary to help students be successful.</p>",
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
                DescriptionHtml = (MarkupString)"The components of <strong>Domain 4: Principled Teaching</strong> capture and reflect the practices of educators that extend beyond their classrooms or any single learning experience. These activities are critical to preserving and enhancing the profession and to the success of students. Teaching is a purpose-driven profession. It is a calling. Those who take up the work have a lasting and profound impact on the lives of students. Their purpose, and the purpose of education more broadly, is not solely to impart academic knowledge; it is the intellectual and moral development of human beings who will themselves flourish and help create a just society.",
                Components = [
                    new() {
                        DomainEnum = DomainEnum.Four,
                        ComponentOrder = 1,
                        Title = "Component 4a: Engaging in Reflective Practice",
                        Code = "4a",
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: The teacher consistently engages in reflective practice based on multiple sources of evidence that results in the exploration of new ideas and approaches focused on supporting students who need it most.",
ElementsOfSuccessHtml = (MarkupString)"<p><strong>Self-Assessment of Teaching</strong></p><p> Teachers use evidence from activities and assessments to identify the impact of different elements of practice on student learning and evaluate the success of learning experiences. </p> <p><strong>Analysis and Discovery</strong></p><p> Based on their self-assessment, teachers consider alternative approaches or perspectives, question their own ideas or beliefs, and learn new ways to further advance student learning. </p> <p><strong>Application and Continuous Improvement</strong></p><p> Teachers demonstrate commitment to the success of all students by planning, practicing, and trying new approaches to enhance their teaching based on their assessment and analysis.</p>",
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
ElementsOfSuccessHtml = (MarkupString)"<p><strong>Student Progress Toward Mastery</strong></p><p> The teacher documents student progress toward learning and developmental goals and shares information with students, parents, and educational collaborators. </p> <p><strong>Shared Ownership</strong></p><p> With support from teachers, students utilize resources to monitor their progress toward learning and developmental goals and regularly analyze and discuss their progress with teachers and caregivers. </p> <p><strong>Maintaining Reliable Records</strong></p><p> The teacher consistently gathers, updates, and shares data that is accurate, accessible, and clear to students and families.</p>",
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
ElementsOfSuccessHtml = (MarkupString)"<p><strong>Respect and Cultural Competence</strong></p><p> Teachers interact with families and the community in ways that respect their values and cultural backgrounds. </p> <p><strong>Community Values</strong></p><p> Learning experiences and environments are extensions of the community and uphold its values, creating a shared vision of student success. </p> <p><strong>Instructional Program</strong></p><p> Established structures and processes keep families informed about the instructional program and provide opportunities for input and feedback. </p> <p><strong>Engagement in Learning Experiences</strong></p><p> Teachers connect students’ outof- school learning and lives to their efforts in school and take the lead in forming partnerships and relationships to strengthen those connections.</p>",
AnswerText = [
"The teacher does not engage students’ families or the community, engages them infrequently, or does so disrespectfully. ",
"The teacher makes some efforts to engage families and communities and does so in a respectful manner. ",
"The teacher engages students’ families and communities in a respectful and culturally responsive manner, making information readily available and inviting participation in the intellectual life of the classroom."
]
                    },
                    new() {
                        DomainEnum = DomainEnum.Four,
                        ComponentOrder = 4,
                        Title = "Component 4d: Contributing to School Community and Culture",
                        Code = "4d",
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: The teacher takes a leadership role in defining, modeling, and holding self and peers accountable to the values and intellectual life of the school, leading with an emphasis on meeting the needs of students and families.",
ElementsOfSuccessHtml = (MarkupString)"<p><strong>Curiosity and Autonomy</strong></p><p> Teachers identify personal and professional growth areas and independently seek opportunities to develop and refine their knowledge. </p> <p><strong>Developing Cultural Competence</strong></p><p> Teachers seek knowledge regarding the students and community they serve and apply findings to their practice and development of the school culture. </p> <p><strong>Enhancing Knowledge and Skills</strong></p><p> Teachers work to deepen content and pedagogical knowledge and exchange new learning with colleagues. </p> <p><strong>Seeking and Acting on Feedback</strong></p><p> Teachers seek opportunities to receive and provide feedback and work collaboratively and constructively to utilize feedback effectively.</p>",
AnswerText = [
"The teacher is not an active member of the school community or contributes negatively to the culture of learning and values of the school. ",
"The teacher makes some contributions to the school culture, supporting professional learning and upholding the values of the school. ",
"The teacher takes initiative in contributing to and leading events, programs, or activities that further the culture of learning in the school and brings the values of the school to life through modeling and positive action.  "
]
                    },
                    new() {
                        DomainEnum = DomainEnum.Four,
                        ComponentOrder = 5,
                        Title = "Component 4e: Growing and Developing Professionally",
                        Code = "4e",
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: The teacher appropriately exercises autonomy to direct professional learning for themselves and their peers, taking a leadership role in the school, setting direction, and supporting colleagues to engage in inquiry and innovation.",
ElementsOfSuccessHtml = (MarkupString)"<p><strong>Acting with Care, Honesty, and Integrity</strong></p><p> Teachers consistently model care, honesty, and integrity in interactions with students, families, and colleagues. </p> <p><strong>Ethical Decision-Making</strong></p><p> Teachers make wise decisions, especially under challenging circumstances, that are in the best interest of students and their families. </p> <p><strong>Advocacy</strong></p><p> Teachers are active advocates for students, their families, and colleagues and lead in taking action on their behalf.</p>",
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
ElementsOfSuccessHtml = (MarkupString)"<p><strong>Disciplinary Expertise</strong></p> <p>Teachers have deep knowledge of the disciplines they teach, including structures, central concepts and skills, prerequisite relationships, and methods of inquiry.</p> <p><strong>Pedagogical Content Knowledge</strong></p> <p>Teachers make content accessible to students by understanding and addressing preconceptions, presenting ideas in comprehensible and powerful ways, and thoughtfully implementing the most effective pedagogical approaches.</p> <p><strong>Knowledge of Interdisciplinary Relationships and Skills</strong></p> <p>Teachers make interdisciplinary connections to scaffold learning, support engagement, and build essential knowledge and skills that cross disciplines and support student learning in multiple contexts.</p>",
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