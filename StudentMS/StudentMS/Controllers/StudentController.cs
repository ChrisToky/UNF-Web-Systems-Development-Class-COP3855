using Microsoft.AspNetCore.Mvc;
using StudentMS.Models;
using StudentMS.Repository;

namespace StudentMS.Controllers
{
    public class StudentController : Controller
    {
        StudentRepository rep = new StudentRepository();

        // GET: /Student/
        public ActionResult Index()
        {
            IEnumerable<Student> obj = rep.SelectAllStudents();
            return View(obj);
        }


        // GET: /Student/Details/5
        public ActionResult Details(int id)
        {
            Student obj = rep.SelectStudentById(id);
            return View(obj);
        }

        // GET: /Student/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Student/Create
        [HttpPost]
        public ActionResult Create(Student student)
        {

            try
            {
                rep.InsertStudent(student);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: /Student/Edit/5
        public ActionResult Edit(int id)
        {
            Student obj = rep.SelectStudentById(id);
            return View(obj);
        }

        //
        // POST: /Student/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Student student)
        {
            try
            {
                rep.UpdateStudent(student);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: /Student/Delete/5
        public ActionResult Delete(int id)
        {
            Student obj = rep.SelectStudentById(id);
            return View(obj);
        }

        //
        // POST: /Student/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                rep.DeleteStudent(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


    }
}
