namespace DataAccessLayer.Entities
{
    public class Application
    {
        public int Id { get; set; }
        public bool HasAttachment { get; set; }
        public int AnswersCount { get; set; }
        public int Rec1ipientType { get; set; }
        public Status AppStatus { get; set; }
        public DateTime Created { get; set; }
        public DateTime Deadline { get; set; }
        public string Title { get; set; }
        public string Customer { get; set; }
        public string Implementer { get; set; }
        public string ServiceName { get; set; }
        public Group ImplementerGroup { get; set; }
        public DateTime BeginWorkingPlanned { get; set; }
        public DateTime BeginWorkingActual { get; set; }
        public DateTime EndWorkingActual { get; set; }
        public DateTime AllWork { get; set; }
        public string Phone { get; set; }
        public string Room { get; set; }
        public string Address { get; set; }
        public string CompanyName { get; set; }
        public string DepartmentName { get; set; }
        public string CreatorName { get; set; }
        public Category AppCategory { get; set; }
        public string Priority { get; set; }
        public string ApplicationText { get; set; }
        public int Rating { get; set; }
    }
}
