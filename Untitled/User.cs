namespace A5.Untitled
{
    abstract public class User
    {
        int ID { get; set; }
        string Name { get; set; }

        string Contact { get; set; }

        public User(string name)
        {
            this.Name = name;
        }

        public User(int id)
        {
            this.ID = id;
        }


        public abstract string setContact();

        public abstract string setName();
    }
}
