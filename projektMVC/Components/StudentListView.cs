using Microsoft.AspNetCore.Mvc;
using projektMVC.Models;

namespace projektMVC.Components
{
    public class StudentListView : ViewComponent
    {
        public IViewComponentResult Invoke(Student student)
        {
            String name = student.Nazwisko + " " + student.Imie;
            return View("Default", name);
        }

    }
}
