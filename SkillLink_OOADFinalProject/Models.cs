using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillLink_OOADFinalProject
{
    internal class Models
    {
    }

    public interface ICertifiable
    {
        void Certify(string courseTitle);
    }

    public abstract class Person
    {
        private static int _nextId = 1000;

        private string _fullName;

        public int ID { get; private set; }

        public string FullName
        {
            get => _fullName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Full Name cannot be empty.");
                _fullName = value;
            }
        }

        public string ContactNo { get; set; }

        public Person(string fullName, string contactNo)
        {
            ID = _nextId++;
            FullName = fullName;
            ContactNo = contactNo;
        }

        public abstract string DisplayDetails();
    }

    public class Trainee : Person, ICertifiable
    {
        public enum TraineeStatus { Enrolled, Certified, Dropped }

        public DateTime DateRegistered { get; }
        public TraineeStatus Status { get; private set; }
        public string EnrolledCourseTitle { get; private set; }

        public Trainee(string fullName, string contactNo) : base(fullName, contactNo)
        {
            DateRegistered = DateTime.Now;
            Status = TraineeStatus.Enrolled; // Default status 
            EnrolledCourseTitle = "N/A";
        }

        public override string DisplayDetails()
        {
            return $"Trainee ID: {ID} | Name: {FullName} | Status: {Status} | Course: {EnrolledCourseTitle}";
        }

        public void Certify(string courseTitle)
        {
            Status = TraineeStatus.Certified;
            EnrolledCourseTitle = courseTitle;
        }

        public void DropCourse()
        {
            Status = TraineeStatus.Dropped;
            EnrolledCourseTitle = "N/A";
        }
    }

    public class Trainer : Person
    {
        public string Specialty { get; set; }

        public Trainer(string fullName, string contactNo, string specialty) : base(fullName, contactNo)
        {
            Specialty = specialty;
        }

        public override string DisplayDetails()
        {
            return $"Trainer ID: {ID} | Name: {FullName} | Specialty: {Specialty}";
        }
    }



    public class TrainingCourse
    {
        private static int _nextCourseId = 500;

        public int CourseID { get; private set; }
        public string Title { get; set; }
        public int DurationHours { get; set; }

        public TrainingCourse(string title, int durationHours)
        {
            CourseID = _nextCourseId++;
            Title = title;
            DurationHours = durationHours;
        }

        public override string ToString()
        {
            return $"{CourseID}: {Title} ({DurationHours} hrs)";
        }
    }

    public class SkillLinkManager
    {
        public List<Trainee> Trainees { get; private set; }
        public List<Trainer> Trainers { get; private set; }
        public List<TrainingCourse> Courses { get; private set; }

        public SkillLinkManager()
        {
            Trainees = new List<Trainee>();
            Trainers = new List<Trainer>();
            Courses = new List<TrainingCourse>();

            Courses.Add(new TrainingCourse("Computer Literacy 101", 40));
            Courses.Add(new TrainingCourse("Basic Carpentry", 60));
            Courses.Add(new TrainingCourse("Dressmaking & Tailoring", 80));

            Trainers.Add(new Trainer("Jose Rizal", "0999-001", "IT & Robotics"));
            Trainers.Add(new Trainer("Melchora Aquino", "0999-002", "Vocational Arts"));
        }

        public void AddTrainee(string name, string contact)
        {
            try
            {
                Trainee newTrainee = new Trainee(name, contact);
                Trainees.Add(newTrainee);
            }
            catch (ArgumentException ex)
            {
                throw new Exception($"Validation Error: {ex.Message}");
            }
        }

        public bool MarkCertified(int traineeId, string courseTitle)
        {
            Trainee trainee = Trainees.Find(t => t.ID == traineeId);
            if (trainee != null)
            {
                trainee.Certify(courseTitle);
                return true;
            }
            return false;
        }

        public List<Trainee> GetCertifiedTrainees()
        {
            return Trainees.FindAll(t => t.Status == Trainee.TraineeStatus.Certified);
        }
    }
}
