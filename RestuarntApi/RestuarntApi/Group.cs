using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestuarntApi
{
    public class Group
    {
        private static int _id = 1;
        public int Id { get; set; }
        public string Names { get; set; }
        public List<Dishes> dish;
        public Group(string name)
        {
            Names = name;
            Id = _id;
            _id++;
            dish = new List<Dishes>();
        }
        public void DeleteStudent(Dishes student)
        {
            dish.Remove(student);
        }
        public void AddStudent(Dishes student)
        {
            dish.Add(student);
        }
        public Group()
        {
                
        }
        public void Fullname()
        {

        }
        public  List<Dishes> GetAlLStudent() => dish;
        public Dictionary<String,List<Dishes>> GetList()
        {
            Dictionary<String, List<Dishes>> keyValues = new Dictionary<string, List<Dishes>>();
            keyValues.Add(this.Names, dish);
            return keyValues;
        }
        public List<string> Nm()
        {
            List<string> str = new List<string>();
            foreach (var item in dish)
            {
                str.Add(item.Name);
            }
            return str;
        }
        public List<double> Prc()
        {
            List<double> str = new List<double>();
            foreach (var item in dish)
            {
                str.Add(item.Price);
            }
            return str;
        }
        //public Dictionary<String, Dishes> ListAll()
        //{
        //    Dictionary<String, Dishes> dct = new Dictionary<String, Dishes>();
        //    foreach (var item in dct)
        //    {
        //    }
        //}
        public override string ToString()
        {
            return $"{Names} {dish}";
        }
    }
}
