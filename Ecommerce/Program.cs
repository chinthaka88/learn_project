﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DALInterfaces;
using DAL_EF;

using ServiceInterfaces;
using Services;
using Entity;
using DTO;

namespace Ecommerce
{
    class Program
    {
        static void Main(string[] args)
        {
         IAppErrors errors=new AppErrors();
            IItemService service = new ItemService(errors,new ItemRepository());
            ItemDTO ex = new ItemDTO();
            ex.Description = "Data By EF";
            ex.CutOffMark = 24;
            ex.CourseID = 1;
            service.AddNewExam(ex);

            if (errors.IsValid)
             {
                 Console.WriteLine("Success");
             }
            else
             {
                 foreach (Error er in errors.GetErrors())
                 {
                     Console.WriteLine(er.Value);
                 }
             }

            IEnumerable<ExaminationDTO> exams = service.GetExams();
             foreach(var x in exams)
             {
                 Console.WriteLine(x.CourseID + "|" + x.Description +"|" +x.CutOffMark);
             }
             Console.ReadLine();
                             
        }
    }
}
