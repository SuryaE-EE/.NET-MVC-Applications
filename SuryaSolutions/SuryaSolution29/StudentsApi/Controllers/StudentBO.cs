namespace StudentsApi.Controllers
{
    public class StudentBO
    {
         
        private List<StudentModel> Students { get; set; }
        public StudentBO()
        {
            Students = new List<StudentModel>
            {
                new StudentModel{Id=1001,SName="Arvind",Course="Azure",Fee=12500},
                new StudentModel{Id=1002,SName="Bharath",Course="React",Fee=14500},
                new StudentModel{Id=1003,SName="Chandu",Course=".NET",Fee=18000}
            };
        }
        public List<StudentModel> GetAll()
        {
            return Students;
        }

        public StudentModel GetById(int id)
        {
            return Students.Single(x =>x.Id==id);
        }

        public void Add(StudentModel s)
        {
            Students.Add(s);
        }
         public void Edit(StudentModel s, int id)
        {
            Students[Students.FindIndex(x =>x.Id==id)] = s;
        }

        public void Delete(int id)
        {
            Students.RemoveAt(Students.FindIndex((x)=>x.Id==id));
        }



    }
}
