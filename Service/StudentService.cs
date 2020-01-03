using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AweBlazor.Data
{
    public class StudentService
    {
        private readonly ProjectDbContext _db;

        public StudentService(ProjectDbContext dbContext)
        {
            _db = dbContext;
        }

        //Get All Student Info
        public List<Student> GetAllStudent()
        {
            var datalist = _db.Students.ToList();
            return datalist;
        }

        //Insert Student Info
        public string Create(Student obj)
        {
            if (obj != null)
            {
                _db.Students.Add(obj);
                var isAdded = _db.SaveChanges() > 0;
                if (isAdded)
                {
                    return "Successfully Saved";
                }
                return "Have a problem during insert";
            }

            return "Given Object is Empty";
        }

        //Get Student Info by Id
        public Student GetStudentById(int id)
        {
            Student student = _db.Students.Where(s => s.Id == id).FirstOrDefault();
            return student;
        }

        //Update Student Info

        public string Update(Student obj)
        {
            if (obj != null)
            {
                _db.Students.Update(obj);
                var isUpdate = _db.SaveChanges() > 0;
                if (isUpdate)
                {
                    return "Update Successfully";
                }
                return "Have a problem during update";
            }

            return "Given Object is Empty";
        }

        //Delete Student Info
        public string Delete(Student obj)
        {
            if (obj != null)
            {
                _db.Students.Remove(obj);
                var isRemove = _db.SaveChanges() > 0;
                if (isRemove)
                {
                    return "This record delete successfully";
                }
                return "Have a problem during delete";
            }

            return "Given Object is Empty";
        }

        public List<Student> _students = new List<Student>()
        {
            new Student(){Id = 1,Name="Sefat",Department = "CSE",PhoneNumber="94634",Address="Gazipur",AdmissionDate = Convert.ToDateTime("01-Jan-2020")},
            new Student(){Id = 2,Name="Kalam",Department = "EEE",PhoneNumber="12363",Address="Dhaka",AdmissionDate = Convert.ToDateTime("03-Feb-2020")},
            new Student(){Id = 3,Name="Jamal",Department = "CSE",PhoneNumber="34535",Address="Uttara",AdmissionDate = Convert.ToDateTime("07-Mar-2020")},
            new Student(){Id = 4,Name="Korim",Department = "MMI",PhoneNumber="47839",Address="Mirpur",AdmissionDate = Convert.ToDateTime("10-Apr-2020")},
            new Student(){Id = 5,Name="Malek",Department = "Arch",PhoneNumber="12345",Address="Tongi",AdmissionDate = Convert.ToDateTime("13-Sep-2020")},
            new Student(){Id = 6,Name="Jalaal",Department = "MC",PhoneNumber="76384",Address="Bonani",AdmissionDate = Convert.ToDateTime("21-Dec-2020")},
            new Student(){Id = 7,Name="Nasirc",Department = "CIVIL",PhoneNumber="783445",Address="Gazipur",AdmissionDate = Convert.ToDateTime("22-Nov-2020")},
            new Student(){Id = 8,Name="Daily",Department = "FDT",PhoneNumber="345656",Address="Asad gate",AdmissionDate = Convert.ToDateTime("31-Jan-2020")},
        };

        public async Task<List<Student>> StudentList()
        {
            return await Task.FromResult(_students);
        }
    }
}