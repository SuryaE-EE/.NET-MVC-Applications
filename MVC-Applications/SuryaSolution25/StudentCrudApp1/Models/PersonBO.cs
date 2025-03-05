namespace StudentCrudApp1.Models
{
    public class PersonBO
    {
        private List<PersonModel> people = new List<PersonModel> {
        new PersonModel {Id=1001,PName="Anil",Gender="Male",Age=30},
        new PersonModel {Id=1002,PName="Bharathi",Gender="Female",Age=20},
        new PersonModel {Id=1003,PName="Charan",Gender="Male",Age=10},
        new PersonModel {Id=1004,PName="Devi",Gender="Female",Age=23}
    };

        public List<PersonModel> GetAll()
        {
            return people;
        }
        public PersonModel GetById(int id)
        {
            return people.Single(x => x.Id == id);
        }
    

    public void Create(PersonModel p)

        {
            people.Add(p);
        }

        public void Edit(PersonModel p, int id)
        {
            people[ people.FindIndex(x=>x.Id == id) ] = p;
        }
        public void Delete(int id)
        {
           people.RemoveAt(people.FindIndex(x=>x.Id == id));
        }






    }
}
