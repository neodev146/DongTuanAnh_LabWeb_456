using DongTuanAnh_Lab_456.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DongTuanAnh_Lab_456.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcomingCoures { get; set; }
        public bool ShowAction { get; set; }
    }
}