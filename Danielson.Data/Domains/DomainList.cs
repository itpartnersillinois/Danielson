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
                        Title = "Component 1a: Demonstrating Knowledge of Content and Pedagogy",
                        Code = "1a",
                        ContinuumOfPracticeHtml = (MarkupString)"Distinguished: The teacher’s engagement of students, families, and communities focuses on supporting the academic and personal success of each student, especially students who have been marginalized.",
                    },
                    new() {
                        DomainEnum = DomainEnum.One,
                        ComponentOrder = 2,
                        Title = "Component 1b: Demonstrating Knowledge of Students",
                        Code = "1b",
                        ContinuumOfPracticeHtml = (MarkupString)"",
                    },
                    new() {
                        DomainEnum = DomainEnum.One,
                        ComponentOrder = 3,
                        Title = "Component 1c: Setting Instructional Outcomes",
                        Code = "1c",
                        ContinuumOfPracticeHtml = (MarkupString)"",
                    },
                    new() {
                        DomainEnum = DomainEnum.One,
                        ComponentOrder = 4,
                        Title = "Component 1d: Demonstrating Knowledge of Resources",
                        Code = "1d",
                        ContinuumOfPracticeHtml = (MarkupString)"",
                    },
                    new() {
                        DomainEnum = DomainEnum.One,
                        ComponentOrder = 5,
                        Title = "Component 1e: Designing Coherent Instruction",
                        Code = "1e",
                        ContinuumOfPracticeHtml = (MarkupString)"",
                    },
                    new() {
                        DomainEnum = DomainEnum.One,
                        ComponentOrder = 6,
                        Title = "Component 1f: Designing Student Assessments",
                        Code = "1f",
                        ContinuumOfPracticeHtml = (MarkupString)"",
                    },
                ],
            },
            new() {
                DomainEnum = DomainEnum.Two,
                Title = "Domain 2: Classroom Environment",
                DescriptionHtml = (MarkupString)"The teacher creates and maintains an environment that supports student learning.",
                Components = [
                    new() {
                        DomainEnum = DomainEnum.Two,
                        ComponentOrder = 1,
                        Title = "Component 2a: Creating an Environment of Respect and Rapport",
                        Code = "2a",
                        ContinuumOfPracticeHtml = (MarkupString)"",
                    },
                    new() {
                        DomainEnum = DomainEnum.Two,
                        ComponentOrder = 2,
                        Title = "Component 2b: Establishing a Culture for Learning",
                        Code = "2b",
                        ContinuumOfPracticeHtml = (MarkupString)"",
                    },
                    new() {
                        DomainEnum = DomainEnum.Two,
                        ComponentOrder = 3,
                        Title = "Component 2c: Managing Classroom Procedures",
                        Code = "2c",
                        ContinuumOfPracticeHtml = (MarkupString)"",
                    },
                    new() {
                        DomainEnum = DomainEnum.Two,
                        ComponentOrder = 4,
                        Title = "Component 2d: Managing Student Behavior",
                        Code = "2d",
                        ContinuumOfPracticeHtml = (MarkupString)"",
                    },
                ],
            },
            new() {
                DomainEnum = DomainEnum.Three,
                Title = "Domain 3: Instruction",
                DescriptionHtml = (MarkupString)"The teacher engages students in learning.",
                Components = [
                    new() {
                        DomainEnum = DomainEnum.Three,
                        ComponentOrder = 1,
                        Title = "Component 3a: Communicating with Students",
                        Code = "3a",
                        ContinuumOfPracticeHtml = (MarkupString)"",
                    },
                    new() {
                        DomainEnum = DomainEnum.Three,
                        ComponentOrder = 2,
                        Title = "Component 3b: Using Questioning and Discussion Techniques",
                        Code = "3b",
                        ContinuumOfPracticeHtml = (MarkupString)"",
                    },
                    new() {
                        DomainEnum = DomainEnum.Three,
                        ComponentOrder = 3,
                        Title = "Component 3c: Engaging Students in Learning",
                        Code = "3c",
                        ContinuumOfPracticeHtml = (MarkupString)"",
                    },
                    new() {
                        DomainEnum = DomainEnum.Three,
                        ComponentOrder = 4,
                        Title = "Component 3d: Using Assessment in Instruction",
                        Code = "3d",
                        ContinuumOfPracticeHtml = (MarkupString)"",
                    },
                    new() {
                        DomainEnum = DomainEnum.Three,
                        ComponentOrder = 5,
                        Title = "Component 3e: Demonstrating Flexibility and Responsiveness",
                        Code = "3e",
                        ContinuumOfPracticeHtml = (MarkupString)"",
                    },
                    new() {
                        DomainEnum = DomainEnum.Three,
                        ComponentOrder = 6,
                        Title = "Component 3f: Demonstrating Knowledge of Resources",
                        Code = "3f",
                        ContinuumOfPracticeHtml = (MarkupString)"",
                    }
                ]
            },
            new() {
                DomainEnum = DomainEnum.Four,
                Title = "Domain 4: Professional Responsibilities",
                DescriptionHtml = (MarkupString)"The teacher maintains accurate records, communicates with families, and participates in the community.",
                Components = [
                    new() {
                        DomainEnum = DomainEnum.Four,
                        ComponentOrder = 1,
                        Title = "Component 4a: Reflecting on Teaching",
                        Code = "4a",
                        ContinuumOfPracticeHtml = (MarkupString)"",
                    },
                    new() {
                        DomainEnum = DomainEnum.Four,
                        ComponentOrder = 2,
                        Title = "Component 4b: Maintaining Accurate Records",
                        Code = "4b",
                        ContinuumOfPracticeHtml = (MarkupString)"",
                    },
                    new() {
                        DomainEnum = DomainEnum.Four,
                        ComponentOrder = 3,
                        Title = "Component 4c: Communicating with Families",
                        Code = "4c",
                        ContinuumOfPracticeHtml = (MarkupString)"",
                    },
                    new() {
                        DomainEnum = DomainEnum.Four,
                        ComponentOrder = 4,
                        Title = "Component 4d: Participating in the Professional Community",
                        Code = "4d",
                        ContinuumOfPracticeHtml = (MarkupString)"",
                    },
                    new() {
                        DomainEnum = DomainEnum.Four,
                        ComponentOrder = 5,
                        Title = "Component 4e: Growing and Developing Professionally",
                        Code = "4e",
                        ContinuumOfPracticeHtml = (MarkupString)"",
                    },
                    new() {
                        DomainEnum = DomainEnum.Four,
                        ComponentOrder = 6,
                        Title = "Component 4f: Showing Professionalism",
                        Code = "4f",
                        ContinuumOfPracticeHtml = (MarkupString)"",
                    }
                ]
            }
        ];
    }
}