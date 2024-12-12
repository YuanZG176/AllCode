using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EmployeeManageDemo
{
    static class EmployeeManager
    {
        //property
        public static List<Employee> employees { get; private set; }
        public static void LoadEmployee(string fileName)
        {
            employees = new List<Employee>();
            FileStream stream = null;
            StreamReader reader = null;
            try
            {
                stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                reader = new StreamReader(stream);
                string readIn = reader.ReadLine();
                while (readIn != null)
                {
                    string name = readIn;
                    string gender = reader.ReadLine();
                    string id = reader.ReadLine();
                    //create Employee Object
                    Employee em = new Employee(name, gender, id);
                    //add collection
                    employees.Add(em);

                    readIn = reader.ReadLine();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.ToString());

            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (stream != null)
                    stream.Close();
            }
        }
        public static List<Employee> SearchEmployeeByName(string name)
        {
            //search result set
            List<Employee> resultList = new List<Employee>();
            //for loop
            foreach (Employee em in employees)
            {
                if (em.Name.Contains(name))
                    resultList.Add(em);
            }
            return resultList;
        }
        public static void Add(Employee em)
        {
            EmployeeManager.employees.Add(em);
        }
        public static void remove(string id)
        {
            foreach (Employee obj in EmployeeManager.employees)
            {
                if (obj.Id == id)
                {
                    EmployeeManager.employees.Remove(obj);

                    break;
                }
            }
        }

        public static void Update(string id, Employee em)
        {
            for (int i=0;i<employees.Count;i++)
            {
                if(employees[i].Id == id)
                {
                    employees[i].Name = em.Name;
                    employees[i].Gender = em.Gender;
                    break;
                }
            }
        }
        public static void SaveEmployeeToFile(string fileName)
        {
            FileStream stream = null;
            StreamWriter writer = null;
            try
            {
                stream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                writer = new StreamWriter(stream);
               
                foreach (Employee em in employees)
                {
                    writer.WriteLine(em.Name);
                    writer.WriteLine(em.Gender);
                    writer.WriteLine(em.Id);
                }
               
            }
            catch (IOException e)
            {
                Console.WriteLine(e.ToString());

            }
            finally
            {
                if (writer != null)
                    writer.Close();
                if (stream != null)
                    stream.Close();
            }
        }
    }
}
