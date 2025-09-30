using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Make_it_stick.Data
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<WeeklyChallenge> WeeklyChallenges { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Answers> Answers { get; set; }
        public DbSet<feedback> Feedbacks { get; set; }
        public DbSet<leaderboard> Leaderboards { get; set; }
        public DbSet<notification> Notifications { get; set; }
        public DbSet<Questions> Questions { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;port=3306;user=root;password=;database=csd_make-it-stick",
                ServerVersion.Parse("8.0.30")
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id = 1,
                    Name = "Alice Johnson",
                    Class = "ICT-01",
                    StudentNumber = "S12345",
                    CurioEmail = "alice.johnson@curio.nl",
                    PhoneNumber = "0612345678"
                },
                new Student
                {
                    Id = 2,
                    Name = "Bob Smith",
                    Class = "ICT-02",
                    StudentNumber = "S67890",
                    CurioEmail = "bob.smith@curio.nl",
                    PhoneNumber = "0698765432"
                }
            );

            modelBuilder.Entity<Teacher>().HasData(
                new Teacher
                {
                    Id = 1,
                    Name = "Mr. Peters",
                    Role = "Math Teacher",
                    CurioEmail = "peters@curio.nl",
                    PhoneNumber = "0611122233"
                },
                new Teacher
                {
                    Id = 2,
                    Name = "Ms. Van Dijk",
                    Role = "Programming Teacher",
                    CurioEmail = "vandijk@curio.nl",
                    PhoneNumber = "0644455566"
                }
            );

            modelBuilder.Entity<WeeklyChallenge>().HasData(
                new WeeklyChallenge
                {
                    Id = 1,
                    TeacherId = 2, 
                    Title = "C# Basics",
                    Description = "Write a simple calculator in C#.",
                    Category = "Programming",
                    Deadline = DateTime.Now.AddDays(7),
                    OpenStatus = true
                },
                new WeeklyChallenge
                {
                    Id = 2,
                    TeacherId = 1,
                    Title = "Algebra Challenge",
                    Description = "Solve 10 algebra problems.",
                    Category = "Math",
                    Deadline = DateTime.Now.AddDays(14),
                    OpenStatus = true
                }
            );

            modelBuilder.Entity<Quiz>().HasData(
                new Quiz 
                { 
                    Id = 1,
                    TeacherId = 2,
                    Title = "C# Quiz",
                    Description = "Test your C# basics.",
                    Category = "Programming",
                    DifficultyLevel = "Easy",
                    TimeLimit = 15,
                    Deadline = DateTime.Now.AddDays(5),
                    OpenStatus = true 
                },

                new Quiz 
                { 
                    Id = 2,
                    TeacherId = 1,
                    Title = "Math Quiz",
                    Description = "Basic algebra quiz.",
                    Category = "Math",
                    DifficultyLevel = "Medium",
                    TimeLimit = 20,
                    Deadline = DateTime.Now.AddDays(10),
                    OpenStatus = true 
                }
            );

            modelBuilder.Entity<Questions>().HasData(
                new Questions 
                { 
                    Id = 1,
                    quiz_Id = 1,
                    Question_Text = "What is the output of 2+2 in C#?",
                    Type = "MCQ",
                    Correct_Answer = "4",
                    Adaptive = false 
                },
                new Questions 
                { 
                    Id = 2,
                    quiz_Id = 2,
                    Question_Text = "Solve: 5x = 20",
                    Type = "Short Answer",
                    Correct_Answer = "4",
                    Adaptive = true 
                }
            );

            modelBuilder.Entity<Answers>().HasData(
                new Answers 
                { 
                    Id = 1,
                    StudentId = 1,
                    QuestionsuestionId = 1,
                    Question_Text = "What is 2+2?",
                    Correct = "4",
                    Datum_entered = DateTime.Now
                },

                new Answers 
                { 
                    Id = 2,
                    StudentId = 2,
                    QuestionsuestionId = 2,
                    Question_Text = "Solve 5x = 20",
                    Correct = "4",
                    Datum_entered = DateTime.Now 
                }
            );

            modelBuilder.Entity<feedback>().HasData(
                new feedback 
                {
                    Id = 1,
                    TeacherId = 2,
                    StudentId = 1,
                    QuizId = 1,
                    Level = 1,
                    Score = 100,
                    Commentary = "Excellent work!",
                    DateTime = DateTime.Now 
                },

                new feedback 
                {
                    Id = 2,
                    TeacherId = 1,
                    StudentId = 2,
                    QuizId = 2,
                    Level = 1,
                    Score = 80,
                    Commentary = "Good job, but review algebra basics.",
                    DateTime = DateTime.Now 
                }
            );

            modelBuilder.Entity<leaderboard>().HasData(
                new leaderboard 
                {
                    Id = 1,
                    QuizId = 1,
                    ChallengeId = 1,
                    StudentId = 1,
                    Score = 100,
                    Rank = 1,
                    DateTime = DateTime.Now 
                },

                new leaderboard 
                {
                    Id = 2,
                    QuizId = 2,
                    ChallengeId = 2,
                    StudentId = 2,
                    Score = 80,
                    Rank = 2,
                    DateTime = DateTime.Now 
                }
            );

            modelBuilder.Entity<notification>().HasData(
                new notification 
                {
                    Id = 1,
                    PushId = 1,
                    StudentId = 1,
                    QuizId = 1,
                    DateSent = DateTime.Now,
                    Type = "Reminder",
                    Status = "Unread" 
                },

                new notification 
                {
                    Id = 2,
                    PushId = 2,
                    StudentId = 2,
                    QuizId = 2,
                    DateSent = DateTime.Now,
                    Type = "Deadline",
                    Status = "Read"
                }
            );

        }
    }
}
